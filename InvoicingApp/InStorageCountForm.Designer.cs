namespace InvoicingApp
{
    partial class InStorageCountForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkDate = new System.Windows.Forms.CheckBox();
            this.dtp_InputDateTo = new System.Windows.Forms.DateTimePicker();
            this.dtp_InputDateFrom = new System.Windows.Forms.DateTimePicker();
            this.comboxInputType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGoodsName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvInputStorage = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maker_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_validity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInputStorage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkDate);
            this.groupBox1.Controls.Add(this.dtp_InputDateTo);
            this.groupBox1.Controls.Add(this.dtp_InputDateFrom);
            this.groupBox1.Controls.Add(this.comboxInputType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnCount);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtGoodsName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(994, 87);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "入库统计";
            // 
            // checkDate
            // 
            this.checkDate.AutoSize = true;
            this.checkDate.Location = new System.Drawing.Point(359, 22);
            this.checkDate.Name = "checkDate";
            this.checkDate.Size = new System.Drawing.Size(96, 16);
            this.checkDate.TabIndex = 2;
            this.checkDate.Text = "是否选择日期";
            this.checkDate.UseVisualStyleBackColor = true;
            this.checkDate.CheckedChanged += new System.EventHandler(this.checkDate_CheckedChanged);
            // 
            // dtp_InputDateTo
            // 
            this.dtp_InputDateTo.CustomFormat = "yyy-MM-dd";
            this.dtp_InputDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_InputDateTo.Location = new System.Drawing.Point(245, 20);
            this.dtp_InputDateTo.Name = "dtp_InputDateTo";
            this.dtp_InputDateTo.Size = new System.Drawing.Size(92, 21);
            this.dtp_InputDateTo.TabIndex = 1;
            // 
            // dtp_InputDateFrom
            // 
            this.dtp_InputDateFrom.CustomFormat = "yyy-MM-dd";
            this.dtp_InputDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_InputDateFrom.Location = new System.Drawing.Point(88, 20);
            this.dtp_InputDateFrom.Name = "dtp_InputDateFrom";
            this.dtp_InputDateFrom.Size = new System.Drawing.Size(92, 21);
            this.dtp_InputDateFrom.TabIndex = 0;
            // 
            // comboxInputType
            // 
            this.comboxInputType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxInputType.FormattingEnabled = true;
            this.comboxInputType.Items.AddRange(new object[] {
            "初始入库",
            "购货入库",
            "赠品入库",
            "退货入库"});
            this.comboxInputType.Location = new System.Drawing.Point(433, 50);
            this.comboxInputType.Name = "comboxInputType";
            this.comboxInputType.Size = new System.Drawing.Size(144, 20);
            this.comboxInputType.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 33;
            this.label3.Text = "产品名称:";
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::InvoicingApp.Properties.Resources.Print;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrint.Location = new System.Drawing.Point(734, 49);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = " 打印(&P)";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.Image = global::InvoicingApp.Properties.Resources.Reset;
            this.btnClear.Location = new System.Drawing.Point(896, 49);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "重置(&R)";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCount
            // 
            this.btnCount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCount.Image = global::InvoicingApp.Properties.Resources.PieChart;
            this.btnCount.Location = new System.Drawing.Point(815, 49);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 5;
            this.btnCount.Text = "统计(&T)";
            this.btnCount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 28;
            this.label6.Text = "入库类别:";
            // 
            // txtGoodsName
            // 
            this.txtGoodsName.Location = new System.Drawing.Point(88, 50);
            this.txtGoodsName.Name = "txtGoodsName";
            this.txtGoodsName.Size = new System.Drawing.Size(249, 21);
            this.txtGoodsName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "到:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "入库日期:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvInputStorage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(10, 97);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel2.Size = new System.Drawing.Size(994, 595);
            this.panel2.TabIndex = 10;
            // 
            // dgvInputStorage
            // 
            this.dgvInputStorage.AllowUserToAddRows = false;
            this.dgvInputStorage.AllowUserToDeleteRows = false;
            this.dgvInputStorage.AllowUserToResizeRows = false;
            this.dgvInputStorage.BackgroundColor = System.Drawing.Color.White;
            this.dgvInputStorage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvInputStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvInputStorage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.goods_name,
            this.goods_type,
            this.maker_name,
            this.goods_unit,
            this.input_count,
            this.goods_validity});
            this.dgvInputStorage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInputStorage.Location = new System.Drawing.Point(0, 5);
            this.dgvInputStorage.Name = "dgvInputStorage";
            this.dgvInputStorage.RowHeadersVisible = false;
            this.dgvInputStorage.RowTemplate.Height = 23;
            this.dgvInputStorage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInputStorage.Size = new System.Drawing.Size(994, 590);
            this.dgvInputStorage.TabIndex = 4;
            this.dgvInputStorage.Sorted += new System.EventHandler(this.dgvInputStorage_Sorted);
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
            this.goods_name.Width = 150;
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
            this.maker_name.Width = 150;
            // 
            // goods_unit
            // 
            this.goods_unit.DataPropertyName = "goods_unit";
            this.goods_unit.HeaderText = "计量单位";
            this.goods_unit.Name = "goods_unit";
            this.goods_unit.ReadOnly = true;
            // 
            // input_count
            // 
            this.input_count.DataPropertyName = "input_count";
            this.input_count.HeaderText = "数量";
            this.input_count.Name = "input_count";
            this.input_count.ReadOnly = true;
            // 
            // goods_validity
            // 
            this.goods_validity.DataPropertyName = "goods_validity";
            this.goods_validity.HeaderText = "有效期(月)";
            this.goods_validity.Name = "goods_validity";
            this.goods_validity.ReadOnly = true;
            // 
            // InStorageCountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1014, 702);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Name = "InStorageCountForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "入库统计";
            this.Load += new System.EventHandler(this.InStorageCountForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInputStorage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvInputStorage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGoodsName;
        private System.Windows.Forms.ComboBox comboxInputType;
        private System.Windows.Forms.DateTimePicker dtp_InputDateFrom;
        private System.Windows.Forms.DateTimePicker dtp_InputDateTo;
        private System.Windows.Forms.CheckBox checkDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn maker_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn input_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_validity;


    }
}