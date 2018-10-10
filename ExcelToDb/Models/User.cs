using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    /// <summary>
    /// Model--管理员信息对象
    /// </summary>
    public class User
    {
        /// <summary>
        /// 登录账号
        /// </summary>
        public string UserCode { get; set; }
        /// <summary>
        /// 登录密码，MD5加密
        /// </summary>
        public  string UserPass { get; set; }
        /// <summary>
        /// .NET生成的GUID，全局唯一标识
        /// </summary>
        public string UserGuid { get; set; }
        /// <summary>
        /// 用户姓名
        /// </summary>
        public string UserNickName { get; set; }
        /// <summary>
        /// 性别，男0 / 女1
        /// </summary>
        public int UserSex { get; set; }
        /// <summary>
        /// 用户注册时间
        /// </summary>
        public DateTime UserCreateDate { get; set; }
    }
}
