using DAL.Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Achievements
{
    /// <summary>
    /// 每日绩效功能--数据访问
    /// </summary>
    public class DEveryDayFinishiLog
    {
        /// <summary>
        /// 传递过来的连接串
        /// </summary>
        private string SystemSqlConn = "";
        DBOperate operate;
        public DEveryDayFinishiLog(string SqlConn)
        {
            this.SystemSqlConn = SqlConn;
            operate = new DBOperate(SystemSqlConn);
        }
        /// <summary>
        /// 绩效日志更新（分配任务专用）
        /// </summary>
        public void TaskAchievementsLog(string TaskNo,string EmployeeGuid,int TaskCount)
        {
            string SQL = string.Format(@"Exec Proc_EverydayFinish_Add '{0}','{1}',{2}",TaskNo,EmployeeGuid,TaskCount);
            operate.ExecuteNonQuery(SQL);
        }

    }
}
