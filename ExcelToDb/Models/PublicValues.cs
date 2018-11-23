using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Models
{
    /// <summary>
    /// 全局静态常量
    /// </summary>
    public static class PublicValues
    {
        /// <summary>
        /// 日志目录
        /// </summary>
        public static string LogFilePath = Application.StartupPath + @"\Log.txt";
    }
}
