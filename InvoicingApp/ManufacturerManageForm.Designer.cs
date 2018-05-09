namespace InvoicingApp
{
    partial class ManufacturerManageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManufacturerManageForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtMaker_yxmSelect = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaker_nameSelect = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtMaker_postal_code = new TCControl.TCTextBox();
            this.txtMaker_tel = new TCControl.TCTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCommit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtMaker_quality_reg = new System.Windows.Forms.TextBox();
            this.txtMaker_yxm = new System.Windows.Forms.TextBox();
            this.txtMaker_licence = new System.Windows.Forms.TextBox();
            this.txtMaker_principal = new System.Windows.Forms.TextBox();
            this.txtMaker_name = new System.Windows.Forms.TextBox();
            this.txtMaker_hygiene = new System.Windows.Forms.TextBox();
            this.txtMaker_business_goods = new System.Windows.Forms.TextBox();
            this.txtMaker_business_scope = new System.Windows.Forms.TextBox();
            this.txtMaker_address = new System.Windows.Forms.TextBox();
            this.txtMaker_code = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maker_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maker_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maker_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maker_quality_reg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maker_business_scope = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maker_business_goods = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maker_principal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maker_postal_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maker_hygiene = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maker_licence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maker_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maker_yxm = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnSelect);
            this.groupBox2.Controls.Add(this.txtMaker_yxmSelect);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtMaker_nameSelect);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(804, 60);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "生产厂家查询";
            // 
            // btnClear
            // 
            this.btnClear.Image = global::InvoicingApp.Properties.Resources.Reset;
            this.btnClear.Location = new System.Drawing.Point(693, 20);
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
            this.btnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelect.Location = new System.Drawing.Point(612, 20);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "查询(&Q)";
            this.btnSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtMaker_yxmSelect
            // 
            this.txtMaker_yxmSelect.Location = new System.Drawing.Point(382, 20);
            this.txtMaker_yxmSelect.MaxLength = 25;
            this.txtMaker_yxmSelect.Name = "txtMaker_yxmSelect";
            this.txtMaker_yxmSelect.Size = new System.Drawing.Size(140, 21);
            this.txtMaker_yxmSelect.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "生产厂家音序码:";
            // 
            // txtMaker_nameSelect
            // 
            this.txtMaker_nameSelect.Location = new System.Drawing.Point(112, 20);
            this.txtMaker_nameSelect.MaxLength = 25;
            this.txtMaker_nameSelect.Name = "txtMaker_nameSelect";
            this.txtMaker_nameSelect.Size = new System.Drawing.Size(140, 21);
            this.txtMaker_nameSelect.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "生产厂家名称:";
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
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.txtMaker_postal_code);
            this.groupBox1.Controls.Add(this.txtMaker_tel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnCommit);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.txtMaker_quality_reg);
            this.groupBox1.Controls.Add(this.txtMaker_yxm);
            this.groupBox1.Controls.Add(this.txtMaker_licence);
            this.groupBox1.Controls.Add(this.txtMaker_principal);
            this.groupBox1.Controls.Add(this.txtMaker_name);
            this.groupBox1.Controls.Add(this.txtMaker_hygiene);
            this.groupBox1.Controls.Add(this.txtMaker_business_goods);
            this.groupBox1.Controls.Add(this.txtMaker_business_scope);
            this.groupBox1.Controls.Add(this.txtMaker_address);
            this.groupBox1.Controls.Add(this.txtMaker_code);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 186);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "生产厂家信息维护";
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::InvoicingApp.Properties.Resources.Delete;
            this.btnDelete.Location = new System.Drawing.Point(178, 151);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "删除(&D)";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtMaker_postal_code
            // 
            this.txtMaker_postal_code.DateTimeFormate = TCControl.TCTextBox.FormatType.yyyyMMdd;
            this.txtMaker_postal_code.Encodeing = "GB2312";
            this.txtMaker_postal_code.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtMaker_postal_code.IsAllowMinus = false;
            this.txtMaker_postal_code.Location = new System.Drawing.Point(628, 50);
            this.txtMaker_postal_code.MatchValue = "^[0-9]+[0-9]*[0-9-]*$";
            this.txtMaker_postal_code.MaxByteLength = 6;
            this.txtMaker_postal_code.MaxLength = 6;
            this.txtMaker_postal_code.Name = "txtMaker_postal_code";
            this.txtMaker_postal_code.PadLeftFirstIsZero = false;
            this.txtMaker_postal_code.Precision = 0;
            this.txtMaker_postal_code.Scale = 0;
            this.txtMaker_postal_code.Size = new System.Drawing.Size(140, 21);
            this.txtMaker_postal_code.TabIndex = 5;
            this.txtMaker_postal_code.TypeSet = TCControl.TCTextBox.Type.MatchDefine;
            this.txtMaker_postal_code.Value = "";
            // 
            // txtMaker_tel
            // 
            this.txtMaker_tel.DateTimeFormate = TCControl.TCTextBox.FormatType.yyyyMMdd;
            this.txtMaker_tel.Encodeing = "GB2312";
            this.txtMaker_tel.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtMaker_tel.IsAllowMinus = false;
            this.txtMaker_tel.Location = new System.Drawing.Point(628, 20);
            this.txtMaker_tel.MatchValue = "^[0-9]+[0-9]*[0-9-]*$";
            this.txtMaker_tel.MaxByteLength = 20;
            this.txtMaker_tel.MaxLength = 25;
            this.txtMaker_tel.Name = "txtMaker_tel";
            this.txtMaker_tel.PadLeftFirstIsZero = false;
            this.txtMaker_tel.Precision = 0;
            this.txtMaker_tel.Scale = 0;
            this.txtMaker_tel.Size = new System.Drawing.Size(140, 21);
            this.txtMaker_tel.TabIndex = 2;
            this.txtMaker_tel.TypeSet = TCControl.TCTextBox.Type.MatchDefine;
            this.txtMaker_tel.Value = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(264, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 73;
            this.label7.Text = "*";
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::InvoicingApp.Properties.Resources.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(693, 151);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCommit
            // 
            this.btnCommit.Image = global::InvoicingApp.Properties.Resources.Save;
            this.btnCommit.Location = new System.Drawing.Point(612, 151);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(75, 23);
            this.btnCommit.TabIndex = 14;
            this.btnCommit.Text = "保存(&S)";
            this.btnCommit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = global::InvoicingApp.Properties.Resources.Edit;
            this.btnUpdate.Location = new System.Drawing.Point(97, 151);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "修改(&M)";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Image = global::InvoicingApp.Properties.Resources.Add;
            this.btnInsert.Location = new System.Drawing.Point(16, 151);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 11;
            this.btnInsert.Text = "增加(&A)";
            this.btnInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtMaker_quality_reg
            // 
            this.txtMaker_quality_reg.Location = new System.Drawing.Point(628, 80);
            this.txtMaker_quality_reg.MaxLength = 25;
            this.txtMaker_quality_reg.Name = "txtMaker_quality_reg";
            this.txtMaker_quality_reg.Size = new System.Drawing.Size(140, 21);
            this.txtMaker_quality_reg.TabIndex = 8;
            // 
            // txtMaker_yxm
            // 
            this.txtMaker_yxm.Location = new System.Drawing.Point(395, 20);
            this.txtMaker_yxm.MaxLength = 25;
            this.txtMaker_yxm.Name = "txtMaker_yxm";
            this.txtMaker_yxm.Size = new System.Drawing.Size(140, 21);
            this.txtMaker_yxm.TabIndex = 1;
            // 
            // txtMaker_licence
            // 
            this.txtMaker_licence.Location = new System.Drawing.Point(394, 110);
            this.txtMaker_licence.MaxLength = 25;
            this.txtMaker_licence.Name = "txtMaker_licence";
            this.txtMaker_licence.Size = new System.Drawing.Size(140, 21);
            this.txtMaker_licence.TabIndex = 10;
            // 
            // txtMaker_principal
            // 
            this.txtMaker_principal.Location = new System.Drawing.Point(395, 50);
            this.txtMaker_principal.MaxLength = 25;
            this.txtMaker_principal.Name = "txtMaker_principal";
            this.txtMaker_principal.Size = new System.Drawing.Size(140, 21);
            this.txtMaker_principal.TabIndex = 4;
            // 
            // txtMaker_name
            // 
            this.txtMaker_name.Location = new System.Drawing.Point(124, 20);
            this.txtMaker_name.MaxLength = 25;
            this.txtMaker_name.Name = "txtMaker_name";
            this.txtMaker_name.Size = new System.Drawing.Size(140, 21);
            this.txtMaker_name.TabIndex = 0;
            this.txtMaker_name.TextChanged += new System.EventHandler(this.txtMaker_name_TextChanged);
            // 
            // txtMaker_hygiene
            // 
            this.txtMaker_hygiene.Location = new System.Drawing.Point(124, 110);
            this.txtMaker_hygiene.MaxLength = 25;
            this.txtMaker_hygiene.Name = "txtMaker_hygiene";
            this.txtMaker_hygiene.Size = new System.Drawing.Size(140, 21);
            this.txtMaker_hygiene.TabIndex = 9;
            // 
            // txtMaker_business_goods
            // 
            this.txtMaker_business_goods.Location = new System.Drawing.Point(124, 80);
            this.txtMaker_business_goods.MaxLength = 50;
            this.txtMaker_business_goods.Name = "txtMaker_business_goods";
            this.txtMaker_business_goods.Size = new System.Drawing.Size(140, 21);
            this.txtMaker_business_goods.TabIndex = 6;
            // 
            // txtMaker_business_scope
            // 
            this.txtMaker_business_scope.Location = new System.Drawing.Point(394, 80);
            this.txtMaker_business_scope.MaxLength = 50;
            this.txtMaker_business_scope.Name = "txtMaker_business_scope";
            this.txtMaker_business_scope.Size = new System.Drawing.Size(140, 21);
            this.txtMaker_business_scope.TabIndex = 7;
            // 
            // txtMaker_address
            // 
            this.txtMaker_address.Location = new System.Drawing.Point(124, 50);
            this.txtMaker_address.MaxLength = 50;
            this.txtMaker_address.Name = "txtMaker_address";
            this.txtMaker_address.Size = new System.Drawing.Size(140, 21);
            this.txtMaker_address.TabIndex = 3;
            // 
            // txtMaker_code
            // 
            this.txtMaker_code.Location = new System.Drawing.Point(798, 198);
            this.txtMaker_code.Name = "txtMaker_code";
            this.txtMaker_code.Size = new System.Drawing.Size(10, 21);
            this.txtMaker_code.TabIndex = 22;
            this.txtMaker_code.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(284, 84);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 12);
            this.label18.TabIndex = 15;
            this.label18.Text = "生产范围:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "生产厂家名称:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "地址:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(554, 54);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 12);
            this.label16.TabIndex = 13;
            this.label16.Text = "邮编:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "卫生许可证编号:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(284, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "音序码:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(284, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 12);
            this.label9.TabIndex = 6;
            this.label9.Text = "生产许可证编号:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(554, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 12);
            this.label13.TabIndex = 10;
            this.label13.Text = "电话:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(284, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 12);
            this.label10.TabIndex = 7;
            this.label10.Text = "联系人:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(554, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 12);
            this.label12.TabIndex = 9;
            this.label12.Text = "质量认证:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 12);
            this.label11.TabIndex = 8;
            this.label11.Text = "主要产品:";
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
            this.panel3.Margin = new System.Windows.Forms.Padding(10);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel3.Size = new System.Drawing.Size(804, 342);
            this.panel3.TabIndex = 2;
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
            this.maker_code,
            this.maker_name,
            this.maker_address,
            this.maker_quality_reg,
            this.maker_business_scope,
            this.maker_business_goods,
            this.maker_principal,
            this.maker_postal_code,
            this.maker_hygiene,
            this.maker_licence,
            this.maker_tel,
            this.maker_yxm});
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
            // maker_code
            // 
            this.maker_code.DataPropertyName = "maker_code";
            this.maker_code.HeaderText = "厂家编号";
            this.maker_code.Name = "maker_code";
            this.maker_code.ReadOnly = true;
            this.maker_code.Visible = false;
            this.maker_code.Width = 130;
            // 
            // maker_name
            // 
            this.maker_name.DataPropertyName = "maker_name";
            this.maker_name.HeaderText = "生产厂家名称";
            this.maker_name.Name = "maker_name";
            this.maker_name.ReadOnly = true;
            this.maker_name.Width = 120;
            // 
            // maker_address
            // 
            this.maker_address.DataPropertyName = "maker_address";
            this.maker_address.HeaderText = "地址";
            this.maker_address.Name = "maker_address";
            this.maker_address.ReadOnly = true;
            this.maker_address.Width = 150;
            // 
            // maker_quality_reg
            // 
            this.maker_quality_reg.DataPropertyName = "maker_quality_reg";
            this.maker_quality_reg.HeaderText = "质量认证";
            this.maker_quality_reg.Name = "maker_quality_reg";
            this.maker_quality_reg.ReadOnly = true;
            // 
            // maker_business_scope
            // 
            this.maker_business_scope.DataPropertyName = "maker_business_scope";
            this.maker_business_scope.HeaderText = "生产范围";
            this.maker_business_scope.Name = "maker_business_scope";
            this.maker_business_scope.ReadOnly = true;
            this.maker_business_scope.Width = 150;
            // 
            // maker_business_goods
            // 
            this.maker_business_goods.DataPropertyName = "maker_business_goods";
            this.maker_business_goods.HeaderText = "主要产品";
            this.maker_business_goods.Name = "maker_business_goods";
            this.maker_business_goods.ReadOnly = true;
            // 
            // maker_principal
            // 
            this.maker_principal.DataPropertyName = "maker_principal";
            this.maker_principal.HeaderText = "联系人";
            this.maker_principal.Name = "maker_principal";
            this.maker_principal.ReadOnly = true;
            // 
            // maker_postal_code
            // 
            this.maker_postal_code.DataPropertyName = "maker_postal_code";
            this.maker_postal_code.HeaderText = "邮编";
            this.maker_postal_code.Name = "maker_postal_code";
            this.maker_postal_code.ReadOnly = true;
            this.maker_postal_code.Visible = false;
            // 
            // maker_hygiene
            // 
            this.maker_hygiene.DataPropertyName = "maker_hygiene";
            this.maker_hygiene.HeaderText = "卫生许可证编号";
            this.maker_hygiene.Name = "maker_hygiene";
            this.maker_hygiene.ReadOnly = true;
            this.maker_hygiene.Visible = false;
            // 
            // maker_licence
            // 
            this.maker_licence.DataPropertyName = "maker_licence";
            this.maker_licence.HeaderText = "生产许可证编号";
            this.maker_licence.Name = "maker_licence";
            this.maker_licence.ReadOnly = true;
            this.maker_licence.Visible = false;
            // 
            // maker_tel
            // 
            this.maker_tel.DataPropertyName = "maker_tel";
            this.maker_tel.HeaderText = "电话";
            this.maker_tel.Name = "maker_tel";
            this.maker_tel.ReadOnly = true;
            this.maker_tel.Visible = false;
            // 
            // maker_yxm
            // 
            this.maker_yxm.DataPropertyName = "maker_yxm";
            this.maker_yxm.HeaderText = "音序码";
            this.maker_yxm.Name = "maker_yxm";
            this.maker_yxm.ReadOnly = true;
            this.maker_yxm.Visible = false;
            // 
            // ManufacturerManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
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
            this.Name = "ManufacturerManageForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "生产厂家管理";
            this.Load += new System.EventHandler(this.ManufacturerManageForm_Load);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaker_nameSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaker_yxmSelect;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaker_address;
        private System.Windows.Forms.TextBox txtMaker_code;
        private System.Windows.Forms.TextBox txtMaker_quality_reg;
        private System.Windows.Forms.TextBox txtMaker_yxm;
        private System.Windows.Forms.TextBox txtMaker_licence;
        private System.Windows.Forms.TextBox txtMaker_principal;
        private System.Windows.Forms.TextBox txtMaker_name;
        private System.Windows.Forms.TextBox txtMaker_hygiene;
        private System.Windows.Forms.TextBox txtMaker_business_goods;
        private System.Windows.Forms.TextBox txtMaker_business_scope;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label7;
        private TCControl.TCTextBox txtMaker_tel;
        private TCControl.TCTextBox txtMaker_postal_code;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn maker_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn maker_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn maker_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn maker_quality_reg;
        private System.Windows.Forms.DataGridViewTextBoxColumn maker_business_scope;
        private System.Windows.Forms.DataGridViewTextBoxColumn maker_business_goods;
        private System.Windows.Forms.DataGridViewTextBoxColumn maker_principal;
        private System.Windows.Forms.DataGridViewTextBoxColumn maker_postal_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn maker_hygiene;
        private System.Windows.Forms.DataGridViewTextBoxColumn maker_licence;
        private System.Windows.Forms.DataGridViewTextBoxColumn maker_tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn maker_yxm;
    }
}