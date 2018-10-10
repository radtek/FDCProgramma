using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using DAL.Public;

namespace DAL.User
{
    public class D_Admin
    {
        DBOperate dbo = new DBOperate("");
        public int AdminRegister(Hashtable HtParams)
        {
           string sql = string.Format(@"INSERT INTO Tb_User (UserCode,UserNickName,UserPass,UserSex,UserGuid)
                                        VALUES ('{0}','{1}','{2}',{3},'{4}')",
                                        HtParams["UserCode"],
                                        HtParams["NickName"],
                                        HtParams["UserPass"],
                                        HtParams["UserSex"],
                                        HtParams["UserGuid"]);
            return dbo.ExecuteNonQuery(sql);
        }
    }
}
