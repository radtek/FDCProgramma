namespace ExcelToDb
{
    partial class FrmAddAdmin
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
            this.PicRandomCode = new System.Windows.Forms.PictureBox();
            this.TbRandomCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TbPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TbPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CbWomen = new System.Windows.Forms.CheckBox();
            this.CbMan = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbNickName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicRandomCode)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PicRandomCode);
            this.groupBox1.Controls.Add(this.TbRandomCode);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TbPass);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TbPhone);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CbWomen);
            this.groupBox1.Controls.Add(this.CbMan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TbNickName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 386);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "注册信息";
            // 
            // PicRandomCode
            // 
            this.PicRandomCode.Location = new System.Drawing.Point(29, 241);
            this.PicRandomCode.Name = "PicRandomCode";
            this.PicRandomCode.Size = new System.Drawing.Size(224, 75);
            this.PicRandomCode.TabIndex = 11;
            this.PicRandomCode.TabStop = false;
            this.PicRandomCode.Click += new System.EventHandler(this.PicRandomCode_Click);
            // 
            // TbRandomCode
            // 
            this.TbRandomCode.Location = new System.Drawing.Point(138, 334);
            this.TbRandomCode.Name = "TbRandomCode";
            this.TbRandomCode.PasswordChar = '*';
            this.TbRandomCode.Size = new System.Drawing.Size(115, 25);
            this.TbRandomCode.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(24, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "图形验证码：";
            // 
            // TbPass
            // 
            this.TbPass.Location = new System.Drawing.Point(86, 197);
            this.TbPass.Name = "TbPass";
            this.TbPass.PasswordChar = '*';
            this.TbPass.Size = new System.Drawing.Size(167, 25);
            this.TbPass.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(24, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "密码：";
            // 
            // TbPhone
            // 
            this.TbPhone.Location = new System.Drawing.Point(86, 142);
            this.TbPhone.Name = "TbPhone";
            this.TbPhone.Size = new System.Drawing.Size(167, 25);
            this.TbPhone.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(24, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "手机：";
            // 
            // CbWomen
            // 
            this.CbWomen.AutoSize = true;
            this.CbWomen.Location = new System.Drawing.Point(164, 97);
            this.CbWomen.Name = "CbWomen";
            this.CbWomen.Size = new System.Drawing.Size(44, 19);
            this.CbWomen.TabIndex = 4;
            this.CbWomen.Text = "女";
            this.CbWomen.UseVisualStyleBackColor = true;
            // 
            // CbMan
            // 
            this.CbMan.AutoSize = true;
            this.CbMan.Checked = true;
            this.CbMan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbMan.Location = new System.Drawing.Point(99, 97);
            this.CbMan.Name = "CbMan";
            this.CbMan.Size = new System.Drawing.Size(44, 19);
            this.CbMan.TabIndex = 3;
            this.CbMan.Text = "男";
            this.CbMan.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(24, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "性别：";
            // 
            // TbNickName
            // 
            this.TbNickName.Location = new System.Drawing.Point(86, 44);
            this.TbNickName.Name = "TbNickName";
            this.TbNickName.Size = new System.Drawing.Size(167, 25);
            this.TbNickName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(24, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名：";
            // 
            // BtnRegister
            // 
            this.BtnRegister.Location = new System.Drawing.Point(12, 438);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(119, 33);
            this.BtnRegister.TabIndex = 1;
            this.BtnRegister.Text = "注册";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(191, 438);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(119, 33);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // FrmAddAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 490);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAddAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册管理员";
            this.Load += new System.EventHandler(this.FrmAddAdmin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicRandomCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TbPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CbWomen;
        private System.Windows.Forms.CheckBox CbMan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbNickName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.PictureBox PicRandomCode;
        private System.Windows.Forms.TextBox TbRandomCode;
        private System.Windows.Forms.Label label5;
    }
}