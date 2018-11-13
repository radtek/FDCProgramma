using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using Models.Message;
using DAL.Public;

namespace BLL.Public
{
    /// <summary>
    /// 用户行为记录BLL
    /// </summary>
    public class BOperationRecord
    {
        private DOperationRecord DRecord;
        public BOperationRecord(string SQLConn)
        {
            DRecord = new DOperationRecord(SQLConn);
        }
        /// <summary>
        /// 行为记录处理
        /// </summary>
        /// <param name="UserGuid"></param>
        /// <param name="level"></param>
        /// <param name="Notes"></param>
        public void RecordHandle(string UserGuid,Level level,string Notes)
        {
            DRecord.Record(UserGuid, GetLevel(level), Notes);
        }
        /// <summary>
        /// 行为记录处理
        /// </summary>
        /// <param name="UserGuid"></param>
        /// <param name="level"></param>
        /// <param name="Notes"></param>
        /// <param name="SqlTxt"></param>
        public void RecordHandle(string UserGuid, Level level, string Notes,string SqlTxt)
        {
            DRecord.Record(UserGuid, GetLevel(level), Notes,SqlTxt);
        }
        /// <summary>
        /// 记录等级
        /// </summary>
        public enum Level
        {
            /// <summary>
            /// 日常操作
            /// </summary>
            Daily = 1,
            /// <summary>
            /// 较敏感操作
            /// </summary>
            Nomal = 2,
            /// <summary>
            /// 敏感操作
            /// </summary>
            Sensitive = 3

        }
        /// <summary>
        /// 获取记录等级
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
        public int GetLevel(Level level)
        {
            switch (level)
            {
                case Level.Daily:
                    return 1;
                case Level.Nomal:
                    return 2;
                case Level.Sensitive:
                    return 3;
                default:
                    return 1;
            }
        }
    }
}
