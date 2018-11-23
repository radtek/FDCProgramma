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
using BLL.Distribute;
using ExcelToDb.MdoelsHelper;

namespace ExcelToDb
{
    public partial class FrmAllot : Form
    {
        
        BOperationRecord BOperation;
        B_Validate bv = new B_Validate();
        BEmployee be;
        int EmployNum;
        BAllotHandle BAllotHandle;
        private AdminMsg LoginMsg = null;
        Log log;
        public FrmAllot(AdminMsg LoginUser)
        {
            InitializeComponent();
            be = new BEmployee(LoginUser.SqlConn);
            LoginMsg = LoginUser;
            InitializeComponent();
            BOperation = new BOperationRecord(LoginUser.SqlConn);
            BAllotHandle = new BAllotHandle(LoginUser);
            log = new Log(PublicValues.LogFilePath);
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
            EmployNum = be.GetEmployNum(LoginMsg.AdminGuid);
            Tb_EmployeeNum2.Text = EmployNum.ToString();
            Tb_EmployeeNum1.Text = EmployNum.ToString();
        }

        private void BtnAutoAllotHandle_Click(object sender, EventArgs e)
        {
            try
            {
                BAllotHandle.MaxTaskNum = 50;
                BAllotHandle.AutoAllotHandle(EmployNum, LoginMsg.AdminGuid);
            }
            catch (Exception ex)
            {
                //日志记录
                Tips.TipsErrorBox(ex.Message);
                log.LogWrite("行为记录","账号：" + LoginMsg.AdminLoginCode + "--执行自动均分任务！");
            }
            
        }

        private void BtnHandle_Click(object sender, EventArgs e)
        {
            try
            {
                BAllotHandle.MaxTaskNum = Convert.ToInt32(Tb_InputNum.Text == "" ?"0": Tb_InputNum.Text);
                BAllotHandle.AutoAllotHandle(EmployNum, LoginMsg.AdminGuid);
            }
            catch (Exception ex)
            {
                //日志记录
                Tips.TipsErrorBox(ex.Message);
                log.LogWrite("行为记录", "账号：" + LoginMsg.AdminLoginCode + "--执行手动均分任务！" + "单人日任务量：" + BAllotHandle.MaxTaskNum);
            }
        }
    }
}
