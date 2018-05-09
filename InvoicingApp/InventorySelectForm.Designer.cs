namespace InvoicingApp
{
    partial class InventorySelectForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_storage = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instorage_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maker_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input_batch_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.output_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lose_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storage_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input_check_persion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input_checktime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input_maketime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input_instorage_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsValidity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_validity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maker_yxm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_yxm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox_input_code = new System.Windows.Forms.TextBox();
            this.textBox_maker_name = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_maker_yxm = new System.Windows.Forms.TextBox();
            this.textBox_goods_yxm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.textBox_goods_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dateInputDateTo = new System.Windows.Forms.DateTimePicker();
            this.dateInputDateFrom = new System.Windows.Forms.DateTimePicker();
            this.checkDate = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_storage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView_storage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(10, 124);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel2.Size = new System.Drawing.Size(996, 533);
            this.panel2.TabIndex = 7;
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
            this.input_code,
            this.instorage_type,
            this.goods_name,
            this.goods_type,
            this.maker_name,
            this.input_batch_num,
            this.input_count,
            this.output_count,
            this.lose_count,
            this.storage_count,
            this.goods_unit,
            this.input_check_persion,
            this.input_checktime,
            this.input_maketime,
            this.input_instorage_date,
            this.goodsValidity,
            this.goods_validity,
            this.maker_yxm,
            this.goods_yxm});
            this.dataGridView_storage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_storage.Location = new System.Drawing.Point(0, 5);
            this.dataGridView_storage.Name = "dataGridView_storage";
            this.dataGridView_storage.ReadOnly = true;
            this.dataGridView_storage.RowHeadersVisible = false;
            this.dataGridView_storage.RowTemplate.Height = 23;
            this.dataGridView_storage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_storage.Size = new System.Drawing.Size(996, 528);
            this.dataGridView_storage.TabIndex = 0;
            this.dataGridView_storage.TabStop = false;
            this.dataGridView_storage.Sorted += new System.EventHandler(this.dataGridView_storage_Sorted);
            this.dataGridView_storage.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_storage_DataBindingComplete);
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
            // input_code
            // 
            this.input_code.DataPropertyName = "input_code";
            this.input_code.HeaderText = "入库编号";
            this.input_code.Name = "input_code";
            this.input_code.ReadOnly = true;
            this.input_code.Width = 130;
            // 
            // instorage_type
            // 
            this.instorage_type.DataPropertyName = "instorage_type";
            this.instorage_type.HeaderText = "入库类别";
            this.instorage_type.Name = "instorage_type";
            this.instorage_type.ReadOnly = true;
            this.instorage_type.Width = 80;
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
            // input_batch_num
            // 
            this.input_batch_num.DataPropertyName = "input_batch_num";
            this.input_batch_num.HeaderText = "批号/设备号";
            this.input_batch_num.Name = "input_batch_num";
            this.input_batch_num.ReadOnly = true;
            // 
            // input_count
            // 
            this.input_count.DataPropertyName = "input_count";
            this.input_count.HeaderText = "入库数量";
            this.input_count.Name = "input_count";
            this.input_count.ReadOnly = true;
            // 
            // output_count
            // 
            this.output_count.DataPropertyName = "output_count";
            this.output_count.HeaderText = "出库数量";
            this.output_count.Name = "output_count";
            this.output_count.ReadOnly = true;
            // 
            // lose_count
            // 
            this.lose_count.DataPropertyName = "lose_count";
            this.lose_count.HeaderText = "报损数量";
            this.lose_count.Name = "lose_count";
            this.lose_count.ReadOnly = true;
            // 
            // storage_count
            // 
            this.storage_count.DataPropertyName = "storage_count";
            this.storage_count.HeaderText = "库存数量";
            this.storage_count.Name = "storage_count";
            this.storage_count.ReadOnly = true;
            // 
            // goods_unit
            // 
            this.goods_unit.DataPropertyName = "goods_unit";
            this.goods_unit.HeaderText = "计量单位";
            this.goods_unit.Name = "goods_unit";
            this.goods_unit.ReadOnly = true;
            // 
            // input_check_persion
            // 
            this.input_check_persion.DataPropertyName = "input_check_persion";
            this.input_check_persion.HeaderText = "验收人";
            this.input_check_persion.Name = "input_check_persion";
            this.input_check_persion.ReadOnly = true;
            // 
            // input_checktime
            // 
            this.input_checktime.DataPropertyName = "input_checktime";
            this.input_checktime.HeaderText = "验收日期";
            this.input_checktime.Name = "input_checktime";
            this.input_checktime.ReadOnly = true;
            // 
            // input_maketime
            // 
            this.input_maketime.DataPropertyName = "input_maketime";
            this.input_maketime.HeaderText = "生产日期";
            this.input_maketime.Name = "input_maketime";
            this.input_maketime.ReadOnly = true;
            // 
            // input_instorage_date
            // 
            this.input_instorage_date.DataPropertyName = "input_instorage_date";
            this.input_instorage_date.HeaderText = "入库日期";
            this.input_instorage_date.Name = "input_instorage_date";
            this.input_instorage_date.ReadOnly = true;
            // 
            // goodsValidity
            // 
            this.goodsValidity.DataPropertyName = "goodsValidity";
            this.goodsValidity.HeaderText = "有效期至";
            this.goodsValidity.Name = "goodsValidity";
            this.goodsValidity.ReadOnly = true;
            // 
            // goods_validity
            // 
            this.goods_validity.DataPropertyName = "goods_validity";
            this.goods_validity.HeaderText = "有效期";
            this.goods_validity.Name = "goods_validity";
            this.goods_validity.ReadOnly = true;
            this.goods_validity.Visible = false;
            // 
            // maker_yxm
            // 
            this.maker_yxm.DataPropertyName = "maker_yxm";
            this.maker_yxm.HeaderText = "生产厂家音序码";
            this.maker_yxm.Name = "maker_yxm";
            this.maker_yxm.ReadOnly = true;
            this.maker_yxm.Visible = false;
            // 
            // goods_yxm
            // 
            this.goods_yxm.DataPropertyName = "goods_yxm";
            this.goods_yxm.HeaderText = "产品名称音序码";
            this.goods_yxm.Name = "goods_yxm";
            this.goods_yxm.ReadOnly = true;
            this.goods_yxm.Visible = false;
            // 
            // textBox_input_code
            // 
            this.textBox_input_code.Location = new System.Drawing.Point(88, 20);
            this.textBox_input_code.MaxLength = 20;
            this.textBox_input_code.Name = "textBox_input_code";
            this.textBox_input_code.Size = new System.Drawing.Size(146, 21);
            this.textBox_input_code.TabIndex = 1;
            // 
            // textBox_maker_name
            // 
            this.textBox_maker_name.Location = new System.Drawing.Point(366, 20);
            this.textBox_maker_name.MaxLength = 25;
            this.textBox_maker_name.Name = "textBox_maker_name";
            this.textBox_maker_name.Size = new System.Drawing.Size(158, 21);
            this.textBox_maker_name.TabIndex = 2;
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Image = global::InvoicingApp.Properties.Resources.Print;
            this.btnPrint.Location = new System.Drawing.Point(898, 20);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "打印(&P)";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.Image = global::InvoicingApp.Properties.Resources.Reset;
            this.btnClear.Location = new System.Drawing.Point(896, 80);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "重置(&R)";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateInputDateTo);
            this.groupBox1.Controls.Add(this.dateInputDateFrom);
            this.groupBox1.Controls.Add(this.checkDate);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBox_maker_yxm);
            this.groupBox1.Controls.Add(this.textBox_goods_yxm);
            this.groupBox1.Controls.Add(this.textBox_input_code);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_maker_name);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnCheck);
            this.groupBox1.Controls.Add(this.textBox_goods_name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(996, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "库存查询";
            // 
            // textBox_maker_yxm
            // 
            this.textBox_maker_yxm.Location = new System.Drawing.Point(656, 20);
            this.textBox_maker_yxm.MaxLength = 25;
            this.textBox_maker_yxm.Name = "textBox_maker_yxm";
            this.textBox_maker_yxm.Size = new System.Drawing.Size(112, 21);
            this.textBox_maker_yxm.TabIndex = 3;
            // 
            // textBox_goods_yxm
            // 
            this.textBox_goods_yxm.Location = new System.Drawing.Point(366, 50);
            this.textBox_goods_yxm.MaxLength = 25;
            this.textBox_goods_yxm.Name = "textBox_goods_yxm";
            this.textBox_goods_yxm.Size = new System.Drawing.Size(158, 21);
            this.textBox_goods_yxm.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 12);
            this.label4.TabIndex = 22;
            this.label4.Text = "产品名称音序码:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(546, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 12);
            this.label5.TabIndex = 21;
            this.label5.Text = "生产厂家音序码:";
            // 
            // btnCheck
            // 
            this.btnCheck.Image = global::InvoicingApp.Properties.Resources.Search;
            this.btnCheck.Location = new System.Drawing.Point(815, 80);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 6;
            this.btnCheck.Text = "查询(&Q)";
            this.btnCheck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // textBox_goods_name
            // 
            this.textBox_goods_name.Location = new System.Drawing.Point(88, 50);
            this.textBox_goods_name.MaxLength = 25;
            this.textBox_goods_name.Name = "textBox_goods_name";
            this.textBox_goods_name.Size = new System.Drawing.Size(146, 21);
            this.textBox_goods_name.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "产品名称:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "生产厂家:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "入库编号:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(10, 657);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(996, 35);
            this.panel3.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(551, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 12);
            this.label9.TabIndex = 33;
            this.label9.Text = "近有效期六个月";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(266, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 28;
            this.label7.Text = "近有效期一个月";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Green;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Location = new System.Drawing.Point(521, 9);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(15, 15);
            this.panel7.TabIndex = 30;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Location = new System.Drawing.Point(103, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(15, 15);
            this.panel4.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(409, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 12);
            this.label8.TabIndex = 32;
            this.label8.Text = "近有效期三个月";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 27;
            this.label6.Text = "已经过有效期";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Yellow;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Location = new System.Drawing.Point(378, 9);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(15, 15);
            this.panel6.TabIndex = 31;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Bisque;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Location = new System.Drawing.Point(236, 9);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(15, 15);
            this.panel5.TabIndex = 29;
            // 
            // dateInputDateTo
            // 
            this.dateInputDateTo.CustomFormat = "yyyy-MM-dd";
            this.dateInputDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateInputDateTo.Location = new System.Drawing.Point(245, 80);
            this.dateInputDateTo.Name = "dateInputDateTo";
            this.dateInputDateTo.Size = new System.Drawing.Size(92, 21);
            this.dateInputDateTo.TabIndex = 32;
            // 
            // dateInputDateFrom
            // 
            this.dateInputDateFrom.CustomFormat = "yyyy-MM-dd";
            this.dateInputDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateInputDateFrom.Location = new System.Drawing.Point(88, 80);
            this.dateInputDateFrom.Name = "dateInputDateFrom";
            this.dateInputDateFrom.Size = new System.Drawing.Size(92, 21);
            this.dateInputDateFrom.TabIndex = 31;
            // 
            // checkDate
            // 
            this.checkDate.AutoSize = true;
            this.checkDate.Checked = true;
            this.checkDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkDate.Location = new System.Drawing.Point(366, 84);
            this.checkDate.Name = "checkDate";
            this.checkDate.Size = new System.Drawing.Size(96, 16);
            this.checkDate.TabIndex = 33;
            this.checkDate.Text = "是否选择日期";
            this.checkDate.UseVisualStyleBackColor = true;
            this.checkDate.CheckedChanged += new System.EventHandler(this.checkDate_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(200, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 12);
            this.label10.TabIndex = 35;
            this.label10.Text = "到:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 12);
            this.label11.TabIndex = 34;
            this.label11.Text = "入库日期:";
            // 
            // InventorySelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1016, 702);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Name = "InventorySelectForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "库存查询";
            this.Load += new System.EventHandler(this.InventorySelectForm_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_storage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_input_code;
        private System.Windows.Forms.TextBox textBox_maker_name;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox textBox_goods_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_storage;
        private System.Windows.Forms.TextBox textBox_maker_yxm;
        private System.Windows.Forms.TextBox textBox_goods_yxm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn input_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn instorage_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn maker_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn input_batch_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn input_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn output_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn lose_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn storage_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn input_check_persion;
        private System.Windows.Forms.DataGridViewTextBoxColumn input_checktime;
        private System.Windows.Forms.DataGridViewTextBoxColumn input_maketime;
        private System.Windows.Forms.DataGridViewTextBoxColumn input_instorage_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsValidity;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_validity;
        private System.Windows.Forms.DataGridViewTextBoxColumn maker_yxm;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_yxm;
        private System.Windows.Forms.DateTimePicker dateInputDateTo;
        private System.Windows.Forms.DateTimePicker dateInputDateFrom;
        private System.Windows.Forms.CheckBox checkDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}