using DAL.Public;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL.Record
{
    public class DRecord
    {
        /// <summary>
        /// 传递过来的连接串
        /// </summary>
        private string SystemSqlConn = "";
        DBOperate operate;
        public DRecord(string SqlConn)
        {
            this.SystemSqlConn = SqlConn;
            operate = new DBOperate(SystemSqlConn);
        }
        /// <summary>
        /// 获取操作行为记录
        /// </summary>
        /// <param name="UserGuid"></param>
        /// <returns></returns>
        public DataTable GetOperationRecord(string UserGuid)
        {
            string SQL = string.Format(@"SELECT TOP(50) R_Note,R_CreateDate,
                                            (CASE R_Level 
                                            WHEN 1 THEN '日常操作' 
                                            WHEN 2 THEN '较敏感操作' 
                                            WHEN 3 THEN '敏感操作' END) AS R_Level 
                                            FROM Tb_OperationRecord WHERE 
                                            R_UserGuid = '{0}' 
                                            ORDER BY R_CreateDate DESC;",UserGuid);
            return operate.ExecuteQuery(SQL).Tables[0];
        }
    }
}
