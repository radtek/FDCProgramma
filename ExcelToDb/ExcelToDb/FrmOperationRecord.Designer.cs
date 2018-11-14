namespace ExcelToDb
{
    partial class FrmOperationRecord
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.R_Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.R_CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.R_Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.R_Note,
            this.R_CreateDate,
            this.R_Level});
            this.dataGridView1.Location = new System.Drawing.Point(8, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(753, 436);
            this.dataGridView1.TabIndex = 0;
            // 
            // R_Note
            // 
            this.R_Note.DataPropertyName = "R_Note";
            this.R_Note.HeaderText = "记录描述";
            this.R_Note.Name = "R_Note";
            this.R_Note.ReadOnly = true;
            // 
            // R_CreateDate
            // 
            this.R_CreateDate.DataPropertyName = "R_CreateDate";
            this.R_CreateDate.HeaderText = "执行时间";
            this.R_CreateDate.Name = "R_CreateDate";
            this.R_CreateDate.ReadOnly = true;
            // 
            // R_Level
            // 
            this.R_Level.DataPropertyName = "R_Level";
            this.R_Level.HeaderText = "操作等级";
            this.R_Level.Name = "R_Level";
            this.R_Level.ReadOnly = true;
            // 
            // FrmOperationRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 460);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmOperationRecord";
            this.Text = "用户操作记录";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn R_Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn R_CreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn R_Level;
    }
}