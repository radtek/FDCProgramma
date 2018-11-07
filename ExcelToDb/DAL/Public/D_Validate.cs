using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using PetaPoco;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Public
{
    /// <summary>
    /// 公共方法--
    /// </summary>
    public  class D_Validate
    {
        /// <summary>
        /// 每次进入窗体时，验证Token
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public Token ValidateToken(string UserGuid, string ParamSqlConn)
        {
            Token token;
            using (SqlConnection sqlConnection = new SqlConnection(ParamSqlConn))
            {
                sqlConnection.Open();
                using (Database db = new PetaPoco.Database(sqlConnection))
                {
                    token = db.SingleOrDefault<Token>(@"SELECT 
                                                        TokenCode,
                                                        TokenLastDate,
                                                        TokenFalseDate,
                                                        UserGuid 
                                                        FROM Tb_Token 
                                                        WHERE UserGuid = @0", UserGuid);
                }
                return token;
            }
        }
    }
}
