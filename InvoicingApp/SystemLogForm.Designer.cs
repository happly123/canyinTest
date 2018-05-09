namespace InvoicingApp
{
    partial class SystemLogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemLogForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvSystemLog = new System.Windows.Forms.DataGridView();
            this.systemlog_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.systemlog_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.systemlog_logon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.systemlog_logoff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dpf_systemlog_logoff = new System.Windows.Forms.DateTimePicker();
            this.btnFind = new System.Windows.Forms.Button();
            this.dpf_systemlog_logon = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSystemLog)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 390);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvSystemLog);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 60);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel3.Size = new System.Drawing.Size(616, 330);
            this.panel3.TabIndex = 10;
            // 
            // dgvSystemLog
            // 
            this.dgvSystemLog.AllowUserToAddRows = false;
            this.dgvSystemLog.AllowUserToDeleteRows = false;
            this.dgvSystemLog.AllowUserToResizeRows = false;
            this.dgvSystemLog.BackgroundColor = System.Drawing.Color.White;
            this.dgvSystemLog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSystemLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSystemLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.systemlog_code,
            this.index,
            this.systemlog_user,
            this.systemlog_logon,
            this.systemlog_logoff});
            this.dgvSystemLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSystemLog.Location = new System.Drawing.Point(0, 5);
            this.dgvSystemLog.Name = "dgvSystemLog";
            this.dgvSystemLog.ReadOnly = true;
            this.dgvSystemLog.RowHeadersVisible = false;
            this.dgvSystemLog.RowTemplate.Height = 23;
            this.dgvSystemLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSystemLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSystemLog.Size = new System.Drawing.Size(616, 325);
            this.dgvSystemLog.TabIndex = 9;
            this.dgvSystemLog.TabStop = false;
            this.dgvSystemLog.Sorted += new System.EventHandler(this.dgvSystemLog_Sorted);
            // 
            // systemlog_code
            // 
            this.systemlog_code.DataPropertyName = "systemlog_code";
            this.systemlog_code.HeaderText = "序号1";
            this.systemlog_code.Name = "systemlog_code";
            this.systemlog_code.ReadOnly = true;
            this.systemlog_code.Visible = false;
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
            // systemlog_user
            // 
            this.systemlog_user.DataPropertyName = "systemlog_user";
            this.systemlog_user.HeaderText = "登录人";
            this.systemlog_user.Name = "systemlog_user";
            this.systemlog_user.ReadOnly = true;
            // 
            // systemlog_logon
            // 
            this.systemlog_logon.DataPropertyName = "systemlog_logon";
            this.systemlog_logon.HeaderText = "登录时间";
            this.systemlog_logon.Name = "systemlog_logon";
            this.systemlog_logon.ReadOnly = true;
            this.systemlog_logon.Width = 200;
            // 
            // systemlog_logoff
            // 
            this.systemlog_logoff.DataPropertyName = "systemlog_logoff";
            this.systemlog_logoff.HeaderText = "退出时间";
            this.systemlog_logoff.Name = "systemlog_logoff";
            this.systemlog_logoff.ReadOnly = true;
            this.systemlog_logoff.Width = 200;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(616, 60);
            this.panel2.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dpf_systemlog_logoff);
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.dpf_systemlog_logon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 60);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "系统日志查询";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "登录日期:";
            // 
            // dpf_systemlog_logoff
            // 
            this.dpf_systemlog_logoff.CustomFormat = "yyyy-MM-dd";
            this.dpf_systemlog_logoff.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpf_systemlog_logoff.Location = new System.Drawing.Point(247, 20);
            this.dpf_systemlog_logoff.Name = "dpf_systemlog_logoff";
            this.dpf_systemlog_logoff.Size = new System.Drawing.Size(92, 21);
            this.dpf_systemlog_logoff.TabIndex = 8;
            // 
            // btnFind
            // 
            this.btnFind.Image = global::InvoicingApp.Properties.Resources.Search;
            this.btnFind.Location = new System.Drawing.Point(524, 19);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "查询(&Q)";
            this.btnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // dpf_systemlog_logon
            // 
            this.dpf_systemlog_logon.CustomFormat = "yyyy-MM-dd";
            this.dpf_systemlog_logon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpf_systemlog_logon.Location = new System.Drawing.Point(95, 20);
            this.dpf_systemlog_logon.Name = "dpf_systemlog_logon";
            this.dpf_systemlog_logon.Size = new System.Drawing.Size(92, 21);
            this.dpf_systemlog_logon.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "到:";
            // 
            // SystemLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(636, 410);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(642, 442);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(642, 442);
            this.Name = "SystemLogForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统日志";
            this.Load += new System.EventHandler(this.SystemLogForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSystemLog)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvSystemLog;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.DateTimePicker dpf_systemlog_logon;
        private System.Windows.Forms.DateTimePicker dpf_systemlog_logoff;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn systemlog_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn systemlog_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn systemlog_logon;
        private System.Windows.Forms.DataGridViewTextBoxColumn systemlog_logoff;
    }
}