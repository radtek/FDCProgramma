using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Models.Message
{
    /// <summary>
    /// 弹窗提示类
    /// </summary>
    public static class Tips
    {
        /// <summary>
        /// 友好的信息弹窗提示
        /// </summary>
        public static void TipsInfoBox(string Message)
        {
            MessageBox.Show(Message,"温馨提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        /// <summary>
        /// 错误信息提示
        /// </summary>
        /// <param name="Message"></param>
        public static void TipsErrorBox(string Message)
        {
            MessageBox.Show(Message, "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
