using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CheckCode.Code;
using ExcelToDb.MdoelsHelper;
using System.Collections;
using BLL.User;

namespace ExcelToDb
{
    public partial class FrmAddAdmin : Form
    {
        CheckCode.Code.CheckCode cc = new CheckCode.Code.CheckCode();
        private string TheImgCode;
        public FrmAddAdmin()
        {
            InitializeComponent();
        }

        private void FrmAddAdmin_Load(object sender, EventArgs e)
        {
            cc.CreateImageFromBytes(Application.StartupPath + "/Img/Demo", cc.RndCodeImg(4, 224, 75));
            TheImgCode = cc.ImgCode;
            this.PicRandomCode.ImageLocation = Application.StartupPath + "/Img/Demo.gif";
        }

        private void PicRandomCode_Click(object sender, EventArgs e)
        {
            cc.CreateImageFromBytes(Application.StartupPath + "/Img/Demo", cc.RndCodeImg(4, 224, 75));
            TheImgCode = cc.ImgCode;
            this.PicRandomCode.ImageLocation = Application.StartupPath + "/Img/Demo.gif";
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string ImgCode = TbRandomCode.Text.ToLower();
            int Sex = 0;
            if (CbMan.Checked != true)
            {
                Sex = 1;
            }
            Hashtable HtUser = new Hashtable();
            HtUser.Add("NickName", TbNickName.Text);
            HtUser.Add("UserCode", TbPhone.Text);
            HtUser.Add("UserPass", PubicHelp.MD5Encrypt(TbPass.Text));
            HtUser.Add("UserSex", Sex);
            HtUser.Add("UserGuid",PubicHelp.GetNetGuid());
            if (ImgCode != TheImgCode)
            {
                MessageBox.Show("验证码错误！请重新输入","提示",MessageBoxButtons.OK);
                return;
            }
            //BAL层
            B_Admin ba = new B_Admin();
            
            if (ba.b_Register(HtUser))
            {
                MessageBox.Show("注册成功！","提示",MessageBoxButtons.OK);
            }
            else
            {
                //错误信息
                MessageBox.Show(ba.Msg, "提示", MessageBoxButtons.OK);
            }

        }
    }
}
