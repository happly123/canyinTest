namespace InvoicingApp
{
    partial class OutStorageSelectForm
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
            this.dgvOutputStorage = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.output_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OUTSTORAGE_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maker_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.output_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input_batch_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_reg_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input_maketime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.output_instorage_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.output_check_persion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.output_checktime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_validity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.output_remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.output_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkDate = new System.Windows.Forms.CheckBox();
            this.dtp_output_instorage_date_End = new System.Windows.Forms.DateTimePicker();
            this.dtp_output_instorage_date_Start = new System.Windows.Forms.DateTimePicker();
            this.cmb_output_type = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_goods_name = new System.Windows.Forms.TextBox();
            this.txt_output_code = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutputStorage)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.output_code,
            this.OUTSTORAGE_TYPE,
            this.goods_name,
            this.goods_type,
            this.supplier_name,
            this.maker_name,
            this.output_count,
            this.input_batch_num,
            this.goods_reg_num,
            this.customer_name,
            this.goods_unit,
            this.input_maketime,
            this.output_instorage_date,
            this.output_check_persion,
            this.output_checktime,
            this.goods_validity,
            this.output_remark,
            this.input_code,
            this.output_type});
            this.dgvOutputStorage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOutputStorage.Location = new System.Drawing.Point(0, 5);
            this.dgvOutputStorage.Name = "dgvOutputStorage";
            this.dgvOutputStorage.RowHeadersVisible = false;
            this.dgvOutputStorage.RowTemplate.Height = 23;
            this.dgvOutputStorage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOutputStorage.Size = new System.Drawing.Size(994, 590);
            this.dgvOutputStorage.TabIndex = 0;
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
            // output_code
            // 
            this.output_code.DataPropertyName = "output_code";
            this.output_code.HeaderText = "出库编号";
            this.output_code.Name = "output_code";
            this.output_code.ReadOnly = true;
            this.output_code.Width = 130;
            // 
            // OUTSTORAGE_TYPE
            // 
            this.OUTSTORAGE_TYPE.DataPropertyName = "OUTSTORAGE_TYPE";
            this.OUTSTORAGE_TYPE.HeaderText = "出库类别";
            this.OUTSTORAGE_TYPE.Name = "OUTSTORAGE_TYPE";
            this.OUTSTORAGE_TYPE.ReadOnly = true;
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
            // supplier_name
            // 
            this.supplier_name.DataPropertyName = "supplier_name";
            this.supplier_name.HeaderText = "供货商";
            this.supplier_name.Name = "supplier_name";
            this.supplier_name.ReadOnly = true;
            this.supplier_name.Width = 150;
            // 
            // maker_name
            // 
            this.maker_name.DataPropertyName = "maker_name";
            this.maker_name.HeaderText = "生产厂家";
            this.maker_name.Name = "maker_name";
            this.maker_name.ReadOnly = true;
            // 
            // output_count
            // 
            this.output_count.DataPropertyName = "output_count";
            this.output_count.HeaderText = "数量";
            this.output_count.Name = "output_count";
            this.output_count.ReadOnly = true;
            this.output_count.Width = 120;
            // 
            // input_batch_num
            // 
            this.input_batch_num.DataPropertyName = "input_batch_num";
            this.input_batch_num.HeaderText = "批号/设备号";
            this.input_batch_num.Name = "input_batch_num";
            this.input_batch_num.ReadOnly = true;
            // 
            // goods_reg_num
            // 
            this.goods_reg_num.DataPropertyName = "goods_reg_num";
            this.goods_reg_num.HeaderText = "产品注册证号";
            this.goods_reg_num.Name = "goods_reg_num";
            this.goods_reg_num.ReadOnly = true;
            // 
            // customer_name
            // 
            this.customer_name.DataPropertyName = "customer_name";
            this.customer_name.HeaderText = "客户名称";
            this.customer_name.Name = "customer_name";
            this.customer_name.ReadOnly = true;
            // 
            // goods_unit
            // 
            this.goods_unit.DataPropertyName = "goods_unit";
            this.goods_unit.HeaderText = "计量单位";
            this.goods_unit.Name = "goods_unit";
            this.goods_unit.ReadOnly = true;
            // 
            // input_maketime
            // 
            this.input_maketime.DataPropertyName = "input_maketime";
            this.input_maketime.HeaderText = "生产日期";
            this.input_maketime.Name = "input_maketime";
            this.input_maketime.ReadOnly = true;
            // 
            // output_instorage_date
            // 
            this.output_instorage_date.DataPropertyName = "output_instorage_date";
            this.output_instorage_date.HeaderText = "出库日期";
            this.output_instorage_date.Name = "output_instorage_date";
            this.output_instorage_date.ReadOnly = true;
            // 
            // output_check_persion
            // 
            this.output_check_persion.DataPropertyName = "output_check_persion";
            this.output_check_persion.HeaderText = "验收人";
            this.output_check_persion.Name = "output_check_persion";
            this.output_check_persion.ReadOnly = true;
            // 
            // output_checktime
            // 
            this.output_checktime.DataPropertyName = "output_checktime";
            this.output_checktime.HeaderText = "验收日期";
            this.output_checktime.Name = "output_checktime";
            this.output_checktime.ReadOnly = true;
            // 
            // goods_validity
            // 
            this.goods_validity.DataPropertyName = "goods_validity";
            this.goods_validity.HeaderText = "有效期(月)";
            this.goods_validity.Name = "goods_validity";
            this.goods_validity.ReadOnly = true;
            this.goods_validity.Visible = false;
            // 
            // output_remark
            // 
            this.output_remark.DataPropertyName = "output_remark";
            this.output_remark.HeaderText = "备注";
            this.output_remark.Name = "output_remark";
            this.output_remark.ReadOnly = true;
            this.output_remark.Visible = false;
            // 
            // input_code
            // 
            this.input_code.DataPropertyName = "input_code";
            this.input_code.HeaderText = "入库编号";
            this.input_code.Name = "input_code";
            this.input_code.ReadOnly = true;
            this.input_code.Width = 130;
            // 
            // output_type
            // 
            this.output_type.DataPropertyName = "output_type";
            this.output_type.HeaderText = "出库类别编号";
            this.output_type.Name = "output_type";
            this.output_type.ReadOnly = true;
            this.output_type.Visible = false;
            this.output_type.Width = 80;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvOutputStorage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(10, 97);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel2.Size = new System.Drawing.Size(994, 595);
            this.panel2.TabIndex = 7;
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::InvoicingApp.Properties.Resources.Print;
            this.btnPrint.Location = new System.Drawing.Point(896, 49);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "打印(&P)";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClear
            // 
            this.btnClear.Image = global::InvoicingApp.Properties.Resources.Reset;
            this.btnClear.Location = new System.Drawing.Point(815, 49);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "重置(&R)";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnFind
            // 
            this.btnFind.Image = global::InvoicingApp.Properties.Resources.Search;
            this.btnFind.Location = new System.Drawing.Point(734, 49);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 5;
            this.btnFind.Text = "查询(&Q)";
            this.btnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkDate);
            this.groupBox1.Controls.Add(this.dtp_output_instorage_date_End);
            this.groupBox1.Controls.Add(this.dtp_output_instorage_date_Start);
            this.groupBox1.Controls.Add(this.cmb_output_type);
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_goods_name);
            this.groupBox1.Controls.Add(this.txt_output_code);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(994, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "出库查询";
            // 
            // checkDate
            // 
            this.checkDate.AutoSize = true;
            this.checkDate.Checked = true;
            this.checkDate.CheckState = System.Windows.Forms.CheckState.Checked;
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
            this.cmb_output_type.Location = new System.Drawing.Point(551, 50);
            this.cmb_output_type.Name = "cmb_output_type";
            this.cmb_output_type.Size = new System.Drawing.Size(146, 20);
            this.cmb_output_type.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(470, 54);
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
            // txt_output_code
            // 
            this.txt_output_code.Location = new System.Drawing.Point(551, 20);
            this.txt_output_code.Name = "txt_output_code";
            this.txt_output_code.Size = new System.Drawing.Size(146, 21);
            this.txt_output_code.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "产品名称:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "出库编号:";
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
            // OutStorageSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1014, 702);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Name = "OutStorageSelectForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "出库查询";
            this.Load += new System.EventHandler(this.OutStorageSelectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutputStorage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOutputStorage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_goods_name;
        private System.Windows.Forms.TextBox txt_output_code;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_output_type;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DateTimePicker dtp_output_instorage_date_Start;
        private System.Windows.Forms.DateTimePicker dtp_output_instorage_date_End;
        private System.Windows.Forms.CheckBox checkDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn output_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn OUTSTORAGE_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn maker_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn output_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn input_batch_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_reg_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn input_maketime;
        private System.Windows.Forms.DataGridViewTextBoxColumn output_instorage_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn output_check_persion;
        private System.Windows.Forms.DataGridViewTextBoxColumn output_checktime;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_validity;
        private System.Windows.Forms.DataGridViewTextBoxColumn output_remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn input_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn output_type;
    }
}