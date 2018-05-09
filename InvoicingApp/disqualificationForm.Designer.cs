namespace InvoicingApp
{
    partial class disqualificationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(disqualificationForm));
            this.dataGridView_Disqualification = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_reg_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input_batch_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maker_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disqualification_to_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disqualification_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input_instorage_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deal_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reamark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issued = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deal_oper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deal_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.undeal_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disqualification_to_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.labelRed2 = new System.Windows.Forms.Label();
            this.labelRed1 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelMAX1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelAddress = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCommit = new System.Windows.Forms.Button();
            this.textBox_deal_oper = new System.Windows.Forms.TextBox();
            this.textBox_disqualification_to_count = new System.Windows.Forms.NumericUpDown();
            this.labelOper = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_deal_type = new System.Windows.Forms.TextBox();
            this.textBox_reamark = new System.Windows.Forms.TextBox();
            this.textBox_deal_address = new System.Windows.Forms.TextBox();
            this.textBox_issued = new System.Windows.Forms.TextBox();
            this.btnMend = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDestory = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Disqualification)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_disqualification_to_count)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Disqualification
            // 
            this.dataGridView_Disqualification.AllowUserToAddRows = false;
            this.dataGridView_Disqualification.AllowUserToDeleteRows = false;
            this.dataGridView_Disqualification.AllowUserToResizeRows = false;
            this.dataGridView_Disqualification.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Disqualification.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_Disqualification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_Disqualification.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.goods_name,
            this.goods_reg_num,
            this.input_batch_num,
            this.maker_name,
            this.disqualification_to_count,
            this.disqualification_type,
            this.input_instorage_date,
            this.deal_date,
            this.reamark,
            this.issued,
            this.deal_oper,
            this.deal_address,
            this.undeal_count,
            this.disqualification_to_code});
            this.dataGridView_Disqualification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Disqualification.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Disqualification.MultiSelect = false;
            this.dataGridView_Disqualification.Name = "dataGridView_Disqualification";
            this.dataGridView_Disqualification.ReadOnly = true;
            this.dataGridView_Disqualification.RowHeadersVisible = false;
            this.dataGridView_Disqualification.RowTemplate.Height = 23;
            this.dataGridView_Disqualification.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Disqualification.Size = new System.Drawing.Size(996, 517);
            this.dataGridView_Disqualification.StandardTab = true;
            this.dataGridView_Disqualification.TabIndex = 0;
            this.dataGridView_Disqualification.Sorted += new System.EventHandler(this.dataGridView_Disqualification_Sorted);
            this.dataGridView_Disqualification.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_Disqualification_DataBindingComplete);
            this.dataGridView_Disqualification.SelectionChanged += new System.EventHandler(this.dataGridView_Disqualification_SelectionChanged);
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
            // goods_name
            // 
            this.goods_name.DataPropertyName = "goods_name";
            this.goods_name.HeaderText = "产品名称";
            this.goods_name.Name = "goods_name";
            this.goods_name.ReadOnly = true;
            // 
            // goods_reg_num
            // 
            this.goods_reg_num.DataPropertyName = "goods_reg_num";
            this.goods_reg_num.HeaderText = "注册证号";
            this.goods_reg_num.Name = "goods_reg_num";
            this.goods_reg_num.ReadOnly = true;
            // 
            // input_batch_num
            // 
            this.input_batch_num.DataPropertyName = "input_batch_num";
            this.input_batch_num.HeaderText = "批号/设备号";
            this.input_batch_num.Name = "input_batch_num";
            this.input_batch_num.ReadOnly = true;
            // 
            // maker_name
            // 
            this.maker_name.DataPropertyName = "maker_name";
            this.maker_name.HeaderText = "生产厂家";
            this.maker_name.Name = "maker_name";
            this.maker_name.ReadOnly = true;
            this.maker_name.Width = 136;
            // 
            // disqualification_to_count
            // 
            this.disqualification_to_count.DataPropertyName = "disqualification_to_count";
            this.disqualification_to_count.HeaderText = "处理数量";
            this.disqualification_to_count.Name = "disqualification_to_count";
            this.disqualification_to_count.ReadOnly = true;
            // 
            // disqualification_type
            // 
            this.disqualification_type.DataPropertyName = "disqualification_type";
            this.disqualification_type.HeaderText = "处理方式";
            this.disqualification_type.Name = "disqualification_type";
            this.disqualification_type.ReadOnly = true;
            // 
            // input_instorage_date
            // 
            this.input_instorage_date.DataPropertyName = "input_instorage_date";
            this.input_instorage_date.HeaderText = "入库日期";
            this.input_instorage_date.Name = "input_instorage_date";
            this.input_instorage_date.ReadOnly = true;
            // 
            // deal_date
            // 
            this.deal_date.DataPropertyName = "deal_date";
            this.deal_date.HeaderText = "处理日期";
            this.deal_date.Name = "deal_date";
            this.deal_date.ReadOnly = true;
            // 
            // reamark
            // 
            this.reamark.DataPropertyName = "reamark";
            this.reamark.HeaderText = "备注";
            this.reamark.Name = "reamark";
            this.reamark.ReadOnly = true;
            // 
            // issued
            // 
            this.issued.DataPropertyName = "issued";
            this.issued.HeaderText = "经办人";
            this.issued.Name = "issued";
            this.issued.ReadOnly = true;
            this.issued.Visible = false;
            // 
            // deal_oper
            // 
            this.deal_oper.DataPropertyName = "deal_oper";
            this.deal_oper.HeaderText = "销毁见证人";
            this.deal_oper.Name = "deal_oper";
            this.deal_oper.ReadOnly = true;
            this.deal_oper.Visible = false;
            // 
            // deal_address
            // 
            this.deal_address.DataPropertyName = "deal_address";
            this.deal_address.HeaderText = "处理地点";
            this.deal_address.Name = "deal_address";
            this.deal_address.ReadOnly = true;
            this.deal_address.Visible = false;
            // 
            // undeal_count
            // 
            this.undeal_count.DataPropertyName = "undeal_count";
            this.undeal_count.HeaderText = "未处理数量";
            this.undeal_count.Name = "undeal_count";
            this.undeal_count.ReadOnly = true;
            this.undeal_count.Visible = false;
            // 
            // disqualification_to_code
            // 
            this.disqualification_to_code.DataPropertyName = "disqualification_to_code";
            this.disqualification_to_code.HeaderText = "记录序号";
            this.disqualification_to_code.Name = "disqualification_to_code";
            this.disqualification_to_code.ReadOnly = true;
            this.disqualification_to_code.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView_Disqualification);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(996, 517);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(10, 527);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel2.Size = new System.Drawing.Size(996, 167);
            this.panel2.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.labelRed2);
            this.groupBox2.Controls.Add(this.labelRed1);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.labelMax);
            this.groupBox2.Controls.Add(this.labelMAX1);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.labelAddress);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnCommit);
            this.groupBox2.Controls.Add(this.textBox_deal_oper);
            this.groupBox2.Controls.Add(this.textBox_disqualification_to_count);
            this.groupBox2.Controls.Add(this.labelOper);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox_deal_type);
            this.groupBox2.Controls.Add(this.textBox_reamark);
            this.groupBox2.Controls.Add(this.textBox_deal_address);
            this.groupBox2.Controls.Add(this.textBox_issued);
            this.groupBox2.Controls.Add(this.btnMend);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnDestory);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnBack);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(996, 157);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "不合格产品去向记录信息维护";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(960, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 12);
            this.label12.TabIndex = 115;
            this.label12.Text = "*";
            // 
            // labelRed2
            // 
            this.labelRed2.AutoSize = true;
            this.labelRed2.ForeColor = System.Drawing.Color.Red;
            this.labelRed2.Location = new System.Drawing.Point(767, 84);
            this.labelRed2.Name = "labelRed2";
            this.labelRed2.Size = new System.Drawing.Size(11, 12);
            this.labelRed2.TabIndex = 114;
            this.labelRed2.Text = "*";
            // 
            // labelRed1
            // 
            this.labelRed1.AutoSize = true;
            this.labelRed1.ForeColor = System.Drawing.Color.Red;
            this.labelRed1.Location = new System.Drawing.Point(551, 84);
            this.labelRed1.Name = "labelRed1";
            this.labelRed1.Size = new System.Drawing.Size(11, 12);
            this.labelRed1.TabIndex = 113;
            this.labelRed1.Text = "*";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.Red;
            this.label22.Location = new System.Drawing.Point(551, 24);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(11, 12);
            this.label22.TabIndex = 112;
            this.label22.Text = "*";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(302, 24);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(0, 12);
            this.labelMax.TabIndex = 21;
            this.labelMax.Visible = false;
            // 
            // labelMAX1
            // 
            this.labelMAX1.AutoSize = true;
            this.labelMAX1.Location = new System.Drawing.Point(208, 24);
            this.labelMAX1.Name = "labelMAX1";
            this.labelMAX1.Size = new System.Drawing.Size(95, 12);
            this.labelMAX1.TabIndex = 20;
            this.labelMAX1.Text = "可输入最大数量:";
            this.labelMAX1.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::InvoicingApp.Properties.Resources.Delete;
            this.btnDelete.Location = new System.Drawing.Point(386, 121);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "删除(&D)";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = global::InvoicingApp.Properties.Resources.Edit;
            this.btnUpdate.Location = new System.Drawing.Point(305, 121);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "修改(&M)";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "处理数量:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 12);
            this.label10.TabIndex = 16;
            this.label10.Text = "备注:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(647, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(120, 21);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(14, 84);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(59, 12);
            this.labelAddress.TabIndex = 13;
            this.labelAddress.Text = "处理地点:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(787, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 12);
            this.label9.TabIndex = 14;
            this.label9.Text = "经办人:";
            // 
            // btnCommit
            // 
            this.btnCommit.Image = global::InvoicingApp.Properties.Resources.Save;
            this.btnCommit.Location = new System.Drawing.Point(815, 121);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(75, 23);
            this.btnCommit.TabIndex = 10;
            this.btnCommit.Text = "保存(&S)";
            this.btnCommit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // textBox_deal_oper
            // 
            this.textBox_deal_oper.Location = new System.Drawing.Point(647, 80);
            this.textBox_deal_oper.MaxLength = 25;
            this.textBox_deal_oper.Name = "textBox_deal_oper";
            this.textBox_deal_oper.ReadOnly = true;
            this.textBox_deal_oper.Size = new System.Drawing.Size(120, 21);
            this.textBox_deal_oper.TabIndex = 6;
            this.textBox_deal_oper.Text = "双击选择一个见证人...";
            this.textBox_deal_oper.DoubleClick += new System.EventHandler(this.textBox_DoubleClick);
            // 
            // textBox_disqualification_to_count
            // 
            this.textBox_disqualification_to_count.Location = new System.Drawing.Point(88, 20);
            this.textBox_disqualification_to_count.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.textBox_disqualification_to_count.Name = "textBox_disqualification_to_count";
            this.textBox_disqualification_to_count.Size = new System.Drawing.Size(120, 21);
            this.textBox_disqualification_to_count.TabIndex = 0;
            this.textBox_disqualification_to_count.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_disqualification_to_count_KeyUp);
            // 
            // labelOper
            // 
            this.labelOper.AutoSize = true;
            this.labelOper.Location = new System.Drawing.Point(578, 84);
            this.labelOper.Name = "labelOper";
            this.labelOper.Size = new System.Drawing.Size(71, 12);
            this.labelOper.TabIndex = 17;
            this.labelOper.Text = "销毁见证人:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "处理方式:";
            // 
            // textBox_deal_type
            // 
            this.textBox_deal_type.Location = new System.Drawing.Point(415, 20);
            this.textBox_deal_type.MaxLength = 25;
            this.textBox_deal_type.Name = "textBox_deal_type";
            this.textBox_deal_type.ReadOnly = true;
            this.textBox_deal_type.Size = new System.Drawing.Size(136, 21);
            this.textBox_deal_type.TabIndex = 1;
            // 
            // textBox_reamark
            // 
            this.textBox_reamark.Location = new System.Drawing.Point(88, 50);
            this.textBox_reamark.MaxLength = 250;
            this.textBox_reamark.Name = "textBox_reamark";
            this.textBox_reamark.Size = new System.Drawing.Size(463, 21);
            this.textBox_reamark.TabIndex = 4;
            // 
            // textBox_deal_address
            // 
            this.textBox_deal_address.Location = new System.Drawing.Point(88, 80);
            this.textBox_deal_address.MaxLength = 50;
            this.textBox_deal_address.Name = "textBox_deal_address";
            this.textBox_deal_address.Size = new System.Drawing.Size(463, 21);
            this.textBox_deal_address.TabIndex = 5;
            // 
            // textBox_issued
            // 
            this.textBox_issued.Location = new System.Drawing.Point(849, 20);
            this.textBox_issued.MaxLength = 25;
            this.textBox_issued.Name = "textBox_issued";
            this.textBox_issued.ReadOnly = true;
            this.textBox_issued.Size = new System.Drawing.Size(111, 21);
            this.textBox_issued.TabIndex = 3;
            this.textBox_issued.Text = "双击选择一个经办人...";
            this.textBox_issued.DoubleClick += new System.EventHandler(this.textBox_DoubleClick);
            // 
            // btnMend
            // 
            this.btnMend.Image = global::InvoicingApp.Properties.Resources.Add;
            this.btnMend.Location = new System.Drawing.Point(208, 121);
            this.btnMend.Name = "btnMend";
            this.btnMend.Size = new System.Drawing.Size(91, 23);
            this.btnMend.TabIndex = 9;
            this.btnMend.Text = "添加维修";
            this.btnMend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMend.UseVisualStyleBackColor = true;
            this.btnMend.Click += new System.EventHandler(this.btnMend_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(573, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "处理日期:";
            // 
            // btnDestory
            // 
            this.btnDestory.Image = global::InvoicingApp.Properties.Resources.Add;
            this.btnDestory.Location = new System.Drawing.Point(111, 121);
            this.btnDestory.Name = "btnDestory";
            this.btnDestory.Size = new System.Drawing.Size(91, 23);
            this.btnDestory.TabIndex = 8;
            this.btnDestory.Text = "添加销毁";
            this.btnDestory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDestory.UseVisualStyleBackColor = true;
            this.btnDestory.Click += new System.EventHandler(this.btnDestory_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::InvoicingApp.Properties.Resources.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(896, 121);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBack
            // 
            this.btnBack.Image = global::InvoicingApp.Properties.Resources.Add;
            this.btnBack.Location = new System.Drawing.Point(16, 121);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(91, 23);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "添加返厂";
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // disqualificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1016, 704);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1024, 736);
            this.MinimumSize = new System.Drawing.Size(1022, 736);
            this.Name = "disqualificationForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "不合格去向记录";
            this.Load += new System.EventHandler(this.disqualificationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Disqualification)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_disqualification_to_count)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Disqualification;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_reg_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn input_batch_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn maker_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn disqualification_to_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn disqualification_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn input_instorage_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn deal_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn reamark;
        private System.Windows.Forms.DataGridViewTextBoxColumn issued;
        private System.Windows.Forms.DataGridViewTextBoxColumn deal_oper;
        private System.Windows.Forms.DataGridViewTextBoxColumn deal_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn undeal_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn disqualification_to_code;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelRed2;
        private System.Windows.Forms.Label labelRed1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelMAX1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.TextBox textBox_deal_oper;
        private System.Windows.Forms.NumericUpDown textBox_disqualification_to_count;
        private System.Windows.Forms.Label labelOper;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_deal_type;
        private System.Windows.Forms.TextBox textBox_reamark;
        private System.Windows.Forms.TextBox textBox_deal_address;
        private System.Windows.Forms.TextBox textBox_issued;
        private System.Windows.Forms.Button btnMend;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDestory;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBack;


    }
}