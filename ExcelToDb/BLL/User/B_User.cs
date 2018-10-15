using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using DAL;
using System.Net;
using System.Net.Sockets;

namespace BLL.User
{
    public  class B_User
    {
        DAL.User.D_User du = new DAL.User.D_User();
        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="UserCode">账号</param>
        /// <param name="UserPass">密码</param>
        /// <returns></returns>
        public Models.User GetUserInfo(string UserCode,string UserPass)
        {
            Models.User user = du.UserInfo(UserCode,UserPass);
            return user;
        }
        /// <summary>
        /// 获取AdminMsg对象信息信息
        /// </summary>
        /// <param name="code"></param>
        /// <param name="Pass"></param>
        /// <returns></returns>
        public Models.AdminMsg GetAdminMsg(string code,string Pass)
        {
            Models.User user = this.GetUserInfo(code, Pass);
            AdminMsg msg = new AdminMsg();
            msg.AdminGuid = user.UserGuid;
            msg.AdminLoginCode = user.UserCode;
            msg.AdminNickName = user.UserNickName;
            msg.AdminSex = user.UserSex;
            

            return null;
        }
        /// <summary>
        /// 获取登录令牌Token
        /// </summary>
        /// <param name="UserGuid">用户GUID</param>
        /// <returns></returns>
        public Token GetLoginToken(string UserGuid)
        {
            //获取本机IP地址
            string UserIP = GetLocalIP();

            return null;
        }
        /// <summary>
        /// 获取本机IP地址
        /// </summary>
        /// <returns>本机IP地址</returns>
        public static string GetLocalIP()
        {
            try
            {
                string HostName = Dns.GetHostName(); //得到主机名
                IPHostEntry IpEntry = Dns.GetHostEntry(HostName);
                for (int i = 0; i < IpEntry.AddressList.Length; i++)
                {
                    //从IP地址列表中筛选出IPv4类型的IP地址
                    //AddressFamily.InterNetwork表示此IP为IPv4,
                    //AddressFamily.InterNetworkV6表示此地址为IPv6类型
                    if (IpEntry.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                    {
                        return IpEntry.AddressList[i].ToString();
                    }
                }
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
