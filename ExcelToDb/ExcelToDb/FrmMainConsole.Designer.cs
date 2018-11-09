namespace ExcelToDb
{
    partial class FrmMainConsole
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excel导入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增操作人员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.历史操作统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.员工效率ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.员工列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.绩效统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.信息总览ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.任务分配ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自动均分任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自定义任务分发ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.GbEmployee = new System.Windows.Forms.GroupBox();
            this.DGVEmployeeList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TbEmployeeCountNum = new System.Windows.Forms.TextBox();
            this.TbLiveEmployeeNum = new System.Windows.Forms.TextBox();
            this.EmployeeGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeNickName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelOperator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeCreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.GbEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmployeeList)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.菜单ToolStripMenuItem,
            this.员工效率ToolStripMenuItem,
            this.任务分配ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1242, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 菜单ToolStripMenuItem
            // 
            this.菜单ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excel导入ToolStripMenuItem,
            this.新增操作人员ToolStripMenuItem,
            this.修改密码ToolStripMenuItem,
            this.历史操作统计ToolStripMenuItem});
            this.菜单ToolStripMenuItem.Name = "菜单ToolStripMenuItem";
            this.菜单ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.菜单ToolStripMenuItem.Text = "菜单";
            // 
            // excel导入ToolStripMenuItem
            // 
            this.excel导入ToolStripMenuItem.Name = "excel导入ToolStripMenuItem";
            this.excel导入ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.excel导入ToolStripMenuItem.Text = "Excel导入";
            // 
            // 新增操作人员ToolStripMenuItem
            // 
            this.新增操作人员ToolStripMenuItem.Name = "新增操作人员ToolStripMenuItem";
            this.新增操作人员ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.新增操作人员ToolStripMenuItem.Text = "新增操作人员";
            this.新增操作人员ToolStripMenuItem.Click += new System.EventHandler(this.新增操作人员ToolStripMenuItem_Click);
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.修改密码ToolStripMenuItem.Text = "修改登录密码";
            // 
            // 历史操作统计ToolStripMenuItem
            // 
            this.历史操作统计ToolStripMenuItem.Name = "历史操作统计ToolStripMenuItem";
            this.历史操作统计ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.历史操作统计ToolStripMenuItem.Text = "历史操作统计";
            // 
            // 员工效率ToolStripMenuItem
            // 
            this.员工效率ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.员工列表ToolStripMenuItem,
            this.绩效统计ToolStripMenuItem,
            this.信息总览ToolStripMenuItem});
            this.员工效率ToolStripMenuItem.Name = "员工效率ToolStripMenuItem";
            this.员工效率ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.员工效率ToolStripMenuItem.Text = "员工效率";
            // 
            // 员工列表ToolStripMenuItem
            // 
            this.员工列表ToolStripMenuItem.Name = "员工列表ToolStripMenuItem";
            this.员工列表ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.员工列表ToolStripMenuItem.Text = "员工列表";
            // 
            // 绩效统计ToolStripMenuItem
            // 
            this.绩效统计ToolStripMenuItem.Name = "绩效统计ToolStripMenuItem";
            this.绩效统计ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.绩效统计ToolStripMenuItem.Text = "绩效统计";
            // 
            // 信息总览ToolStripMenuItem
            // 
            this.信息总览ToolStripMenuItem.Name = "信息总览ToolStripMenuItem";
            this.信息总览ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.信息总览ToolStripMenuItem.Text = "绩效信息总览";
            // 
            // 任务分配ToolStripMenuItem
            // 
            this.任务分配ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.自动均分任务ToolStripMenuItem,
            this.自定义任务分发ToolStripMenuItem});
            this.任务分配ToolStripMenuItem.Name = "任务分配ToolStripMenuItem";
            this.任务分配ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.任务分配ToolStripMenuItem.Text = "任务分配";
            // 
            // 自动均分任务ToolStripMenuItem
            // 
            this.自动均分任务ToolStripMenuItem.Name = "自动均分任务ToolStripMenuItem";
            this.自动均分任务ToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.自动均分任务ToolStripMenuItem.Text = "自动均分任务";
            // 
            // 自定义任务分发ToolStripMenuItem
            // 
            this.自定义任务分发ToolStripMenuItem.Name = "自定义任务分发ToolStripMenuItem";
            this.自定义任务分发ToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.自定义任务分发ToolStripMenuItem.Text = "自定义任务分发";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(818, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "尊敬的：李先锋 先生/女士，欢迎您使用系统！";
            // 
            // GbEmployee
            // 
            this.GbEmployee.Controls.Add(this.DGVEmployeeList);
            this.GbEmployee.Location = new System.Drawing.Point(12, 31);
            this.GbEmployee.Name = "GbEmployee";
            this.GbEmployee.Size = new System.Drawing.Size(1218, 529);
            this.GbEmployee.TabIndex = 2;
            this.GbEmployee.TabStop = false;
            // 
            // DGVEmployeeList
            // 
            this.DGVEmployeeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVEmployeeList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.DGVEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEmployeeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeGuid,
            this.EmployeeCode,
            this.EmployeeTel,
            this.EmployeeNickName,
            this.EmployeeSex,
            this.TelOperator,
            this.EmployeeCreateDate});
            this.DGVEmployeeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVEmployeeList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DGVEmployeeList.Location = new System.Drawing.Point(3, 21);
            this.DGVEmployeeList.Name = "DGVEmployeeList";
            this.DGVEmployeeList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DGVEmployeeList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.DGVEmployeeList.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVEmployeeList.RowTemplate.Height = 27;
            this.DGVEmployeeList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGVEmployeeList.Size = new System.Drawing.Size(1212, 505);
            this.DGVEmployeeList.TabIndex = 0;
            this.DGVEmployeeList.Click += new System.EventHandler(this.DGVEmployeeList_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(22, 580);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "当前员工总数：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(336, 580);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "当前在线人数：";
            // 
            // TbEmployeeCountNum
            // 
            this.TbEmployeeCountNum.Location = new System.Drawing.Point(197, 579);
            this.TbEmployeeCountNum.Name = "TbEmployeeCountNum";
            this.TbEmployeeCountNum.ReadOnly = true;
            this.TbEmployeeCountNum.Size = new System.Drawing.Size(100, 25);
            this.TbEmployeeCountNum.TabIndex = 5;
            this.TbEmployeeCountNum.Text = "15";
            // 
            // TbLiveEmployeeNum
            // 
            this.TbLiveEmployeeNum.Location = new System.Drawing.Point(484, 580);
            this.TbLiveEmployeeNum.Name = "TbLiveEmployeeNum";
            this.TbLiveEmployeeNum.ReadOnly = true;
            this.TbLiveEmployeeNum.Size = new System.Drawing.Size(100, 25);
            this.TbLiveEmployeeNum.TabIndex = 6;
            this.TbLiveEmployeeNum.Text = "10";
            // 
            // EmployeeGuid
            // 
            this.EmployeeGuid.DataPropertyName = "EmployeeGuid";
            this.EmployeeGuid.HeaderText = "员工GUID";
            this.EmployeeGuid.Name = "EmployeeGuid";
            this.EmployeeGuid.Visible = false;
            // 
            // EmployeeCode
            // 
            this.EmployeeCode.DataPropertyName = "EmployeeCode";
            this.EmployeeCode.HeaderText = "员工编号";
            this.EmployeeCode.Name = "EmployeeCode";
            this.EmployeeCode.ReadOnly = true;
            // 
            // EmployeeTel
            // 
            this.EmployeeTel.DataPropertyName = "EmployeeTel";
            this.EmployeeTel.HeaderText = "员工电话";
            this.EmployeeTel.Name = "EmployeeTel";
            this.EmployeeTel.ReadOnly = true;
            // 
            // EmployeeNickName
            // 
            this.EmployeeNickName.DataPropertyName = "EmployeeNickName";
            this.EmployeeNickName.HeaderText = "昵称";
            this.EmployeeNickName.Name = "EmployeeNickName";
            this.EmployeeNickName.ReadOnly = true;
            // 
            // EmployeeSex
            // 
            this.EmployeeSex.DataPropertyName = "EmployeeSex";
            this.EmployeeSex.HeaderText = "性别";
            this.EmployeeSex.Name = "EmployeeSex";
            this.EmployeeSex.ReadOnly = true;
            // 
            // TelOperator
            // 
            this.TelOperator.DataPropertyName = "TelOperator";
            this.TelOperator.HeaderText = "运营商";
            this.TelOperator.Name = "TelOperator";
            this.TelOperator.ReadOnly = true;
            // 
            // EmployeeCreateDate
            // 
            this.EmployeeCreateDate.DataPropertyName = "EmployeeCreateDate";
            this.EmployeeCreateDate.HeaderText = "入职时间";
            this.EmployeeCreateDate.Name = "EmployeeCreateDate";
            this.EmployeeCreateDate.ReadOnly = true;
            // 
            // FrmMainConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 621);
            this.Controls.Add(this.TbLiveEmployeeNum);
            this.Controls.Add(this.TbEmployeeCountNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GbEmployee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Red;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMainConsole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AF信息管理平台主控台";
            this.Load += new System.EventHandler(this.FrmMainConsole_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GbEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmployeeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 菜单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excel导入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增操作人员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 历史操作统计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 员工效率ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 员工列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 绩效统计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 信息总览ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 任务分配ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自动均分任务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自定义任务分发ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GbEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbEmployeeCountNum;
        private System.Windows.Forms.TextBox TbLiveEmployeeNum;
        private System.Windows.Forms.DataGridView DGVEmployeeList;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeNickName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelOperator;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeCreateDate;
    }
}