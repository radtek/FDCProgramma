using DAL.Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using System.Data.SqlClient;
using PetaPoco;
using System.Data;
using Models;

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
        /// <summary>
        /// 统计员工数量
        /// </summary>
        /// <returns></returns>
        public int GetEmployeeCount(string LoginGuid)
        {
            string SQL = string.Format(@"select COUNT(*) AS NUM 
                                        from Tb_Employee where 
                                        BelongToUser = '{0}' 
                                        and ISNULL(EmployeeIsLocked,0) = 0 ",LoginGuid);
           return Convert.ToInt32(operate.ExecuteQuery(SQL).Tables[0].Rows[0]["NUM"]); 
        }
        /// <summary>
        /// 获取员工信息集合(简要信息)
        /// 区别：这是简要的员工信息，用来做任务分配
        /// </summary>
        /// <param name="LoginGuid">登入者GUID</param>
        /// <returns></returns>
        public List<MEmployee> GetEmployeeList(string LoginGuid)
        {
            List<MEmployee> employees;
            using (SqlConnection sqlConnection = new SqlConnection(SystemSqlConn))
            {
                sqlConnection.Open();
                using (Database db = new PetaPoco.Database(sqlConnection))
                {
                    employees = db.SingleOrDefault<List<MEmployee>>(@"SELECT EmployeeGuid,
                                EmployeeCode,
                                EmployeeNickName,
                                EmployeeSex,
                                EmployeeTel,TelOperator
                                FROM Tb_Employee
                                 WHERE BelongToUser = '{0}' 
                                AND EmployeeIsLocked = 0",LoginGuid);
                }
                return employees;
            }
        }
    }
}
