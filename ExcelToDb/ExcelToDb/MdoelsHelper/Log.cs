using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToDb.MdoelsHelper
{
    /// <summary>
    /// 写入本地文件的日志类
    /// </summary>
    public class Log
    {
        public string _FilePath;
        private StreamWriter writer;
        private FileStream fileStream = null;
        /// <summary>
        /// 实例化传入路径
        /// </summary>
        /// <param name="FileName"></param>
        public Log(string FilePath)
        {
            this._FilePath = FilePath;
            //验证
            CreateDirectory(_FilePath);
        }
        /// <summary>
        /// Log日志写入本地文件
        /// </summary>
        /// <param name="info"></param>
        public void LogWrite(string Remarks,string info)
        {
            try
            {
                System.IO.FileInfo fileInfo = new System.IO.FileInfo(_FilePath);
                if (!fileInfo.Exists)
                {
                    fileStream = fileInfo.Create();
                    writer = new StreamWriter(fileStream);
                }
                else
                {
                    fileStream = fileInfo.Open(FileMode.Append, FileAccess.Write);
                    writer = new StreamWriter(fileStream);
                }
                writer.WriteLine(DateTime.Now + "--类型:" + Remarks + "---->" + "\r\n描述：" + info);

            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                    writer.Dispose();
                    fileStream.Close();
                    fileStream.Dispose();
                }
            }
        }
        /// <summary>
        /// 判断写入文件是否存在，不存在就创建
        /// </summary>
        /// <param name="infoPath"></param>
        public void CreateDirectory(string FilePath)
        {
            DirectoryInfo directoryInfo = Directory.GetParent(FilePath);
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }
        }
        /// <summary>
        /// 获取文件大小
        /// </summary>
        /// <param name="sFullName"></param>
        /// <returns></returns>
        public static long GetFileSize(string sFullName)
        {
            long lSize = 0;
            if (File.Exists(sFullName))
                lSize = new FileInfo(sFullName).Length;
            return lSize;
        }
        /// <summary>
        /// 计算文件大小函数(保留两位小数),Size为字节大小
        /// </summary>
        /// <param name="Size"></param>
        /// <returns></returns>
        public static string CountSize(long Size)
        {
            string m_strSize = "";
            long FactSize = 0;
            FactSize = Size;
            if (FactSize < 1024.00)
                m_strSize = FactSize.ToString("F2") + "Byte";
            else if (FactSize >= 1024.00 && FactSize < 1048576)
                m_strSize = (FactSize / 1024.00).ToString("F2") + "K";
            else if (FactSize >= 1048576 && FactSize < 1073741824)
                m_strSize = (FactSize / 1024.00 / 1024.00).ToString("F2") + "M";
            else if (FactSize >= 1073741824)
                m_strSize = (FactSize / 1024.00 / 1024.00 / 1024.00).ToString("F2") + "G";
            return m_strSize;
        }
        /// <summary>
        /// 获取文件大小
        /// </summary>
        /// <param name="FilePath"></param>
        /// <returns>/1M/2G</returns>
        public string GetFileLength(string FilePath)
        {
            return CountSize(GetFileSize(FilePath));
        }
    }
}
