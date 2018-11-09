using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Employee;
using Models;

namespace BLL.Employee
{
    /// <summary>
    /// 员工效率统计BAL
    /// </summary>
    public class BEmployee
    {
        DEmployee dEmployee;
        public BEmployee(string InputSqlConn)
        {
            dEmployee = new DEmployee(InputSqlConn);
        }
        public MEmployee GetEmployeeGroup(string UserGuid)
        {
            return dEmployee.GetEmployeeList(UserGuid);
        }


    }
}
