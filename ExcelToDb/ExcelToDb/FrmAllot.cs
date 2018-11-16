using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Employee;
using Models;
using Models.Message;
using BLL.Public;
    

namespace ExcelToDb
{
    public partial class FrmAllot : Form
    {
        BOperationRecord BOperation;
        B_Validate bv = new B_Validate();
        BEmployee be;
        private AdminMsg LoginMsg = null;
        public FrmAllot(AdminMsg LoginUser)
        {
            InitializeComponent();
            be = new BEmployee(LoginUser.SqlConn);
            LoginMsg = LoginUser;
            InitializeComponent();
            BOperation = new BOperationRecord(LoginUser.SqlConn);
        }

        private void FrmAllot_Load(object sender, EventArgs e)
        {
            try
            {
                //验证登陆者身份
                //如果不符要求，要重新登录
                string Message = ""; bool HasError = true;
                bv.ValidateCard(LoginMsg, ref Message, ref HasError);
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
            string ENum = be.GetEmployNum(LoginMsg.AdminGuid).ToString();
            Tb_EmployeeNum2.Text = ENum;
            Tb_EmployeeNum1.Text = ENum;
        }
    }
}
