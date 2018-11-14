using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL.Record;

namespace BLL.Record
{
    public class BRecord
    {
        DRecord D_Record;
        public BRecord(string SqlConn)
        {
            D_Record = new DRecord(SqlConn);
        }
        /// <summary>
        /// 返回操作日志记录Table
        /// </summary>
        /// <param name="LoginGuid"></param>
        /// <returns></returns>
        public DataTable GetRecordTable(string LoginGuid)
        {
            return D_Record.GetOperationRecord(LoginGuid);
        }
    }
}
