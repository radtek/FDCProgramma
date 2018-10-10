using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections;

namespace DAL.Public
{
    /// <summary>
    /// 数据访问类
    /// </summary>
    public sealed class DBOperate
    {
        /// <summary>
        /// 连接字符串
        /// </summary>
        private string ConnString { get; set; }
        public DBOperate(string ConnStr)
        {
            this.ConnString = ConnStr;
        }
        /// <summary>
        /// 执行增删改
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <param name="HtParams">SQL参数/值</param>
        /// <returns></returns>
        public int ExecuteNonQuery(string sql, Hashtable HtParams)
        {
            List<SqlParameter> Sp = new List<SqlParameter>();
            foreach (var key in HtParams.Keys)
            {
                Sp.Add(new SqlParameter(key as string, HtParams[key]));
            }
            return CreateExecuteNonQuery(this.ConnString, sql, Sp);
        }
        /// <summary>
        /// 执行增删改
        /// </summary>
        /// <param name="sql">Sql语句</param>
        /// <returns></returns>
        public int ExecuteNonQuery(string sql)
        {
            return CreateExecuteNonQuery(this.ConnString, sql);
        }
        /// <summary>
        /// 执行查询返回DataSet
        /// </summary>
        /// <param name="sql">Sql语句</param>
        /// <returns></returns>
        public DataSet ExecuteQuery(string sql)
        {
            return ExecuteDataSet(this.ConnString, sql);
        }
        /// <summary>
        /// 执行查询返回DataSet
        /// </summary>
        /// <param name="sql">Sql语句</param>
        /// <param name="HtParams">SQL参数/值</param>
        /// <returns></returns>
        public DataSet ExecuteQuery(string sql,Hashtable HtParams)
        {
            List<SqlParameter> Sp = new List<SqlParameter>();
            foreach (var key in HtParams.Keys)
            {
                Sp.Add(new SqlParameter(key as string, HtParams[key]));
            }
            return ExecuteDataSet(this.ConnString, sql, Sp);
        }
        #region 创建连接，执行存储过程
         
        #endregion
        #region 创建连接，返回DataSet
        /// <summary>
        /// 执行一个查询语句，返回一个包含查询结果的DataSet
        /// </summary>
        /// <param name="ConnStr">连接串</param>
        /// <param name="SqlText">SQL语句</param>
        /// <param name="SqlParams">SQL参数/值</param>
        /// <returns></returns>
        private DataSet ExecuteDataSet(string ConnStr,string SqlText, List<SqlParameter> SqlParams)
        {
            DataSet ds = new DataSet();
            using (SqlConnection sqlConnection = new SqlConnection(ConnStr))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = new SqlCommand(SqlText, sqlConnection))
                {
                    cmd.CommandType = CommandType.Text;
                    foreach (var Param in SqlParams)
                    {
                        cmd.Parameters.Add(Param);
                    }
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(ds);
                }
            }
            return ds;
        }
        /// <summary>
        /// 执行一个查询语句，返回一个包含查询结果的DataSet
        /// </summary>
        /// <param name="ConnStr">连接串</param>
        /// <param name="SqlText">SQL语句</param>
        /// <returns></returns>
        private DataSet ExecuteDataSet(string ConnStr, string SqlText)
        {
            DataSet ds = new DataSet();
            using (SqlConnection sqlConnection = new SqlConnection(ConnStr))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = new SqlCommand(SqlText, sqlConnection))
                {
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(ds);
                }
            }
            return ds;
        }
        #endregion

        #region 创建连接，返回受影响行数
        private int CreateExecuteNonQuery(string ConnStr,string SqlText)
        {
            int i = 0;
            using (SqlConnection sqlConnection = new SqlConnection(ConnStr))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = new SqlCommand(SqlText, sqlConnection))
                {
                    cmd.CommandType = CommandType.Text;
                    i = cmd.ExecuteNonQuery();
                }
            }
            return i;
        }
        private int CreateExecuteNonQuery(string ConnStr, string SqlText,List<SqlParameter> SqlParams)
        {
            int i = 0;
            using (SqlConnection sqlConnection = new SqlConnection(ConnStr))
            {
                
                sqlConnection.Open();
                using (SqlCommand cmd = new SqlCommand(SqlText, sqlConnection))
                {
                    cmd.CommandType = CommandType.Text;
                    foreach (var Param in SqlParams)
                    {
                        cmd.Parameters.Add(Param);
                    }
                    i = cmd.ExecuteNonQuery();
                }
            }
            return i;
        }
        #endregion
    }
}
