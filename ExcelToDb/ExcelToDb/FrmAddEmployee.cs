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
using BLL.Employee;
using BLL.Public;

namespace ExcelToDb
{
    public partial class FrmAddEmployee : Form
    {
        B_Validate bv = new B_Validate();
        BEmployee be;
        private AdminMsg SystemMsg = null;
        public FrmAddEmployee(AdminMsg LoginUser)
        {
            be = new BEmployee(LoginUser.SqlConn);
            SystemMsg = LoginUser;
            InitializeComponent();
            
        }
        private void FrmAddEmployee_Load(object sender, EventArgs e)
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
            }
            catch (Exception ex)
            {
                Tips.TipsInfoBox(ex.Message);
            }
            Tb_EmlpoyeeCode.Text = DateTime.Now.ToString("yyyyMMddHHmmss");
            Tb_CreateDate.Text = DateTime.Now.ToString("yyyy年MM月dd日 HH时mm分");
            Tb_BelongTo.Text = SystemMsg.AdminNickName;
        }
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            string Name = Tb_EmployeeName.Text;
            string Tel = Tb_EmployeeTel.Text;
            string Pass = Tb_Passwords.Text;
            if (string.IsNullOrEmpty(Name) || 
                string.IsNullOrEmpty(Tel) || 
                string.IsNullOrEmpty(Pass) 
                
                )
            {
                Tips.TipsErrorBox("信息填入不完整，请再确认一下！");
            }
            else
            {
                string ErrorMsg = string.Empty;
                Dictionary<string, object> Params = new Dictionary<string, object>();
                Params.Add("GUID",Guid.NewGuid().ToString());
                Params.Add("Code",Tb_EmlpoyeeCode.Text);
                Params.Add("Tel",Tel);
                Params.Add("Pass",Pass);
                Params.Add("Name",Name);
                Params.Add("Belong",SystemMsg.AdminGuid);
                Params.Add("Operator",GetRedioCheck());
                Params.Add("Sex",GetEmployeeSex());
                //执行存储操作
                if (!be.AddEmployee(Params, ref ErrorMsg))
                {
                    Tips.TipsErrorBox(ErrorMsg);
                }
                else
                {
                    Tips.TipsInfoBox("添加成功！");
                    Tb_EmployeeName.Text = "";
                    Tb_EmployeeTel.Text = "";
                    Tb_Passwords.Text = "";
                    Tb_EmlpoyeeCode.Text = DateTime.Now.ToString("yyyyMMddHHmmss");
                }
            }
        }
        private int GetEmployeeSex()
        {
            if (Cb_Man.Checked)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        private void Tb_EmlpoyeeCode_DoubleClick(object sender, EventArgs e)
        {
            //双击员工编号刷新编号
            Tb_EmlpoyeeCode.Text = DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        private void Cb_Man_Click(object sender, EventArgs e)
        {
            Cb_Man.Checked = true;
            Cb_Women.Checked = false;
        }

        private void Cb_Women_Click(object sender, EventArgs e)
        {
            Cb_Man.Checked = false;
            Cb_Women.Checked = true;
        }
        public string GetRedioCheck()
        {
            if (Rb_YiDong.Checked)
            {
                return Rb_YiDong.Text;
            }
            if (Rb_DianXin.Checked)
            {
                return Rb_DianXin.Text;
            }
            if (Rb_LianTong.Checked)
            {
                return Rb_LianTong.Text;
            }
            if (Rb_Other.Checked)
            {
                return Rb_Other.Text;
            }
            else
            {
                return Rb_YiDong.Text;
            }
        }
    }
}
