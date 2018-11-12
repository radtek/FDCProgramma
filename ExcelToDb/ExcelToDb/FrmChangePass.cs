using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models.Message;
using Models;
using BLL.Public;

namespace ExcelToDb
{
    public partial class FrmChangePass : Form
    {
        B_Validate bv = new B_Validate();
        private AdminMsg LoginInMsg = null;
        public FrmChangePass(AdminMsg LoginMsg)
        {
            InitializeComponent();
            LoginInMsg = LoginMsg;
        }
        private void FrmChangePass_Load(object sender, EventArgs e)
        {
            try
            {
                //验证登陆者身份
                //如果不符要求，要重新登录
                string Message = ""; bool HasError = true;
                bv.ValidateCard(LoginInMsg, ref Message, ref HasError);
                if (HasError)
                {
                    MessageBox.Show(Message, "安全提醒", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Hide();
                    FrmLogin login = new FrmLogin();
                    login.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Tips.TipsInfoBox(ex.Message);
            }
        }
        private void BtnEnter_Click(object sender, EventArgs e)
        {
            string YPass = Tb_YPass.Text;
            string NPass = Tb_NPass.Text;
            string EnterPass = Tb_EnterPass.Text;
            string PrivateKey = Tb_PrivateKey.Text;
            if (string.IsNullOrEmpty(YPass) 
                || string.IsNullOrEmpty(NPass) 
                || string.IsNullOrEmpty(EnterPass) 
                || string.IsNullOrEmpty(PrivateKey))
            {
                Tips.TipsErrorBox("请按要求输入该填写的项！");
            }
            else
            {
                if (!NPass.Equals(EnterPass))
                {
                    Tips.TipsErrorBox("2次新密码输入不一致请重新输入！");
                    Tb_EnterPass.Text = "";
                    Tb_NPass.Text = "";
                }
                else
                {
                    //执行数据更改操作
                }
            }
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Cb_PassShow_Click(object sender, EventArgs e)
        {

        }

        private void Cb_PassShow_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb_PassShow.Checked)
            {
                Tb_NPass.UseSystemPasswordChar = false;
                Tb_NPass.PasswordChar = new char();
                Tb_YPass.UseSystemPasswordChar = false;
                Tb_YPass.PasswordChar = new char();
                Tb_EnterPass.UseSystemPasswordChar = false;
                Tb_EnterPass.PasswordChar = new char();
            }
            else
            {
                Tb_NPass.UseSystemPasswordChar = true;
                Tb_NPass.PasswordChar = '*';
                Tb_YPass.UseSystemPasswordChar = true;
                Tb_YPass.PasswordChar = '*';
                Tb_EnterPass.UseSystemPasswordChar = true;
                Tb_EnterPass.PasswordChar = '*';
            }
        }
    }
}
