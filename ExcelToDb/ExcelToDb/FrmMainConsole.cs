using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelToDb
{
    public partial class FrmMainConsole : Form
    {
        public FrmMainConsole()
        {
            InitializeComponent();
        }
        private void FrmMainConsole_Load(object sender, EventArgs e)
        {
            //设置系统显示时间
            LbNowDate.Text = "系统时间 :" + DateTime.Now.ToString("f");




        }
    }
}
