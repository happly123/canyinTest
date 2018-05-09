namespace InvoicingApp
{
    partial class MaintenanceManagementForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtGoods_yxmSelect = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGoods_nameSelect = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaintain_codeSelect = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtGoods_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCommit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtMaintain_application = new System.Windows.Forms.TextBox();
            this.dateMaintain_create_date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaintain_quality = new System.Windows.Forms.TextBox();
            this.txtMaintain_characters = new System.Windows.Forms.TextBox();
            this.txtMaintain_test_items = new System.Windows.Forms.TextBox();
            this.txtMaintain_purpose = new System.Windows.Forms.TextBox();
            this.txtMaintain_input_code = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintain_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintain_input_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input_batch_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintain_create_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_validity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_reg_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maker_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maker_postal_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maker_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maker_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintain_application = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintain_purpose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintain_quality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintain_test_items = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintain_characters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_storemethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input_packing_in = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input_packing_mid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input_packing_out = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_yxm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(996, 682);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgv);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 60);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel4.Size = new System.Drawing.Size(996, 486);
            this.panel4.TabIndex = 3;
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
            this.maintain_code,
            this.maintain_input_code,
            this.goods_name,
            this.input_batch_num,
            this.maintain_create_date,
            this.goods_validity,
            this.goods_type,
            this.goods_reg_num,
            this.maker_name,
            this.maker_postal_code,
            this.maker_address,
            this.maker_tel,
            this.maintain_application,
            this.maintain_purpose,
            this.maintain_quality,
            this.maintain_test_items,
            this.maintain_characters,
            this.goods_storemethod,
            this.input_packing_in,
            this.input_packing_mid,
            this.input_packing_out,
            this.goods_yxm});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 5);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(996, 481);
            this.dgv.StandardTab = true;
            this.dgv.TabIndex = 101;
            this.dgv.Sorted += new System.EventHandler(this.dgv_Sorted);
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(996, 60);
            this.panel3.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnSelect);
            this.groupBox1.Controls.Add(this.txtGoods_yxmSelect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtGoods_nameSelect);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMaintain_codeSelect);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.groupBox1.Size = new System.Drawing.Size(996, 60);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "养护查询";
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::InvoicingApp.Properties.Resources.Print;
            this.btnPrint.Location = new System.Drawing.Point(896, 20);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "打印(&P)";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClear
            // 
            this.btnClear.Image = global::InvoicingApp.Properties.Resources.Reset;
            this.btnClear.Location = new System.Drawing.Point(815, 19);
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
            this.btnSelect.Location = new System.Drawing.Point(734, 19);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "查询(&Q)";
            this.btnSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtGoods_yxmSelect
            // 
            this.txtGoods_yxmSelect.Location = new System.Drawing.Point(544, 20);
            this.txtGoods_yxmSelect.MaxLength = 25;
            this.txtGoods_yxmSelect.Name = "txtGoods_yxmSelect";
            this.txtGoods_yxmSelect.Size = new System.Drawing.Size(140, 21);
            this.txtGoods_yxmSelect.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "音序码:";
            // 
            // txtGoods_nameSelect
            // 
            this.txtGoods_nameSelect.Location = new System.Drawing.Point(322, 20);
            this.txtGoods_nameSelect.MaxLength = 25;
            this.txtGoods_nameSelect.Name = "txtGoods_nameSelect";
            this.txtGoods_nameSelect.Size = new System.Drawing.Size(140, 21);
            this.txtGoods_nameSelect.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "产品名称:";
            // 
            // txtMaintain_codeSelect
            // 
            this.txtMaintain_codeSelect.Location = new System.Drawing.Point(88, 20);
            this.txtMaintain_codeSelect.MaxLength = 25;
            this.txtMaintain_codeSelect.Name = "txtMaintain_codeSelect";
            this.txtMaintain_codeSelect.Size = new System.Drawing.Size(140, 21);
            this.txtMaintain_codeSelect.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "养护编号:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 546);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel1.Size = new System.Drawing.Size(996, 136);
            this.panel1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtGoods_name);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnCommit);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnInsert);
            this.groupBox2.Controls.Add(this.txtMaintain_application);
            this.groupBox2.Controls.Add(this.dateMaintain_create_date);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtMaintain_quality);
            this.groupBox2.Controls.Add(this.txtMaintain_characters);
            this.groupBox2.Controls.Add(this.txtMaintain_test_items);
            this.groupBox2.Controls.Add(this.txtMaintain_purpose);
            this.groupBox2.Controls.Add(this.txtMaintain_input_code);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(996, 126);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "养护信息维护";
            // 
            // txtGoods_name
            // 
            this.txtGoods_name.Location = new System.Drawing.Point(332, 20);
            this.txtGoods_name.MaxLength = 25;
            this.txtGoods_name.Name = "txtGoods_name";
            this.txtGoods_name.Size = new System.Drawing.Size(150, 21);
            this.txtGoods_name.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 89;
            this.label5.Text = "产品名称:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(238, 24);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(11, 12);
            this.label21.TabIndex = 87;
            this.label21.Text = "*";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = global::InvoicingApp.Properties.Resources.Edit;
            this.btnUpdate.Location = new System.Drawing.Point(97, 91);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 9;
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
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "删除(&D)";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCommit
            // 
            this.btnCommit.Image = global::InvoicingApp.Properties.Resources.Save;
            this.btnCommit.Location = new System.Drawing.Point(815, 91);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(75, 23);
            this.btnCommit.TabIndex = 11;
            this.btnCommit.Text = "保存(&S)";
            this.btnCommit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::InvoicingApp.Properties.Resources.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(896, 91);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
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
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "增加(&A)";
            this.btnInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtMaintain_application
            // 
            this.txtMaintain_application.Location = new System.Drawing.Point(796, 50);
            this.txtMaintain_application.MaxLength = 25;
            this.txtMaintain_application.Name = "txtMaintain_application";
            this.txtMaintain_application.Size = new System.Drawing.Size(150, 21);
            this.txtMaintain_application.TabIndex = 7;
            // 
            // dateMaintain_create_date
            // 
            this.dateMaintain_create_date.CustomFormat = "yyyy-MM-dd";
            this.dateMaintain_create_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateMaintain_create_date.Location = new System.Drawing.Point(88, 50);
            this.dateMaintain_create_date.Name = "dateMaintain_create_date";
            this.dateMaintain_create_date.Size = new System.Drawing.Size(150, 21);
            this.dateMaintain_create_date.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(746, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "用途:";
            // 
            // txtMaintain_quality
            // 
            this.txtMaintain_quality.Location = new System.Drawing.Point(576, 50);
            this.txtMaintain_quality.MaxLength = 25;
            this.txtMaintain_quality.Name = "txtMaintain_quality";
            this.txtMaintain_quality.Size = new System.Drawing.Size(150, 21);
            this.txtMaintain_quality.TabIndex = 6;
            // 
            // txtMaintain_characters
            // 
            this.txtMaintain_characters.Location = new System.Drawing.Point(796, 20);
            this.txtMaintain_characters.MaxLength = 25;
            this.txtMaintain_characters.Name = "txtMaintain_characters";
            this.txtMaintain_characters.Size = new System.Drawing.Size(150, 21);
            this.txtMaintain_characters.TabIndex = 3;
            // 
            // txtMaintain_test_items
            // 
            this.txtMaintain_test_items.Location = new System.Drawing.Point(332, 50);
            this.txtMaintain_test_items.MaxLength = 25;
            this.txtMaintain_test_items.Name = "txtMaintain_test_items";
            this.txtMaintain_test_items.Size = new System.Drawing.Size(150, 21);
            this.txtMaintain_test_items.TabIndex = 5;
            // 
            // txtMaintain_purpose
            // 
            this.txtMaintain_purpose.Location = new System.Drawing.Point(576, 20);
            this.txtMaintain_purpose.MaxLength = 25;
            this.txtMaintain_purpose.Name = "txtMaintain_purpose";
            this.txtMaintain_purpose.Size = new System.Drawing.Size(150, 21);
            this.txtMaintain_purpose.TabIndex = 2;
            // 
            // txtMaintain_input_code
            // 
            this.txtMaintain_input_code.Location = new System.Drawing.Point(88, 20);
            this.txtMaintain_input_code.MaxLength = 25;
            this.txtMaintain_input_code.Name = "txtMaintain_input_code";
            this.txtMaintain_input_code.Size = new System.Drawing.Size(150, 21);
            this.txtMaintain_input_code.TabIndex = 0;
            this.txtMaintain_input_code.DoubleClick += new System.EventHandler(this.txtMaintain_input_code_DoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(258, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "检验项目:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(502, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 17;
            this.label9.Text = "质量标准:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 14;
            this.label10.Text = "建档日期:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(746, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 12);
            this.label12.TabIndex = 17;
            this.label12.Text = "性状:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(502, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 12);
            this.label13.TabIndex = 15;
            this.label13.Text = "建档目的:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 12);
            this.label14.TabIndex = 13;
            this.label14.Text = "入库编号:";
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
            // maintain_code
            // 
            this.maintain_code.DataPropertyName = "maintain_code";
            this.maintain_code.HeaderText = "养护编号";
            this.maintain_code.Name = "maintain_code";
            this.maintain_code.ReadOnly = true;
            this.maintain_code.Width = 130;
            // 
            // maintain_input_code
            // 
            this.maintain_input_code.DataPropertyName = "maintain_input_code";
            this.maintain_input_code.HeaderText = "入库编号";
            this.maintain_input_code.Name = "maintain_input_code";
            this.maintain_input_code.ReadOnly = true;
            this.maintain_input_code.Width = 130;
            // 
            // goods_name
            // 
            this.goods_name.DataPropertyName = "goods_name";
            this.goods_name.HeaderText = "产品名称";
            this.goods_name.Name = "goods_name";
            this.goods_name.ReadOnly = true;
            // 
            // input_batch_num
            // 
            this.input_batch_num.DataPropertyName = "input_batch_num";
            this.input_batch_num.HeaderText = "批号/设备号";
            this.input_batch_num.Name = "input_batch_num";
            this.input_batch_num.ReadOnly = true;
            // 
            // maintain_create_date
            // 
            this.maintain_create_date.DataPropertyName = "maintain_create_date";
            this.maintain_create_date.HeaderText = "建档日期";
            this.maintain_create_date.Name = "maintain_create_date";
            this.maintain_create_date.ReadOnly = true;
            // 
            // goods_validity
            // 
            this.goods_validity.DataPropertyName = "goods_validity";
            this.goods_validity.HeaderText = "有效期(月)";
            this.goods_validity.Name = "goods_validity";
            this.goods_validity.ReadOnly = true;
            // 
            // goods_type
            // 
            this.goods_type.DataPropertyName = "goods_type";
            this.goods_type.HeaderText = "规格型号";
            this.goods_type.Name = "goods_type";
            this.goods_type.ReadOnly = true;
            // 
            // goods_reg_num
            // 
            this.goods_reg_num.DataPropertyName = "goods_reg_num";
            this.goods_reg_num.HeaderText = "注册证号";
            this.goods_reg_num.Name = "goods_reg_num";
            this.goods_reg_num.ReadOnly = true;
            // 
            // maker_name
            // 
            this.maker_name.DataPropertyName = "maker_name";
            this.maker_name.HeaderText = "生产厂家";
            this.maker_name.Name = "maker_name";
            this.maker_name.ReadOnly = true;
            // 
            // maker_postal_code
            // 
            this.maker_postal_code.DataPropertyName = "maker_postal_code";
            this.maker_postal_code.HeaderText = "生产厂家邮编";
            this.maker_postal_code.Name = "maker_postal_code";
            this.maker_postal_code.ReadOnly = true;
            // 
            // maker_address
            // 
            this.maker_address.DataPropertyName = "maker_address";
            this.maker_address.HeaderText = "生产厂家地址";
            this.maker_address.Name = "maker_address";
            this.maker_address.ReadOnly = true;
            // 
            // maker_tel
            // 
            this.maker_tel.DataPropertyName = "maker_tel";
            this.maker_tel.HeaderText = "生产厂家电话";
            this.maker_tel.Name = "maker_tel";
            this.maker_tel.ReadOnly = true;
            // 
            // maintain_application
            // 
            this.maintain_application.DataPropertyName = "maintain_application";
            this.maintain_application.HeaderText = "用途";
            this.maintain_application.Name = "maintain_application";
            this.maintain_application.ReadOnly = true;
            // 
            // maintain_purpose
            // 
            this.maintain_purpose.DataPropertyName = "maintain_purpose";
            this.maintain_purpose.HeaderText = "建档目的";
            this.maintain_purpose.Name = "maintain_purpose";
            this.maintain_purpose.ReadOnly = true;
            // 
            // maintain_quality
            // 
            this.maintain_quality.DataPropertyName = "maintain_quality";
            this.maintain_quality.HeaderText = "质量标准";
            this.maintain_quality.Name = "maintain_quality";
            this.maintain_quality.ReadOnly = true;
            // 
            // maintain_test_items
            // 
            this.maintain_test_items.DataPropertyName = "maintain_test_items";
            this.maintain_test_items.HeaderText = "检验项目";
            this.maintain_test_items.Name = "maintain_test_items";
            this.maintain_test_items.ReadOnly = true;
            // 
            // maintain_characters
            // 
            this.maintain_characters.DataPropertyName = "maintain_characters";
            this.maintain_characters.HeaderText = "性状";
            this.maintain_characters.Name = "maintain_characters";
            this.maintain_characters.ReadOnly = true;
            // 
            // goods_storemethod
            // 
            this.goods_storemethod.DataPropertyName = "goods_storemethod";
            this.goods_storemethod.HeaderText = "储藏要求";
            this.goods_storemethod.Name = "goods_storemethod";
            this.goods_storemethod.ReadOnly = true;
            // 
            // input_packing_in
            // 
            this.input_packing_in.DataPropertyName = "input_packing_in";
            this.input_packing_in.HeaderText = "包装情况(内)";
            this.input_packing_in.Name = "input_packing_in";
            this.input_packing_in.ReadOnly = true;
            // 
            // input_packing_mid
            // 
            this.input_packing_mid.DataPropertyName = "input_packing_mid";
            this.input_packing_mid.HeaderText = "包装情况(中)";
            this.input_packing_mid.Name = "input_packing_mid";
            this.input_packing_mid.ReadOnly = true;
            // 
            // input_packing_out
            // 
            this.input_packing_out.DataPropertyName = "input_packing_out";
            this.input_packing_out.HeaderText = "包装情况(外)";
            this.input_packing_out.Name = "input_packing_out";
            this.input_packing_out.ReadOnly = true;
            // 
            // goods_yxm
            // 
            this.goods_yxm.DataPropertyName = "goods_yxm";
            this.goods_yxm.HeaderText = "音序码";
            this.goods_yxm.Name = "goods_yxm";
            this.goods_yxm.ReadOnly = true;
            this.goods_yxm.Visible = false;
            // 
            // MaintenanceManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1016, 702);
            this.Controls.Add(this.panel2);
            this.Name = "MaintenanceManagementForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "养护管理";
            this.Load += new System.EventHandler(this.MaintenanceManagementForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtMaintain_codeSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMaintain_quality;
        private System.Windows.Forms.TextBox txtMaintain_characters;
        private System.Windows.Forms.TextBox txtMaintain_test_items;
        private System.Windows.Forms.TextBox txtMaintain_purpose;
        private System.Windows.Forms.TextBox txtMaintain_input_code;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtGoods_nameSelect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGoods_yxmSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateMaintain_create_date;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMaintain_application;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtGoods_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintain_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintain_input_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn input_batch_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintain_create_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_validity;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_reg_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn maker_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn maker_postal_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn maker_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn maker_tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintain_application;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintain_purpose;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintain_quality;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintain_test_items;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintain_characters;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_storemethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn input_packing_in;
        private System.Windows.Forms.DataGridViewTextBoxColumn input_packing_mid;
        private System.Windows.Forms.DataGridViewTextBoxColumn input_packing_out;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_yxm;
    }
}