namespace InvoicingApp
{
    partial class InventoryCountForm
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.txtGoodsName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_goods_yxm = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_storage = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maker_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_validity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_storage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Image = global::InvoicingApp.Properties.Resources.Print;
            this.btnPrint.Location = new System.Drawing.Point(734, 19);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "打印(&P)";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClear
            // 
            this.btnClear.Image = global::InvoicingApp.Properties.Resources.Reset;
            this.btnClear.Location = new System.Drawing.Point(896, 19);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "重置(&R)";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCount
            // 
            this.btnCount.Image = global::InvoicingApp.Properties.Resources.PieChart;
            this.btnCount.Location = new System.Drawing.Point(815, 19);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 3;
            this.btnCount.Text = "统计(&T)";
            this.btnCount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // txtGoodsName
            // 
            this.txtGoodsName.Location = new System.Drawing.Point(88, 20);
            this.txtGoodsName.MaxLength = 25;
            this.txtGoodsName.Name = "txtGoodsName";
            this.txtGoodsName.Size = new System.Drawing.Size(146, 21);
            this.txtGoodsName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "产品名称:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_goods_yxm);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnCount);
            this.groupBox1.Controls.Add(this.txtGoodsName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(996, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "库存统计";
            // 
            // txt_goods_yxm
            // 
            this.txt_goods_yxm.Location = new System.Drawing.Point(366, 20);
            this.txt_goods_yxm.MaxLength = 25;
            this.txt_goods_yxm.Name = "txt_goods_yxm";
            this.txt_goods_yxm.Size = new System.Drawing.Size(146, 21);
            this.txt_goods_yxm.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(256, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 12);
            this.label8.TabIndex = 24;
            this.label8.Text = "产品名称音序码:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView_storage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(10, 70);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel2.Size = new System.Drawing.Size(996, 622);
            this.panel2.TabIndex = 16;
            // 
            // dataGridView_storage
            // 
            this.dataGridView_storage.AllowUserToAddRows = false;
            this.dataGridView_storage.AllowUserToDeleteRows = false;
            this.dataGridView_storage.AllowUserToOrderColumns = true;
            this.dataGridView_storage.AllowUserToResizeRows = false;
            this.dataGridView_storage.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_storage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_storage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_storage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.goods_name,
            this.goods_type,
            this.maker_name,
            this.goods_unit,
            this.count,
            this.goods_validity});
            this.dataGridView_storage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_storage.Location = new System.Drawing.Point(0, 5);
            this.dataGridView_storage.Name = "dataGridView_storage";
            this.dataGridView_storage.RowHeadersVisible = false;
            this.dataGridView_storage.RowTemplate.Height = 23;
            this.dataGridView_storage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_storage.Size = new System.Drawing.Size(996, 617);
            this.dataGridView_storage.TabIndex = 0;
            this.dataGridView_storage.TabStop = false;
            this.dataGridView_storage.Sorted += new System.EventHandler(this.dataGridView_storage_Sorted);
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
            // goods_type
            // 
            this.goods_type.DataPropertyName = "goods_type";
            this.goods_type.HeaderText = "规格型号";
            this.goods_type.Name = "goods_type";
            this.goods_type.ReadOnly = true;
            // 
            // maker_name
            // 
            this.maker_name.DataPropertyName = "maker_name";
            this.maker_name.HeaderText = "生产厂家";
            this.maker_name.Name = "maker_name";
            this.maker_name.ReadOnly = true;
            // 
            // goods_unit
            // 
            this.goods_unit.DataPropertyName = "goods_unit";
            this.goods_unit.HeaderText = "计量单位";
            this.goods_unit.Name = "goods_unit";
            this.goods_unit.ReadOnly = true;
            // 
            // count
            // 
            this.count.DataPropertyName = "count";
            this.count.HeaderText = "库存数量";
            this.count.Name = "count";
            this.count.ReadOnly = true;
            // 
            // goods_validity
            // 
            this.goods_validity.DataPropertyName = "goods_validity";
            this.goods_validity.HeaderText = "有效期(月)";
            this.goods_validity.Name = "goods_validity";
            this.goods_validity.ReadOnly = true;
            // 
            // InventoryCountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1016, 702);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Name = "InventoryCountForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "库存统计";
            this.Load += new System.EventHandler(this.InventoryCountForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_storage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.TextBox txtGoodsName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView_storage;
        private System.Windows.Forms.TextBox txt_goods_yxm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn maker_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_validity;


    }
}