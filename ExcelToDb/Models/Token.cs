using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    /// <summary>
    /// Token信息对象
    /// </summary>
    public class Token
    {
        /// <summary>
        /// 登陆用户对应的全局标识GUID
        /// </summary>
        public string UserGuid { get; set; }
        /// <summary>
        /// 生成的通行令牌
        /// </summary>
        public string TokenCode { get; set; }
        /// <summary>
        /// 最后一次登录时间，每次登录都要更新时间
        /// </summary>
        public DateTime TokenLastDate { get; set; }
        /// <summary>
        /// Token失效时间，有效时间1小时
        /// </summary>
        public DateTime TokenFalseDate { get; set; }
    }
}
