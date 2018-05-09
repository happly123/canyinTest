namespace InvoicingApp
{
    partial class OutStorageCountForm
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
            this.components = new System.ComponentModel.Container();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkDate = new System.Windows.Forms.CheckBox();
            this.dtp_output_instorage_date_End = new System.Windows.Forms.DateTimePicker();
            this.dtp_output_instorage_date_Start = new System.Windows.Forms.DateTimePicker();
            this.cmb_output_type = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_goods_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvOutputStorage = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maker_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.out_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_validity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutputStorage)).BeginInit();
            this.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkDate);
            this.groupBox1.Controls.Add(this.dtp_output_instorage_date_End);
            this.groupBox1.Controls.Add(this.dtp_output_instorage_date_Start);
            this.groupBox1.Controls.Add(this.cmb_output_type);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_goods_name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnStatistics);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(994, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "出库统计";
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
            // dtp_output_instorage_date_End
            // 
            this.dtp_output_instorage_date_End.CustomFormat = "yyyy-MM-dd";
            this.dtp_output_instorage_date_End.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_output_instorage_date_End.Location = new System.Drawing.Point(245, 20);
            this.dtp_output_instorage_date_End.Name = "dtp_output_instorage_date_End";
            this.dtp_output_instorage_date_End.Size = new System.Drawing.Size(92, 21);
            this.dtp_output_instorage_date_End.TabIndex = 1;
            // 
            // dtp_output_instorage_date_Start
            // 
            this.dtp_output_instorage_date_Start.CustomFormat = "yyyy-MM-dd";
            this.dtp_output_instorage_date_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_output_instorage_date_Start.Location = new System.Drawing.Point(88, 20);
            this.dtp_output_instorage_date_Start.Name = "dtp_output_instorage_date_Start";
            this.dtp_output_instorage_date_Start.Size = new System.Drawing.Size(92, 21);
            this.dtp_output_instorage_date_Start.TabIndex = 0;
            // 
            // cmb_output_type
            // 
            this.cmb_output_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_output_type.FormattingEnabled = true;
            this.cmb_output_type.Items.AddRange(new object[] {
            "销售出库",
            "退货出库"});
            this.cmb_output_type.Location = new System.Drawing.Point(433, 50);
            this.cmb_output_type.Name = "cmb_output_type";
            this.cmb_output_type.Size = new System.Drawing.Size(144, 20);
            this.cmb_output_type.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "出库类别:";
            // 
            // txt_goods_name
            // 
            this.txt_goods_name.Location = new System.Drawing.Point(88, 50);
            this.txt_goods_name.Name = "txt_goods_name";
            this.txt_goods_name.Size = new System.Drawing.Size(249, 21);
            this.txt_goods_name.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "产品名称:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "到:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "出库日期:";
            // 
            // btnStatistics
            // 
            this.btnStatistics.Image = global::InvoicingApp.Properties.Resources.PieChart;
            this.btnStatistics.Location = new System.Drawing.Point(815, 49);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(75, 23);
            this.btnStatistics.TabIndex = 5;
            this.btnStatistics.Text = "统计(&T)";
            this.btnStatistics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvOutputStorage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(10, 97);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel2.Size = new System.Drawing.Size(994, 595);
            this.panel2.TabIndex = 14;
            // 
            // dgvOutputStorage
            // 
            this.dgvOutputStorage.AllowUserToAddRows = false;
            this.dgvOutputStorage.AllowUserToDeleteRows = false;
            this.dgvOutputStorage.AllowUserToResizeRows = false;
            this.dgvOutputStorage.BackgroundColor = System.Drawing.Color.White;
            this.dgvOutputStorage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvOutputStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOutputStorage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.goods_name,
            this.goods_type,
            this.maker_name,
            this.goods_unit,
            this.out_count,
            this.goods_validity});
            this.dgvOutputStorage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOutputStorage.Location = new System.Drawing.Point(0, 5);
            this.dgvOutputStorage.Name = "dgvOutputStorage";
            this.dgvOutputStorage.RowHeadersVisible = false;
            this.dgvOutputStorage.RowTemplate.Height = 23;
            this.dgvOutputStorage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOutputStorage.Size = new System.Drawing.Size(994, 590);
            this.dgvOutputStorage.TabIndex = 5;
            this.dgvOutputStorage.TabStop = false;
            this.dgvOutputStorage.Sorted += new System.EventHandler(this.dgvOutputStorage_Sorted);
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
            this.goods_name.Width = 80;
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
            // out_count
            // 
            this.out_count.DataPropertyName = "out_count";
            this.out_count.HeaderText = "销售/退货数量";
            this.out_count.Name = "out_count";
            this.out_count.ReadOnly = true;
            this.out_count.Width = 150;
            // 
            // goods_validity
            // 
            this.goods_validity.DataPropertyName = "goods_validity";
            this.goods_validity.HeaderText = "有效期(月)";
            this.goods_validity.Name = "goods_validity";
            this.goods_validity.ReadOnly = true;
            this.goods_validity.Visible = false;
            // 
            // OutStorageCountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1014, 702);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Name = "OutStorageCountForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "出库统计";
            this.Load += new System.EventHandler(this.OutStorageCountForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutputStorage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvOutputStorage;
        private System.Windows.Forms.ComboBox cmb_output_type;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_goods_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DateTimePicker dtp_output_instorage_date_Start;
        private System.Windows.Forms.DateTimePicker dtp_output_instorage_date_End;
        private System.Windows.Forms.CheckBox checkDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn maker_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn out_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_validity;

    }
}