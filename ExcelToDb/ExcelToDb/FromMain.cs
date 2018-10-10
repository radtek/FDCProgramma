using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NPOI.HSSF.UserModel;
using System.IO;
using ExcelToDb.Mdoels;
using System.Threading;
using System.Configuration;

namespace ExcelToDb
{
    public partial class FormMain : Form
    {
        //数据库连接
        private string connStr = ConfigurationManager.ConnectionStrings["strCon"].ToString();
        //Excel文件路径
        public string ExecFilePath = string.Empty;
        //创建提示框
        private Msg msg = new Msg();
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //服务器位置存放
            //List<ConnItem> CSItem = new List<ConnItem>();
            //CSItem.Add(new ConnItem { ServerName = "测试服务器①",ServerAddress = ""});
            //CSItem.Add(new ConnItem { ServerName = "测试服务器②", ServerAddress = "" });
            //CSItem.Add(new ConnItem { ServerName = "测试服务器③", ServerAddress = "" });
            //CbServer.DataSource = CSItem;
            ////把实体类映射到Commbox中
            //CbServer.DisplayMember = "ServerName";
            ////插入0移动/1联通/2电信
            //List<ListItem> CbItem = new List<ListItem>();
            //CbItem.Add(new ListItem { Name = "联通用户",Value = 1 });
            //CbItem.Add(new ListItem { Name = "移动用户", Value = 0 });
            //CbItem.Add(new ListItem { Name = "电信用户", Value = 2 });
            //CbItem.Add(new ListItem { Name = "其他用户", Value = 3 });
            //CbType.DataSource = CbItem;
            //CbType.DisplayMember = "Name";
            ////默认选中第一个
            //CbType.SelectedIndex = 0;

        }

        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFile = new OpenFileDialog();
            OpenFile.ShowDialog();
            if (OpenFile.SafeFileName == "")
            {
                MessageBox.Show("请选择有效存在的文件！");
                return;
            }
            ExecFilePath = OpenFile.FileName;
            TbFileName.Text = ExecFilePath;
            TbFileName.TextAlign = HorizontalAlignment.Center;
            string _SafeName = OpenFile.SafeFileName;
            //获取文件扩展名
            string TheSafeFileName = _SafeName.Substring(_SafeName.LastIndexOf('.'));
            //验证文件扩展名
            if (TheSafeFileName != ".xls" && TheSafeFileName != ".xlsx")
            {
                //清空显示
                TbFileName.Text = "";
                MessageBox.Show("请选择有效的Excel文件！");
                ExecFilePath = string.Empty;
            }

        }
        /// <summary>
        /// 对话框提示
        /// </summary>
        /// <param name="MessageStr">提示内容</param>
        /// <param name="TitleStr">提示标题</param>
        /// <returns></returns>
        public bool IsCheckOK(string MessageStr,string TitleStr)
        {
            //默认未选中
            bool CheckResult = false;
            //消息框中需要显示哪些按钮，此处显示“确定”和“取消”
            MessageBoxButtons MessButton = MessageBoxButtons.OKCancel;
            //默认情况下，如MessageBox.Show("确定要退出吗？")只显示一个“确定”按钮。
            DialogResult dr = MessageBox.Show(MessageStr, TitleStr, MessButton);
            if (dr == DialogResult.OK)
            {
                CheckResult = true;
            }
            return CheckResult;
        }
        public void InsertToDb(int Type)
        {
            ExcelHelper Eh = new ExcelHelper(ExecFilePath);
            //读取Execl中的数据，转换成DataTable
            DataTable ExecDatas = Eh.ExcelToDataTable("", true);
            DBHelper Dh = new DBHelper(connStr);
            Dh.SQLTran(ExecDatas, Type);
        }
        /// <summary>
        /// 导入联通数据表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnToLt_Click(object sender, EventArgs e)
        {
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (ExecFilePath == string.Empty)
            {
                MessageBox.Show("请先选择.xls文件，再导入！");
                return;
            }
            //获取选中值
            //ListItem CheckItem = CbType.SelectedItem as ListItem;
            //int CheckValue = CheckItem.Value;
            //string CheckName = CheckItem.Name;
            int CheckValue = 0;
            string CheckName = "";
            //插入0移动/1联通/2电信
            if (CheckValue == 0)
            {
                if (IsCheckOK("你确定要导入到"+CheckName+"客户表吗？", "友情提示"))
                {
                    if (bWorker.IsBusy)
                    {
                        MessageBox.Show("请等待上一个处理完成，请稍后...");
                        return;
                    }
                    bWorker.RunWorkerAsync(CheckValue);
                    //虚拟进度条
                    msg.Show();

                }
                
            }
            if (CheckValue == 1)
            {
                if (IsCheckOK("你确定要导入到" + CheckName + "客户表吗？", "友情提示"))
                {
                    if (bWorker.IsBusy)
                    {
                        MessageBox.Show("请等待上一个处理完成，请稍后...");
                        return;
                    }
                    bWorker.RunWorkerAsync(CheckValue);
                    //虚拟进度条
                    msg.Show();

                }
            }
            if (CheckValue == 2)
            {
                if (IsCheckOK("你确定要导入到" + CheckName + "客户表吗？", "友情提示"))
                {
                    if (bWorker.IsBusy)
                    {
                        MessageBox.Show("请等待上一个处理完成，请稍后...");
                        return;
                    }
                    bWorker.RunWorkerAsync(CheckValue);
                    //虚拟进度条
                    msg.Show();

                }
            }
            else
            {
                if (IsCheckOK("你确定要导入到" + CheckName + "客户表吗？", "友情提示"))
                {
                    if (bWorker.IsBusy)
                    {
                        MessageBox.Show("请等待上一个处理完成，请稍后...");
                        return;
                    }
                    bWorker.RunWorkerAsync(CheckValue);
                    //虚拟进度条
                    msg.Show();

                }
            }
        }
        private void bWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int TheType =(int)e.Argument;
            InsertToDb(TheType);
        }

        private void bWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.ToString());
                msg.Close();
                return;
            }
            msg.Close();
            MessageBox.Show("导入成功！");
        }
    }
}
