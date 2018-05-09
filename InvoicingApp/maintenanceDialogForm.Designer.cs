namespace InvoicingApp
{
    partial class maintenanceDialogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(maintenanceDialogForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupbox = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCommit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dateMaintain_datetime = new System.Windows.Forms.DateTimePicker();
            this.txtMaintain_detail_settle = new System.Windows.Forms.TextBox();
            this.txtMaintain_detail_quality = new System.Windows.Forms.TextBox();
            this.txtMaintain_detail_remark = new System.Windows.Forms.TextBox();
            this.txtMaintain_detail_oper = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintain_detail_quality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintain_detail_settle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintain_detail_datetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintain_detail_oper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintain_detail_remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintain_detail_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintain_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupbox.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupbox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(10, 336);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel1.Size = new System.Drawing.Size(724, 136);
            this.panel1.TabIndex = 0;
            // 
            // groupbox
            // 
            this.groupbox.Controls.Add(this.label21);
            this.groupbox.Controls.Add(this.btnUpdate);
            this.groupbox.Controls.Add(this.btnDelete);
            this.groupbox.Controls.Add(this.btnCommit);
            this.groupbox.Controls.Add(this.btnCancel);
            this.groupbox.Controls.Add(this.btnInsert);
            this.groupbox.Controls.Add(this.dateMaintain_datetime);
            this.groupbox.Controls.Add(this.txtMaintain_detail_settle);
            this.groupbox.Controls.Add(this.txtMaintain_detail_quality);
            this.groupbox.Controls.Add(this.txtMaintain_detail_remark);
            this.groupbox.Controls.Add(this.txtMaintain_detail_oper);
            this.groupbox.Controls.Add(this.label5);
            this.groupbox.Controls.Add(this.label4);
            this.groupbox.Controls.Add(this.label3);
            this.groupbox.Controls.Add(this.label2);
            this.groupbox.Controls.Add(this.label1);
            this.groupbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupbox.Location = new System.Drawing.Point(0, 10);
            this.groupbox.Name = "groupbox";
            this.groupbox.Size = new System.Drawing.Size(724, 126);
            this.groupbox.TabIndex = 76;
            this.groupbox.TabStop = false;
            this.groupbox.Text = "养护明细信息维护";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(218, 24);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(11, 12);
            this.label21.TabIndex = 88;
            this.label21.Text = "*";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = global::InvoicingApp.Properties.Resources.Edit;
            this.btnUpdate.Location = new System.Drawing.Point(97, 91);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "修改(&M)";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::InvoicingApp.Properties.Resources.Delete;
            this.btnDelete.Location = new System.Drawing.Point(178, 91);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "删除(&D)";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCommit
            // 
            this.btnCommit.Image = global::InvoicingApp.Properties.Resources.Save;
            this.btnCommit.Location = new System.Drawing.Point(510, 91);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(75, 23);
            this.btnCommit.TabIndex = 8;
            this.btnCommit.Text = "保存(&S)";
            this.btnCommit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::InvoicingApp.Properties.Resources.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(591, 91);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Image = global::InvoicingApp.Properties.Resources.Add;
            this.btnInsert.Location = new System.Drawing.Point(16, 91);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "增加(&A)";
            this.btnInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dateMaintain_datetime
            // 
            this.dateMaintain_datetime.CustomFormat = "yyyy-MM-dd";
            this.dateMaintain_datetime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateMaintain_datetime.Location = new System.Drawing.Point(88, 50);
            this.dateMaintain_datetime.Name = "dateMaintain_datetime";
            this.dateMaintain_datetime.Size = new System.Drawing.Size(130, 21);
            this.dateMaintain_datetime.TabIndex = 3;
            // 
            // txtMaintain_detail_settle
            // 
            this.txtMaintain_detail_settle.Location = new System.Drawing.Point(536, 20);
            this.txtMaintain_detail_settle.MaxLength = 25;
            this.txtMaintain_detail_settle.Name = "txtMaintain_detail_settle";
            this.txtMaintain_detail_settle.Size = new System.Drawing.Size(130, 21);
            this.txtMaintain_detail_settle.TabIndex = 2;
            // 
            // txtMaintain_detail_quality
            // 
            this.txtMaintain_detail_quality.Location = new System.Drawing.Point(312, 20);
            this.txtMaintain_detail_quality.MaxLength = 25;
            this.txtMaintain_detail_quality.Name = "txtMaintain_detail_quality";
            this.txtMaintain_detail_quality.Size = new System.Drawing.Size(130, 21);
            this.txtMaintain_detail_quality.TabIndex = 1;
            // 
            // txtMaintain_detail_remark
            // 
            this.txtMaintain_detail_remark.Location = new System.Drawing.Point(312, 51);
            this.txtMaintain_detail_remark.MaxLength = 50;
            this.txtMaintain_detail_remark.Name = "txtMaintain_detail_remark";
            this.txtMaintain_detail_remark.Size = new System.Drawing.Size(354, 21);
            this.txtMaintain_detail_remark.TabIndex = 4;
            // 
            // txtMaintain_detail_oper
            // 
            this.txtMaintain_detail_oper.Location = new System.Drawing.Point(88, 20);
            this.txtMaintain_detail_oper.MaxLength = 25;
            this.txtMaintain_detail_oper.Name = "txtMaintain_detail_oper";
            this.txtMaintain_detail_oper.Size = new System.Drawing.Size(130, 21);
            this.txtMaintain_detail_oper.TabIndex = 0;
            this.txtMaintain_detail_oper.DoubleClick += new System.EventHandler(this.txtMaintain_detail_oper_DoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "备注:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "养护时间:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(462, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "处理措施:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "质量问题:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "养护员:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(724, 326);
            this.panel2.TabIndex = 1;
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
            this.maintain_detail_quality,
            this.maintain_detail_settle,
            this.maintain_detail_datetime,
            this.maintain_detail_oper,
            this.maintain_detail_remark,
            this.maintain_detail_code,
            this.maintain_code});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(724, 326);
            this.dgv.StandardTab = true;
            this.dgv.TabIndex = 0;
            this.dgv.Sorted += new System.EventHandler(this.dgv_Sorted);
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
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
            // maintain_detail_quality
            // 
            this.maintain_detail_quality.DataPropertyName = "maintain_detail_quality";
            this.maintain_detail_quality.HeaderText = "质量问题";
            this.maintain_detail_quality.Name = "maintain_detail_quality";
            this.maintain_detail_quality.ReadOnly = true;
            // 
            // maintain_detail_settle
            // 
            this.maintain_detail_settle.DataPropertyName = "maintain_detail_settle";
            this.maintain_detail_settle.HeaderText = "处理措施";
            this.maintain_detail_settle.Name = "maintain_detail_settle";
            this.maintain_detail_settle.ReadOnly = true;
            this.maintain_detail_settle.Width = 143;
            // 
            // maintain_detail_datetime
            // 
            this.maintain_detail_datetime.DataPropertyName = "maintain_detail_datetime";
            this.maintain_detail_datetime.HeaderText = "养护时间";
            this.maintain_detail_datetime.Name = "maintain_detail_datetime";
            this.maintain_detail_datetime.ReadOnly = true;
            // 
            // maintain_detail_oper
            // 
            this.maintain_detail_oper.DataPropertyName = "maintain_detail_oper";
            this.maintain_detail_oper.HeaderText = "养护员";
            this.maintain_detail_oper.Name = "maintain_detail_oper";
            this.maintain_detail_oper.ReadOnly = true;
            // 
            // maintain_detail_remark
            // 
            this.maintain_detail_remark.DataPropertyName = "maintain_detail_remark";
            this.maintain_detail_remark.HeaderText = "备注";
            this.maintain_detail_remark.Name = "maintain_detail_remark";
            this.maintain_detail_remark.ReadOnly = true;
            this.maintain_detail_remark.Width = 220;
            // 
            // maintain_detail_code
            // 
            this.maintain_detail_code.DataPropertyName = "maintain_detail_code";
            this.maintain_detail_code.HeaderText = "养护明细编号";
            this.maintain_detail_code.Name = "maintain_detail_code";
            this.maintain_detail_code.ReadOnly = true;
            this.maintain_detail_code.Visible = false;
            // 
            // maintain_code
            // 
            this.maintain_code.DataPropertyName = "maintain_code";
            this.maintain_code.HeaderText = "养护编号";
            this.maintain_code.Name = "maintain_code";
            this.maintain_code.ReadOnly = true;
            this.maintain_code.Visible = false;
            this.maintain_code.Width = 130;
            // 
            // maintenanceDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(744, 482);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(750, 514);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(750, 514);
            this.Name = "maintenanceDialogForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "养护明细管理";
            this.Load += new System.EventHandler(this.maintenanceDialogForm_Load);
            this.panel1.ResumeLayout(false);
            this.groupbox.ResumeLayout(false);
            this.groupbox.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txtMaintain_detail_settle;
        private System.Windows.Forms.TextBox txtMaintain_detail_quality;
        private System.Windows.Forms.TextBox txtMaintain_detail_remark;
        private System.Windows.Forms.TextBox txtMaintain_detail_oper;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn maintain_code;
        private System.Windows.Forms.DateTimePicker dateMaintain_datetime;
        private System.Windows.Forms.GroupBox groupbox;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintain_detail_quality;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintain_detail_settle;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintain_detail_datetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintain_detail_oper;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintain_detail_remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintain_detail_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintain_code;
    }
}