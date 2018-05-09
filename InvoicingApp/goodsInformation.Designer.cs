namespace InvoicingApp
{
    partial class goodsInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(goodsInformation));
            this.dataGridView_goods = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_reg_mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_reg_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maker_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_validity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_yxm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_storemethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_appliance_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maker_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_maker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_goods_name = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.textBox_goods_yxm = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_goods)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_goods
            // 
            this.dataGridView_goods.AllowUserToAddRows = false;
            this.dataGridView_goods.AllowUserToDeleteRows = false;
            this.dataGridView_goods.AllowUserToResizeRows = false;
            this.dataGridView_goods.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_goods.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_goods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_goods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.goods_code,
            this.goods_name,
            this.goods_reg_mark,
            this.goods_type,
            this.goods_reg_num,
            this.maker_name,
            this.goods_validity,
            this.goods_unit,
            this.goods_yxm,
            this.goods_storemethod,
            this.goods_appliance_code,
            this.maker_code,
            this.goods_maker});
            this.dataGridView_goods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_goods.Location = new System.Drawing.Point(0, 5);
            this.dataGridView_goods.MultiSelect = false;
            this.dataGridView_goods.Name = "dataGridView_goods";
            this.dataGridView_goods.RowHeadersVisible = false;
            this.dataGridView_goods.RowTemplate.Height = 23;
            this.dataGridView_goods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_goods.Size = new System.Drawing.Size(790, 367);
            this.dataGridView_goods.TabIndex = 2;
            this.dataGridView_goods.TabStop = false;
            this.dataGridView_goods.Sorted += new System.EventHandler(this.dataGridView_goods_Sorted);
            this.dataGridView_goods.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_goods_CellDoubleClick);
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
            // goods_code
            // 
            this.goods_code.DataPropertyName = "goods_code";
            this.goods_code.HeaderText = "产品编号";
            this.goods_code.Name = "goods_code";
            this.goods_code.ReadOnly = true;
            this.goods_code.Visible = false;
            this.goods_code.Width = 130;
            // 
            // goods_name
            // 
            this.goods_name.DataPropertyName = "goods_name";
            this.goods_name.HeaderText = "产品名称";
            this.goods_name.Name = "goods_name";
            this.goods_name.ReadOnly = true;
            // 
            // goods_reg_mark
            // 
            this.goods_reg_mark.DataPropertyName = "goods_reg_mark";
            this.goods_reg_mark.HeaderText = "注册商标";
            this.goods_reg_mark.Name = "goods_reg_mark";
            this.goods_reg_mark.ReadOnly = true;
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
            // goods_validity
            // 
            this.goods_validity.DataPropertyName = "goods_validity";
            this.goods_validity.HeaderText = "有效期";
            this.goods_validity.Name = "goods_validity";
            this.goods_validity.ReadOnly = true;
            // 
            // goods_unit
            // 
            this.goods_unit.DataPropertyName = "goods_unit";
            this.goods_unit.HeaderText = "计量单位";
            this.goods_unit.Name = "goods_unit";
            this.goods_unit.Visible = false;
            // 
            // goods_yxm
            // 
            this.goods_yxm.DataPropertyName = "goods_yxm";
            this.goods_yxm.HeaderText = "产品音序码";
            this.goods_yxm.Name = "goods_yxm";
            this.goods_yxm.ReadOnly = true;
            this.goods_yxm.Visible = false;
            // 
            // goods_storemethod
            // 
            this.goods_storemethod.DataPropertyName = "goods_storemethod";
            this.goods_storemethod.HeaderText = "储藏方法";
            this.goods_storemethod.Name = "goods_storemethod";
            this.goods_storemethod.ReadOnly = true;
            this.goods_storemethod.Visible = false;
            // 
            // goods_appliance_code
            // 
            this.goods_appliance_code.DataPropertyName = "goods_appliance_code";
            this.goods_appliance_code.HeaderText = "器械代码";
            this.goods_appliance_code.Name = "goods_appliance_code";
            this.goods_appliance_code.ReadOnly = true;
            this.goods_appliance_code.Visible = false;
            // 
            // maker_code
            // 
            this.maker_code.DataPropertyName = "maker_code";
            this.maker_code.HeaderText = "生产厂家编号";
            this.maker_code.Name = "maker_code";
            this.maker_code.Visible = false;
            // 
            // goods_maker
            // 
            this.goods_maker.DataPropertyName = "goods_maker";
            this.goods_maker.HeaderText = "生产厂家编号1";
            this.goods_maker.Name = "goods_maker";
            this.goods_maker.Visible = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Image = global::InvoicingApp.Properties.Resources.Ok;
            this.btnConfirm.Location = new System.Drawing.Point(591, 24);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "确定(&O)";
            this.btnConfirm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "产品名称:";
            // 
            // textBox_goods_name
            // 
            this.textBox_goods_name.Location = new System.Drawing.Point(88, 20);
            this.textBox_goods_name.MaxLength = 25;
            this.textBox_goods_name.Name = "textBox_goods_name";
            this.textBox_goods_name.Size = new System.Drawing.Size(168, 21);
            this.textBox_goods_name.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::InvoicingApp.Properties.Resources.Search;
            this.btnSearch.Location = new System.Drawing.Point(591, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "查询(&Q)";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.textBox_goods_yxm);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.textBox_goods_name);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // btnReset
            // 
            this.btnReset.Image = global::InvoicingApp.Properties.Resources.Reset;
            this.btnReset.Location = new System.Drawing.Point(672, 19);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "重置(&R)";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // textBox_goods_yxm
            // 
            this.textBox_goods_yxm.Location = new System.Drawing.Point(364, 20);
            this.textBox_goods_yxm.Name = "textBox_goods_yxm";
            this.textBox_goods_yxm.Size = new System.Drawing.Size(155, 21);
            this.textBox_goods_yxm.TabIndex = 2;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(278, 24);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(71, 12);
            this.label22.TabIndex = 9;
            this.label22.Text = "产品音序码:";
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::InvoicingApp.Properties.Resources.Close;
            this.btnCancel.Location = new System.Drawing.Point(672, 24);
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
            this.btnInsert.Location = new System.Drawing.Point(16, 24);
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
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(5, 437);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel1.Size = new System.Drawing.Size(790, 61);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView_goods);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(5, 65);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel2.Size = new System.Drawing.Size(790, 372);
            this.panel2.TabIndex = 3;
            // 
            // goodsInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(806, 535);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(806, 535);
            this.Name = "goodsInformation";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "产品名称列表";
            this.Load += new System.EventHandler(this.goodsInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_goods)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_goods;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_goods_name;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox textBox_goods_yxm;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_reg_mark;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_reg_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn maker_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_validity;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_yxm;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_storemethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_appliance_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn maker_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_maker;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}