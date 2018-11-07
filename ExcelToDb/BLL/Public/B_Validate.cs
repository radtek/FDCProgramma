using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using DAL.Public;

namespace BLL.Public
{
    /*
     * 每个窗体都要用到的验证
     * 设计目的：为了每次进入新的窗体时，验证Token令牌的有效性
     */
    public class B_Validate
    {
        D_Validate dv = new D_Validate();
        /// <summary>
        /// 验证登陆者的身份
        /// </summary>
        /// <param name="adminMsg">管理员登录类</param>
        /// <param name="Message">信息提示</param>
        /// <param name="HasError">是否存在问题</param>
        public void ValidateCard(AdminMsg adminMsg,ref string Message,ref bool HasError)
        {
            
            //验证Token是否超时
            if (adminMsg.Token.TokenFalseDate < DateTime.Now )
            {
                HasError = true;
                Message = "Token已超时失效，请重新登录！";
            }
            //验证Token是正确
            if (string.IsNullOrEmpty(adminMsg.AdminGuid))
            {
                HasError = true;
                Message = "未传入有效Guid，请重新登录！";
            }
            else
            {
                Token QueryToken = dv.ValidateToken(adminMsg.AdminGuid,adminMsg.SqlConn);
                if (QueryToken.TokenCode != adminMsg.Token.TokenCode)
                {
                    HasError = true;
                    Message = "错误的Token令牌，请重新登录！";
                }
                else
                {
                    HasError = false;
                    Message = "恭喜，验证通过！";
                }

            }


        }
    }
}
