namespace ExcelToDb
{
    partial class FrmAddEmployee
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
            this.label1 = new System.Windows.Forms.Label();
            this.Tb_EmployeeName = new System.Windows.Forms.TextBox();
            this.Cb_Man = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cb_Women = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Tb_EmployeeTel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Tb_Passwords = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Tb_BelongTo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Tb_CreateDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Tb_EmlpoyeeCode = new System.Windows.Forms.TextBox();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Rb_YiDong = new System.Windows.Forms.RadioButton();
            this.Rb_LianTong = new System.Windows.Forms.RadioButton();
            this.Rb_DianXin = new System.Windows.Forms.RadioButton();
            this.Rb_Other = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(31, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名：";
            // 
            // Tb_EmployeeName
            // 
            this.Tb_EmployeeName.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tb_EmployeeName.Location = new System.Drawing.Point(109, 54);
            this.Tb_EmployeeName.MaxLength = 10;
            this.Tb_EmployeeName.Name = "Tb_EmployeeName";
            this.Tb_EmployeeName.Size = new System.Drawing.Size(208, 31);
            this.Tb_EmployeeName.TabIndex = 1;
            // 
            // Cb_Man
            // 
            this.Cb_Man.AutoSize = true;
            this.Cb_Man.Checked = true;
            this.Cb_Man.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Cb_Man.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cb_Man.ForeColor = System.Drawing.Color.Black;
            this.Cb_Man.Location = new System.Drawing.Point(109, 198);
            this.Cb_Man.Name = "Cb_Man";
            this.Cb_Man.Size = new System.Drawing.Size(61, 24);
            this.Cb_Man.TabIndex = 2;
            this.Cb_Man.Text = "先生";
            this.Cb_Man.UseVisualStyleBackColor = true;
            this.Cb_Man.Click += new System.EventHandler(this.Cb_Man_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(31, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "性别：";
            // 
            // Cb_Women
            // 
            this.Cb_Women.AutoSize = true;
            this.Cb_Women.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cb_Women.ForeColor = System.Drawing.Color.Black;
            this.Cb_Women.Location = new System.Drawing.Point(185, 198);
            this.Cb_Women.Name = "Cb_Women";
            this.Cb_Women.Size = new System.Drawing.Size(61, 24);
            this.Cb_Women.TabIndex = 4;
            this.Cb_Women.Text = "女士";
            this.Cb_Women.UseVisualStyleBackColor = true;
            this.Cb_Women.Click += new System.EventHandler(this.Cb_Women_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(31, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "电话：";
            // 
            // Tb_EmployeeTel
            // 
            this.Tb_EmployeeTel.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tb_EmployeeTel.Location = new System.Drawing.Point(109, 102);
            this.Tb_EmployeeTel.MaxLength = 11;
            this.Tb_EmployeeTel.Name = "Tb_EmployeeTel";
            this.Tb_EmployeeTel.Size = new System.Drawing.Size(208, 31);
            this.Tb_EmployeeTel.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "员工编号：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Rb_Other);
            this.groupBox1.Controls.Add(this.Rb_DianXin);
            this.groupBox1.Controls.Add(this.Rb_LianTong);
            this.groupBox1.Controls.Add(this.Rb_YiDong);
            this.groupBox1.Controls.Add(this.Tb_Passwords);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Tb_EmployeeTel);
            this.groupBox1.Controls.Add(this.Tb_EmployeeName);
            this.groupBox1.Controls.Add(this.Cb_Women);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Cb_Man);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(484, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 429);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "需要自主填写信息";
            // 
            // Tb_Passwords
            // 
            this.Tb_Passwords.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tb_Passwords.Location = new System.Drawing.Point(109, 146);
            this.Tb_Passwords.MaxLength = 16;
            this.Tb_Passwords.Name = "Tb_Passwords";
            this.Tb_Passwords.PasswordChar = '*';
            this.Tb_Passwords.Size = new System.Drawing.Size(208, 31);
            this.Tb_Passwords.TabIndex = 10;
            this.Tb_Passwords.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(31, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 27);
            this.label8.TabIndex = 9;
            this.label8.Text = "密码：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(31, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 27);
            this.label5.TabIndex = 7;
            this.label5.Text = "使用电话所属运营商：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Tb_BelongTo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Tb_CreateDate);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Tb_EmlpoyeeCode);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(32, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 261);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "系统自动分配信息";
            // 
            // Tb_BelongTo
            // 
            this.Tb_BelongTo.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tb_BelongTo.Location = new System.Drawing.Point(164, 189);
            this.Tb_BelongTo.Name = "Tb_BelongTo";
            this.Tb_BelongTo.ReadOnly = true;
            this.Tb_BelongTo.Size = new System.Drawing.Size(138, 31);
            this.Tb_BelongTo.TabIndex = 12;
            this.Tb_BelongTo.Text = "李经理";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 27);
            this.label7.TabIndex = 11;
            this.label7.Text = "隶属经理/部门：";
            // 
            // Tb_CreateDate
            // 
            this.Tb_CreateDate.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tb_CreateDate.Location = new System.Drawing.Point(112, 122);
            this.Tb_CreateDate.Name = "Tb_CreateDate";
            this.Tb_CreateDate.ReadOnly = true;
            this.Tb_CreateDate.Size = new System.Drawing.Size(262, 31);
            this.Tb_CreateDate.TabIndex = 10;
            this.Tb_CreateDate.Text = "2018年08月23日";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 27);
            this.label6.TabIndex = 9;
            this.label6.Text = "注册时间：";
            // 
            // Tb_EmlpoyeeCode
            // 
            this.Tb_EmlpoyeeCode.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tb_EmlpoyeeCode.Location = new System.Drawing.Point(112, 48);
            this.Tb_EmlpoyeeCode.Name = "Tb_EmlpoyeeCode";
            this.Tb_EmlpoyeeCode.ReadOnly = true;
            this.Tb_EmlpoyeeCode.Size = new System.Drawing.Size(262, 31);
            this.Tb_EmlpoyeeCode.TabIndex = 8;
            this.Tb_EmlpoyeeCode.Text = "2018082301";
            this.Tb_EmlpoyeeCode.DoubleClick += new System.EventHandler(this.Tb_EmlpoyeeCode_DoubleClick);
            // 
            // Btn_Add
            // 
            this.Btn_Add.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Add.ForeColor = System.Drawing.Color.Black;
            this.Btn_Add.Location = new System.Drawing.Point(32, 408);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(374, 71);
            this.Btn_Add.TabIndex = 10;
            this.Btn_Add.Text = "注册";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Rb_YiDong
            // 
            this.Rb_YiDong.AutoSize = true;
            this.Rb_YiDong.Checked = true;
            this.Rb_YiDong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Rb_YiDong.Location = new System.Drawing.Point(36, 282);
            this.Rb_YiDong.Name = "Rb_YiDong";
            this.Rb_YiDong.Size = new System.Drawing.Size(113, 31);
            this.Rb_YiDong.TabIndex = 11;
            this.Rb_YiDong.TabStop = true;
            this.Rb_YiDong.Text = "中国移动";
            this.Rb_YiDong.UseVisualStyleBackColor = true;
            // 
            // Rb_LianTong
            // 
            this.Rb_LianTong.AutoSize = true;
            this.Rb_LianTong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Rb_LianTong.Location = new System.Drawing.Point(36, 319);
            this.Rb_LianTong.Name = "Rb_LianTong";
            this.Rb_LianTong.Size = new System.Drawing.Size(113, 31);
            this.Rb_LianTong.TabIndex = 12;
            this.Rb_LianTong.Text = "中国联通";
            this.Rb_LianTong.UseVisualStyleBackColor = true;
            // 
            // Rb_DianXin
            // 
            this.Rb_DianXin.AutoSize = true;
            this.Rb_DianXin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Rb_DianXin.Location = new System.Drawing.Point(36, 356);
            this.Rb_DianXin.Name = "Rb_DianXin";
            this.Rb_DianXin.Size = new System.Drawing.Size(113, 31);
            this.Rb_DianXin.TabIndex = 13;
            this.Rb_DianXin.Text = "中国电信";
            this.Rb_DianXin.UseVisualStyleBackColor = true;
            // 
            // Rb_Other
            // 
            this.Rb_Other.AutoSize = true;
            this.Rb_Other.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Rb_Other.Location = new System.Drawing.Point(36, 392);
            this.Rb_Other.Name = "Rb_Other";
            this.Rb_Other.Size = new System.Drawing.Size(73, 31);
            this.Rb_Other.TabIndex = 14;
            this.Rb_Other.Text = "其他";
            this.Rb_Other.UseVisualStyleBackColor = true;
            // 
            // FrmAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 509);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "新增员工/话务人员";
            this.Load += new System.EventHandler(this.FrmAddEmployee_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tb_EmployeeName;
        private System.Windows.Forms.CheckBox Cb_Man;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox Cb_Women;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tb_EmployeeTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Tb_EmlpoyeeCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Tb_CreateDate;
        private System.Windows.Forms.TextBox Tb_BelongTo;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.TextBox Tb_Passwords;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton Rb_Other;
        private System.Windows.Forms.RadioButton Rb_DianXin;
        private System.Windows.Forms.RadioButton Rb_LianTong;
        private System.Windows.Forms.RadioButton Rb_YiDong;
    }
}