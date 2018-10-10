using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelToDb.MdoelsHelper;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using CheckCode.Code;

namespace ExcelToDb
{
    public partial class FrmLogin : Form
    {
        Log log = new Log(Application.StartupPath + "Log.txt");
        CheckCode.Code.CheckCode cc = new CheckCode.Code.CheckCode();
        //图形中的随机码
        private string PicCode;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            PicboxCode.Image = cc.BytesToImage(cc.RndCodeImg(4, 200, 65));
            //图形中的随机码
            PicCode = cc.ImgCode;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string LoginCode = TbLoginCode.Text.Trim();
            string LoginPass = TbLoginPass.Text.Trim();
            string SignKey = TbSignKey.Text.Trim();
            string InputPicCode = TbPicCode.Text.ToUpper();
            //图形码验证
            if (PicCode != InputPicCode)
            {
                MessageBox.Show("图形验证码输入错误！请重新输入");
                return;
            }
            //获取数据库连接串和验证登录身份
            string WebResult = new GetSQLconnectioncs(LoginCode, PubicHelp.MD5Encrypt(LoginPass), SignKey).WebGetConnection();
            JObject RJson = JsonConvert.DeserializeObject<JObject>(WebResult);
            string RCode = (string)RJson["Code"];
            string SQLConnStr;
            if (RCode.Equals("00"))
            {
                //连接串
                SQLConnStr = HandleDesConn((string)RJson["SQLConn"]);
                //获取登陆者的相关信息


                   
                /**/
                string WelcomeStr = string.Format("亲爱的“{0}”,欢迎您！", "李先锋");
                MessageBox.Show(WelcomeStr);
                
            }
            else
            {
                string ExcptionStr = (string)RJson["Msg"];
                /*错误日志记录*/
                log.LogWrite("错误记录", ExcptionStr);
                MessageBox.Show(ExcptionStr);
            }
        }
        /// <summary>
        /// 解析返回的DES加密的SQLConn连接串
        /// </summary>
        /// <param name="DesConn"></param>
        /// <returns></returns>
        private string HandleDesConn(string DesConn)
        {
            return PubicHelp.DESDecrypt(DesConn, "");
        }

        private void PicboxCode_Click(object sender, EventArgs e)
        {
            PicboxCode.Image = cc.BytesToImage(cc.RndCodeImg(4, 200, 65));
            //图形中的随机码
            PicCode = cc.ImgCode;
        }
    }
}
