using DAL.Public;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL.Distribute
{
    /// <summary>
    /// 分配处理DAL
    /// </summary>
    public class DAllotHandle
    {
        /// <summary>
        /// 传递过来的连接串
        /// </summary>
        private string SystemSqlConn = "";
        DBOperate operate;
        public DAllotHandle(string SqlConn)
        {
            this.SystemSqlConn = SqlConn;
            operate = new DBOperate(SystemSqlConn);
        }
        /// <summary>
        /// 获取自动分配的数据源
        /// </summary>
        /// <param name="NeedNum"></param>
        /// <param name="LoginGuid"></param>
        /// <returns></returns>
        public DataTable GetAutoTable(int NeedNum,string LoginGuid,ref int RowsCount)
        {
            string SQL = string.Format(@"SELECT TOP({0}) CF_NickName AS Name,
                                        CF_ID AS ID,
                                        CF_Tel AS Tel,
                                        CF_BelongOperator AS Company 
                                        FROM Tb_CustomInformation 
                                        WHERE CF_IsUsed = 0 AND 
                                        CF_UserGuid = '{1}' 
                                        ORDER BY CF_CreateDate DESC;", NeedNum,LoginGuid);
            DataSet Result = operate.ExecuteQuery(SQL);
            if (Result.Tables.Count > 0)
            {
                RowsCount = Result.Tables[0].Rows.Count;
                return Result.Tables[0];
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 增加任务主表记录
        /// </summary>
        /// <param name="BillNo">流水号</param>
        /// <param name="Guid">GUID</param>
        /// <param name="Count">数量</param>
        /// <param name="Name">姓名</param>
        /// <param name="IsOK">结果</param>
        /// <param name="Msg">信息</param>
        public void AddTaskMain(string BillNo,string Guid,int Count,string Name,ref bool IsOK,ref string Msg)
        {
            try
            {
                string TmSql = string.Format(@"Exec Proc_TaskMain_Add '{0}','{1}',{2},'{3}'", BillNo, Guid, Count, Name);
                if (operate.ExecuteNonQuery(TmSql) > 0)
                {
                    IsOK = true;
                    Msg = "";
                } 
            }
            catch (Exception ex)
            {
                IsOK = false;
                Msg = ex.Message;
            }
        }
        /// <summary>
        /// 增加任务字表记录
        /// </summary>
        /// <param name="ET_No">流水号</param>
        /// <param name="Name">名称</param>
        /// <param name="Tel">电话</param>
        /// <param name="Sort">排序</param>
        /// <param name="Company">运营商</param>
        public void AddTaskSub(string ET_No,string Name,string Tel,int Sort,string Company,int Customer_ID)
        {
            string SQL = string.Format(@"Exec Proc_TaskSub_Add '{0}','{1}','{2}',{3},'{4}',{5}",
                                            ET_No,
                                            Name,
                                            Tel,
                                            Sort,
                                            Company,
                                            Customer_ID
                                            );
            operate.ExecuteNonQuery(SQL);
        }
    }
}
