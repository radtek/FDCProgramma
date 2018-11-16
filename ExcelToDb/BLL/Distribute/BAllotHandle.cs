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
        private AdminMsg LocalUser = "";
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
             */
            if (SourceRowsCount < TableCount)
            {

            }
            //当数据剩余量等于需要的数据量时，正常处理
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
