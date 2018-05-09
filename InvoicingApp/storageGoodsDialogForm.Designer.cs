namespace InvoicingApp
{
    partial class storageGoodsDialogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(storageGoodsDialogForm));
            this.btnFind = new System.Windows.Forms.Button();
            this.txt_goods_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCommit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.txt_input_code = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nud_output_count = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvStorageGoods = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.剩余数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input_instorage_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_reg_mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_validity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.output_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lose_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input_maketime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_output_count)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorageGoods)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.Image = global::InvoicingApp.Properties.Resources.Search;
            this.btnFind.Location = new System.Drawing.Point(464, 19);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "查询(&Q)";
            this.btnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txt_goods_name
            // 
            this.txt_goods_name.Location = new System.Drawing.Point(325, 20);
            this.txt_goods_name.Name = "txt_goods_name";
            this.txt_goods_name.Size = new System.Drawing.Size(133, 21);
            this.txt_goods_name.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "产品名称:";
            // 
            // btnCommit
            // 
            this.btnCommit.Image = global::InvoicingApp.Properties.Resources.Ok;
            this.btnCommit.Location = new System.Drawing.Point(464, 12);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(76, 23);
            this.btnCommit.TabIndex = 2;
            this.btnCommit.Text = "确定(&O)";
            this.btnCommit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.txt_input_code);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_goods_name);
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // btnReset
            // 
            this.btnReset.Image = global::InvoicingApp.Properties.Resources.Reset;
            this.btnReset.Location = new System.Drawing.Point(545, 19);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "重置(&R)";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txt_input_code
            // 
            this.txt_input_code.Location = new System.Drawing.Point(88, 20);
            this.txt_input_code.Name = "txt_input_code";
            this.txt_input_code.Size = new System.Drawing.Size(141, 21);
            this.txt_input_code.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(14, 24);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(59, 12);
            this.label.TabIndex = 0;
            this.label.Text = "入库编号:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "XXXX数量:";
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::InvoicingApp.Properties.Resources.Close;
            this.btnCancel.Location = new System.Drawing.Point(545, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "关闭(&C)";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nud_output_count);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnCommit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(5, 385);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel2.Size = new System.Drawing.Size(645, 50);
            this.panel2.TabIndex = 7;
            // 
            // nud_output_count
            // 
            this.nud_output_count.Location = new System.Drawing.Point(88, 14);
            this.nud_output_count.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nud_output_count.Name = "nud_output_count";
            this.nud_output_count.Size = new System.Drawing.Size(141, 21);
            this.nud_output_count.TabIndex = 4;
            this.nud_output_count.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nud_output_count_KeyUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvStorageGoods);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 65);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel1.Size = new System.Drawing.Size(645, 320);
            this.panel1.TabIndex = 8;
            // 
            // dgvStorageGoods
            // 
            this.dgvStorageGoods.AllowUserToAddRows = false;
            this.dgvStorageGoods.AllowUserToDeleteRows = false;
            this.dgvStorageGoods.AllowUserToResizeRows = false;
            this.dgvStorageGoods.BackgroundColor = System.Drawing.Color.White;
            this.dgvStorageGoods.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvStorageGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStorageGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.goods_name,
            this.supplier_name,
            this.剩余数量,
            this.input_code,
            this.goods_code,
            this.input_instorage_date,
            this.goods_reg_mark,
            this.goods_type,
            this.goods_validity,
            this.input_count,
            this.output_count,
            this.lose_count,
            this.input_maketime});
            this.dgvStorageGoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStorageGoods.Location = new System.Drawing.Point(0, 5);
            this.dgvStorageGoods.MultiSelect = false;
            this.dgvStorageGoods.Name = "dgvStorageGoods";
            this.dgvStorageGoods.RowHeadersVisible = false;
            this.dgvStorageGoods.RowTemplate.Height = 23;
            this.dgvStorageGoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStorageGoods.Size = new System.Drawing.Size(645, 315);
            this.dgvStorageGoods.TabIndex = 5;
            this.dgvStorageGoods.TabStop = false;
            this.dgvStorageGoods.Sorted += new System.EventHandler(this.dgvStorageGoods_Sorted);
            this.dgvStorageGoods.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStorageGoods_CellDoubleClick);
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
            // 
            // supplier_name
            // 
            this.supplier_name.DataPropertyName = "supplier_name";
            this.supplier_name.HeaderText = "供货商";
            this.supplier_name.Name = "supplier_name";
            this.supplier_name.ReadOnly = true;
            // 
            // 剩余数量
            // 
            this.剩余数量.DataPropertyName = "剩余数量";
            this.剩余数量.HeaderText = "实际剩余数量";
            this.剩余数量.Name = "剩余数量";
            this.剩余数量.ReadOnly = true;
            // 
            // input_code
            // 
            this.input_code.DataPropertyName = "input_code";
            this.input_code.HeaderText = "入库编号";
            this.input_code.Name = "input_code";
            this.input_code.ReadOnly = true;
            this.input_code.Width = 130;
            // 
            // goods_code
            // 
            this.goods_code.DataPropertyName = "goods_code";
            this.goods_code.HeaderText = "产品编号";
            this.goods_code.Name = "goods_code";
            this.goods_code.Visible = false;
            // 
            // input_instorage_date
            // 
            this.input_instorage_date.DataPropertyName = "input_instorage_date";
            this.input_instorage_date.HeaderText = "入库日期";
            this.input_instorage_date.Name = "input_instorage_date";
            this.input_instorage_date.ReadOnly = true;
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
            // goods_validity
            // 
            this.goods_validity.DataPropertyName = "goods_validity";
            this.goods_validity.HeaderText = "有效期(月)";
            this.goods_validity.Name = "goods_validity";
            this.goods_validity.ReadOnly = true;
            // 
            // input_count
            // 
            this.input_count.DataPropertyName = "input_count";
            this.input_count.HeaderText = "验收数量";
            this.input_count.Name = "input_count";
            this.input_count.Visible = false;
            // 
            // output_count
            // 
            this.output_count.DataPropertyName = "output_count";
            this.output_count.HeaderText = "销售数量";
            this.output_count.Name = "output_count";
            this.output_count.Visible = false;
            // 
            // lose_count
            // 
            this.lose_count.DataPropertyName = "lose_count";
            this.lose_count.HeaderText = "报损数量";
            this.lose_count.Name = "lose_count";
            this.lose_count.Visible = false;
            // 
            // input_maketime
            // 
            this.input_maketime.DataPropertyName = "input_maketime";
            this.input_maketime.HeaderText = "生产日期";
            this.input_maketime.Name = "input_maketime";
            // 
            // storageGoodsDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(655, 440);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "storageGoodsDialogForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "产品库存临时列表";
            this.Load += new System.EventHandler(this.storageGoodsDialogForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_output_count)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorageGoods)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txt_goods_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_input_code;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown nud_output_count;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvStorageGoods;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn 剩余数量;
        private System.Windows.Forms.DataGridViewTextBoxColumn input_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn input_instorage_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_reg_mark;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_validity;
        private System.Windows.Forms.DataGridViewTextBoxColumn input_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn output_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn lose_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn input_maketime;
    }
}