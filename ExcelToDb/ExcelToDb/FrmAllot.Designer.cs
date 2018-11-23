namespace ExcelToDb
{
    partial class FrmAllot
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
            this.Tb_TotalNum = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Tb_InputNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnHandle = new System.Windows.Forms.Button();
            this.Cb_Handle = new System.Windows.Forms.CheckBox();
            this.Cb_NoHandle = new System.Windows.Forms.CheckBox();
            this.Tb_EmployeeNum1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Tb_EmployeeNum2 = new System.Windows.Forms.TextBox();
            this.Tb_AutoAllotNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Cb_AutoAllotHandle = new System.Windows.Forms.CheckBox();
            this.Cb_AutoAllotNoHandle = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAutoAllotHandle = new System.Windows.Forms.Button();
            this.skinLine1 = new CCWin.SkinControl.SkinLine();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(2, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "可用信息数据量（条）：";
            // 
            // Tb_TotalNum
            // 
            this.Tb_TotalNum.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tb_TotalNum.Location = new System.Drawing.Point(298, 21);
            this.Tb_TotalNum.Name = "Tb_TotalNum";
            this.Tb_TotalNum.ReadOnly = true;
            this.Tb_TotalNum.Size = new System.Drawing.Size(100, 34);
            this.Tb_TotalNum.TabIndex = 1;
            this.Tb_TotalNum.Text = "525";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Tb_InputNum);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.BtnHandle);
            this.groupBox1.Controls.Add(this.Cb_Handle);
            this.groupBox1.Controls.Add(this.Cb_NoHandle);
            this.groupBox1.Controls.Add(this.Tb_EmployeeNum1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(12, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 358);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "手动设置均分";
            // 
            // Tb_InputNum
            // 
            this.Tb_InputNum.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tb_InputNum.ForeColor = System.Drawing.Color.Red;
            this.Tb_InputNum.Location = new System.Drawing.Point(228, 82);
            this.Tb_InputNum.Name = "Tb_InputNum";
            this.Tb_InputNum.Size = new System.Drawing.Size(100, 31);
            this.Tb_InputNum.TabIndex = 9;
            this.Tb_InputNum.Text = "100";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(15, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "设置任务量（人/条）：";
            // 
            // BtnHandle
            // 
            this.BtnHandle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnHandle.Location = new System.Drawing.Point(48, 254);
            this.BtnHandle.Name = "BtnHandle";
            this.BtnHandle.Size = new System.Drawing.Size(294, 53);
            this.BtnHandle.TabIndex = 7;
            this.BtnHandle.Text = "开始分配";
            this.BtnHandle.UseVisualStyleBackColor = true;
            // 
            // Cb_Handle
            // 
            this.Cb_Handle.AutoSize = true;
            this.Cb_Handle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cb_Handle.ForeColor = System.Drawing.Color.Black;
            this.Cb_Handle.Location = new System.Drawing.Point(204, 159);
            this.Cb_Handle.Name = "Cb_Handle";
            this.Cb_Handle.Size = new System.Drawing.Size(151, 24);
            this.Cb_Handle.TabIndex = 6;
            this.Cb_Handle.Text = "自动分配剩余数据";
            this.Cb_Handle.UseVisualStyleBackColor = true;
            // 
            // Cb_NoHandle
            // 
            this.Cb_NoHandle.AutoSize = true;
            this.Cb_NoHandle.Checked = true;
            this.Cb_NoHandle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Cb_NoHandle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cb_NoHandle.ForeColor = System.Drawing.Color.Black;
            this.Cb_NoHandle.Location = new System.Drawing.Point(20, 159);
            this.Cb_NoHandle.Name = "Cb_NoHandle";
            this.Cb_NoHandle.Size = new System.Drawing.Size(151, 24);
            this.Cb_NoHandle.TabIndex = 5;
            this.Cb_NoHandle.Text = "剩余数据不做分配";
            this.Cb_NoHandle.UseVisualStyleBackColor = true;
            // 
            // Tb_EmployeeNum1
            // 
            this.Tb_EmployeeNum1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tb_EmployeeNum1.ForeColor = System.Drawing.Color.Red;
            this.Tb_EmployeeNum1.Location = new System.Drawing.Point(228, 44);
            this.Tb_EmployeeNum1.Name = "Tb_EmployeeNum1";
            this.Tb_EmployeeNum1.ReadOnly = true;
            this.Tb_EmployeeNum1.Size = new System.Drawing.Size(100, 31);
            this.Tb_EmployeeNum1.TabIndex = 4;
            this.Tb_EmployeeNum1.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(15, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "      员工数量：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Tb_EmployeeNum2);
            this.groupBox2.Controls.Add(this.Tb_AutoAllotNum);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Cb_AutoAllotHandle);
            this.groupBox2.Controls.Add(this.Cb_AutoAllotNoHandle);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.BtnAutoAllotHandle);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(582, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 358);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "自动设置均分";
            // 
            // Tb_EmployeeNum2
            // 
            this.Tb_EmployeeNum2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tb_EmployeeNum2.ForeColor = System.Drawing.Color.Red;
            this.Tb_EmployeeNum2.Location = new System.Drawing.Point(245, 37);
            this.Tb_EmployeeNum2.Name = "Tb_EmployeeNum2";
            this.Tb_EmployeeNum2.ReadOnly = true;
            this.Tb_EmployeeNum2.Size = new System.Drawing.Size(100, 31);
            this.Tb_EmployeeNum2.TabIndex = 14;
            this.Tb_EmployeeNum2.Text = "100";
            // 
            // Tb_AutoAllotNum
            // 
            this.Tb_AutoAllotNum.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tb_AutoAllotNum.ForeColor = System.Drawing.Color.Red;
            this.Tb_AutoAllotNum.Location = new System.Drawing.Point(245, 76);
            this.Tb_AutoAllotNum.Name = "Tb_AutoAllotNum";
            this.Tb_AutoAllotNum.ReadOnly = true;
            this.Tb_AutoAllotNum.Size = new System.Drawing.Size(100, 31);
            this.Tb_AutoAllotNum.TabIndex = 13;
            this.Tb_AutoAllotNum.Text = "50";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "            员工数量：";
            // 
            // Cb_AutoAllotHandle
            // 
            this.Cb_AutoAllotHandle.AutoSize = true;
            this.Cb_AutoAllotHandle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cb_AutoAllotHandle.ForeColor = System.Drawing.Color.Black;
            this.Cb_AutoAllotHandle.Location = new System.Drawing.Point(178, 159);
            this.Cb_AutoAllotHandle.Name = "Cb_AutoAllotHandle";
            this.Cb_AutoAllotHandle.Size = new System.Drawing.Size(151, 24);
            this.Cb_AutoAllotHandle.TabIndex = 11;
            this.Cb_AutoAllotHandle.Text = "自动分配剩余数据";
            this.Cb_AutoAllotHandle.UseVisualStyleBackColor = true;
            // 
            // Cb_AutoAllotNoHandle
            // 
            this.Cb_AutoAllotNoHandle.AutoSize = true;
            this.Cb_AutoAllotNoHandle.Checked = true;
            this.Cb_AutoAllotNoHandle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Cb_AutoAllotNoHandle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cb_AutoAllotNoHandle.ForeColor = System.Drawing.Color.Black;
            this.Cb_AutoAllotNoHandle.Location = new System.Drawing.Point(21, 159);
            this.Cb_AutoAllotNoHandle.Name = "Cb_AutoAllotNoHandle";
            this.Cb_AutoAllotNoHandle.Size = new System.Drawing.Size(151, 24);
            this.Cb_AutoAllotNoHandle.TabIndex = 10;
            this.Cb_AutoAllotNoHandle.Text = "剩余数据不做分配";
            this.Cb_AutoAllotNoHandle.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "自动均分设置的任务量（人/条）：";
            // 
            // BtnAutoAllotHandle
            // 
            this.BtnAutoAllotHandle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnAutoAllotHandle.Location = new System.Drawing.Point(21, 254);
            this.BtnAutoAllotHandle.Name = "BtnAutoAllotHandle";
            this.BtnAutoAllotHandle.Size = new System.Drawing.Size(294, 53);
            this.BtnAutoAllotHandle.TabIndex = 8;
            this.BtnAutoAllotHandle.Text = "开始分配";
            this.BtnAutoAllotHandle.UseVisualStyleBackColor = true;
            this.BtnAutoAllotHandle.Click += new System.EventHandler(this.BtnAutoAllotHandle_Click);
            // 
            // skinLine1
            // 
            this.skinLine1.BackColor = System.Drawing.Color.Transparent;
            this.skinLine1.LineColor = System.Drawing.Color.Black;
            this.skinLine1.LineHeight = 1;
            this.skinLine1.Location = new System.Drawing.Point(-1, 73);
            this.skinLine1.Name = "skinLine1";
            this.skinLine1.Size = new System.Drawing.Size(944, 10);
            this.skinLine1.TabIndex = 5;
            this.skinLine1.Text = "skinLine1";
            // 
            // FrmAllot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 477);
            this.Controls.Add(this.skinLine1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Tb_TotalNum);
            this.Name = "FrmAllot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "任务分配";
            this.Load += new System.EventHandler(this.FrmAllot_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tb_TotalNum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private CCWin.SkinControl.SkinLine skinLine1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tb_EmployeeNum1;
        private System.Windows.Forms.TextBox Tb_InputNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnHandle;
        private System.Windows.Forms.CheckBox Cb_Handle;
        private System.Windows.Forms.CheckBox Cb_NoHandle;
        private System.Windows.Forms.TextBox Tb_EmployeeNum2;
        private System.Windows.Forms.TextBox Tb_AutoAllotNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox Cb_AutoAllotHandle;
        private System.Windows.Forms.CheckBox Cb_AutoAllotNoHandle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAutoAllotHandle;
    }
}