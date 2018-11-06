using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PetaPoco;
using Models;
using System.Collections;
using DAL.Public;
using System.Data.SqlClient;
using System.Data;

namespace DAL.User
{
    /// <summary>
    /// DAL---管理员信息
    /// </summary>
    public class D_User
    {
        /// <summary>
        /// 传递过来的连接串
        /// </summary>
        private string SystemSqlConn = "";
        DBOperate operate;
        public D_User(string SqlConn)
        {
            this.SystemSqlConn = SqlConn;
            operate = new DBOperate(SystemSqlConn);
        }
        /// <summary>
        /// 获取用户全部信息
        /// </summary>
        /// <param name="UserCode"></param>
        /// <param name="UserPass"></param>
        /// <returns></returns>
        public Models.User UserInfo(string UserCode,string UserPass)
        {
            Models.User MUser;
            using (SqlConnection sqlConnection = new SqlConnection(SystemSqlConn))
            {
                sqlConnection.Open();
                using (Database db = new PetaPoco.Database(sqlConnection))
                {
                    MUser = db.SingleOrDefault<Models.User>(@"
                        SELECT * FROM Tb_User WHERE UserCode = @0
                        AND ISNULL(UserIsLocked,0) = 0 
                        AND UserPass = @1", UserCode, UserPass);
                }
                return MUser;
            }

        }
        /// <summary>
        /// 获取登录通行证Token
        /// </summary>
        /// <param name="UserGuid">用户标识</param>
        /// <returns></returns>
        public Token GetToken(string UserGuid,string UserIP)
        {
            Token token = new Token();
            //1.新增或修改Token标识 2.更新最后登录时间和Token失效时间
            string NewTokenCode = GetToken();
            string ProcSql = string.Format(@"EXEC Proc_LoginToken '{0}','{1}','{2}'",UserGuid,UserIP,NewTokenCode);
            DataSet ds = operate.ExecuteQuery(ProcSql);
            token.TokenCode = (string)ds.Tables[0].Rows[0]["TokenCode"];
            token.TokenLastDate = (DateTime)ds.Tables[0].Rows[0]["TokenLastDate"];
            token.TokenFalseDate = (DateTime)ds.Tables[0].Rows[0]["TokenFalseDate"];
            return token;
        }

        public string GetToken()
        {
            string result;
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@len",SqlDbType.Int,1),
                new SqlParameter("@token",SqlDbType.VarChar,6)
            };
            para[0].Value = 6;
            para[1].Value = "";
            para[1].Direction = ParameterDirection.Output;
            operate.ExecuteStoredPro("Pro_Token", para, out result, 1);
            return result;
        }



    }
}
