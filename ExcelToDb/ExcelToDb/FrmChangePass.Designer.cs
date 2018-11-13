namespace ExcelToDb
{
    partial class FrmChangePass
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Cb_PassShow = new System.Windows.Forms.CheckBox();
            this.Tb_PrivateKey = new System.Windows.Forms.TextBox();
            this.Tb_EnterPass = new System.Windows.Forms.TextBox();
            this.Tb_NPass = new System.Windows.Forms.TextBox();
            this.Tb_YPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEnter = new System.Windows.Forms.Button();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Cb_PassShow);
            this.groupBox1.Controls.Add(this.Tb_PrivateKey);
            this.groupBox1.Controls.Add(this.Tb_EnterPass);
            this.groupBox1.Controls.Add(this.Tb_NPass);
            this.groupBox1.Controls.Add(this.Tb_YPass);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 290);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "信息确认";
            // 
            // Cb_PassShow
            // 
            this.Cb_PassShow.AutoSize = true;
            this.Cb_PassShow.Location = new System.Drawing.Point(59, 265);
            this.Cb_PassShow.Name = "Cb_PassShow";
            this.Cb_PassShow.Size = new System.Drawing.Size(89, 19);
            this.Cb_PassShow.TabIndex = 18;
            this.Cb_PassShow.Text = "密码可见";
            this.Cb_PassShow.UseVisualStyleBackColor = true;
            this.Cb_PassShow.CheckedChanged += new System.EventHandler(this.Cb_PassShow_CheckedChanged);
            this.Cb_PassShow.Click += new System.EventHandler(this.Cb_PassShow_Click);
            // 
            // Tb_PrivateKey
            // 
            this.Tb_PrivateKey.Location = new System.Drawing.Point(106, 216);
            this.Tb_PrivateKey.MaxLength = 32;
            this.Tb_PrivateKey.Name = "Tb_PrivateKey";
            this.Tb_PrivateKey.PasswordChar = '*';
            this.Tb_PrivateKey.Size = new System.Drawing.Size(230, 25);
            this.Tb_PrivateKey.TabIndex = 17;
            this.Tb_PrivateKey.UseSystemPasswordChar = true;
            // 
            // Tb_EnterPass
            // 
            this.Tb_EnterPass.Location = new System.Drawing.Point(106, 163);
            this.Tb_EnterPass.MaxLength = 16;
            this.Tb_EnterPass.Name = "Tb_EnterPass";
            this.Tb_EnterPass.PasswordChar = '*';
            this.Tb_EnterPass.Size = new System.Drawing.Size(230, 25);
            this.Tb_EnterPass.TabIndex = 16;
            this.Tb_EnterPass.UseSystemPasswordChar = true;
            // 
            // Tb_NPass
            // 
            this.Tb_NPass.Location = new System.Drawing.Point(106, 107);
            this.Tb_NPass.MaxLength = 16;
            this.Tb_NPass.Name = "Tb_NPass";
            this.Tb_NPass.PasswordChar = '*';
            this.Tb_NPass.Size = new System.Drawing.Size(230, 25);
            this.Tb_NPass.TabIndex = 15;
            this.Tb_NPass.UseSystemPasswordChar = true;
            // 
            // Tb_YPass
            // 
            this.Tb_YPass.Location = new System.Drawing.Point(106, 51);
            this.Tb_YPass.MaxLength = 16;
            this.Tb_YPass.Name = "Tb_YPass";
            this.Tb_YPass.PasswordChar = '*';
            this.Tb_YPass.Size = new System.Drawing.Size(230, 25);
            this.Tb_YPass.TabIndex = 14;
            this.Tb_YPass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "验证秘钥：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "确认密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "新密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "原密码：";
            // 
            // BtnEnter
            // 
            this.BtnEnter.Location = new System.Drawing.Point(47, 324);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(130, 40);
            this.BtnEnter.TabIndex = 1;
            this.BtnEnter.Text = "确认修改";
            this.BtnEnter.UseVisualStyleBackColor = true;
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // BtnQuit
            // 
            this.BtnQuit.Location = new System.Drawing.Point(238, 324);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(122, 40);
            this.BtnQuit.TabIndex = 2;
            this.BtnQuit.Text = "取消";
            this.BtnQuit.UseVisualStyleBackColor = true;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // FrmChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 379);
            this.Controls.Add(this.BtnQuit);
            this.Controls.Add(this.BtnEnter);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.FrmChangePass_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Tb_PrivateKey;
        private System.Windows.Forms.TextBox Tb_EnterPass;
        private System.Windows.Forms.TextBox Tb_NPass;
        private System.Windows.Forms.TextBox Tb_YPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEnter;
        private System.Windows.Forms.Button BtnQuit;
        private System.Windows.Forms.CheckBox Cb_PassShow;
    }
}