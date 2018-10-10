using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.User;
using System.Collections;
using System.ComponentModel;

namespace BLL.User
{
    public class B_Admin
    {
        /// <summary>
        /// 颜色
        /// </summary>
        public enum Color
        {
            [Description("水果")]
            red = 0,
            /// <summary>
            /// 绿色
            /// </summary>
            green = 1,
            /// <summary>
            /// 黄色
            /// </summary>
            yellow = 2
        }
        private string _Msg = "";
        /// <summary>
        /// 提示信息
        /// </summary>
        public string Msg
        {
            get { return _Msg; }
            set { _Msg = value;}
        }
        D_Admin da = new D_Admin();
        public bool b_Register(Hashtable Ht)
        {
            
            bool isok = false;
            try
            {
                int row = da.AdminRegister(Ht);
                if (row > 0)
                {
                    isok = true;
                }
            }
            catch (Exception ex)
            {
                Msg = "注册失败！原因是："+ex.ToString();
            }
            return isok;
        }
    }
}
