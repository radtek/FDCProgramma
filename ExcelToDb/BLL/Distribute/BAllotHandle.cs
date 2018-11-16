using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL.Distribute;
using Models;

namespace BLL.Distribute
{
    /// <summary>
    /// 任务均分处理类（最关键的类）
    /// </summary>
    public  class BAllotHandle
    {
        DAllotHandle DAllotHandle;
        private AdminMsg LocalUser;
        public BAllotHandle(AdminMsg LoginMsg)
        {
            
            DAllotHandle = new DAllotHandle(LoginMsg.SqlConn);
        }
        /*
         * 1.写一些自动处理的想法吧
         * 
         * 
         */
        private int TotalNum = 100000;
        public int EmployeeCount = 6;
        //单人最大任务量
        private int MaxTaskNum = 50;



        /// <summary>
        /// 自动分配处理
        /// </summary>
        public void AutoAllotHandle(int EmployeeCount)
        {
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
                    DataRowCollection TheRows = SourceTable.Rows;
                    for (int i = 0; i < EmployeeCount; i++)
                    {
                        //每次只取单人任务量的行进行操作
                        //var TheRows = (from DataRowCollection cc in SourceTable.Rows select cc).Skip(i*SingleTask).Take(SingleTask);
                        DataRow[] LinqRows = TheRows.OfType<DataRow>().Skip(i * SingleTask).Take(SingleTask).ToArray();
                        foreach (DataRow item in LinqRows)
                        {
                            string Name = (string)item["Name"];
                        }






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
