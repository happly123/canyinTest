namespace InvoicingApp
{
    partial class supplierManageDialogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(supplierManageDialogForm));
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView_supplier = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_artificial_person = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_licence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_business_scpoe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_yxm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_trustpersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_postal_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_principal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_bank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_bank_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_tariff_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_make_quality_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_business_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_business_licence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.textBox_supplier_yxm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_supplier_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_supplier)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Image = global::InvoicingApp.Properties.Resources.Ok;
            this.btnConfirm.Location = new System.Drawing.Point(538, 19);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "确定(&O)";
            this.btnConfirm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::InvoicingApp.Properties.Resources.Search;
            this.btnSearch.Location = new System.Drawing.Point(535, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "查询(&Q)";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridView_supplier
            // 
            this.dataGridView_supplier.AllowUserToAddRows = false;
            this.dataGridView_supplier.AllowUserToDeleteRows = false;
            this.dataGridView_supplier.AllowUserToResizeRows = false;
            this.dataGridView_supplier.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_supplier.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_supplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.supplier_code,
            this.supplier_name,
            this.supplier_address,
            this.supplier_fax,
            this.supplier_artificial_person,
            this.supplier_licence,
            this.supplier_type,
            this.supplier_business_scpoe,
            this.supplier_yxm,
            this.supplier_trustpersion,
            this.supplier_postal_code,
            this.supplier_principal,
            this.supplier_bank,
            this.supplier_bank_num,
            this.supplier_tel,
            this.supplier_tariff_num,
            this.supplier_make_quality_num,
            this.supplier_business_num,
            this.supplier_business_licence});
            this.dataGridView_supplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_supplier.Location = new System.Drawing.Point(0, 5);
            this.dataGridView_supplier.MultiSelect = false;
            this.dataGridView_supplier.Name = "dataGridView_supplier";
            this.dataGridView_supplier.ReadOnly = true;
            this.dataGridView_supplier.RowHeadersVisible = false;
            this.dataGridView_supplier.RowTemplate.Height = 23;
            this.dataGridView_supplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_supplier.Size = new System.Drawing.Size(706, 372);
            this.dataGridView_supplier.TabIndex = 0;
            this.dataGridView_supplier.TabStop = false;
            this.dataGridView_supplier.Sorted += new System.EventHandler(this.dataGridView_supplier_Sorted);
            this.dataGridView_supplier.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_supplier_CellDoubleClick);
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
            // supplier_code
            // 
            this.supplier_code.DataPropertyName = "supplier_code";
            this.supplier_code.HeaderText = "供货商编号";
            this.supplier_code.Name = "supplier_code";
            this.supplier_code.ReadOnly = true;
            this.supplier_code.Visible = false;
            this.supplier_code.Width = 130;
            // 
            // supplier_name
            // 
            this.supplier_name.DataPropertyName = "supplier_name";
            this.supplier_name.HeaderText = "供货商名称";
            this.supplier_name.Name = "supplier_name";
            this.supplier_name.ReadOnly = true;
            this.supplier_name.Width = 150;
            // 
            // supplier_address
            // 
            this.supplier_address.DataPropertyName = "supplier_address";
            this.supplier_address.HeaderText = "地址";
            this.supplier_address.Name = "supplier_address";
            this.supplier_address.ReadOnly = true;
            // 
            // supplier_fax
            // 
            this.supplier_fax.DataPropertyName = "supplier_fax";
            this.supplier_fax.HeaderText = "传真";
            this.supplier_fax.Name = "supplier_fax";
            this.supplier_fax.ReadOnly = true;
            // 
            // supplier_artificial_person
            // 
            this.supplier_artificial_person.DataPropertyName = "supplier_artificial_person";
            this.supplier_artificial_person.HeaderText = "法人代表";
            this.supplier_artificial_person.Name = "supplier_artificial_person";
            this.supplier_artificial_person.ReadOnly = true;
            // 
            // supplier_licence
            // 
            this.supplier_licence.DataPropertyName = "supplier_licence";
            this.supplier_licence.HeaderText = "许可证号";
            this.supplier_licence.Name = "supplier_licence";
            this.supplier_licence.ReadOnly = true;
            // 
            // supplier_type
            // 
            this.supplier_type.DataPropertyName = "supplier_type";
            this.supplier_type.HeaderText = "供货商类别";
            this.supplier_type.Name = "supplier_type";
            this.supplier_type.ReadOnly = true;
            // 
            // supplier_business_scpoe
            // 
            this.supplier_business_scpoe.DataPropertyName = "supplier_business_scpoe";
            this.supplier_business_scpoe.HeaderText = "经营范围";
            this.supplier_business_scpoe.Name = "supplier_business_scpoe";
            this.supplier_business_scpoe.ReadOnly = true;
            // 
            // supplier_yxm
            // 
            this.supplier_yxm.DataPropertyName = "supplier_yxm";
            this.supplier_yxm.HeaderText = "音序码";
            this.supplier_yxm.Name = "supplier_yxm";
            this.supplier_yxm.ReadOnly = true;
            this.supplier_yxm.Visible = false;
            // 
            // supplier_trustpersion
            // 
            this.supplier_trustpersion.DataPropertyName = "supplier_trustpersion";
            this.supplier_trustpersion.HeaderText = "法人委托";
            this.supplier_trustpersion.Name = "supplier_trustpersion";
            this.supplier_trustpersion.ReadOnly = true;
            this.supplier_trustpersion.Visible = false;
            // 
            // supplier_postal_code
            // 
            this.supplier_postal_code.DataPropertyName = "supplier_postal_code";
            this.supplier_postal_code.HeaderText = "邮编";
            this.supplier_postal_code.Name = "supplier_postal_code";
            this.supplier_postal_code.ReadOnly = true;
            this.supplier_postal_code.Visible = false;
            // 
            // supplier_principal
            // 
            this.supplier_principal.DataPropertyName = "supplier_principal";
            this.supplier_principal.HeaderText = "联系人";
            this.supplier_principal.Name = "supplier_principal";
            this.supplier_principal.ReadOnly = true;
            this.supplier_principal.Visible = false;
            // 
            // supplier_bank
            // 
            this.supplier_bank.DataPropertyName = "supplier_bank";
            this.supplier_bank.HeaderText = "开户银行";
            this.supplier_bank.Name = "supplier_bank";
            this.supplier_bank.ReadOnly = true;
            this.supplier_bank.Visible = false;
            // 
            // supplier_bank_num
            // 
            this.supplier_bank_num.DataPropertyName = "supplier_bank_num";
            this.supplier_bank_num.HeaderText = "银行账号";
            this.supplier_bank_num.Name = "supplier_bank_num";
            this.supplier_bank_num.ReadOnly = true;
            this.supplier_bank_num.Visible = false;
            // 
            // supplier_tel
            // 
            this.supplier_tel.DataPropertyName = "supplier_tel";
            this.supplier_tel.HeaderText = "电话";
            this.supplier_tel.Name = "supplier_tel";
            this.supplier_tel.ReadOnly = true;
            this.supplier_tel.Visible = false;
            // 
            // supplier_tariff_num
            // 
            this.supplier_tariff_num.DataPropertyName = "supplier_tariff_num";
            this.supplier_tariff_num.HeaderText = "税号";
            this.supplier_tariff_num.Name = "supplier_tariff_num";
            this.supplier_tariff_num.ReadOnly = true;
            this.supplier_tariff_num.Visible = false;
            // 
            // supplier_make_quality_num
            // 
            this.supplier_make_quality_num.DataPropertyName = "supplier_make_quality_num";
            this.supplier_make_quality_num.HeaderText = "生产质量体系认证";
            this.supplier_make_quality_num.Name = "supplier_make_quality_num";
            this.supplier_make_quality_num.ReadOnly = true;
            this.supplier_make_quality_num.Visible = false;
            // 
            // supplier_business_num
            // 
            this.supplier_business_num.DataPropertyName = "supplier_business_num";
            this.supplier_business_num.HeaderText = "经营质量体系认证";
            this.supplier_business_num.Name = "supplier_business_num";
            this.supplier_business_num.ReadOnly = true;
            this.supplier_business_num.Visible = false;
            // 
            // supplier_business_licence
            // 
            this.supplier_business_licence.DataPropertyName = "supplier_business_licence";
            this.supplier_business_licence.HeaderText = "营业执照";
            this.supplier_business_licence.Name = "supplier_business_licence";
            this.supplier_business_licence.ReadOnly = true;
            this.supplier_business_licence.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.textBox_supplier_yxm);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_supplier_name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // btnClear
            // 
            this.btnClear.Image = global::InvoicingApp.Properties.Resources.Reset;
            this.btnClear.Location = new System.Drawing.Point(618, 19);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "重置(&R)";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // textBox_supplier_yxm
            // 
            this.textBox_supplier_yxm.Location = new System.Drawing.Point(356, 20);
            this.textBox_supplier_yxm.MaxLength = 25;
            this.textBox_supplier_yxm.Name = "textBox_supplier_yxm";
            this.textBox_supplier_yxm.Size = new System.Drawing.Size(142, 21);
            this.textBox_supplier_yxm.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "供货商音序码:";
            // 
            // textBox_supplier_name
            // 
            this.textBox_supplier_name.Location = new System.Drawing.Point(100, 20);
            this.textBox_supplier_name.MaxLength = 25;
            this.textBox_supplier_name.Name = "textBox_supplier_name";
            this.textBox_supplier_name.Size = new System.Drawing.Size(136, 21);
            this.textBox_supplier_name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "供货商名称:";
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::InvoicingApp.Properties.Resources.Close;
            this.btnCancel.Location = new System.Drawing.Point(619, 19);
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
            this.btnInsert.Location = new System.Drawing.Point(14, 19);
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
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(10, 447);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 64);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView_supplier);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(10, 70);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel2.Size = new System.Drawing.Size(706, 377);
            this.panel2.TabIndex = 2;
            // 
            // supplierManageDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(726, 521);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(732, 553);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(732, 553);
            this.Name = "supplierManageDialogForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "供货商列表";
            this.Load += new System.EventHandler(this.supplierManageDialogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_supplier)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView_supplier;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_supplier_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox textBox_supplier_yxm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_fax;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_artificial_person;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_licence;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_business_scpoe;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_yxm;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_trustpersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_postal_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_principal;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_bank;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_bank_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_tariff_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_make_quality_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_business_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_business_licence;
    }
}