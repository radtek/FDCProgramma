using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL.Distribute;
using DAL.Employee;
using Models;
using BLL.Public;
using DAL.Achievements;
using System.Threading;

namespace BLL.Distribute
{
    /// <summary>
    /// 任务均分处理类（最关键的类）
    /// </summary>
    public  class BAllotHandle
    {
        SerialNo serialNo = new SerialNo();
        DEveryDayFinishiLog DEFLog;
        DEmployee DEmployee;
        DAllotHandle DAllotHandle;
        private AdminMsg LocalUser;
        public BAllotHandle(AdminMsg LoginMsg)
        {
            LocalUser = LoginMsg;
            DAllotHandle = new DAllotHandle(LoginMsg.SqlConn);
            DEmployee = new DEmployee(LoginMsg.SqlConn);
            DEFLog = new DEveryDayFinishiLog(LoginMsg.SqlConn);
        }

        //单人最大任务量--(自动分配时默认值50)
        public int MaxTaskNum { get; set; } = 50;
        /// <summary>
        /// 自动分配处理
        /// </summary>
        public void AutoAllotHandle(int EmployeeCount,string UserGUID)
        {
            //员工简要信息汇总
            List<MEmployee> EmployListGroup = DEmployee.GetEmployeeList(UserGUID);
            //验证一下，看看员工数量是否统一，避免索引超出数组界限
            if (EmployeeCount != EmployListGroup.Count)
            {
                EmployeeCount = EmployListGroup.Count;
            }
            int TableCount = MaxTaskNum * EmployeeCount;
            int SourceRowsCount = 0;
            /*按需查询DataTable操作*/
            DataTable SourceTable = DAllotHandle.GetAutoTable(TableCount, LocalUser.AdminGuid,ref SourceRowsCount);
            /*
             * 任务量大于GoupSubNum时，开启多线程
             * 最大线程开销量：4
             */
            int MaxThread = 4;
            int GoupSubNum = 2000;
            decimal NeedNewThread = SourceRowsCount / GoupSubNum;


            if (NeedNewThread > 1)
            {
                int thenum = Convert.ToInt32(Math.Round(NeedNewThread)); 
                if (NeedNewThread <= MaxThread)
                {
                    
                    //循环创建任务线程
                    for (int t = 0; t < thenum; t++)
                    {
                        DataRow[] LinqRows = SourceTable.AsEnumerable().Skip(t * GoupSubNum).Take(GoupSubNum).ToArray();
                        
                        Dictionary<string, object> threadParam = new Dictionary<string, object>();
                        threadParam.Add("EmployeeCount", EmployeeCount);
                        threadParam.Add("SourceRowsCount", LinqRows.Count());
                        threadParam.Add("SourceRows", LinqRows);
                        threadParam.Add("EmployeeList", EmployListGroup);
                        threadParam.Add("SingleTask", null);

                        Thread thread = new Thread(TaskRunHandle);
                        thread.Start(threadParam);
                    }
                    //存在剩余时，处理剩余
                    if (thenum * GoupSubNum < SourceRowsCount)
                    {
                        



                        //应该处理的剩余行数
                        int surplusNum = SourceRowsCount - thenum * GoupSubNum;
                        DataRow[] LinqRows = SourceTable.AsEnumerable().Skip(thenum * GoupSubNum).Take(surplusNum).ToArray();

                        Dictionary<string, object> threadParam = new Dictionary<string, object>();
                        threadParam.Add("EmployeeCount", EmployeeCount);
                        threadParam.Add("SourceRowsCount", LinqRows.Count());
                        threadParam.Add("SourceRows", LinqRows);
                        threadParam.Add("EmployeeList", EmployListGroup);
                        threadParam.Add("SingleTask", null);

                        Thread thread = new Thread(TaskRunHandle);
                        thread.Start(threadParam);

                    }
                }
                else
                {
                    //最多循环创建4个线程，加上一个额外处理剩余数据的线程
                    for (int t = 0; t < MaxThread; t++)
                    {



                        DataRow[] LinqRows = SourceTable.AsEnumerable().Skip(t * GoupSubNum).Take(GoupSubNum).ToArray();

                        Dictionary<string, object> threadParam1 = new Dictionary<string, object>();
                        threadParam1.Add("EmployeeCount", EmployeeCount);
                        threadParam1.Add("SourceRowsCount", LinqRows.Count());
                        threadParam1.Add("SourceRows", LinqRows);
                        threadParam1.Add("EmployeeList", EmployListGroup);
                        threadParam1.Add("SingleTask", null);

                        Thread thread = new Thread(TaskRunHandle);
                        thread.Start(threadParam1);
                    }

                    int surplusNum = SourceRowsCount - MaxThread * GoupSubNum;
                    DataRow[] surLinqRows = SourceTable.AsEnumerable().Skip(MaxTaskNum * GoupSubNum).Take(surplusNum).ToArray();

                    Dictionary<string, object> threadParam = new Dictionary<string, object>();
                    threadParam.Add("EmployeeCount", EmployeeCount);
                    threadParam.Add("SourceRowsCount", surLinqRows.Count());
                    threadParam.Add("SourceRows", surLinqRows);
                    threadParam.Add("EmployeeList", EmployListGroup);
                    threadParam.Add("SingleTask", null);


                    Thread surthread = new Thread(TaskRunHandle);
                    surthread.Start(threadParam);
                }
                
            }
            else
            {
                //当数据剩余量小于需要的数据量时
                /*
                 * 处理逻辑？
                 * 1.先判断数据剩余量能不能平分到每个人相同的量
                 * 2.剩余的不作处理，只处理满足平分条件的
                 * 原则是：
                 * 只处理在最大处理量内的任务
                 */
                if (SourceRowsCount <= TableCount)
                {
                    /*
                     * Linq使用博客地址：https://blog.csdn.net/zlbcdn/article/details/79192485
                     */
                    //单人任务量
                    int SingleTask;
                    decimal r = SourceRowsCount / EmployeeCount;
                    //2.数据量够分配一次或者数次
                    if (Math.Round(r, 3) >= 1)
                    {
                        SingleTask = SourceRowsCount / EmployeeCount;
                        for (int i = 0; i < EmployeeCount; i++)
                        {
                            //每次只取单人任务量的行进行操作
                            //var TheRows = (from DataRowCollection cc in SourceTable.Rows select cc).Skip(i*SingleTask).Take(SingleTask);
                            DataRow[] LinqRows = SourceTable.AsEnumerable().Skip(i * SingleTask).Take(SingleTask).ToArray();



                            //当前分配员工的GUID
                            string BillNo = serialNo.CreateSerialNo();
                            string EGuid = EmployListGroup[i].EmployeeGuid;
                            string ENickName = EmployListGroup[i].EmployeeNickName;
                            bool MianResullt = false;
                            string ExpotionMsg = "";
                            //存入主表
                            DAllotHandle.AddTaskMain(BillNo, EGuid, SingleTask, ENickName, ref MianResullt, ref ExpotionMsg);
                            if (!MianResullt)
                            {
                                //日志记录
                                throw new Exception(ExpotionMsg);
                                //下面代码不再执行
                            }
                            //字表写入
                            int Sort = 0;
                            foreach (DataRow item in LinqRows)
                            {
                                Sort++;
                                int ID = (int)item["ID"];
                                string Name = (string)item["Name"];
                                string Tel = (string)item["Tel"];
                                string Company = (string)item["Company"];
                                DAllotHandle.AddTaskSub(BillNo, Name, Tel, Sort, Company, ID);
                            }
                            //每日任务绩效表记录插入/更新
                            DEFLog.TaskAchievementsLog(BillNo, EGuid, SingleTask);
                        }
                    }
                }
            }




        }
        /// <summary>
        /// 手动分配处理
        /// </summary>
        public void AllotHandle(int InputTaskNum, int EmployeeCount, string UserGUID)
        {
            //手动分配就是重新设置一下最大任务量
            MaxTaskNum = InputTaskNum;
            AutoAllotHandle(EmployeeCount, UserGUID);
        }
        public void TaskRunHandle(object obj)
        {
            Dictionary<string, object> paramvalue = obj as Dictionary<string, object>;

            int EmployeeCount = int.Parse(paramvalue["EmployeeCount"].ToString());
            int SourceRowsCount = ((DataRow[])paramvalue["SourceRowsCount"]).Count();
            List<MEmployee> employeeList = paramvalue["EmployeeList"] as List<MEmployee>;
            DataRow[] SourceRows = paramvalue["SourceRows"] as DataRow[];

            int SingleTask = SourceRowsCount / EmployeeCount;
            for (int i = 0; i < EmployeeCount; i++)
            {
                //每次只取单人任务量的行进行操作
                //var TheRows = (from DataRowCollection cc in SourceTable.Rows select cc).Skip(i*SingleTask).Take(SingleTask);
                DataRow[] LinqRows = SourceRows.AsEnumerable().Skip(i * SingleTask).Take(SingleTask).ToArray();
                //当前分配员工的GUID
                string BillNo = serialNo.CreateSerialNo();
                string EGuid = employeeList[i].EmployeeGuid;
                string ENickName = employeeList[i].EmployeeNickName;
                bool MianResullt = false;
                string ExpotionMsg = "";
                //存入主表
                DAllotHandle.AddTaskMain(BillNo, EGuid, SingleTask, ENickName, ref MianResullt, ref ExpotionMsg);
                if (!MianResullt)
                {
                    //日志记录
                    throw new Exception(ExpotionMsg);
                    //下面代码不再执行
                }
                //字表写入
                int Sort = 0;
                foreach (DataRow item in LinqRows)
                {
                    Sort++;
                    int ID = (int)item["ID"];
                    string Name = (string)item["Name"];
                    string Tel = (string)item["Tel"];
                    string Company = (string)item["Company"];
                    DAllotHandle.AddTaskSub(BillNo, Name, Tel, Sort, Company, ID);
                }
                //每日任务绩效表记录插入/更新
                DEFLog.TaskAchievementsLog(BillNo, EGuid, SingleTask);
            }



        }
    }
}
