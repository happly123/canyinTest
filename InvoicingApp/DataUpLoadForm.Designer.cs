namespace InvoicingApp
{
    partial class DataUpLoadForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataUpLoadForm));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.upload_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.upload_ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.upload_result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.upload_date,
            this.upload_ip,
            this.upload_result});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(10, 10);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(472, 388);
            this.dgv.TabIndex = 10;
            this.dgv.TabStop = false;
            this.dgv.Sorted += new System.EventHandler(this.dgv_Sorted);
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
            // upload_date
            // 
            this.upload_date.DataPropertyName = "upload_date";
            this.upload_date.HeaderText = "数据上传日期";
            this.upload_date.Name = "upload_date";
            this.upload_date.ReadOnly = true;
            this.upload_date.Width = 130;
            // 
            // upload_ip
            // 
            this.upload_ip.DataPropertyName = "upload_ip";
            this.upload_ip.HeaderText = "数据上传地址";
            this.upload_ip.Name = "upload_ip";
            this.upload_ip.ReadOnly = true;
            this.upload_ip.Width = 150;
            // 
            // upload_result
            // 
            this.upload_result.DataPropertyName = "upload_result";
            this.upload_result.HeaderText = "数据上传结果";
            this.upload_result.Name = "upload_result";
            this.upload_result.ReadOnly = true;
            this.upload_result.Width = 130;
            // 
            // DataUpLoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 408);
            this.Controls.Add(this.dgv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 442);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 442);
            this.Name = "DataUpLoadForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据上传日志";
            this.Load += new System.EventHandler(this.DataUpLoadForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn upload_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn upload_ip;
        private System.Windows.Forms.DataGridViewTextBoxColumn upload_result;
    }
}