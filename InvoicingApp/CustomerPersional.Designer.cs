namespace InvoicingApp
{
    partial class CustomerPersional
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerPersional));
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtCustomer_tel = new TCControl.TCTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCustomer_codeSelect = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtCustomer_yxmSelect = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomer_nameSelect = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCommit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_usecode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_yxm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Archives_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label25 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtCustomer_yxm = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCustomer_age = new TCControl.TCTextBox();
            this.cbCustomer_sex = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustomer_usecode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCustomer_address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCustomer_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::InvoicingApp.Properties.Resources.Delete;
            this.btnDelete.Location = new System.Drawing.Point(178, 121);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "删除(&D)";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtCustomer_tel
            // 
            this.txtCustomer_tel.DateTimeFormate = TCControl.TCTextBox.FormatType.yyyyMMdd;
            this.txtCustomer_tel.Encodeing = "GB2312";
            this.txtCustomer_tel.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtCustomer_tel.IsAllowMinus = false;
            this.txtCustomer_tel.Location = new System.Drawing.Point(605, 50);
            this.txtCustomer_tel.MatchValue = "^[0-9]+[0-9]*[0-9-]*$";
            this.txtCustomer_tel.MaxByteLength = 20;
            this.txtCustomer_tel.MaxLength = 25;
            this.txtCustomer_tel.Name = "txtCustomer_tel";
            this.txtCustomer_tel.PadLeftFirstIsZero = false;
            this.txtCustomer_tel.Precision = 0;
            this.txtCustomer_tel.Scale = 0;
            this.txtCustomer_tel.Size = new System.Drawing.Size(150, 21);
            this.txtCustomer_tel.TabIndex = 5;
            this.txtCustomer_tel.TypeSet = TCControl.TCTextBox.Type.MatchDefine;
            this.txtCustomer_tel.Value = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(490, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 73;
            this.label3.Text = "*";
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::InvoicingApp.Properties.Resources.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(680, 121);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 60);
            this.panel1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCustomer_codeSelect);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnSelect);
            this.groupBox2.Controls.Add(this.txtCustomer_yxmSelect);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtCustomer_nameSelect);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(804, 60);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "客户查询";
            // 
            // txtCustomer_codeSelect
            // 
            this.txtCustomer_codeSelect.Location = new System.Drawing.Point(79, 20);
            this.txtCustomer_codeSelect.MaxLength = 25;
            this.txtCustomer_codeSelect.Name = "txtCustomer_codeSelect";
            this.txtCustomer_codeSelect.Size = new System.Drawing.Size(100, 21);
            this.txtCustomer_codeSelect.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 12);
            this.label12.TabIndex = 80;
            this.label12.Text = "客户编号:";
            // 
            // btnClear
            // 
            this.btnClear.Image = global::InvoicingApp.Properties.Resources.Reset;
            this.btnClear.Location = new System.Drawing.Point(680, 20);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "重置(&R)";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Image = global::InvoicingApp.Properties.Resources.Search;
            this.btnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelect.Location = new System.Drawing.Point(599, 20);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "查询(&Q)";
            this.btnSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtCustomer_yxmSelect
            // 
            this.txtCustomer_yxmSelect.Location = new System.Drawing.Point(460, 20);
            this.txtCustomer_yxmSelect.Name = "txtCustomer_yxmSelect";
            this.txtCustomer_yxmSelect.Size = new System.Drawing.Size(100, 21);
            this.txtCustomer_yxmSelect.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "客户音序码:";
            // 
            // txtCustomer_nameSelect
            // 
            this.txtCustomer_nameSelect.Location = new System.Drawing.Point(268, 20);
            this.txtCustomer_nameSelect.Name = "txtCustomer_nameSelect";
            this.txtCustomer_nameSelect.Size = new System.Drawing.Size(100, 21);
            this.txtCustomer_nameSelect.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "客户姓名:";
            // 
            // btnCommit
            // 
            this.btnCommit.Image = global::InvoicingApp.Properties.Resources.Save;
            this.btnCommit.Location = new System.Drawing.Point(599, 121);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(75, 23);
            this.btnCommit.TabIndex = 10;
            this.btnCommit.Text = "保存(&S)";
            this.btnCommit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = global::InvoicingApp.Properties.Resources.Edit;
            this.btnUpdate.Location = new System.Drawing.Point(97, 121);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "修改(&M)";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Image = global::InvoicingApp.Properties.Resources.Add;
            this.btnInsert.Location = new System.Drawing.Point(16, 121);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "增加(&A)";
            this.btnInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
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
            this.customer_usecode,
            this.customer_name,
            this.customer_sex,
            this.customer_age,
            this.customer_tel,
            this.customer_address,
            this.customer_yxm,
            this.customer_code,
            this.Archives_id});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 5);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(804, 372);
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
            // customer_usecode
            // 
            this.customer_usecode.DataPropertyName = "customer_usecode";
            this.customer_usecode.HeaderText = "客户编号";
            this.customer_usecode.Name = "customer_usecode";
            this.customer_usecode.ReadOnly = true;
            // 
            // customer_name
            // 
            this.customer_name.DataPropertyName = "customer_name";
            this.customer_name.HeaderText = "客户姓名";
            this.customer_name.Name = "customer_name";
            this.customer_name.ReadOnly = true;
            // 
            // customer_sex
            // 
            this.customer_sex.DataPropertyName = "customer_sex";
            this.customer_sex.HeaderText = "性别";
            this.customer_sex.Name = "customer_sex";
            this.customer_sex.ReadOnly = true;
            // 
            // customer_age
            // 
            this.customer_age.DataPropertyName = "customer_age";
            this.customer_age.HeaderText = "年龄";
            this.customer_age.Name = "customer_age";
            this.customer_age.ReadOnly = true;
            // 
            // customer_tel
            // 
            this.customer_tel.DataPropertyName = "customer_tel";
            this.customer_tel.HeaderText = "电话";
            this.customer_tel.Name = "customer_tel";
            this.customer_tel.ReadOnly = true;
            // 
            // customer_address
            // 
            this.customer_address.DataPropertyName = "customer_address";
            this.customer_address.HeaderText = "地址";
            this.customer_address.Name = "customer_address";
            this.customer_address.ReadOnly = true;
            this.customer_address.Width = 200;
            // 
            // customer_yxm
            // 
            this.customer_yxm.DataPropertyName = "customer_yxm";
            this.customer_yxm.HeaderText = "音序码";
            this.customer_yxm.Name = "customer_yxm";
            this.customer_yxm.ReadOnly = true;
            this.customer_yxm.Visible = false;
            // 
            // customer_code
            // 
            this.customer_code.DataPropertyName = "customer_code";
            this.customer_code.HeaderText = "客户编号表";
            this.customer_code.Name = "customer_code";
            this.customer_code.ReadOnly = true;
            this.customer_code.Visible = false;
            // 
            // Archives_id
            // 
            this.Archives_id.DataPropertyName = "Archives_id";
            this.Archives_id.HeaderText = "档案主键";
            this.Archives_id.Name = "Archives_id";
            this.Archives_id.ReadOnly = true;
            this.Archives_id.Visible = false;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(531, 54);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(35, 12);
            this.label25.TabIndex = 24;
            this.label25.Text = "电话:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(10, 70);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel3.Size = new System.Drawing.Size(804, 377);
            this.panel3.TabIndex = 5;
            // 
            // txtCustomer_yxm
            // 
            this.txtCustomer_yxm.Location = new System.Drawing.Point(605, 20);
            this.txtCustomer_yxm.MaxLength = 25;
            this.txtCustomer_yxm.Name = "txtCustomer_yxm";
            this.txtCustomer_yxm.Size = new System.Drawing.Size(150, 21);
            this.txtCustomer_yxm.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCustomer_age);
            this.groupBox1.Controls.Add(this.cbCustomer_sex);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCustomer_usecode);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCustomer_address);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.txtCustomer_tel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnCommit);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.txtCustomer_yxm);
            this.groupBox1.Controls.Add(this.txtCustomer_name);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10, 15, 10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "客户信息维护";
            // 
            // txtCustomer_age
            // 
            this.txtCustomer_age.DateTimeFormate = TCControl.TCTextBox.FormatType.yyyyMMdd;
            this.txtCustomer_age.Encodeing = "GB2312";
            this.txtCustomer_age.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtCustomer_age.IsAllowMinus = false;
            this.txtCustomer_age.Location = new System.Drawing.Point(340, 50);
            this.txtCustomer_age.MatchValue = "^[0-9]*$";
            this.txtCustomer_age.MaxByteLength = 3;
            this.txtCustomer_age.MaxLength = 25;
            this.txtCustomer_age.Name = "txtCustomer_age";
            this.txtCustomer_age.PadLeftFirstIsZero = false;
            this.txtCustomer_age.Precision = 0;
            this.txtCustomer_age.Scale = 0;
            this.txtCustomer_age.Size = new System.Drawing.Size(150, 21);
            this.txtCustomer_age.TabIndex = 4;
            this.txtCustomer_age.TypeSet = TCControl.TCTextBox.Type.MatchDefine;
            this.txtCustomer_age.Value = "";
            // 
            // cbCustomer_sex
            // 
            this.cbCustomer_sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustomer_sex.FormattingEnabled = true;
            this.cbCustomer_sex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbCustomer_sex.Location = new System.Drawing.Point(88, 51);
            this.cbCustomer_sex.Name = "cbCustomer_sex";
            this.cbCustomer_sex.Size = new System.Drawing.Size(150, 20);
            this.cbCustomer_sex.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(266, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 12);
            this.label13.TabIndex = 87;
            this.label13.Text = "年龄:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 81;
            this.label9.Text = "性别:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(238, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 79;
            this.label4.Text = "*";
            // 
            // txtCustomer_usecode
            // 
            this.txtCustomer_usecode.Location = new System.Drawing.Point(88, 20);
            this.txtCustomer_usecode.MaxLength = 25;
            this.txtCustomer_usecode.Name = "txtCustomer_usecode";
            this.txtCustomer_usecode.Size = new System.Drawing.Size(150, 21);
            this.txtCustomer_usecode.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 78;
            this.label6.Text = "客户编号:";
            // 
            // txtCustomer_address
            // 
            this.txtCustomer_address.Location = new System.Drawing.Point(88, 81);
            this.txtCustomer_address.MaxLength = 50;
            this.txtCustomer_address.Name = "txtCustomer_address";
            this.txtCustomer_address.Size = new System.Drawing.Size(402, 21);
            this.txtCustomer_address.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 76;
            this.label5.Text = "地址:";
            // 
            // txtCustomer_name
            // 
            this.txtCustomer_name.Location = new System.Drawing.Point(340, 20);
            this.txtCustomer_name.MaxLength = 25;
            this.txtCustomer_name.Name = "txtCustomer_name";
            this.txtCustomer_name.Size = new System.Drawing.Size(150, 21);
            this.txtCustomer_name.TabIndex = 1;
            this.txtCustomer_name.TextChanged += new System.EventHandler(this.txtCustomer_name_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(266, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 20;
            this.label7.Text = "客户姓名:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(531, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 21;
            this.label8.Text = "音序码:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(10, 447);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel2.Size = new System.Drawing.Size(804, 161);
            this.panel2.TabIndex = 4;
            // 
            // CustomerPersional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 618);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(830, 650);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(830, 650);
            this.Name = "CustomerPersional";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "个人客户管理";
            this.Load += new System.EventHandler(this.CustomerPersional_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private TCControl.TCTextBox txtCustomer_tel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtCustomer_yxmSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomer_nameSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtCustomer_yxm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCustomer_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCustomer_address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustomer_usecode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCustomer_codeSelect;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbCustomer_sex;
        private TCControl.TCTextBox txtCustomer_age;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_usecode;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_age;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_yxm;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Archives_id;
    }
}