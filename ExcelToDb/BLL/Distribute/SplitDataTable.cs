using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL.Distribute
{
    /// <summary>
    /// 拆分DataTable帮助类
    /// </summary>
    public static class SplitDataTable
    {
        /// <summary>
        /// DataTable分组
        /// </summary>
        /// <param name="source">数据源（要拆分的数据）类型转换</param>
        /// <param name="destination">分组结果</param>
        /// <param name="groupByFields">分组条件</param>
        /// <param name="fieldIndex">条件个数</param>
        /// <param name="schema">数据源（要拆分的数据）</param>
        public static void GroupDataRows(IEnumerable<DataRow> source, List<DataTable> destination, string[] groupByFields, int fieldIndex, DataTable schema)
        {
            if (fieldIndex >= groupByFields.Length || fieldIndex < 0)
            {
                DataTable dt = schema.Clone();
                foreach (DataRow row in source)
                {
                    DataRow dr = dt.NewRow();
                    dr.ItemArray = row.ItemArray;
                    dt.Rows.Add(dr);
                }
                destination.Add(dt);
                return;
            }

            var results = source.GroupBy(o => o[groupByFields[fieldIndex]]);
            foreach (var rows in results)
            {
                GroupDataRows(rows, destination, groupByFields, fieldIndex + 1, schema);
            }
            fieldIndex++;
        }
    }
}
