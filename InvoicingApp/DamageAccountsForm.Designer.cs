namespace InvoicingApp
{
    partial class DamageAccountsForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.txt_input_code_Select = new System.Windows.Forms.TextBox();
            this.txt_goods_name_Select = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCommit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nud_lose_count = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_input_code = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_lose_remark = new System.Windows.Forms.TextBox();
            this.txt_lose_result = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_lose_reason = new System.Windows.Forms.TextBox();
            this.dtp_lose_datetime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_lose_checker = new System.Windows.Forms.TextBox();
            this.txt_lose_applier = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_goods_name = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvLose = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input_goods_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maker_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input_maketime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_reg_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lose_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input_batch_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_validity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsValidate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lose_applier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lose_checker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lose_result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lose_datetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lose_reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lose_remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lose_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_lose_count)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 60);
            this.panel1.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.txt_input_code_Select);
            this.groupBox1.Controls.Add(this.txt_goods_name_Select);
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(994, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "报损下账查询";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "入库编号:";
            // 
            // btnReset
            // 
            this.btnReset.Image = global::InvoicingApp.Properties.Resources.Reset;
            this.btnReset.Location = new System.Drawing.Point(896, 19);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "重置(&R)";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txt_input_code_Select
            // 
            this.txt_input_code_Select.Location = new System.Drawing.Point(88, 20);
            this.txt_input_code_Select.Name = "txt_input_code_Select";
            this.txt_input_code_Select.Size = new System.Drawing.Size(155, 21);
            this.txt_input_code_Select.TabIndex = 1;
            // 
            // txt_goods_name_Select
            // 
            this.txt_goods_name_Select.Location = new System.Drawing.Point(339, 20);
            this.txt_goods_name_Select.Name = "txt_goods_name_Select";
            this.txt_goods_name_Select.Size = new System.Drawing.Size(140, 21);
            this.txt_goods_name_Select.TabIndex = 2;
            // 
            // btnFind
            // 
            this.btnFind.Image = global::InvoicingApp.Properties.Resources.Search;
            this.btnFind.Location = new System.Drawing.Point(815, 19);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "查询(&Q)";
            this.btnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(265, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "产品名称:";
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::InvoicingApp.Properties.Resources.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(896, 121);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCommit
            // 
            this.btnCommit.Image = global::InvoicingApp.Properties.Resources.Save;
            this.btnCommit.Location = new System.Drawing.Point(815, 121);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(75, 23);
            this.btnCommit.TabIndex = 12;
            this.btnCommit.Text = "保存(&S)";
            this.btnCommit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::InvoicingApp.Properties.Resources.Delete;
            this.btnDelete.Location = new System.Drawing.Point(97, 121);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "作废(&D)";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::InvoicingApp.Properties.Resources.Add;
            this.btnAdd.Location = new System.Drawing.Point(16, 121);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "增加(&A)";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(10, 526);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel2.Size = new System.Drawing.Size(994, 166);
            this.panel2.TabIndex = 28;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nud_lose_count);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnCommit);
            this.groupBox2.Controls.Add(this.txt_input_code);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.txt_lose_remark);
            this.groupBox2.Controls.Add(this.txt_lose_result);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txt_lose_reason);
            this.groupBox2.Controls.Add(this.dtp_lose_datetime);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_lose_checker);
            this.groupBox2.Controls.Add(this.txt_lose_applier);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txt_goods_name);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(994, 156);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "报损下账信息维护";
            // 
            // nud_lose_count
            // 
            this.nud_lose_count.Enabled = false;
            this.nud_lose_count.Location = new System.Drawing.Point(582, 20);
            this.nud_lose_count.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nud_lose_count.Name = "nud_lose_count";
            this.nud_lose_count.Size = new System.Drawing.Size(133, 21);
            this.nud_lose_count.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(951, 24);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(11, 12);
            this.label18.TabIndex = 36;
            this.label18.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(715, 54);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(11, 12);
            this.label15.TabIndex = 35;
            this.label15.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(715, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(11, 12);
            this.label14.TabIndex = 34;
            this.label14.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(486, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 33;
            this.label7.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(486, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 32;
            this.label5.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(235, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 31;
            this.label1.Text = "*";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(235, 24);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(11, 12);
            this.label17.TabIndex = 30;
            this.label17.Text = "*";
            // 
            // txt_input_code
            // 
            this.txt_input_code.Location = new System.Drawing.Point(100, 20);
            this.txt_input_code.MaxLength = 200;
            this.txt_input_code.Name = "txt_input_code";
            this.txt_input_code.ReadOnly = true;
            this.txt_input_code.Size = new System.Drawing.Size(135, 21);
            this.txt_input_code.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txt_input_code, "双击此处选择一个入库编号");
            this.txt_input_code.DoubleClick += new System.EventHandler(this.textBox_DoubleClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(508, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 12);
            this.label13.TabIndex = 16;
            this.label13.Text = "备注:";
            // 
            // txt_lose_remark
            // 
            this.txt_lose_remark.Location = new System.Drawing.Point(582, 80);
            this.txt_lose_remark.MaxLength = 100;
            this.txt_lose_remark.Name = "txt_lose_remark";
            this.txt_lose_remark.Size = new System.Drawing.Size(369, 21);
            this.txt_lose_remark.TabIndex = 9;
            // 
            // txt_lose_result
            // 
            this.txt_lose_result.Location = new System.Drawing.Point(582, 50);
            this.txt_lose_result.MaxLength = 100;
            this.txt_lose_result.Name = "txt_lose_result";
            this.txt_lose_result.ReadOnly = true;
            this.txt_lose_result.Size = new System.Drawing.Size(133, 21);
            this.txt_lose_result.TabIndex = 7;
            this.txt_lose_result.Text = "销毁";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "入库编号:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 12);
            this.label11.TabIndex = 14;
            this.label11.Text = "报损原因:";
            // 
            // txt_lose_reason
            // 
            this.txt_lose_reason.Location = new System.Drawing.Point(100, 80);
            this.txt_lose_reason.MaxLength = 100;
            this.txt_lose_reason.Name = "txt_lose_reason";
            this.txt_lose_reason.Size = new System.Drawing.Size(386, 21);
            this.txt_lose_reason.TabIndex = 8;
            // 
            // dtp_lose_datetime
            // 
            this.dtp_lose_datetime.CustomFormat = "yyyy-MM-dd";
            this.dtp_lose_datetime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_lose_datetime.Location = new System.Drawing.Point(811, 20);
            this.dtp_lose_datetime.Name = "dtp_lose_datetime";
            this.dtp_lose_datetime.Size = new System.Drawing.Size(140, 21);
            this.dtp_lose_datetime.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "产品名称:";
            // 
            // txt_lose_checker
            // 
            this.txt_lose_checker.Location = new System.Drawing.Point(343, 50);
            this.txt_lose_checker.MaxLength = 100;
            this.txt_lose_checker.Name = "txt_lose_checker";
            this.txt_lose_checker.ReadOnly = true;
            this.txt_lose_checker.Size = new System.Drawing.Size(143, 21);
            this.txt_lose_checker.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txt_lose_checker, "双击此处选择一名报损核准人");
            this.txt_lose_checker.DoubleClick += new System.EventHandler(this.textBox_DoubleClick);
            // 
            // txt_lose_applier
            // 
            this.txt_lose_applier.Location = new System.Drawing.Point(100, 50);
            this.txt_lose_applier.MaxLength = 100;
            this.txt_lose_applier.Name = "txt_lose_applier";
            this.txt_lose_applier.ReadOnly = true;
            this.txt_lose_applier.Size = new System.Drawing.Size(135, 21);
            this.txt_lose_applier.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txt_lose_applier, "双击此处选择一名报损申请人");
            this.txt_lose_applier.DoubleClick += new System.EventHandler(this.textBox_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "处理结果:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(257, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 12);
            this.label10.TabIndex = 10;
            this.label10.Text = "报损核准人:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 12);
            this.label12.TabIndex = 8;
            this.label12.Text = "报损申请人:";
            // 
            // txt_goods_name
            // 
            this.txt_goods_name.Location = new System.Drawing.Point(343, 20);
            this.txt_goods_name.Name = "txt_goods_name";
            this.txt_goods_name.ReadOnly = true;
            this.txt_goods_name.Size = new System.Drawing.Size(143, 21);
            this.txt_goods_name.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(508, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 12);
            this.label16.TabIndex = 4;
            this.label16.Text = "报损数量:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(737, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 6;
            this.label9.Text = "报损日期:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvLose);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(10, 70);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel3.Size = new System.Drawing.Size(994, 456);
            this.panel3.TabIndex = 29;
            // 
            // dgvLose
            // 
            this.dgvLose.AllowUserToAddRows = false;
            this.dgvLose.AllowUserToDeleteRows = false;
            this.dgvLose.AllowUserToResizeRows = false;
            this.dgvLose.BackgroundColor = System.Drawing.Color.White;
            this.dgvLose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLose.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLose.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.input_code,
            this.goods_name,
            this.input_goods_code,
            this.maker_name,
            this.input_maketime,
            this.goods_reg_num,
            this.lose_count,
            this.goods_unit,
            this.goods_type,
            this.input_batch_num,
            this.goods_validity,
            this.goodsValidate,
            this.lose_applier,
            this.lose_checker,
            this.lose_result,
            this.lose_datetime,
            this.lose_reason,
            this.lose_remark,
            this.lose_code});
            this.dgvLose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLose.Location = new System.Drawing.Point(0, 10);
            this.dgvLose.MultiSelect = false;
            this.dgvLose.Name = "dgvLose";
            this.dgvLose.RowHeadersVisible = false;
            this.dgvLose.RowTemplate.Height = 23;
            this.dgvLose.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLose.Size = new System.Drawing.Size(994, 446);
            this.dgvLose.StandardTab = true;
            this.dgvLose.TabIndex = 1;
            this.dgvLose.Sorted += new System.EventHandler(this.dgvLose_Sorted);
            this.dgvLose.SelectionChanged += new System.EventHandler(this.dgvLose_SelectionChanged);
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
            // input_code
            // 
            this.input_code.DataPropertyName = "input_code";
            this.input_code.HeaderText = "入库编号";
            this.input_code.Name = "input_code";
            this.input_code.ReadOnly = true;
            this.input_code.Width = 130;
            // 
            // goods_name
            // 
            this.goods_name.DataPropertyName = "goods_name";
            this.goods_name.HeaderText = "产品名称";
            this.goods_name.Name = "goods_name";
            this.goods_name.ReadOnly = true;
            this.goods_name.Width = 80;
            // 
            // input_goods_code
            // 
            this.input_goods_code.DataPropertyName = "input_goods_code";
            this.input_goods_code.HeaderText = "产品编号";
            this.input_goods_code.Name = "input_goods_code";
            this.input_goods_code.ReadOnly = true;
            this.input_goods_code.Visible = false;
            this.input_goods_code.Width = 130;
            // 
            // maker_name
            // 
            this.maker_name.DataPropertyName = "maker_name";
            this.maker_name.HeaderText = "生产厂家";
            this.maker_name.Name = "maker_name";
            this.maker_name.ReadOnly = true;
            // 
            // input_maketime
            // 
            this.input_maketime.DataPropertyName = "input_maketime";
            this.input_maketime.HeaderText = "生产日期";
            this.input_maketime.Name = "input_maketime";
            this.input_maketime.ReadOnly = true;
            // 
            // goods_reg_num
            // 
            this.goods_reg_num.DataPropertyName = "goods_reg_num";
            this.goods_reg_num.HeaderText = "产品注册证号";
            this.goods_reg_num.Name = "goods_reg_num";
            this.goods_reg_num.ReadOnly = true;
            // 
            // lose_count
            // 
            this.lose_count.DataPropertyName = "lose_count";
            this.lose_count.HeaderText = "报损数量";
            this.lose_count.Name = "lose_count";
            this.lose_count.ReadOnly = true;
            // 
            // goods_unit
            // 
            this.goods_unit.DataPropertyName = "goods_unit";
            this.goods_unit.HeaderText = "计量单位";
            this.goods_unit.Name = "goods_unit";
            this.goods_unit.ReadOnly = true;
            // 
            // goods_type
            // 
            this.goods_type.DataPropertyName = "goods_type";
            this.goods_type.HeaderText = "规格型号";
            this.goods_type.Name = "goods_type";
            this.goods_type.ReadOnly = true;
            // 
            // input_batch_num
            // 
            this.input_batch_num.DataPropertyName = "input_batch_num";
            this.input_batch_num.HeaderText = "批号/设备号";
            this.input_batch_num.Name = "input_batch_num";
            this.input_batch_num.ReadOnly = true;
            // 
            // goods_validity
            // 
            this.goods_validity.DataPropertyName = "goods_validity";
            this.goods_validity.HeaderText = "有效期(月)";
            this.goods_validity.Name = "goods_validity";
            this.goods_validity.ReadOnly = true;
            this.goods_validity.Visible = false;
            // 
            // goodsValidate
            // 
            this.goodsValidate.DataPropertyName = "goodsValidate";
            this.goodsValidate.HeaderText = "有效期至";
            this.goodsValidate.Name = "goodsValidate";
            this.goodsValidate.ReadOnly = true;
            // 
            // lose_applier
            // 
            this.lose_applier.DataPropertyName = "lose_applier";
            this.lose_applier.HeaderText = "报损申请人";
            this.lose_applier.Name = "lose_applier";
            this.lose_applier.ReadOnly = true;
            // 
            // lose_checker
            // 
            this.lose_checker.DataPropertyName = "lose_checker";
            this.lose_checker.HeaderText = "报损核准人";
            this.lose_checker.Name = "lose_checker";
            this.lose_checker.ReadOnly = true;
            // 
            // lose_result
            // 
            this.lose_result.DataPropertyName = "lose_result";
            this.lose_result.HeaderText = "处理结果";
            this.lose_result.Name = "lose_result";
            this.lose_result.ReadOnly = true;
            // 
            // lose_datetime
            // 
            this.lose_datetime.DataPropertyName = "lose_datetime";
            this.lose_datetime.HeaderText = "报损日期";
            this.lose_datetime.Name = "lose_datetime";
            this.lose_datetime.ReadOnly = true;
            // 
            // lose_reason
            // 
            this.lose_reason.DataPropertyName = "lose_reason";
            this.lose_reason.HeaderText = "报损原因";
            this.lose_reason.Name = "lose_reason";
            this.lose_reason.ReadOnly = true;
            // 
            // lose_remark
            // 
            this.lose_remark.DataPropertyName = "lose_remark";
            this.lose_remark.HeaderText = "备注";
            this.lose_remark.Name = "lose_remark";
            this.lose_remark.ReadOnly = true;
            // 
            // lose_code
            // 
            this.lose_code.DataPropertyName = "lose_code";
            this.lose_code.HeaderText = "报损编号";
            this.lose_code.Name = "lose_code";
            this.lose_code.ReadOnly = true;
            this.lose_code.Width = 130;
            // 
            // DamageAccountsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1014, 702);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DamageAccountsForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "报损下账";
            this.Load += new System.EventHandler(this.DamageAccountsForm_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_lose_count)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_lose_remark;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_lose_applier;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_lose_checker;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_lose_reason;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_input_code;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_goods_name_Select;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_input_code_Select;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_lose_datetime;
        private System.Windows.Forms.TextBox txt_lose_result;
        private System.Windows.Forms.TextBox txt_goods_name;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvLose;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_lose_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn input_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn input_goods_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn maker_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn input_maketime;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_reg_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn lose_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn input_batch_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_validity;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsValidate;
        private System.Windows.Forms.DataGridViewTextBoxColumn lose_applier;
        private System.Windows.Forms.DataGridViewTextBoxColumn lose_checker;
        private System.Windows.Forms.DataGridViewTextBoxColumn lose_result;
        private System.Windows.Forms.DataGridViewTextBoxColumn lose_datetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn lose_reason;
        private System.Windows.Forms.DataGridViewTextBoxColumn lose_remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn lose_code;
    }
}