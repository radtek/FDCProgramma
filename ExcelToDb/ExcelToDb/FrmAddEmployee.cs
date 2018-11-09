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

namespace ExcelToDb
{
    public partial class FrmAddEmployee : Form
    {
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
            Tb_EmlpoyeeCode.Text = DateTime.Now.ToString("yyyyMMddHHmmss");
            Tb_CreateDate.Text = DateTime.Now.ToString("yyyy年MM月dd日 HH时mm分");
            Tb_BelongTo.Text = SystemMsg.AdminNickName;
            //设置默认选中供应商
            CbList_Operator.SetSelected(0, true);
            CbList_Operator.SetItemChecked(0, true);
        }
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            string Name = Tb_EmployeeName.Text;
            string Tel = Tb_EmployeeTel.Text;
            string Pass = Tb_Passwords.Text;
            if (string.IsNullOrEmpty(Name) || 
                string.IsNullOrEmpty(Tel) || 
                string.IsNullOrEmpty(Pass) ||
                CbList_Operator.SelectedItem == null
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
                Params.Add("Operator",CbList_Operator.SelectedItem.ToString());
                Params.Add("Sex",GetEmployeeSex());
                //执行存储操作
                if (!be.AddEmployee(Params, ref ErrorMsg))
                {
                    Tips.TipsErrorBox(ErrorMsg);
                }
                else
                {
                    Tips.TipsInfoBox("添加成功！");
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
    }
}
