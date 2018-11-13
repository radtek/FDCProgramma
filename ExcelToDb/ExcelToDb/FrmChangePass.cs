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
using BLL.User;

namespace ExcelToDb
{
    public partial class FrmChangePass : Form
    {
        BOperationRecord BOperation;
        B_User bu;
        B_Validate bv = new B_Validate();
        private AdminMsg LoginInMsg = null;
        public FrmChangePass(AdminMsg LoginMsg)
        {
            InitializeComponent();
            LoginInMsg = LoginMsg;
            bu = new B_User(LoginInMsg.SqlConn);
            BOperation = new BOperationRecord(LoginInMsg.SqlConn);
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
                    //行为记录
                    BOperation.RecordHandle(LoginInMsg.AdminGuid, BOperationRecord.Level.Sensitive, "修改密码", "Exec Proc_User_ChangePass");
                    //执行数据更改操作
                    bool HasEror = false;
                    string Message = "";
                    bu.ChangePass(LoginInMsg.AdminGuid, YPass, NPass, PrivateKey,ref  HasEror, ref Message);
                    if (!HasEror)
                    {
                        Tips.TipsErrorBox(Message);
                        ClearBox();
                    }
                    else
                    {
                        Tips.TipsInfoBox("恭喜~密码修改成功！");
                        ClearBox();
                    }
                }
            }
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        /// <summary>
        /// 清空输入框
        /// </summary>
        public void ClearBox()
        {
            Tb_NPass.Text = "";
            Tb_YPass.Text = "";
            Tb_EnterPass.Text = "";
            Tb_EnterPass.Text = "";
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
