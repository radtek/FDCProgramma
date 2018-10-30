namespace ExcelToDb
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.PicboxCode = new System.Windows.Forms.PictureBox();
            this.TbPicCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbSignKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.TbLoginPass = new System.Windows.Forms.TextBox();
            this.LbLoginPass = new System.Windows.Forms.Label();
            this.TbLoginCode = new System.Windows.Forms.TextBox();
            this.LbLoginCode = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicboxCode)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox1.Controls.Add(this.BtnQuit);
            this.groupBox1.Controls.Add(this.PicboxCode);
            this.groupBox1.Controls.Add(this.TbPicCode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TbSignKey);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnLogin);
            this.groupBox1.Controls.Add(this.TbLoginPass);
            this.groupBox1.Controls.Add(this.LbLoginPass);
            this.groupBox1.Controls.Add(this.TbLoginCode);
            this.groupBox1.Controls.Add(this.LbLoginCode);
            this.groupBox1.Location = new System.Drawing.Point(104, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(299, 290);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // BtnQuit
            // 
            this.BtnQuit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnQuit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnQuit.Location = new System.Drawing.Point(150, 244);
            this.BtnQuit.Margin = new System.Windows.Forms.Padding(2);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(118, 33);
            this.BtnQuit.TabIndex = 10;
            this.BtnQuit.Text = "取消";
            this.BtnQuit.UseVisualStyleBackColor = false;
            // 
            // PicboxCode
            // 
            this.PicboxCode.Location = new System.Drawing.Point(49, 172);
            this.PicboxCode.Margin = new System.Windows.Forms.Padding(2);
            this.PicboxCode.Name = "PicboxCode";
            this.PicboxCode.Size = new System.Drawing.Size(207, 59);
            this.PicboxCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicboxCode.TabIndex = 9;
            this.PicboxCode.TabStop = false;
            this.PicboxCode.Click += new System.EventHandler(this.PicboxCode_Click);
            // 
            // TbPicCode
            // 
            this.TbPicCode.BackColor = System.Drawing.SystemColors.Window;
            this.TbPicCode.Location = new System.Drawing.Point(116, 139);
            this.TbPicCode.Margin = new System.Windows.Forms.Padding(2);
            this.TbPicCode.Name = "TbPicCode";
            this.TbPicCode.Size = new System.Drawing.Size(153, 21);
            this.TbPicCode.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(28, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "图形验证码：";
            // 
            // TbSignKey
            // 
            this.TbSignKey.BackColor = System.Drawing.SystemColors.Window;
            this.TbSignKey.Location = new System.Drawing.Point(116, 102);
            this.TbSignKey.Margin = new System.Windows.Forms.Padding(2);
            this.TbSignKey.Name = "TbSignKey";
            this.TbSignKey.PasswordChar = '*';
            this.TbSignKey.Size = new System.Drawing.Size(153, 21);
            this.TbSignKey.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(28, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "验证秘钥：";
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnLogin.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnLogin.Location = new System.Drawing.Point(32, 244);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(118, 33);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "登录";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TbLoginPass
            // 
            this.TbLoginPass.BackColor = System.Drawing.SystemColors.Window;
            this.TbLoginPass.Location = new System.Drawing.Point(116, 68);
            this.TbLoginPass.Margin = new System.Windows.Forms.Padding(2);
            this.TbLoginPass.Name = "TbLoginPass";
            this.TbLoginPass.PasswordChar = '*';
            this.TbLoginPass.Size = new System.Drawing.Size(153, 21);
            this.TbLoginPass.TabIndex = 3;
            // 
            // LbLoginPass
            // 
            this.LbLoginPass.AutoSize = true;
            this.LbLoginPass.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LbLoginPass.ForeColor = System.Drawing.Color.Red;
            this.LbLoginPass.Location = new System.Drawing.Point(28, 68);
            this.LbLoginPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbLoginPass.Name = "LbLoginPass";
            this.LbLoginPass.Size = new System.Drawing.Size(90, 21);
            this.LbLoginPass.TabIndex = 2;
            this.LbLoginPass.Text = "登录密码：";
            // 
            // TbLoginCode
            // 
            this.TbLoginCode.Location = new System.Drawing.Point(116, 33);
            this.TbLoginCode.Margin = new System.Windows.Forms.Padding(2);
            this.TbLoginCode.Name = "TbLoginCode";
            this.TbLoginCode.Size = new System.Drawing.Size(153, 21);
            this.TbLoginCode.TabIndex = 1;
            // 
            // LbLoginCode
            // 
            this.LbLoginCode.AutoSize = true;
            this.LbLoginCode.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LbLoginCode.ForeColor = System.Drawing.Color.Red;
            this.LbLoginCode.Location = new System.Drawing.Point(28, 33);
            this.LbLoginCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbLoginCode.Name = "LbLoginCode";
            this.LbLoginCode.Size = new System.Drawing.Size(90, 21);
            this.LbLoginCode.TabIndex = 0;
            this.LbLoginCode.Text = "登录账号：";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(519, 396);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmLogin";
            this.Text = "AF平台信息管理系统";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicboxCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TextBox TbLoginPass;
        private System.Windows.Forms.Label LbLoginPass;
        private System.Windows.Forms.TextBox TbLoginCode;
        private System.Windows.Forms.Label LbLoginCode;
        private System.Windows.Forms.PictureBox PicboxCode;
        private System.Windows.Forms.TextBox TbPicCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbSignKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnQuit;
    }
}