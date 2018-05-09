namespace InvoicingApp
{
    partial class DeviceManageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeviceManageForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtTypeSelect = new System.Windows.Forms.TextBox();
            this.txtCodeSelect = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNameSelect = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCode = new TCControl.TCTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCommit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.txtUseMethod = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSetPlace = new System.Windows.Forms.TextBox();
            this.dtpBuyDate = new System.Windows.Forms.DateTimePicker();
            this.dtpUseDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvDevice = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.device_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.device_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.device_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.device_made = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.device_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.device_usedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.device_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.device_application = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.device_remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.device_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 60);
            this.panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.btnSelect);
            this.groupBox1.Controls.Add(this.txtTypeSelect);
            this.groupBox1.Controls.Add(this.txtCodeSelect);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtNameSelect);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(994, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设备仪器查询";
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrint.Image = global::InvoicingApp.Properties.Resources.Print;
            this.btnPrint.Location = new System.Drawing.Point(896, 20);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "打印(&P)";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReset.Image = global::InvoicingApp.Properties.Resources.Reset;
            this.btnReset.Location = new System.Drawing.Point(815, 20);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "重置(&R)";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 12);
            this.label14.TabIndex = 0;
            this.label14.Text = "设备编号:";
            // 
            // btnSelect
            // 
            this.btnSelect.Image = global::InvoicingApp.Properties.Resources.Search;
            this.btnSelect.Location = new System.Drawing.Point(734, 19);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = "查询(&Q)";
            this.btnSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtTypeSelect
            // 
            this.txtTypeSelect.Location = new System.Drawing.Point(514, 20);
            this.txtTypeSelect.Name = "txtTypeSelect";
            this.txtTypeSelect.Size = new System.Drawing.Size(125, 21);
            this.txtTypeSelect.TabIndex = 3;
            // 
            // txtCodeSelect
            // 
            this.txtCodeSelect.Location = new System.Drawing.Point(88, 20);
            this.txtCodeSelect.Name = "txtCodeSelect";
            this.txtCodeSelect.Size = new System.Drawing.Size(112, 21);
            this.txtCodeSelect.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(440, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "规格型号:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(223, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 12);
            this.label13.TabIndex = 2;
            this.label13.Text = "设备名称:";
            // 
            // txtNameSelect
            // 
            this.txtNameSelect.Location = new System.Drawing.Point(292, 20);
            this.txtNameSelect.Name = "txtNameSelect";
            this.txtNameSelect.Size = new System.Drawing.Size(124, 21);
            this.txtNameSelect.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(10, 524);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel2.Size = new System.Drawing.Size(994, 168);
            this.panel2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtCode);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtMake);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtType);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnCommit);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.txtRemarks);
            this.groupBox2.Controls.Add(this.txtUseMethod);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtSetPlace);
            this.groupBox2.Controls.Add(this.dtpBuyDate);
            this.groupBox2.Controls.Add(this.dtpUseDate);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtUser);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(994, 158);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "设备仪器信息维护";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(254, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 45;
            this.label6.Text = "*";
            // 
            // txtCode
            // 
            this.txtCode.DateTimeFormate = TCControl.TCTextBox.FormatType.yyyyMMdd;
            this.txtCode.Encodeing = "GB2312";
            this.txtCode.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtCode.IsAllowMinus = false;
            this.txtCode.Location = new System.Drawing.Point(124, 20);
            this.txtCode.MatchValue = "";
            this.txtCode.MaxByteLength = 20;
            this.txtCode.Name = "txtCode";
            this.txtCode.PadLeftFirstIsZero = false;
            this.txtCode.Precision = 0;
            this.txtCode.Scale = 0;
            this.txtCode.Size = new System.Drawing.Size(130, 21);
            this.txtCode.TabIndex = 1;
            this.txtCode.TypeSet = TCControl.TCTextBox.Type.NumberAndLetter;
            this.txtCode.Value = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(702, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 44;
            this.label2.Text = "*";
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::InvoicingApp.Properties.Resources.Delete;
            this.btnDelete.Location = new System.Drawing.Point(178, 123);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "删除(&D)";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = global::InvoicingApp.Properties.Resources.Edit;
            this.btnUpdate.Location = new System.Drawing.Point(97, 123);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "修改(&M)";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(722, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 12);
            this.label12.TabIndex = 43;
            this.label12.Text = "生产厂家:";
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(796, 21);
            this.txtMake.MaxLength = 25;
            this.txtMake.Name = "txtMake";
            this.txtMake.ReadOnly = true;
            this.txtMake.Size = new System.Drawing.Size(130, 21);
            this.txtMake.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(498, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 40;
            this.label3.Text = "规格型号:";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(572, 20);
            this.txtType.MaxLength = 10;
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(130, 21);
            this.txtType.TabIndex = 3;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(478, 24);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(11, 12);
            this.label19.TabIndex = 30;
            this.label19.Text = "*";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(254, 24);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(11, 12);
            this.label17.TabIndex = 29;
            this.label17.Text = "*";
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::InvoicingApp.Properties.Resources.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(896, 123);
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
            this.btnCommit.Location = new System.Drawing.Point(815, 123);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(75, 23);
            this.btnCommit.TabIndex = 14;
            this.btnCommit.Text = "保存(&S)";
            this.btnCommit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::InvoicingApp.Properties.Resources.Add;
            this.btnAdd.Location = new System.Drawing.Point(16, 123);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "增加(&A)";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "设备编号:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(274, 84);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 12);
            this.label18.TabIndex = 24;
            this.label18.Text = "备注:";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(348, 81);
            this.txtRemarks.MaxLength = 50;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(578, 21);
            this.txtRemarks.TabIndex = 10;
            // 
            // txtUseMethod
            // 
            this.txtUseMethod.Location = new System.Drawing.Point(796, 50);
            this.txtUseMethod.MaxLength = 50;
            this.txtUseMethod.Name = "txtUseMethod";
            this.txtUseMethod.ReadOnly = true;
            this.txtUseMethod.Size = new System.Drawing.Size(130, 21);
            this.txtUseMethod.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(722, 54);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 12);
            this.label15.TabIndex = 20;
            this.label15.Text = "用途:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "购置时间:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(498, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "配置地点:";
            // 
            // txtSetPlace
            // 
            this.txtSetPlace.Location = new System.Drawing.Point(572, 50);
            this.txtSetPlace.MaxLength = 25;
            this.txtSetPlace.Name = "txtSetPlace";
            this.txtSetPlace.ReadOnly = true;
            this.txtSetPlace.Size = new System.Drawing.Size(130, 21);
            this.txtSetPlace.TabIndex = 7;
            // 
            // dtpBuyDate
            // 
            this.dtpBuyDate.CustomFormat = "yyyy-MM-dd";
            this.dtpBuyDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBuyDate.Location = new System.Drawing.Point(124, 50);
            this.dtpBuyDate.Name = "dtpBuyDate";
            this.dtpBuyDate.Size = new System.Drawing.Size(130, 21);
            this.dtpBuyDate.TabIndex = 5;
            // 
            // dtpUseDate
            // 
            this.dtpUseDate.CustomFormat = "yyyy-MM-dd";
            this.dtpUseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpUseDate.Location = new System.Drawing.Point(348, 50);
            this.dtpUseDate.Name = "dtpUseDate";
            this.dtpUseDate.Size = new System.Drawing.Size(130, 21);
            this.dtpUseDate.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(274, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 16;
            this.label10.Text = "启用时间:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(274, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "设备名称:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(348, 20);
            this.txtName.MaxLength = 25;
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(130, 21);
            this.txtName.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "维护或使用人员:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(124, 81);
            this.txtUser.MaxLength = 10;
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(130, 21);
            this.txtUser.TabIndex = 9;
            this.txtUser.DoubleClick += new System.EventHandler(this.txtUser_DoubleClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvDevice);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(10, 70);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel3.Size = new System.Drawing.Size(994, 454);
            this.panel3.TabIndex = 26;
            // 
            // dgvDevice
            // 
            this.dgvDevice.AllowUserToAddRows = false;
            this.dgvDevice.AllowUserToDeleteRows = false;
            this.dgvDevice.AllowUserToResizeRows = false;
            this.dgvDevice.BackgroundColor = System.Drawing.Color.White;
            this.dgvDevice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDevice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.device_code,
            this.device_name,
            this.device_type,
            this.device_made,
            this.device_date,
            this.device_usedate,
            this.device_address,
            this.device_application,
            this.staff_name,
            this.device_remarks,
            this.device_id});
            this.dgvDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDevice.Location = new System.Drawing.Point(0, 5);
            this.dgvDevice.MultiSelect = false;
            this.dgvDevice.Name = "dgvDevice";
            this.dgvDevice.RowHeadersVisible = false;
            this.dgvDevice.RowTemplate.Height = 23;
            this.dgvDevice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDevice.Size = new System.Drawing.Size(994, 449);
            this.dgvDevice.StandardTab = true;
            this.dgvDevice.TabIndex = 0;
            this.dgvDevice.Sorted += new System.EventHandler(this.dgvDevice_Sorted);
            this.dgvDevice.SelectionChanged += new System.EventHandler(this.dgvDevice_SelectionChanged);
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
            // device_code
            // 
            this.device_code.DataPropertyName = "device_code";
            this.device_code.HeaderText = "设备编号";
            this.device_code.Name = "device_code";
            this.device_code.ReadOnly = true;
            this.device_code.Width = 110;
            // 
            // device_name
            // 
            this.device_name.DataPropertyName = "device_name";
            this.device_name.HeaderText = "设备名称";
            this.device_name.Name = "device_name";
            this.device_name.ReadOnly = true;
            this.device_name.Width = 80;
            // 
            // device_type
            // 
            this.device_type.DataPropertyName = "device_type";
            this.device_type.HeaderText = "规格型号";
            this.device_type.Name = "device_type";
            this.device_type.ReadOnly = true;
            // 
            // device_made
            // 
            this.device_made.DataPropertyName = "device_made";
            this.device_made.HeaderText = "生产厂家";
            this.device_made.Name = "device_made";
            this.device_made.ReadOnly = true;
            this.device_made.Visible = false;
            this.device_made.Width = 130;
            // 
            // device_date
            // 
            this.device_date.DataPropertyName = "device_date";
            this.device_date.HeaderText = "购置时间";
            this.device_date.Name = "device_date";
            this.device_date.ReadOnly = true;
            // 
            // device_usedate
            // 
            this.device_usedate.DataPropertyName = "device_usedate";
            this.device_usedate.HeaderText = "启用时间";
            this.device_usedate.Name = "device_usedate";
            this.device_usedate.ReadOnly = true;
            // 
            // device_address
            // 
            this.device_address.DataPropertyName = "device_address";
            this.device_address.HeaderText = "配置地点";
            this.device_address.Name = "device_address";
            this.device_address.ReadOnly = true;
            // 
            // device_application
            // 
            this.device_application.DataPropertyName = "device_application";
            this.device_application.HeaderText = "用途";
            this.device_application.Name = "device_application";
            this.device_application.ReadOnly = true;
            // 
            // staff_name
            // 
            this.staff_name.DataPropertyName = "staff_name";
            this.staff_name.HeaderText = "使用和维护人员";
            this.staff_name.Name = "staff_name";
            this.staff_name.ReadOnly = true;
            // 
            // device_remarks
            // 
            this.device_remarks.DataPropertyName = "device_remarks";
            this.device_remarks.HeaderText = "备注";
            this.device_remarks.Name = "device_remarks";
            this.device_remarks.ReadOnly = true;
            this.device_remarks.Width = 130;
            // 
            // device_id
            // 
            this.device_id.DataPropertyName = "device_id";
            this.device_id.HeaderText = "表主键";
            this.device_id.Name = "device_id";
            this.device_id.ReadOnly = true;
            this.device_id.Visible = false;
            // 
            // DeviceManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 702);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeviceManageForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "设备仪器管理";
            this.Load += new System.EventHandler(this.FacilityManageForm_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtTypeSelect;
        private System.Windows.Forms.TextBox txtCodeSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNameSelect;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.TextBox txtUseMethod;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSetPlace;
        private System.Windows.Forms.DateTimePicker dtpBuyDate;
        private System.Windows.Forms.DateTimePicker dtpUseDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvDevice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn device_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn device_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn device_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn device_made;
        private System.Windows.Forms.DataGridViewTextBoxColumn device_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn device_usedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn device_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn device_application;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn device_remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn device_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrint;
        private TCControl.TCTextBox txtCode;
        private System.Windows.Forms.Label label6;
    }
}