using DAL.Public;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL.Distribute
{
    /// <summary>
    /// 分配处理DAL
    /// </summary>
    public class DAllotHandle
    {
        /// <summary>
        /// 传递过来的连接串
        /// </summary>
        private string SystemSqlConn = "";
        DBOperate operate;
        public DAllotHandle(string SqlConn)
        {
            this.SystemSqlConn = SqlConn;
            operate = new DBOperate(SystemSqlConn);
        }
        /// <summary>
        /// 获取自动分配的数据源
        /// </summary>
        /// <param name="NeedNum"></param>
        /// <param name="LoginGuid"></param>
        /// <returns></returns>
        public DataTable GetAutoTable(int NeedNum,string LoginGuid,ref int RowsCount)
        {
            string SQL = string.Format(@"SELECT TOP({0}) CF_NickName AS Name,
                                        CF_Tel AS Tel,
                                        CF_BelongOperator AS Company 
                                        FROM Tb_CustomInformation 
                                        WHERE CF_IsUsed = 0 AND 
                                        CF_UserGuid = '{1}' 
                                        ORDER BY CF_CreateDate DESC;",NeedNum,LoginGuid);
            DataSet Result = operate.ExecuteQuery(SQL);
            if (Result.Tables.Count > 0)
            {
                RowsCount = Result.Tables[0].Rows.Count;
                return Result.Tables[0];
            }
            else
            {
                return null;
            }
        }
    }
}
