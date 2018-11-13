using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Public
{
    /// <summary>
    /// 用户行为记录DAL
    /// </summary>
    public  class DOperationRecord
    {
        /// <summary>
        /// 传递过来的连接串
        /// </summary>
        private string SystemSqlConn = "";
        DBOperate operate;
        public DOperationRecord(string SqlConn)
        {
            this.SystemSqlConn = SqlConn;
            operate = new DBOperate(SystemSqlConn);
        }
        /// <summary>
        /// 操作行为记录
        /// </summary>
        public int Record(string UserGuid,int Level,string Note)
        {
            string SQL = string.Format(@"INSERT INTO [AFDB].[dbo].[Tb_OperationRecord]
                                               ([R_UserGuid]
                                               ,[R_Level]
                                               ,[R_Note])
                                         VALUES
                                               ('{0}',
                                               {1},
                                               '{2}'
                                               )",UserGuid,Level,Note);
            return operate.ExecuteNonQuery(SQL);
        }
        /// <summary>
        /// 操作行为记录
        /// </summary>
        /// <param name="UserGuid"></param>
        /// <param name="Level"></param>
        /// <param name="Note"></param>
        /// <param name="SqlTxt"></param>
        /// <returns></returns>
        public int Record(string UserGuid, int Level, string Note,string SqlTxt)
        {
            string SQL = string.Format(@"INSERT INTO [AFDB].[dbo].[Tb_OperationRecord]
                                       ([R_UserGuid]
                                       ,[R_Level]
                                       ,[R_Note]
                                       ,R_SQLText
                                       )
                                     VALUES
                                       ('{0}',
                                       {1},
                                       '{2}',
                                       '{3}'
                                       )",UserGuid,Level,Note,SqlTxt);
            return operate.ExecuteNonQuery(SQL);
        }
    }
}
