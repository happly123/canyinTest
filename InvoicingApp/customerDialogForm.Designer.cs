namespace InvoicingApp
{
    partial class customerDialogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customerDialogForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_yxm_Select = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.txt_Customer_Select = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCommit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_artificial_person = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_principal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_postal_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_quality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_yxm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_bank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_bank_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_tariff_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_licence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_business_licence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_medical_institutions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_yxm_Select);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.txt_Customer_Select);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // txt_yxm_Select
            // 
            this.txt_yxm_Select.Location = new System.Drawing.Point(291, 20);
            this.txt_yxm_Select.Name = "txt_yxm_Select";
            this.txt_yxm_Select.Size = new System.Drawing.Size(119, 21);
            this.txt_yxm_Select.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "音序码:";
            // 
            // btnReset
            // 
            this.btnReset.Image = global::InvoicingApp.Properties.Resources.Reset;
            this.btnReset.Location = new System.Drawing.Point(520, 19);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "重置(&R)";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnFind
            // 
            this.btnFind.Image = global::InvoicingApp.Properties.Resources.Search;
            this.btnFind.Location = new System.Drawing.Point(439, 19);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "查询(&Q)";
            this.btnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txt_Customer_Select
            // 
            this.txt_Customer_Select.Location = new System.Drawing.Point(88, 20);
            this.txt_Customer_Select.Name = "txt_Customer_Select";
            this.txt_Customer_Select.Size = new System.Drawing.Size(119, 21);
            this.txt_Customer_Select.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "客户名称:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnCommit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(10, 394);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(615, 56);
            this.panel3.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::InvoicingApp.Properties.Resources.Add;
            this.btnAdd.Location = new System.Drawing.Point(24, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "增加(&A)";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::InvoicingApp.Properties.Resources.Close;
            this.btnCancel.Location = new System.Drawing.Point(520, 16);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "关闭(&C)";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCommit
            // 
            this.btnCommit.Image = global::InvoicingApp.Properties.Resources.Ok;
            this.btnCommit.Location = new System.Drawing.Point(439, 16);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(75, 23);
            this.btnCommit.TabIndex = 1;
            this.btnCommit.Text = "确定(&O)";
            this.btnCommit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvCustomer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 70);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel1.Size = new System.Drawing.Size(615, 324);
            this.panel1.TabIndex = 2;
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.AllowUserToResizeRows = false;
            this.dgvCustomer.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.customer_name,
            this.customer_code,
            this.customer_artificial_person,
            this.customer_address,
            this.customer_principal,
            this.customer_tel,
            this.customer_fax,
            this.customer_postal_code,
            this.customer_quality,
            this.customer_yxm,
            this.customer_bank,
            this.customer_bank_num,
            this.customer_tariff_num,
            this.customer_licence,
            this.customer_business_licence,
            this.customer_medical_institutions,
            this.customer_type});
            this.dgvCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomer.Location = new System.Drawing.Point(0, 5);
            this.dgvCustomer.MultiSelect = false;
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.RowHeadersVisible = false;
            this.dgvCustomer.RowTemplate.Height = 23;
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.Size = new System.Drawing.Size(615, 319);
            this.dgvCustomer.TabIndex = 2;
            this.dgvCustomer.TabStop = false;
            this.dgvCustomer.Sorted += new System.EventHandler(this.dgvCustomer_Sorted);
            this.dgvCustomer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellDoubleClick);
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
            // customer_name
            // 
            this.customer_name.DataPropertyName = "customer_name";
            this.customer_name.HeaderText = "客户名称";
            this.customer_name.Name = "customer_name";
            this.customer_name.ReadOnly = true;
            // 
            // customer_code
            // 
            this.customer_code.DataPropertyName = "customer_code";
            this.customer_code.HeaderText = "客户编码";
            this.customer_code.Name = "customer_code";
            this.customer_code.ReadOnly = true;
            this.customer_code.Visible = false;
            // 
            // customer_artificial_person
            // 
            this.customer_artificial_person.DataPropertyName = "customer_artificial_person";
            this.customer_artificial_person.HeaderText = "法人代表";
            this.customer_artificial_person.Name = "customer_artificial_person";
            this.customer_artificial_person.ReadOnly = true;
            // 
            // customer_address
            // 
            this.customer_address.DataPropertyName = "customer_address";
            this.customer_address.HeaderText = "地址";
            this.customer_address.Name = "customer_address";
            this.customer_address.ReadOnly = true;
            // 
            // customer_principal
            // 
            this.customer_principal.DataPropertyName = "customer_principal";
            this.customer_principal.HeaderText = "联系人";
            this.customer_principal.Name = "customer_principal";
            this.customer_principal.ReadOnly = true;
            // 
            // customer_tel
            // 
            this.customer_tel.DataPropertyName = "customer_tel";
            this.customer_tel.HeaderText = "电话";
            this.customer_tel.Name = "customer_tel";
            this.customer_tel.ReadOnly = true;
            // 
            // customer_fax
            // 
            this.customer_fax.DataPropertyName = "customer_fax";
            this.customer_fax.HeaderText = "传真";
            this.customer_fax.Name = "customer_fax";
            this.customer_fax.ReadOnly = true;
            // 
            // customer_postal_code
            // 
            this.customer_postal_code.DataPropertyName = "customer_postal_code";
            this.customer_postal_code.HeaderText = "邮编";
            this.customer_postal_code.Name = "customer_postal_code";
            this.customer_postal_code.ReadOnly = true;
            // 
            // customer_quality
            // 
            this.customer_quality.DataPropertyName = "customer_quality";
            this.customer_quality.HeaderText = "质量体系认证";
            this.customer_quality.Name = "customer_quality";
            this.customer_quality.ReadOnly = true;
            // 
            // customer_yxm
            // 
            this.customer_yxm.DataPropertyName = "customer_yxm";
            this.customer_yxm.HeaderText = "Column1";
            this.customer_yxm.Name = "customer_yxm";
            this.customer_yxm.ReadOnly = true;
            this.customer_yxm.Visible = false;
            // 
            // customer_bank
            // 
            this.customer_bank.DataPropertyName = "customer_bank";
            this.customer_bank.HeaderText = "Column2";
            this.customer_bank.Name = "customer_bank";
            this.customer_bank.ReadOnly = true;
            this.customer_bank.Visible = false;
            // 
            // customer_bank_num
            // 
            this.customer_bank_num.DataPropertyName = "customer_bank_num";
            this.customer_bank_num.HeaderText = "Column3";
            this.customer_bank_num.Name = "customer_bank_num";
            this.customer_bank_num.ReadOnly = true;
            this.customer_bank_num.Visible = false;
            // 
            // customer_tariff_num
            // 
            this.customer_tariff_num.DataPropertyName = "customer_tariff_num";
            this.customer_tariff_num.HeaderText = "Column4";
            this.customer_tariff_num.Name = "customer_tariff_num";
            this.customer_tariff_num.ReadOnly = true;
            this.customer_tariff_num.Visible = false;
            // 
            // customer_licence
            // 
            this.customer_licence.DataPropertyName = "customer_licence";
            this.customer_licence.HeaderText = "Column5";
            this.customer_licence.Name = "customer_licence";
            this.customer_licence.ReadOnly = true;
            this.customer_licence.Visible = false;
            // 
            // customer_business_licence
            // 
            this.customer_business_licence.DataPropertyName = "customer_business_licence";
            this.customer_business_licence.HeaderText = "Column6";
            this.customer_business_licence.Name = "customer_business_licence";
            this.customer_business_licence.ReadOnly = true;
            this.customer_business_licence.Visible = false;
            // 
            // customer_medical_institutions
            // 
            this.customer_medical_institutions.DataPropertyName = "customer_medical_institutions";
            this.customer_medical_institutions.HeaderText = "Column7";
            this.customer_medical_institutions.Name = "customer_medical_institutions";
            this.customer_medical_institutions.ReadOnly = true;
            this.customer_medical_institutions.Visible = false;
            // 
            // customer_type
            // 
            this.customer_type.DataPropertyName = "customer_type";
            this.customer_type.HeaderText = "客户性质";
            this.customer_type.Name = "customer_type";
            this.customer_type.ReadOnly = true;
            // 
            // customerDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(635, 460);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "customerDialogForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "客户单位列表";
            this.Load += new System.EventHandler(this.customerDialogForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txt_Customer_Select;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.TextBox txt_yxm_Select;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_artificial_person;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_principal;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_fax;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_postal_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_quality;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_yxm;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_bank;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_bank_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_tariff_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_licence;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_business_licence;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_medical_institutions;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_type;
    }
}