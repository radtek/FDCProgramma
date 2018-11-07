﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using BLL.Public;

namespace ExcelToDb
{
    public partial class FrmMainConsole : Form
    {
        B_Validate bv = new B_Validate();
        /// <summary>
        /// AdminMsg登录对象
        /// </summary>
        private AdminMsg SystemMsg = null;
        public FrmMainConsole(AdminMsg msg)
        {
            InitializeComponent();
            this.SystemMsg = msg;
        }
        private void FrmMainConsole_Load(object sender, EventArgs e)
        {
            //验证登陆者身份
            //如果不符要求，要重新登录
            string Message = "";bool HasError = true; 
            bv.ValidateCard(SystemMsg,ref Message,ref HasError);
            if (HasError)
            {
                MessageBox.Show(Message, "安全提醒", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Hide();
                FrmLogin login = new FrmLogin();
                login.ShowDialog();
            }

        }
    }
}
