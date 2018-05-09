namespace InvoicingApp
{
    partial class DataRecoveryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataRecoveryForm));
            this.dgvRecovery = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.file = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backpath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecovery)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRecovery
            // 
            this.dgvRecovery.AllowUserToAddRows = false;
            this.dgvRecovery.AllowUserToDeleteRows = false;
            this.dgvRecovery.AllowUserToResizeRows = false;
            this.dgvRecovery.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecovery.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRecovery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRecovery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.backdate,
            this.file,
            this.backpath});
            this.dgvRecovery.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvRecovery.Location = new System.Drawing.Point(5, 5);
            this.dgvRecovery.MultiSelect = false;
            this.dgvRecovery.Name = "dgvRecovery";
            this.dgvRecovery.RowHeadersVisible = false;
            this.dgvRecovery.RowTemplate.Height = 23;
            this.dgvRecovery.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecovery.Size = new System.Drawing.Size(564, 281);
            this.dgvRecovery.TabIndex = 1;
            this.dgvRecovery.Sorted += new System.EventHandler(this.dgvRecovery_Sorted);
            // 
            // index
            // 
            this.index.DataPropertyName = "index";
            this.index.HeaderText = "序号";
            this.index.Name = "index";
            this.index.ReadOnly = true;
            this.index.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.index.Width = 55;
            // 
            // backdate
            // 
            this.backdate.DataPropertyName = "backdate";
            this.backdate.HeaderText = "备份日期";
            this.backdate.Name = "backdate";
            this.backdate.ReadOnly = true;
            this.backdate.Width = 275;
            // 
            // file
            // 
            this.file.DataPropertyName = "file";
            this.file.HeaderText = "文件名";
            this.file.Name = "file";
            this.file.ReadOnly = true;
            this.file.Width = 212;
            // 
            // backpath
            // 
            this.backpath.DataPropertyName = "backpath";
            this.backpath.HeaderText = "路径";
            this.backpath.Name = "backpath";
            this.backpath.ReadOnly = true;
            this.backpath.Visible = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::InvoicingApp.Properties.Resources.Ok;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Location = new System.Drawing.Point(441, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = " 确定恢复(&O)";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DataRecoveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(574, 318);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvRecovery);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataRecoveryForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据恢复";
            this.Load += new System.EventHandler(this.DataRecoveryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecovery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRecovery;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn backdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn file;
        private System.Windows.Forms.DataGridViewTextBoxColumn backpath;
    }
}