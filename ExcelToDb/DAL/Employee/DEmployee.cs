using DAL.Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using System.Data.SqlClient;
using PetaPoco;
using System.Data;

namespace DAL.Employee
{
    /// <summary>
    /// 员工效率统计DAL
    /// </summary>
    public class DEmployee
    {
        /// <summary>
        /// 传递过来的连接串
        /// </summary>
        private string SystemSqlConn = "";
        DBOperate operate;
        public DEmployee(string SqlConn)
        {
            this.SystemSqlConn = SqlConn;
            operate = new DBOperate(SystemSqlConn);
        }
        /// <summary>
        /// 获取登陆者的下级员工集合
        /// </summary>
        /// <param name="UserGuid"></param>
        /// <returns></returns>
        public DataTable GetEmployeeTable(string UserGuid)
        {
            return operate.ExecuteQuery(string.Format("Exec Proc_Employee_Total '{0}'", UserGuid)).Tables[0];
        }
        /// <summary>
        /// 返回新增结果
        /// </summary>
        /// <param name="EmployeeInfo"></param>
        /// <returns></returns>
        public int AddEmployee(Dictionary<string,object> EmployeeInfo)
        {
            return operate.ExecuteNonQuery(string.Format(@"Exec Proc_Add_Employee 
                        '{0}',
                        '{1}',
                        '{2}',
                        '{3}',
                        '{4}',
                        '{5}',
                        '{6}',
                        {7}",
                        EmployeeInfo["GUID"],
                        EmployeeInfo["Code"],
                        EmployeeInfo["Tel"],
                        EmployeeInfo["Pass"],
                        EmployeeInfo["Name"],
                        EmployeeInfo["Belong"],
                        EmployeeInfo["Operator"],
                        EmployeeInfo["Sex"]
                        ));
        }
    }
}
