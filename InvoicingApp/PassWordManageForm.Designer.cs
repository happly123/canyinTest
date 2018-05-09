namespace InvoicingApp
{
    partial class PassWordManageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassWordManageForm));
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRepassword = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStaff_name = new System.Windows.Forms.TextBox();
            this.txtAuthority_user_code = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCommit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_job_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authority_user_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authority_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(42, 269);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "修改管理员密码";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRepassword
            // 
            this.btnRepassword.Location = new System.Drawing.Point(42, 241);
            this.btnRepassword.Name = "btnRepassword";
            this.btnRepassword.Size = new System.Drawing.Size(112, 23);
            this.btnRepassword.TabIndex = 0;
            this.btnRepassword.Text = "初始化用户密码";
            this.btnRepassword.UseVisualStyleBackColor = true;
            this.btnRepassword.Click += new System.EventHandler(this.btnRepassword_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "用户姓名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "登录账号:";
            // 
            // txtStaff_name
            // 
            this.txtStaff_name.Location = new System.Drawing.Point(19, 50);
            this.txtStaff_name.MaxLength = 20;
            this.txtStaff_name.Name = "txtStaff_name";
            this.txtStaff_name.Size = new System.Drawing.Size(139, 21);
            this.txtStaff_name.TabIndex = 0;
            this.txtStaff_name.DoubleClick += new System.EventHandler(this.txtStaff_name_DoubleClick);
            // 
            // txtAuthority_user_code
            // 
            this.txtAuthority_user_code.Location = new System.Drawing.Point(19, 98);
            this.txtAuthority_user_code.MaxLength = 20;
            this.txtAuthority_user_code.Name = "txtAuthority_user_code";
            this.txtAuthority_user_code.Size = new System.Drawing.Size(139, 21);
            this.txtAuthority_user_code.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnCommit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.txtAuthority_user_code);
            this.groupBox1.Controls.Add(this.txtStaff_name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "用户信息维护";
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::InvoicingApp.Properties.Resources.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(100, 186);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 81;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCommit
            // 
            this.btnCommit.Image = global::InvoicingApp.Properties.Resources.Save;
            this.btnCommit.Location = new System.Drawing.Point(15, 186);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(75, 23);
            this.btnCommit.TabIndex = 80;
            this.btnCommit.Text = "保存(&S)";
            this.btnCommit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(158, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 79;
            this.label3.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(158, 101);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(11, 12);
            this.label16.TabIndex = 78;
            this.label16.Text = "*";
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::InvoicingApp.Properties.Resources.Delete;
            this.btnDelete.Location = new System.Drawing.Point(100, 150);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "删除(&D)";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Image = global::InvoicingApp.Properties.Resources.Add;
            this.btnInsert.Location = new System.Drawing.Point(15, 150);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "增加(&A)";
            this.btnInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnRepassword);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(389, 5);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(200, 302);
            this.panel2.TabIndex = 1;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.staff_name,
            this.staff_job_title,
            this.authority_user_code,
            this.staff_code,
            this.authority_id});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv.Location = new System.Drawing.Point(5, 5);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(384, 302);
            this.dgv.StandardTab = true;
            this.dgv.TabIndex = 4;
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
            // staff_name
            // 
            this.staff_name.DataPropertyName = "staff_name";
            this.staff_name.HeaderText = "员工姓名";
            this.staff_name.Name = "staff_name";
            this.staff_name.ReadOnly = true;
            // 
            // staff_job_title
            // 
            this.staff_job_title.DataPropertyName = "staff_dep";
            this.staff_job_title.HeaderText = "职位";
            this.staff_job_title.Name = "staff_job_title";
            this.staff_job_title.ReadOnly = true;
            // 
            // authority_user_code
            // 
            this.authority_user_code.DataPropertyName = "authority_user_code";
            this.authority_user_code.HeaderText = "账号";
            this.authority_user_code.Name = "authority_user_code";
            this.authority_user_code.ReadOnly = true;
            // 
            // staff_code
            // 
            this.staff_code.DataPropertyName = "staff_code";
            this.staff_code.HeaderText = "员工编号";
            this.staff_code.Name = "staff_code";
            this.staff_code.ReadOnly = true;
            this.staff_code.Visible = false;
            // 
            // authority_id
            // 
            this.authority_id.DataPropertyName = "authority_id";
            this.authority_id.HeaderText = "用户编号";
            this.authority_id.Name = "authority_id";
            this.authority_id.ReadOnly = true;
            this.authority_id.Visible = false;
            // 
            // PassWordManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(594, 312);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 344);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 344);
            this.Name = "PassWordManageForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户管理";
            this.Load += new System.EventHandler(this.PassWordManageForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRepassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStaff_name;
        private System.Windows.Forms.TextBox txtAuthority_user_code;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_job_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn authority_user_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn authority_id;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCommit;
    }
}