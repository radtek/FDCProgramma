﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL.Distribute;
using DAL.Employee;
using Models;
using BLL.Public;
using DAL.Achievements;

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
            
            DAllotHandle = new DAllotHandle(LoginMsg.SqlConn);
            DEmployee = new DEmployee(LoginMsg.SqlConn);
            DEFLog = new DEveryDayFinishiLog(LoginMsg.SqlConn);
        }
        /*
         * 1.写一些自动处理的想法吧
         * 
         * 
         */
        private int TotalNum = 100000;
        //员工数量
        public int EmployeeCount = 0;
        //单人最大任务量--(自动分配时默认值50)
        public int MaxTaskNum { get; set; } = 50;



        /// <summary>
        /// 自动分配处理
        /// </summary>
        public void AutoAllotHandle(int EmployeeCount,string UserGUID)
        {
            //员工简要信息汇总
            List<MEmployee> EmployListGroup = DEmployee.GetEmployeeList(UserGUID);
            EmployeeCount = EmployListGroup.Count;


            int TableCount = MaxTaskNum * EmployeeCount;
            int SourceRowsCount = 0;
            /*按需查询DataTable操作*/
            DataTable SourceTable = DAllotHandle.GetAutoTable(TableCount, LocalUser.AdminGuid,ref SourceRowsCount);
            //当数据剩余量小于需要的数据量时
            /*
             * 处理逻辑？
             * 1.先判断数据剩余量能不能平分到每个人相同的量
             * 2.剩余的不作处理，只处理满足平分条件的
             * 3. 
             */
            if (SourceRowsCount < TableCount)
            {
                /*
                 * Linq使用博客地址：https://blog.csdn.net/zlbcdn/article/details/79192485
                 */
                //单人任务量
                int SingleTask;
                /*
                 * 正好整除，不用再剔除剩余的
                 */
                if (SourceRowsCount % EmployeeCount == 0)
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

                            return;
                        }
                        //字表写入
                        int Sort = 0;
                        foreach (DataRow item in LinqRows)
                        {
                            Sort++;
                            string Name = (string)item["Name"];
                            string Tel = (string)item["Tel"];
                            string Company = (string)item["Company"];
                            DAllotHandle.AddTaskSub(BillNo, Name, Tel, Sort, Company);
                        }
                        //每日任务绩效表记录插入/更新
                        DEFLog.TaskAchievementsLog(BillNo, EGuid, SingleTask);
                    }
                    List<DataRow> TaskRows = new List<DataRow>(SingleTask);
                }
                /*
                 * 剔除多余的数据再进行拆分的2中情况
                 * 1.数据量太少不够一次分配的
                 * 2.数据量够分配数次还有剩余
                 */






            }
            /*
             * 2种情况
             * 1.当数据剩余量等于需要的数据量时
             * 2.当剩余数据量远远大于需要的数据量时
             */
            else
            {

            }

        }
        /// <summary>
        /// 手动分配处理
        /// </summary>
        public void AllotHandle()
        {

        }
    }
}
