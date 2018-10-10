using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ExcelToDb.Mdoels
{
    /// <summary>
    /// 数据库数据操作支持类
    /// </summary>
    public  class DBHelper
    {
        private string Connstring = string.Empty;
        public DBHelper(string Connstring)
        {
            this.Connstring = Connstring;
        }
        /// <summary>
        /// 打开数据库连接
        /// </summary>
        /// <param name="Conn"></param>
        public void OpenConn(string Conn)
        {
            SqlConnection conn = new SqlConnection(Conn);
            conn.Open();
        }
        /// <summary>
        /// 执行的T-SQL语句
        /// </summary>
        /// <param name="Conn">连接串</param>
        /// <returns></returns>
        public SqlCommand SQLCmd()
        {
            SqlConnection conn = new SqlConnection(Connstring);
            conn.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = conn;
            return com;
        }
        /// <summary>
        /// 执行事务/T-SQL
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="Type">插入0移动/1联通/2电信/3其他</param>
        public void SQLTran(DataTable dt,int Type)
        {
            SqlConnection conn = new SqlConnection(Connstring);
            conn.Open();
            string SQLCom = "";

            SqlTransaction TheTran = conn.BeginTransaction();

            if (Type == 0)
            {
                //移动
                SQLCom = "INSERT INTO TelUser (UserName,UserTel,InfoType) VALUES(@UserName,@UserTel,'移动用户')";
            }
            if (Type == 1)
            {
                //联通
                SQLCom = "INSERT INTO TelUser (UserName,UserTel,InfoType) VALUES(@UserName,@UserTel,'联通用户')";
            }
            if(Type == 2)
            {
                //电信
                SQLCom = "INSERT INTO TelUser (UserName,UserTel,InfoType) VALUES(@UserName,@UserTel,'电信用户')";
            }
            if (Type == 3)
            {
                //其他
                SQLCom = "INSERT INTO TelUser (UserName,UserTel,InfoType) VALUES(@UserName,@UserTel,'其他用户')";
            }
            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                    SqlCommand com = new SqlCommand();
                    com.Connection = conn;
                    com.Transaction = TheTran;
                    com.CommandText = SQLCom;
                    com.Parameters.Add("@UserName", SqlDbType.VarChar);
                    com.Parameters["@UserName"].Value = Convert.ToString(dr["UserName"]);
                    com.Parameters.Add("@UserTel", SqlDbType.VarChar);
                    com.Parameters["@UserTel"].Value = dr["UserTel"].ToString();
                    com.ExecuteNonQuery();
                }
                //提交
                TheTran.Commit();
            }
            catch (Exception)
            {
                //回滚
                TheTran.Rollback();
                throw;
            }
            finally
            {
                //关闭数据库连接
                conn.Close();
            }
        }

    }
}
