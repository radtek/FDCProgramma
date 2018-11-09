using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    /// <summary>
    /// 员工信息类
    /// </summary>
    public class MEmployee
    {
        /// <summary>
        /// 员工ID
        /// </summary>
        public int EmployeeID { get; set; }
        /// <summary>
        /// 员工GUID
        /// </summary>
        public string EmployeeGuid { get; set; }
        /// <summary>
        /// 员工编号
        /// </summary>
        public string EmployeeCode { get; set; }
        /// <summary>
        /// 员工所使用的电话
        /// </summary>
        public string EmployeeTel { get; set; }
        /// <summary>
        /// 员工名称
        /// </summary>
        public string EmployeeNickName { get; set; }
        /// <summary>
        /// 员工性别
        /// </summary>
        public string EmployeeSex { get; set; }
        /// <summary>
        /// 手机所属的运营商
        /// </summary>
        public string TelOperator { get; set; }
        /// <summary>
        /// 入职时间/注册时间
        /// </summary>
        public string CreateDate { get; set; }
        /// <summary>
        /// 历史记录
        /// </summary>
        public int HisNum { get; set; } 
        /// <summary>
        /// 今日数量
        /// </summary>
        public int TodayNum { get; set; }
    }
}
