using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL.Employee;
using Models;
using BLL.Public;

namespace BLL.Employee
{
    /// <summary>
    /// 员工效率统计BAL
    /// </summary>
    public class BEmployee
    {
        SecurityHelper helper = new SecurityHelper();
        DEmployee dEmployee;
        public BEmployee(string InputSqlConn)
        {
            dEmployee = new DEmployee(InputSqlConn);
        }
        public DataTable GetEmployeeGroup(string UserGuid)
        {
            return dEmployee.GetEmployeeTable(UserGuid);
        }
        /// <summary>
        /// 新增员工
        /// </summary>
        /// <param name="UIEmployeeInfo"></param>
        /// <param name="ErrMessage">错误提示</param>
        /// <returns></returns>
        public bool AddEmployee(Dictionary<string,object> UIEmployeeInfo,ref string ErrMessage)
        {
            try
            {

                UIEmployeeInfo["Pass"] = helper.MD5Encrypt((string)UIEmployeeInfo["Pass"], Encoding.UTF8).ToLower();
                if (dEmployee.AddEmployee(UIEmployeeInfo) != 1)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                ErrMessage = ex.Message;
                return false;
            }
        }
    }
}
