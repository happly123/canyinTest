namespace InvoicingApp
{
    partial class InStorageSelectForm
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
            this.btnSelect = new System.Windows.Forms.Button();
            this.dgvInputStorage = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGoodsName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateInputDateTo = new System.Windows.Forms.DateTimePicker();
            this.dateInputDateFrom = new System.Windows.Forms.DateTimePicker();
            this.checkDate = new System.Windows.Forms.CheckBox();
            this.comboxInputType = new System.Windows.Forms.ComboBox();
            this.txtInputCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INPUT_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GOODS_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUPPLIER_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maker_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INPUT_STANDARD_COUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input_batch_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INPUT_INSTORAGE_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INPUT_MAKETIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_validity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INPUT_CHECK_PERSION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input_issued = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input_checktime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInputStorage)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelect.Image = global::InvoicingApp.Properties.Resources.Search;
            this.btnSelect.Location = new System.Drawing.Point(734, 49);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 6;
            this.btnSelect.Text = "查询(&Q)";
            this.btnSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // dgvInputStorage
            // 
            this.dgvInputStorage.AllowUserToAddRows = false;
            this.dgvInputStorage.AllowUserToDeleteRows = false;
            this.dgvInputStorage.AllowUserToOrderColumns = true;
            this.dgvInputStorage.AllowUserToResizeRows = false;
            this.dgvInputStorage.BackgroundColor = System.Drawing.Color.White;
            this.dgvInputStorage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvInputStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvInputStorage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.INPUT_CODE,
            this.input_type,
            this.GOODS_NAME,
            this.goods_type,
            this.SUPPLIER_NAME,
            this.maker_name,
            this.INPUT_STANDARD_COUNT,
            this.input_batch_num,
            this.INPUT_INSTORAGE_DATE,
            this.INPUT_MAKETIME,
            this.goods_validity,
            this.INPUT_CHECK_PERSION,
            this.input_issued,
            this.input_checktime});
            this.dgvInputStorage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInputStorage.Location = new System.Drawing.Point(0, 5);
            this.dgvInputStorage.Name = "dgvInputStorage";
            this.dgvInputStorage.RowHeadersVisible = false;
            this.dgvInputStorage.RowTemplate.Height = 23;
            this.dgvInputStorage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInputStorage.Size = new System.Drawing.Size(994, 590);
            this.dgvInputStorage.TabIndex = 3;
            this.dgvInputStorage.Sorted += new System.EventHandler(this.dgvInputStorage_Sorted);
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrint.Image = global::InvoicingApp.Properties.Resources.Print;
            this.btnPrint.Location = new System.Drawing.Point(896, 49);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 8;
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
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "重置(&R)";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(470, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "入库类别:";
            // 
            // txtGoodsName
            // 
            this.txtGoodsName.Location = new System.Drawing.Point(88, 50);
            this.txtGoodsName.Name = "txtGoodsName";
            this.txtGoodsName.Size = new System.Drawing.Size(249, 21);
            this.txtGoodsName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "产品名称:";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "到:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateInputDateTo);
            this.groupBox1.Controls.Add(this.dateInputDateFrom);
            this.groupBox1.Controls.Add(this.checkDate);
            this.groupBox1.Controls.Add(this.comboxInputType);
            this.groupBox1.Controls.Add(this.txtInputCode);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnSelect);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtGoodsName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(994, 87);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "入库查询";
            // 
            // dateInputDateTo
            // 
            this.dateInputDateTo.CustomFormat = "yyyy-MM-dd";
            this.dateInputDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateInputDateTo.Location = new System.Drawing.Point(245, 20);
            this.dateInputDateTo.Name = "dateInputDateTo";
            this.dateInputDateTo.Size = new System.Drawing.Size(92, 21);
            this.dateInputDateTo.TabIndex = 1;
            // 
            // dateInputDateFrom
            // 
            this.dateInputDateFrom.CustomFormat = "yyyy-MM-dd";
            this.dateInputDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateInputDateFrom.Location = new System.Drawing.Point(88, 20);
            this.dateInputDateFrom.Name = "dateInputDateFrom";
            this.dateInputDateFrom.Size = new System.Drawing.Size(92, 21);
            this.dateInputDateFrom.TabIndex = 0;
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
            // comboxInputType
            // 
            this.comboxInputType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxInputType.FormattingEnabled = true;
            this.comboxInputType.Items.AddRange(new object[] {
            "初始入库",
            "购货入库",
            "赠品入库",
            "退货入库"});
            this.comboxInputType.Location = new System.Drawing.Point(551, 50);
            this.comboxInputType.Name = "comboxInputType";
            this.comboxInputType.Size = new System.Drawing.Size(146, 20);
            this.comboxInputType.TabIndex = 5;
            // 
            // txtInputCode
            // 
            this.txtInputCode.Location = new System.Drawing.Point(551, 20);
            this.txtInputCode.Name = "txtInputCode";
            this.txtInputCode.Size = new System.Drawing.Size(146, 21);
            this.txtInputCode.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(470, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "入库编号:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "入库日期:";
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
            // INPUT_CODE
            // 
            this.INPUT_CODE.DataPropertyName = "INPUT_CODE";
            this.INPUT_CODE.HeaderText = "入库编号";
            this.INPUT_CODE.Name = "INPUT_CODE";
            this.INPUT_CODE.ReadOnly = true;
            this.INPUT_CODE.Width = 130;
            // 
            // input_type
            // 
            this.input_type.DataPropertyName = "input_type";
            this.input_type.HeaderText = "入库类别";
            this.input_type.Name = "input_type";
            this.input_type.ReadOnly = true;
            this.input_type.Width = 80;
            // 
            // GOODS_NAME
            // 
            this.GOODS_NAME.DataPropertyName = "GOODS_NAME";
            this.GOODS_NAME.HeaderText = "产品名称";
            this.GOODS_NAME.Name = "GOODS_NAME";
            this.GOODS_NAME.ReadOnly = true;
            // 
            // goods_type
            // 
            this.goods_type.DataPropertyName = "goods_type";
            this.goods_type.HeaderText = "规格型号";
            this.goods_type.Name = "goods_type";
            this.goods_type.ReadOnly = true;
            // 
            // SUPPLIER_NAME
            // 
            this.SUPPLIER_NAME.DataPropertyName = "SUPPLIER_NAME";
            this.SUPPLIER_NAME.HeaderText = "供货商";
            this.SUPPLIER_NAME.Name = "SUPPLIER_NAME";
            this.SUPPLIER_NAME.ReadOnly = true;
            this.SUPPLIER_NAME.Width = 150;
            // 
            // maker_name
            // 
            this.maker_name.DataPropertyName = "maker_name";
            this.maker_name.HeaderText = "生产厂家";
            this.maker_name.Name = "maker_name";
            this.maker_name.ReadOnly = true;
            // 
            // INPUT_STANDARD_COUNT
            // 
            this.INPUT_STANDARD_COUNT.DataPropertyName = "INPUT_STANDARD_COUNT";
            this.INPUT_STANDARD_COUNT.HeaderText = "数量";
            this.INPUT_STANDARD_COUNT.Name = "INPUT_STANDARD_COUNT";
            this.INPUT_STANDARD_COUNT.ReadOnly = true;
            // 
            // input_batch_num
            // 
            this.input_batch_num.DataPropertyName = "input_batch_num";
            this.input_batch_num.HeaderText = "批号/设备号";
            this.input_batch_num.Name = "input_batch_num";
            this.input_batch_num.ReadOnly = true;
            // 
            // INPUT_INSTORAGE_DATE
            // 
            this.INPUT_INSTORAGE_DATE.DataPropertyName = "INPUT_INSTORAGE_DATE";
            this.INPUT_INSTORAGE_DATE.HeaderText = "入库日期";
            this.INPUT_INSTORAGE_DATE.Name = "INPUT_INSTORAGE_DATE";
            this.INPUT_INSTORAGE_DATE.ReadOnly = true;
            // 
            // INPUT_MAKETIME
            // 
            this.INPUT_MAKETIME.DataPropertyName = "INPUT_MAKETIME";
            this.INPUT_MAKETIME.HeaderText = "生产日期";
            this.INPUT_MAKETIME.Name = "INPUT_MAKETIME";
            this.INPUT_MAKETIME.ReadOnly = true;
            // 
            // goods_validity
            // 
            this.goods_validity.DataPropertyName = "goods_validity";
            this.goods_validity.HeaderText = "有效期(月)";
            this.goods_validity.Name = "goods_validity";
            this.goods_validity.ReadOnly = true;
            // 
            // INPUT_CHECK_PERSION
            // 
            this.INPUT_CHECK_PERSION.DataPropertyName = "INPUT_CHECK_PERSION";
            this.INPUT_CHECK_PERSION.HeaderText = "验收人";
            this.INPUT_CHECK_PERSION.Name = "INPUT_CHECK_PERSION";
            this.INPUT_CHECK_PERSION.ReadOnly = true;
            // 
            // input_issued
            // 
            this.input_issued.DataPropertyName = "input_issued";
            this.input_issued.HeaderText = "审核人";
            this.input_issued.Name = "input_issued";
            this.input_issued.ReadOnly = true;
            // 
            // input_checktime
            // 
            this.input_checktime.DataPropertyName = "input_checktime";
            this.input_checktime.HeaderText = "验收日期";
            this.input_checktime.Name = "input_checktime";
            this.input_checktime.ReadOnly = true;
            // 
            // InStorageSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1014, 702);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Name = "InStorageSelectForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "入库查询";
            this.Load += new System.EventHandler(this.InStorageSelectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInputStorage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DataGridView dgvInputStorage;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGoodsName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInputCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboxInputType;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox checkDate;
        private System.Windows.Forms.DateTimePicker dateInputDateFrom;
        private System.Windows.Forms.DateTimePicker dateInputDateTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn INPUT_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn input_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn GOODS_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUPPLIER_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn maker_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn INPUT_STANDARD_COUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn input_batch_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn INPUT_INSTORAGE_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn INPUT_MAKETIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_validity;
        private System.Windows.Forms.DataGridViewTextBoxColumn INPUT_CHECK_PERSION;
        private System.Windows.Forms.DataGridViewTextBoxColumn input_issued;
        private System.Windows.Forms.DataGridViewTextBoxColumn input_checktime;

    }
}