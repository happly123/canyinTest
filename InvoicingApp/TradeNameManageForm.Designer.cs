namespace InvoicingApp
{
    partial class TradeNameManageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TradeNameManageForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtGoods_yxmSelect = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGoods_nameSelect = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCommit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtMaker_code = new System.Windows.Forms.TextBox();
            this.cb_goods_unit = new System.Windows.Forms.ComboBox();
            this.txtGoods_validity = new TCControl.TCTextBox();
            this.txtGoods_storemethod = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtGoods_type = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtGoods_reg_mark = new System.Windows.Forms.TextBox();
            this.txtGoods_yxm = new System.Windows.Forms.TextBox();
            this.txtGoods_reg_num = new System.Windows.Forms.TextBox();
            this.txtGoods_name = new System.Windows.Forms.TextBox();
            this.txtGoods_maker = new System.Windows.Forms.TextBox();
            this.txtGoods_appliance_code = new System.Windows.Forms.TextBox();
            this.txtGoods_code = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maker_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_validity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_storemethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_appliance_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_reg_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_reg_mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_yxm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_maker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maker_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 60);
            this.panel1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnSelect);
            this.groupBox2.Controls.Add(this.txtGoods_yxmSelect);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtGoods_nameSelect);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(804, 60);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "产品查询";
            // 
            // btnClear
            // 
            this.btnClear.Image = global::InvoicingApp.Properties.Resources.Reset;
            this.btnClear.Location = new System.Drawing.Point(688, 20);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "重置(&R)";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Image = global::InvoicingApp.Properties.Resources.Search;
            this.btnSelect.Location = new System.Drawing.Point(607, 20);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "查询(&Q)";
            this.btnSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtGoods_yxmSelect
            // 
            this.txtGoods_yxmSelect.Location = new System.Drawing.Point(322, 20);
            this.txtGoods_yxmSelect.MaxLength = 25;
            this.txtGoods_yxmSelect.Name = "txtGoods_yxmSelect";
            this.txtGoods_yxmSelect.Size = new System.Drawing.Size(140, 21);
            this.txtGoods_yxmSelect.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "音序码:";
            // 
            // txtGoods_nameSelect
            // 
            this.txtGoods_nameSelect.Location = new System.Drawing.Point(88, 20);
            this.txtGoods_nameSelect.MaxLength = 25;
            this.txtGoods_nameSelect.Name = "txtGoods_nameSelect";
            this.txtGoods_nameSelect.Size = new System.Drawing.Size(150, 21);
            this.txtGoods_nameSelect.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "产品名称:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(10, 412);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel2.Size = new System.Drawing.Size(804, 196);
            this.panel2.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnCommit);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.txtMaker_code);
            this.groupBox1.Controls.Add(this.cb_goods_unit);
            this.groupBox1.Controls.Add(this.txtGoods_validity);
            this.groupBox1.Controls.Add(this.txtGoods_storemethod);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txtGoods_type);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtGoods_reg_mark);
            this.groupBox1.Controls.Add(this.txtGoods_yxm);
            this.groupBox1.Controls.Add(this.txtGoods_reg_num);
            this.groupBox1.Controls.Add(this.txtGoods_name);
            this.groupBox1.Controls.Add(this.txtGoods_maker);
            this.groupBox1.Controls.Add(this.txtGoods_appliance_code);
            this.groupBox1.Controls.Add(this.txtGoods_code);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 186);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "产品信息维护";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(250, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 80;
            this.label5.Text = "*";
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::InvoicingApp.Properties.Resources.Delete;
            this.btnDelete.Location = new System.Drawing.Point(178, 151);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "删除(&D)";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(510, 114);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(11, 12);
            this.label20.TabIndex = 79;
            this.label20.Text = "*";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(763, 83);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(11, 12);
            this.label19.TabIndex = 78;
            this.label19.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(763, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(11, 12);
            this.label16.TabIndex = 77;
            this.label16.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(250, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(11, 12);
            this.label15.TabIndex = 76;
            this.label15.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(763, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 12);
            this.label12.TabIndex = 75;
            this.label12.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(510, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 12);
            this.label10.TabIndex = 74;
            this.label10.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(250, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 72;
            this.label3.Text = "*";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = global::InvoicingApp.Properties.Resources.Edit;
            this.btnUpdate.Location = new System.Drawing.Point(97, 151);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "修改(&M)";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCommit
            // 
            this.btnCommit.Image = global::InvoicingApp.Properties.Resources.Save;
            this.btnCommit.Location = new System.Drawing.Point(607, 151);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(75, 23);
            this.btnCommit.TabIndex = 13;
            this.btnCommit.Text = "保存(&S)";
            this.btnCommit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::InvoicingApp.Properties.Resources.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(688, 151);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Image = global::InvoicingApp.Properties.Resources.Add;
            this.btnInsert.Location = new System.Drawing.Point(16, 151);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "增加(&A)";
            this.btnInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtMaker_code
            // 
            this.txtMaker_code.Location = new System.Drawing.Point(728, 110);
            this.txtMaker_code.Name = "txtMaker_code";
            this.txtMaker_code.Size = new System.Drawing.Size(10, 21);
            this.txtMaker_code.TabIndex = 71;
            this.txtMaker_code.Visible = false;
            // 
            // cb_goods_unit
            // 
            this.cb_goods_unit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_goods_unit.Enabled = false;
            this.cb_goods_unit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb_goods_unit.FormattingEnabled = true;
            this.cb_goods_unit.Location = new System.Drawing.Point(606, 80);
            this.cb_goods_unit.Name = "cb_goods_unit";
            this.cb_goods_unit.Size = new System.Drawing.Size(157, 20);
            this.cb_goods_unit.TabIndex = 8;
            // 
            // txtGoods_validity
            // 
            this.txtGoods_validity.DateTimeFormate = TCControl.TCTextBox.FormatType.yyyyMMdd;
            this.txtGoods_validity.Encodeing = "GB2312";
            this.txtGoods_validity.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtGoods_validity.IsAllowMinus = false;
            this.txtGoods_validity.Location = new System.Drawing.Point(100, 80);
            this.txtGoods_validity.MatchValue = "^[0-9]*$";
            this.txtGoods_validity.MaxByteLength = 3;
            this.txtGoods_validity.MaxLength = 25;
            this.txtGoods_validity.Name = "txtGoods_validity";
            this.txtGoods_validity.PadLeftFirstIsZero = false;
            this.txtGoods_validity.Precision = 0;
            this.txtGoods_validity.Scale = 0;
            this.txtGoods_validity.Size = new System.Drawing.Size(150, 21);
            this.txtGoods_validity.TabIndex = 6;
            this.txtGoods_validity.TypeSet = TCControl.TCTextBox.Type.MatchDefine;
            this.txtGoods_validity.Value = "";
            // 
            // txtGoods_storemethod
            // 
            this.txtGoods_storemethod.Location = new System.Drawing.Point(99, 110);
            this.txtGoods_storemethod.MaxLength = 50;
            this.txtGoods_storemethod.Name = "txtGoods_storemethod";
            this.txtGoods_storemethod.Size = new System.Drawing.Size(411, 21);
            this.txtGoods_storemethod.TabIndex = 9;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(14, 114);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(59, 12);
            this.label23.TabIndex = 63;
            this.label23.Text = "储藏方法:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(532, 84);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 12);
            this.label18.TabIndex = 61;
            this.label18.Text = "计量单位:";
            // 
            // txtGoods_type
            // 
            this.txtGoods_type.Location = new System.Drawing.Point(606, 50);
            this.txtGoods_type.MaxLength = 25;
            this.txtGoods_type.Name = "txtGoods_type";
            this.txtGoods_type.Size = new System.Drawing.Size(157, 21);
            this.txtGoods_type.TabIndex = 5;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(532, 54);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 12);
            this.label17.TabIndex = 59;
            this.label17.Text = "规格型号:";
            // 
            // txtGoods_reg_mark
            // 
            this.txtGoods_reg_mark.Location = new System.Drawing.Point(353, 80);
            this.txtGoods_reg_mark.MaxLength = 25;
            this.txtGoods_reg_mark.Name = "txtGoods_reg_mark";
            this.txtGoods_reg_mark.Size = new System.Drawing.Size(157, 21);
            this.txtGoods_reg_mark.TabIndex = 7;
            // 
            // txtGoods_yxm
            // 
            this.txtGoods_yxm.Location = new System.Drawing.Point(353, 20);
            this.txtGoods_yxm.Name = "txtGoods_yxm";
            this.txtGoods_yxm.Size = new System.Drawing.Size(157, 21);
            this.txtGoods_yxm.TabIndex = 1;
            // 
            // txtGoods_reg_num
            // 
            this.txtGoods_reg_num.Location = new System.Drawing.Point(100, 50);
            this.txtGoods_reg_num.MaxLength = 25;
            this.txtGoods_reg_num.Name = "txtGoods_reg_num";
            this.txtGoods_reg_num.Size = new System.Drawing.Size(150, 21);
            this.txtGoods_reg_num.TabIndex = 3;
            // 
            // txtGoods_name
            // 
            this.txtGoods_name.Location = new System.Drawing.Point(100, 20);
            this.txtGoods_name.MaxLength = 25;
            this.txtGoods_name.Name = "txtGoods_name";
            this.txtGoods_name.Size = new System.Drawing.Size(150, 21);
            this.txtGoods_name.TabIndex = 0;
            this.txtGoods_name.TextChanged += new System.EventHandler(this.txtMaker_name_TextChanged);
            // 
            // txtGoods_maker
            // 
            this.txtGoods_maker.Location = new System.Drawing.Point(353, 50);
            this.txtGoods_maker.MaxLength = 25;
            this.txtGoods_maker.Name = "txtGoods_maker";
            this.txtGoods_maker.Size = new System.Drawing.Size(157, 21);
            this.txtGoods_maker.TabIndex = 4;
            this.txtGoods_maker.DoubleClick += new System.EventHandler(this.txtGoods_maker_DoubleClick);
            // 
            // txtGoods_appliance_code
            // 
            this.txtGoods_appliance_code.Location = new System.Drawing.Point(606, 20);
            this.txtGoods_appliance_code.Name = "txtGoods_appliance_code";
            this.txtGoods_appliance_code.Size = new System.Drawing.Size(157, 21);
            this.txtGoods_appliance_code.TabIndex = 2;
            this.txtGoods_appliance_code.DoubleClick += new System.EventHandler(this.txtGoods_appliance_code_DoubleClick);
            // 
            // txtGoods_code
            // 
            this.txtGoods_code.Location = new System.Drawing.Point(712, 110);
            this.txtGoods_code.Name = "txtGoods_code";
            this.txtGoods_code.Size = new System.Drawing.Size(10, 21);
            this.txtGoods_code.TabIndex = 22;
            this.txtGoods_code.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "产品名称:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(532, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "器械分类:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(272, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "音序码:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(272, 84);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 12);
            this.label14.TabIndex = 11;
            this.label14.Text = "注册商标:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 6;
            this.label9.Text = "注册证号:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 12);
            this.label13.TabIndex = 10;
            this.label13.Text = "有效期(月):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(272, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 12);
            this.label11.TabIndex = 8;
            this.label11.Text = "生产厂家:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "label6";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(10, 70);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel3.Size = new System.Drawing.Size(804, 342);
            this.panel3.TabIndex = 6;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.goods_name,
            this.goods_unit,
            this.goods_type,
            this.maker_name,
            this.goods_validity,
            this.goods_storemethod,
            this.goods_appliance_code,
            this.goods_code,
            this.goods_reg_num,
            this.goods_reg_mark,
            this.goods_yxm,
            this.goods_maker,
            this.maker_code});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 5);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(804, 337);
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
            // goods_name
            // 
            this.goods_name.DataPropertyName = "goods_name";
            this.goods_name.HeaderText = "产品名称";
            this.goods_name.Name = "goods_name";
            this.goods_name.ReadOnly = true;
            this.goods_name.Width = 125;
            // 
            // goods_unit
            // 
            this.goods_unit.DataPropertyName = "goods_unit";
            this.goods_unit.HeaderText = "计量单位";
            this.goods_unit.Name = "goods_unit";
            this.goods_unit.ReadOnly = true;
            this.goods_unit.Width = 90;
            // 
            // goods_type
            // 
            this.goods_type.DataPropertyName = "goods_type";
            this.goods_type.HeaderText = "规格型号";
            this.goods_type.Name = "goods_type";
            this.goods_type.ReadOnly = true;
            this.goods_type.Width = 80;
            // 
            // maker_name
            // 
            this.maker_name.DataPropertyName = "maker_name";
            this.maker_name.HeaderText = "生产厂家";
            this.maker_name.Name = "maker_name";
            this.maker_name.ReadOnly = true;
            this.maker_name.Width = 140;
            // 
            // goods_validity
            // 
            this.goods_validity.DataPropertyName = "goods_validity";
            this.goods_validity.HeaderText = "有效期(月)";
            this.goods_validity.Name = "goods_validity";
            this.goods_validity.ReadOnly = true;
            this.goods_validity.Width = 90;
            // 
            // goods_storemethod
            // 
            this.goods_storemethod.DataPropertyName = "goods_storemethod";
            this.goods_storemethod.HeaderText = "储藏方法";
            this.goods_storemethod.Name = "goods_storemethod";
            this.goods_storemethod.ReadOnly = true;
            this.goods_storemethod.Width = 110;
            // 
            // goods_appliance_code
            // 
            this.goods_appliance_code.DataPropertyName = "goods_appliance_code";
            this.goods_appliance_code.HeaderText = "器械分类";
            this.goods_appliance_code.Name = "goods_appliance_code";
            this.goods_appliance_code.ReadOnly = true;
            // 
            // goods_code
            // 
            this.goods_code.DataPropertyName = "goods_code";
            this.goods_code.HeaderText = "产品编号";
            this.goods_code.Name = "goods_code";
            this.goods_code.ReadOnly = true;
            this.goods_code.Visible = false;
            this.goods_code.Width = 130;
            // 
            // goods_reg_num
            // 
            this.goods_reg_num.DataPropertyName = "goods_reg_num";
            this.goods_reg_num.HeaderText = "注册证号";
            this.goods_reg_num.Name = "goods_reg_num";
            this.goods_reg_num.ReadOnly = true;
            this.goods_reg_num.Visible = false;
            // 
            // goods_reg_mark
            // 
            this.goods_reg_mark.DataPropertyName = "goods_reg_mark";
            this.goods_reg_mark.HeaderText = "注册商标";
            this.goods_reg_mark.Name = "goods_reg_mark";
            this.goods_reg_mark.ReadOnly = true;
            this.goods_reg_mark.Visible = false;
            // 
            // goods_yxm
            // 
            this.goods_yxm.DataPropertyName = "goods_yxm";
            this.goods_yxm.HeaderText = "音序码";
            this.goods_yxm.Name = "goods_yxm";
            this.goods_yxm.ReadOnly = true;
            this.goods_yxm.Visible = false;
            // 
            // goods_maker
            // 
            this.goods_maker.DataPropertyName = "goods_maker";
            this.goods_maker.HeaderText = "生产厂家编号";
            this.goods_maker.Name = "goods_maker";
            this.goods_maker.ReadOnly = true;
            this.goods_maker.Visible = false;
            // 
            // maker_code
            // 
            this.maker_code.DataPropertyName = "maker_code";
            this.maker_code.HeaderText = "厂家编号";
            this.maker_code.Name = "maker_code";
            this.maker_code.ReadOnly = true;
            this.maker_code.Visible = false;
            // 
            // TradeNameManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(824, 618);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(830, 650);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(830, 650);
            this.Name = "TradeNameManageForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "产品名称管理";
            this.Load += new System.EventHandler(this.TradeNameManageForm_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtGoods_yxmSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGoods_nameSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtMaker_code;
        private System.Windows.Forms.ComboBox cb_goods_unit;
        private TCControl.TCTextBox txtGoods_validity;
        private System.Windows.Forms.TextBox txtGoods_storemethod;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtGoods_type;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtGoods_reg_mark;
        private System.Windows.Forms.TextBox txtGoods_yxm;
        private System.Windows.Forms.TextBox txtGoods_reg_num;
        private System.Windows.Forms.TextBox txtGoods_name;
        private System.Windows.Forms.TextBox txtGoods_maker;
        private System.Windows.Forms.TextBox txtGoods_appliance_code;
        private System.Windows.Forms.TextBox txtGoods_code;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn maker_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_validity;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_storemethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_appliance_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_reg_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_reg_mark;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_yxm;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_maker;
        private System.Windows.Forms.DataGridViewTextBoxColumn maker_code;
    }
}