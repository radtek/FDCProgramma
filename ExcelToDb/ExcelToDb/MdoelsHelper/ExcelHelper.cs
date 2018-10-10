using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.HSSF.UserModel;
using System.Data;
using System.IO;

namespace ExcelToDb.Mdoels
{
    /// <summary>
    /// 引用NOPI操作Excel和Word
    /// </summary>
    public  class ExcelHelper : IDisposable
    {
        private string fileName = null; //文件名
        private IWorkbook workbook = null;
        private FileStream fs = null;
        private bool disposed;

        public ExcelHelper(string fileName)
        {
            this.fileName = fileName;
            disposed = false;
        }

        /// <summary>
        /// 将DataTable数据导入到excel中
        /// </summary>
        /// <param name="data">要导入的数据</param>
        /// <param name="isColumnWritten">DataTable的列名是否要导入</param>
        /// <param name="sheetName">要导入的excel的sheet的名称</param>
        /// <returns>导入数据行数(包含列名那一行)</returns>
        public int DataTableToExcel(DataTable data, string sheetName, bool isColumnWritten)
        {
            int i = 0;
            int j = 0;
            int count = 0;
            ISheet sheet = null;

            fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            if (fileName.IndexOf(".xlsx") > 0) // 2007版本
                workbook = new XSSFWorkbook();
            else if (fileName.IndexOf(".xls") > 0) // 2003版本
                workbook = new HSSFWorkbook();

            try
            {
                if (workbook != null)
                {
                    sheet = workbook.CreateSheet(sheetName);
                }
                else
                {
                    return -1;
                }

                if (isColumnWritten == true) //写入DataTable的列名
                {
                    IRow row = sheet.CreateRow(0);
                    for (j = 0; j < data.Columns.Count; ++j)
                    {
                        row.CreateCell(j).SetCellValue(data.Columns[j].ColumnName);
                    }
                    count = 1;
                }
                else
                {
                    count = 0;
                }

                for (i = 0; i < data.Rows.Count; ++i)
                {
                    IRow row = sheet.CreateRow(count);
                    for (j = 0; j < data.Columns.Count; ++j)
                    {
                        row.CreateCell(j).SetCellValue(data.Rows[i][j].ToString());
                    }
                    ++count;
                }
                workbook.Write(fs); //写入到excel
                return count;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
                return -1;
            }
        }

        /// <summary>
        /// 将excel中的数据导入到DataTable中
        /// </summary>
        /// <param name="sheetName">excel工作薄sheet的名称</param>
        /// <param name="isFirstRowColumn">第一行是否是DataTable的列名</param>
        /// <returns>返回的DataTable</returns>
        public DataTable ExcelToDataTable(string sheetName, bool isFirstRowColumn)
        {
            ISheet sheet = null;
            DataTable data = new DataTable();
            int startRow = 0;
            try
            {
                fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                if (fileName.IndexOf(".xlsx") > 0) // 2007版本
                    workbook = new XSSFWorkbook(fs);
                else if (fileName.IndexOf(".xls") > 0) // 2003版本
                    workbook = new HSSFWorkbook(fs);

                if (sheetName != null)
                {
                    sheet = workbook.GetSheet(sheetName);
                    if (sheet == null) //如果没有找到指定的sheetName对应的sheet，则尝试获取第一个sheet
                    {
                        sheet = workbook.GetSheetAt(0);
                    }
                }
                else
                {
                    sheet = workbook.GetSheetAt(0);
                }
                if (sheet != null)
                {
                    IRow firstRow = sheet.GetRow(0);
                    int cellCount = firstRow.LastCellNum; //一行最后一个cell的编号 即总的列数

                    if (isFirstRowColumn)
                    {
                        for (int i = firstRow.FirstCellNum; i < cellCount; ++i)
                        {
                            ICell cell = firstRow.GetCell(i);
                            if (cell != null)
                            {
                                string cellValue = cell.StringCellValue;
                                if (cellValue != null)
                                {
                                    DataColumn column = new DataColumn(cellValue);
                                    data.Columns.Add(column);
                                }
                            }
                        }
                        startRow = sheet.FirstRowNum + 1;
                    }
                    else
                    {
                        startRow = sheet.FirstRowNum;
                    }

                    //最后一列的标号
                    int rowCount = sheet.LastRowNum;
                    for (int i = startRow; i <= rowCount; i++)
                    {
                        IRow row = sheet.GetRow(i);
                        if (row == null) continue; //没有数据的行默认是null　　　　　　　

                        DataRow dataRow = data.NewRow();
                        for (int j = row.FirstCellNum; j < cellCount; j++)
                        {
                            if (row.GetCell(j) != null) //同理，没有数据的单元格都默认是null
                                dataRow[j] = row.GetCell(j).ToString();
                        }
                        data.Rows.Add(dataRow);
                    }
                }

                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
                return null;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    if (fs != null)
                        fs.Close();
                }

                fs = null;
                disposed = true;
            }
        }
        #region 
        ///// <summary>
        ///// 将DataTable中数据写入数据库中
        ///// </summary>
        ///// <param name="dt"></param>
        ///// <returns></returns>
        //public static bool WriteDataToDB(DataTable dt)
        //{
        //    if (dt == null || dt.Rows.Count == 0)
        //    {
        //        return true;
        //    }
        //    string tname = dt.TableName;
        //    string colNames = "";
        //    for (int i = 0; i < dt.Columns.Count; i++)
        //    {
        //        colNames += dt.Columns[i].ColumnName + ",";
        //    }
        //    colNames = colNames.TrimEnd(',');
        //    string cmd = "";
        //    string colValues;
        //    string cmdmode = string.Format("insert into {0}({1}) values({{0}});", tname, colNames);
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        colValues = "";
        //        for (int j = 0; j < dt.Columns.Count; j++)
        //        {
        //            if (dt.Rows[i][j].GetType() == typeof(DBNull))
        //            {
        //                colValues += "NULL,";
        //                continue;
        //            }
        //            if (dt.Columns[j].DataType == typeof(string))
        //                colValues += string.Format("'{0}',", dt.Rows[i][j]);
        //            else if (dt.Columns[j].DataType == typeof(int) || dt.Columns[j].DataType == typeof(float) || dt.Columns[j].DataType == typeof(double))
        //            {
        //                colValues += string.Format("{0},", dt.Rows[i][j]);
        //            }
        //            else if (dt.Columns[j].DataType == typeof(DateTime))
        //            {
        //                colValues += string.Format("cast('{0}' as datetime),", dt.Rows[i][j]);
        //            }
        //            else if (dt.Columns[j].DataType == typeof(bool))
        //            {
        //                colValues += string.Format("{0},", dt.Rows[i][j].ToString());
        //            }
        //            else
        //                colValues += string.Format("'{0}',", dt.Rows[i][j]);
        //        }
        //        cmd = string.Format(cmdmode, colValues.TrimEnd(','));
        //    }
        //    int ret = 0;
        //    try
        //    {
        //        ret = DbHelperSQL.ExecuteSql(cmd);
        //    }
        //    catch (Exception e)
        //    {
        //        //写错误日志...
        //        string strOuput = string.Format("向数据库中写数据失败,错误信息:{0},异常{1}\n", e.Message, e.InnerException);
        //        //将信息写入到日志输出文件
        //        DllComm.TP_WriteAppLogFileEx(DllComm.g_AppLogFileName, strOuput);

