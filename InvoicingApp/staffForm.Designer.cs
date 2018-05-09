namespace InvoicingApp
{
    partial class StaffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffForm));
            this.dataGridView_staff = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_yxm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_card = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_edu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_introduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_dep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_contract_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_specialities = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_job_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBox_staffName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_staff_yxm = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_staff)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_staff
            // 
            this.dataGridView_staff.AllowUserToAddRows = false;
            this.dataGridView_staff.AllowUserToDeleteRows = false;
            this.dataGridView_staff.AllowUserToOrderColumns = true;
            this.dataGridView_staff.AllowUserToResizeRows = false;
            this.dataGridView_staff.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_staff.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_staff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.staff_name,
            this.staff_yxm,
            this.staff_sex,
            this.staff_birthday,
            this.staff_card,
            this.staff_tel,
            this.staff_edu,
            this.staff_introduction,
            this.staff_code,
            this.staff_dep,
            this.staff_contract_num,
            this.staff_specialities,
            this.staff_job_title});
            this.dataGridView_staff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_staff.Location = new System.Drawing.Point(0, 5);
            this.dataGridView_staff.MultiSelect = false;
            this.dataGridView_staff.Name = "dataGridView_staff";
            this.dataGridView_staff.ReadOnly = true;
            this.dataGridView_staff.RowHeadersVisible = false;
            this.dataGridView_staff.RowTemplate.Height = 23;
            this.dataGridView_staff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_staff.Size = new System.Drawing.Size(630, 312);
            this.dataGridView_staff.TabIndex = 0;
            this.dataGridView_staff.TabStop = false;
            this.dataGridView_staff.Sorted += new System.EventHandler(this.dataGridView_staff_Sorted);
            this.dataGridView_staff.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_staff_CellDoubleClick);
            // 
            // num
            // 
            this.num.DataPropertyName = "num";
            this.num.HeaderText = "序号";
            this.num.Name = "num";
            this.num.ReadOnly = true;
            this.num.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.num.Width = 55;
            // 
            // staff_name
            // 
            this.staff_name.DataPropertyName = "staff_name";
            this.staff_name.HeaderText = "姓名";
            this.staff_name.Name = "staff_name";
            this.staff_name.ReadOnly = true;
            this.staff_name.Width = 110;
            // 
            // staff_yxm
            // 
            this.staff_yxm.DataPropertyName = "staff_yxm";
            this.staff_yxm.HeaderText = "输入码";
            this.staff_yxm.Name = "staff_yxm";
            this.staff_yxm.ReadOnly = true;
            this.staff_yxm.Visible = false;
            this.staff_yxm.Width = 110;
            // 
            // staff_sex
            // 
            this.staff_sex.DataPropertyName = "staff_sex";
            this.staff_sex.HeaderText = "性别";
            this.staff_sex.Name = "staff_sex";
            this.staff_sex.ReadOnly = true;
            this.staff_sex.Width = 110;
            // 
            // staff_birthday
            // 
            this.staff_birthday.DataPropertyName = "staff_birthday";
            this.staff_birthday.HeaderText = "出生日期";
            this.staff_birthday.Name = "staff_birthday";
            this.staff_birthday.ReadOnly = true;
            this.staff_birthday.Visible = false;
            this.staff_birthday.Width = 110;
            // 
            // staff_card
            // 
            this.staff_card.DataPropertyName = "staff_card";
            this.staff_card.HeaderText = "身份证号";
            this.staff_card.Name = "staff_card";
            this.staff_card.ReadOnly = true;
            this.staff_card.Visible = false;
            this.staff_card.Width = 110;
            // 
            // staff_tel
            // 
            this.staff_tel.DataPropertyName = "staff_tel";
            this.staff_tel.HeaderText = "电话";
            this.staff_tel.Name = "staff_tel";
            this.staff_tel.ReadOnly = true;
            this.staff_tel.Width = 110;
            // 
            // staff_edu
            // 
            this.staff_edu.DataPropertyName = "staff_edu";
            this.staff_edu.HeaderText = "学历";
            this.staff_edu.Name = "staff_edu";
            this.staff_edu.ReadOnly = true;
            this.staff_edu.Width = 110;
            // 
            // staff_introduction
            // 
            this.staff_introduction.DataPropertyName = "staff_introduction";
            this.staff_introduction.HeaderText = "就职简历";
            this.staff_introduction.Name = "staff_introduction";
            this.staff_introduction.ReadOnly = true;
            this.staff_introduction.Visible = false;
            this.staff_introduction.Width = 110;
            // 
            // staff_code
            // 
            this.staff_code.DataPropertyName = "staff_code";
            this.staff_code.HeaderText = "员工编号";
            this.staff_code.Name = "staff_code";
            this.staff_code.ReadOnly = true;
            this.staff_code.Visible = false;
            this.staff_code.Width = 130;
            // 
            // staff_dep
            // 
            this.staff_dep.DataPropertyName = "staff_dep";
            this.staff_dep.HeaderText = "职位";
            this.staff_dep.Name = "staff_dep";
            this.staff_dep.ReadOnly = true;
            this.staff_dep.Visible = false;
            // 
            // staff_contract_num
            // 
            this.staff_contract_num.DataPropertyName = "staff_contract_num";
            this.staff_contract_num.HeaderText = "合同编号";
            this.staff_contract_num.Name = "staff_contract_num";
            this.staff_contract_num.ReadOnly = true;
            this.staff_contract_num.Visible = false;
            // 
            // staff_specialities
            // 
            this.staff_specialities.DataPropertyName = "staff_specialities";
            this.staff_specialities.HeaderText = "专业";
            this.staff_specialities.Name = "staff_specialities";
            this.staff_specialities.ReadOnly = true;
            this.staff_specialities.Visible = false;
            // 
            // staff_job_title
            // 
            this.staff_job_title.DataPropertyName = "staff_job_title";
            this.staff_job_title.HeaderText = "职称";
            this.staff_job_title.Name = "staff_job_title";
            this.staff_job_title.ReadOnly = true;
            this.staff_job_title.Visible = false;
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Image = global::InvoicingApp.Properties.Resources.Ok;
            this.btn_Confirm.Location = new System.Drawing.Point(459, 15);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_Confirm.TabIndex = 1;
            this.btn_Confirm.Text = "确定(&O)";
            this.btn_Confirm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "员工姓名:";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::InvoicingApp.Properties.Resources.Search;
            this.btnSearch.Location = new System.Drawing.Point(459, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "查询(&Q)";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textBox_staffName
            // 
            this.textBox_staffName.Location = new System.Drawing.Point(88, 20);
            this.textBox_staffName.MaxLength = 25;
            this.textBox_staffName.Name = "textBox_staffName";
            this.textBox_staffName.Size = new System.Drawing.Size(129, 21);
            this.textBox_staffName.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_staff_yxm);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.textBox_staffName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // btnClear
            // 
            this.btnClear.Image = global::InvoicingApp.Properties.Resources.Reset;
            this.btnClear.Location = new System.Drawing.Point(540, 19);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "重置(&R)";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "音序码:";
            // 
            // textBox_staff_yxm
            // 
            this.textBox_staff_yxm.Location = new System.Drawing.Point(301, 20);
            this.textBox_staff_yxm.MaxLength = 25;
            this.textBox_staff_yxm.Name = "textBox_staff_yxm";
            this.textBox_staff_yxm.Size = new System.Drawing.Size(129, 21);
            this.textBox_staff_yxm.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::InvoicingApp.Properties.Resources.Close;
            this.btnCancel.Location = new System.Drawing.Point(540, 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "关闭(&C)";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Image = global::InvoicingApp.Properties.Resources.Add;
            this.btnInsert.Location = new System.Drawing.Point(16, 15);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "增加(&A)";
            this.btnInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btn_Confirm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(5, 382);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel1.Size = new System.Drawing.Size(630, 53);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView_staff);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(5, 65);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel2.Size = new System.Drawing.Size(630, 317);
            this.panel2.TabIndex = 2;
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(640, 440);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StaffForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "员工信息列表";
            this.Load += new System.EventHandler(this.StaffForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_staff)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_staff;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBox_staffName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_staff_yxm;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_yxm;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_card;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_edu;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_introduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_dep;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_contract_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_specialities;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_job_title;
    }
}