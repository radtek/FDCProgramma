using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    /// <summary>
    /// 管理员登陆信息存储类
    /// </summary>
    public class AdminMsg
    {
        /// <summary>
        /// 登录Code
        /// </summary>
        public string AdminLoginCode { get; set; }
        /// <summary>
        /// 管理员全局唯一标识Guid
        /// </summary>
        public string AdminGuid { get; set; }
        /// <summary>
        /// 登录标识/验证字段
        /// </summary>
        public Token Token { get; set; }
        /// <summary>
        /// 登录人姓名
        /// </summary>
        public string AdminNickName { get; set; }
        /// <summary>
        /// 登录IP
        /// </summary>
        public string LoginIP { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public int AdminSex { get; set; }
        /// <summary>
        /// Token失效时间
        /// </summary>
        public DateTime TokenFalseTime { get; set; }
        /// <summary>
        /// 记录登录时间
        /// </summary>
        public DateTime LoginTime { get; set; }
        /// <summary>
        /// 手下员工数量
        /// </summary>
        public int EmployeeNum { get; set; }
        /// <summary>
        /// 通过请求接口获取到的数据库连接串
        /// </summary>
        public string SqlConn { get; set; }
    }
}
