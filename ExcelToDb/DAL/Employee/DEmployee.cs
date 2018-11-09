using DAL.Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using System.Data.SqlClient;
using PetaPoco;

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
        public MEmployee GetEmployeeList(string UserGuid)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SystemSqlConn))
            {
                sqlConnection.Open();
                using (Database db = new PetaPoco.Database(sqlConnection))
                {
                    return db.SingleOrDefault<MEmployee>(@"Exec Proc_Employee_Total @0", UserGuid);
                }
            }
        }

    }
}
