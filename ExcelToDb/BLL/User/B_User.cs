using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using DAL;
using System.Net;
using System.Net.Sockets;
using BLL.Public;

namespace BLL.User
{
    public  class B_User
    {
        private  SecurityHelper sh = new SecurityHelper();
        private string SqlConn = "";
        DAL.User.D_User du;
        public B_User(string conn)
        {
            SqlConn = conn;
            du = new DAL.User.D_User(SqlConn);
        }
        //"Data Source=.;Initial Catalog=InfoManageDB;Integrated Security=True"
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
            string IP = GetLocalIP();
            Models.User user = this.GetUserInfo(code, Pass);
            AdminMsg msg = new AdminMsg();
            msg.AdminGuid = user.UserGuid;
            msg.AdminLoginCode = user.UserCode;
            msg.AdminNickName = user.UserNickName;
            msg.AdminSex = user.UserSex;
            msg.Token = GetLoginToken(user.UserGuid, IP);
            msg.LoginTime = DateTime.Now;
            msg.LoginIP = IP;
            return msg;
        }
        /// <summary>
        /// 获取登录令牌Token
        /// </summary>
        /// <param name="UserGuid">用户GUID</param>
        /// <returns></returns>
        public Token GetLoginToken(string UserGuid,string IP)
        {
            //存入guid，ip
            //返回Token，失效时间、最后登陆时间
            return du.GetToken(UserGuid, IP); ;
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
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="LoginGuid">GUID</param>
        /// <param name="YPass">原密码</param>
        /// <param name="NPass">新密码</param>
        /// <param name="Privatekey">私钥</param>
        /// <param name="HasError">是否存在问题</param>
        /// <param name="Message">错误提示</param>
        public void ChangePass(string LoginGuid,string YPass,string NPass,string Privatekey,ref bool HasError,ref string Message)
        {
            try
            {
                //密码MD5处理
                string B_YPass = sh.MD5Encrypt(YPass, Encoding.UTF8).ToLower();
                string B_NPass = sh.MD5Encrypt(NPass, Encoding.UTF8).ToLower();
                if (du.ChangePass(LoginGuid, B_YPass, B_NPass, Privatekey) != 1)
                {
                    HasError = false;
                    throw new Exception("糟糕~~修改密码失败！");
                }
                else
                {
                    HasError = true;
                    Message = "恭喜，修改密码成功！";
                }
            }
            catch (Exception ex)
            {
                Message = ex.Message;
                HasError = false;
            }
        }
    }
}
