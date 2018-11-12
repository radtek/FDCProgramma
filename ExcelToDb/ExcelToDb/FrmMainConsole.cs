using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using Models.Message;
using BLL.Public;
using BLL.Employee;

namespace ExcelToDb
{
    public partial class FrmMainConsole : Form
    {
        BEmployee bEmployee;
        B_Validate bv = new B_Validate();
        /// <summary>
        /// AdminMsg登录对象
        /// </summary>
        private AdminMsg SystemMsg = null;
        public FrmMainConsole(AdminMsg msg)
        {
            InitializeComponent();
            this.SystemMsg = msg;
            bEmployee = new BEmployee(msg.SqlConn);
        }

        private void FrmMainConsole_Load(object sender, EventArgs e)
        {
            try
            {
                //验证登陆者身份
                //如果不符要求，要重新登录
                string Message = ""; bool HasError = true;
                bv.ValidateCard(SystemMsg, ref Message, ref HasError);
                if (HasError)
                {
                    MessageBox.Show(Message, "安全提醒", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Hide();
                    FrmLogin login = new FrmLogin();
                    login.ShowDialog();
                }
                Lb_Msg.Text = string.Format("尊敬的‘{0}’会员,欢迎登入！", SystemMsg.AdminNickName);
                //查询员工列表，把下属员工全部陈列统计
                DataTable result = bEmployee.GetEmployeeGroup(SystemMsg.AdminGuid);
                DGVEmployeeList.DataSource = result;
                TbEmployeeCountNum.Text = result.Rows.Count.ToString();

            }
            catch (Exception ex)
            {
                Tips.TipsInfoBox(ex.Message);
            }

        }

        private void 新增操作人员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddEmployee frmAddEmployee = new FrmAddEmployee(SystemMsg);
            frmAddEmployee.ShowDialog();
        }

        private void DGVEmployeeList_Click(object sender, EventArgs e)
        {
            //点击数据表格，刷新数据源
            DataTable result = bEmployee.GetEmployeeGroup(SystemMsg.AdminGuid);
            DGVEmployeeList.DataSource = result;
            TbEmployeeCountNum.Text = result.Rows.Count.ToString();
        }
    }
}
