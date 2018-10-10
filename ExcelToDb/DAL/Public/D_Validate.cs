using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using PetaPoco;

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
        public Token ValidateToken(AdminMsg msg)
        {
            Token token;
            using (Database db = new PetaPoco.Database("DefaultConnection"))
            {
                token = db.SingleOrDefault<Token>(@"SELECT TokenCode,TokenLastDate,TokenFalseDate,UserGuid
                                WHERE UserGuid = @0", msg.AdminGuid);
            }
            return token;
        }
    }
}
