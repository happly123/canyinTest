namespace InvoicingApp
{
    partial class manufacturerManageDialogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manufacturerManageDialogForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtMaker_yxmSelect = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaker_nameSelect = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maker_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maker_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maker_yxm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maker_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maker_quality_reg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maker_business_scope = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maker_business_goods = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maker_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maker_principal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maker_postal_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maker_hygiene = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maker_licence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 440);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnInsert);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 391);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(615, 49);
            this.panel3.TabIndex = 1;
            // 
            // btnInsert
            // 
            this.btnInsert.Image = global::InvoicingApp.Properties.Resources.Add;
            this.btnInsert.Location = new System.Drawing.Point(14, 13);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 12;
            this.btnInsert.Text = "增加(&A)";
            this.btnInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::InvoicingApp.Properties.Resources.Close;
            this.btnCancel.Location = new System.Drawing.Point(521, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "关闭(&C)";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::InvoicingApp.Properties.Resources.Ok;
            this.btnSave.Location = new System.Drawing.Point(440, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "确定(&O)";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(615, 313);
            this.panel2.TabIndex = 0;
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
            this.maker_code,
            this.index,
            this.maker_name,
            this.maker_yxm,
            this.maker_address,
            this.maker_quality_reg,
            this.maker_business_scope,
            this.maker_business_goods,
            this.maker_tel,
            this.maker_principal,
            this.maker_postal_code,
            this.maker_hygiene,
            this.maker_licence});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(615, 313);
            this.dgv.TabIndex = 1;
            this.dgv.Sorted += new System.EventHandler(this.dgv_Sorted);
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.txtMaker_yxmSelect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaker_nameSelect);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 60);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "生产厂家查询";
            // 
            // btnClear
            // 
            this.btnClear.Image = global::InvoicingApp.Properties.Resources.Reset;
            this.btnClear.Location = new System.Drawing.Point(521, 19);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "重置(&R)";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnFind
            // 
            this.btnFind.Image = global::InvoicingApp.Properties.Resources.Search;
            this.btnFind.Location = new System.Drawing.Point(440, 19);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 15;
            this.btnFind.Text = "查询(&Q)";
            this.btnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtMaker_yxmSelect
            // 
            this.txtMaker_yxmSelect.Location = new System.Drawing.Point(316, 20);
            this.txtMaker_yxmSelect.Name = "txtMaker_yxmSelect";
            this.txtMaker_yxmSelect.Size = new System.Drawing.Size(95, 21);
            this.txtMaker_yxmSelect.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "厂家音序码:";
            // 
            // txtMaker_nameSelect
            // 
            this.txtMaker_nameSelect.Location = new System.Drawing.Point(88, 20);
            this.txtMaker_nameSelect.Name = "txtMaker_nameSelect";
            this.txtMaker_nameSelect.Size = new System.Drawing.Size(120, 21);
            this.txtMaker_nameSelect.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "厂家名称:";
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
            // index
            // 
            this.index.DataPropertyName = "index";
            this.index.HeaderText = "序号";
            this.index.Name = "index";
            this.index.ReadOnly = true;
            this.index.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.index.Width = 55;
            // 
            // maker_name
            // 
            this.maker_name.DataPropertyName = "maker_name";
            this.maker_name.HeaderText = "厂家名称";
            this.maker_name.Name = "maker_name";
            this.maker_name.ReadOnly = true;
            this.maker_name.Width = 130;
            // 
            // maker_yxm
            // 
            this.maker_yxm.DataPropertyName = "maker_yxm";
            this.maker_yxm.HeaderText = "音序码";
            this.maker_yxm.Name = "maker_yxm";
            this.maker_yxm.ReadOnly = true;
            this.maker_yxm.Visible = false;
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
            this.maker_quality_reg.Visible = false;
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
            this.maker_business_goods.Width = 170;
            // 
            // maker_tel
            // 
            this.maker_tel.DataPropertyName = "maker_tel";
            this.maker_tel.HeaderText = "电话";
            this.maker_tel.Name = "maker_tel";
            this.maker_tel.ReadOnly = true;
            this.maker_tel.Visible = false;
            // 
            // maker_principal
            // 
            this.maker_principal.DataPropertyName = "maker_principal";
            this.maker_principal.HeaderText = "联系人";
            this.maker_principal.Name = "maker_principal";
            this.maker_principal.ReadOnly = true;
            this.maker_principal.Visible = false;
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
            // manufacturerManageDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(635, 460);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(641, 492);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(641, 492);
            this.Name = "manufacturerManageDialogForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "生产厂家列表";
            this.Load += new System.EventHandler(this.ManufacturerManageForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMaker_yxmSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaker_nameSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridViewTextBoxColumn maker_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn maker_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn maker_yxm;
        private System.Windows.Forms.DataGridViewTextBoxColumn maker_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn maker_quality_reg;
        private System.Windows.Forms.DataGridViewTextBoxColumn maker_business_scope;
        private System.Windows.Forms.DataGridViewTextBoxColumn maker_business_goods;
        private System.Windows.Forms.DataGridViewTextBoxColumn maker_tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn maker_principal;
        private System.Windows.Forms.DataGridViewTextBoxColumn maker_postal_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn maker_hygiene;
        private System.Windows.Forms.DataGridViewTextBoxColumn maker_licence;
    }
}