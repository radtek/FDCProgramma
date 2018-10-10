using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PetaPoco;
using Models;
using System.Collections;

namespace DAL.User
{
    /// <summary>
    /// DAL---管理员信息
    /// </summary>
    public class D_User
    {
        /// <summary>
        /// 根据账号查询用户所有信息
        /// </summary>
        /// <param name="UserCode">账号</param>
        /// <returns></returns>
        public Models.User Login (string UserCode)
        {
            Models.User MUser;
            using (Database db = new PetaPoco.Database("DefaultConnection"))
            {
                MUser = db.SingleOrDefault<Models.User>(@"SELECT UserSex,UserNickName,UserGuid,UserPass 
                    FROM Tb_User WHERE UserCode = @0 AND UserIsLocked = 0", UserCode);
            }
            return MUser;
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
            using (Database db = new PetaPoco.Database("DefaultConnection"))
            {
                MUser = db.SingleOrDefault<Models.User>(@"SELECT * 
                    FROM Tb_User WHERE UserCode = @0 AND UserIsLocked = 0 AND UserPass = @1", UserCode,UserPass);
            }
            return MUser;
        }
        /// <summary>
        /// 获取登录通行证Token
        /// </summary>
        /// <param name="UserGuid">用户标识</param>
        /// <returns></returns>
        public Token GetToken(string UserGuid,string UserIP)
        {
            Token token;
            //1.新增或修改Token标识 2.更新最后登录时间和Token失效时间
            using (Database db = new PetaPoco.Database("DefaultConnection"))
            {

            }
            return null;
        }

    }
}