        //    }
        //    if (ret == -1)
        //    {
        //        return false;
        //    }
        //    return true;

        //}

        ///// <summary>
        ///// 写入基础数据，并删除其中的重复的项目
        ///// </summary>
        ///// <param name="dt"></param>
        ///// <param name="KeyName">主键</param>
        ///// <param name="icol">主键所在的列</param>
        ///// <returns></returns>
        //public static bool WriteDataToDB(DataTable dt, string KeyName, int icol)
        //{
        //    //删除数据库中的重复项目
        //    string mKeyStr = "";
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        mKeyStr += "'" + dt.Rows[i][icol] + "',";
        //    }
        //    mKeyStr = mKeyStr.Trim(',');
        //    string sqlStr = "Delete  from  " + dt.TableName + " where " + KeyName + " in (" + mKeyStr + ")";
        //    DbHelperSQL.ExecuteSql(sqlStr);

        //    //向数据库中写入新的数据
        //    string tname = dt.TableName;
        //    string colNames = "";
        //    for (int i = 0; i < dt.Columns.Count; i++)
        //    {
        //        colNames += dt.Columns[i].ColumnName + ",";
        //    }
        //    colNames = colNames + "CreateDate ";

        //    string cmd = "";
        //    string colValues;
        //    string cmdmode = string.Format("insert into {0}({1}) values({{0}});", tname, colNames);
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        colValues = "";
        //        for (int j = 0; j < dt.Columns.Count; j++)
        //        {
        //            if (dt.Rows[i][j].GetType() == typeof(DBNull))
        //            {
        //                colValues += "NULL,";
        //                continue;
        //            }
        //            if (dt.Columns[j].DataType == typeof(string))
        //            {
        //                colValues += string.Format("'{0}',", dt.Rows[i][j]);
        //            }
        //            else if (dt.Columns[j].DataType == typeof(int) || dt.Columns[j].DataType == typeof(float) || dt.Columns[j].DataType == typeof(double))
        //            {
        //                colValues += string.Format("{0},", dt.Rows[i][j]);
        //            }
        //            else if (dt.Columns[j].DataType == typeof(DateTime))
        //            {
        //                colValues += string.Format("cast('{0}' as datetime),", dt.Rows[i][j]);
        //            }
        //            else if (dt.Columns[j].DataType == typeof(bool))
        //            {
        //                colValues += string.Format("{0},", dt.Rows[i][j].ToString());
        //            }
        //            else
        //                colValues += string.Format("'{0}',", dt.Rows[i][j]);
        //        }
        //        colValues += "getdate()";
        //        cmd = string.Format(cmdmode, colValues);

        //        int ret = 0;
        //        try
        //        {
        //            ret = DbHelperSQL.ExecuteSql(cmd);
        //        }
        //        catch (Exception e)
        //        {
        //            //写错误日志...
        //            string strOuput = string.Format("向数据库中写数据失败,错误信息:{0},异常{1}\n", e.Message, e.InnerException);
        //            //将信息写入到日志输出文件
        //            DllComm.TP_WriteAppLogFileEx(DllComm.g_AppLogFileName, strOuput);

        //        }
        //        if (ret == -1)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}
        #endregion


    }
}
