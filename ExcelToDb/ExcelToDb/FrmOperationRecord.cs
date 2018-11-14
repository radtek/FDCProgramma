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
using BLL;
using BLL.Public;
using BLL.Record;

namespace ExcelToDb
{
    public partial class FrmOperationRecord : Form
    {
        B_Validate bv = new B_Validate();
        BRecord  BRecord;
        private AdminMsg TheUser;
        public FrmOperationRecord(AdminMsg LoginMsg)
        {
            InitializeComponent();
            BRecord = new BRecord(LoginMsg.SqlConn);
            TheUser = LoginMsg;
        }

        private void FrmOperationRecord_Load(object sender, EventArgs e)
        {
            try
            {
                //验证登陆者身份
                //如果不符要求，要重新登录
                string Message = ""; bool HasError = true;
                bv.ValidateCard(TheUser, ref Message, ref HasError);
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
            dataGridView1.DataSource = BRecord.GetRecordTable(TheUser.AdminGuid);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //双击刷新数据源
            dataGridView1.DataSource = BRecord.GetRecordTable(TheUser.AdminGuid);
        }
    }
}
