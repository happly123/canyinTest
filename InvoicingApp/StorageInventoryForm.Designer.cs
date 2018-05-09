namespace InvoicingApp
{
    partial class StorageInventoryForm
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
            this.btnCheck = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instorage_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsValidity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maker_yxm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_yxm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox_input_code = new System.Windows.Forms.TextBox();
            this.textBox_goods_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateInputDateTo = new System.Windows.Forms.DateTimePicker();
            this.dateInputDateFrom = new System.Windows.Forms.DateTimePicker();
            this.checkDate = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_maker_yxm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_maker_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_goods_yxm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Image = global::InvoicingApp.Properties.Resources.Print;
            this.btnPrint.Location = new System.Drawing.Point(836, 18);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "打印(&P)";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
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
            // btnCheck
            // 
            this.btnCheck.Image = global::InvoicingApp.Properties.Resources.Check;
            this.btnCheck.Location = new System.Drawing.Point(815, 80);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 6;
            this.btnCheck.Text = "盘点(&W)";
            this.btnCheck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(10, 124);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel2.Size = new System.Drawing.Size(996, 533);
            this.panel2.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.instorage_type,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn14,
            this.goodsValidity,
            this.maker_yxm,
            this.goods_yxm,
            this.dataGridViewTextBoxColumn13});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(996, 528);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.Sorted += new System.EventHandler(this.dataGridView1_Sorted);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "goods_name";
            this.dataGridViewTextBoxColumn1.HeaderText = "产品名称";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "input_code";
            this.dataGridViewTextBoxColumn2.HeaderText = "入库编号";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 130;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "goods_type";
            this.dataGridViewTextBoxColumn3.HeaderText = "规格型号";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "maker_name";
            this.dataGridViewTextBoxColumn4.HeaderText = "生产厂家";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "goods_unit";
            this.dataGridViewTextBoxColumn5.HeaderText = "计量单位";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // instorage_type
            // 
            this.instorage_type.DataPropertyName = "instorage_type";
            this.instorage_type.HeaderText = "入库类别";
            this.instorage_type.Name = "instorage_type";
            this.instorage_type.ReadOnly = true;
            this.instorage_type.Width = 80;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "input_count";
            this.dataGridViewTextBoxColumn6.HeaderText = "入库数量";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "output_count";
            this.dataGridViewTextBoxColumn7.HeaderText = "出库数量";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "lose_count";
            this.dataGridViewTextBoxColumn8.HeaderText = "报损数量";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "storage_count";
            this.dataGridViewTextBoxColumn9.HeaderText = "库存数量";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "input_batch_num";
            this.dataGridViewTextBoxColumn11.HeaderText = "批号/设备号";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "input_maketime";
            this.dataGridViewTextBoxColumn12.HeaderText = "生产日期";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "input_instorage_date";
            this.dataGridViewTextBoxColumn14.HeaderText = "入库日期";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // goodsValidity
            // 
            this.goodsValidity.DataPropertyName = "goodsValidity";
            this.goodsValidity.HeaderText = "有效期至";
            this.goodsValidity.Name = "goodsValidity";
            this.goodsValidity.ReadOnly = true;
            // 
            // maker_yxm
            // 
            this.maker_yxm.DataPropertyName = "maker_yxm";
            this.maker_yxm.HeaderText = "生产厂家音序码";
            this.maker_yxm.Name = "maker_yxm";
            this.maker_yxm.Visible = false;
            // 
            // goods_yxm
            // 
            this.goods_yxm.DataPropertyName = "goods_yxm";
            this.goods_yxm.HeaderText = "产品名称音序码";
            this.goods_yxm.Name = "goods_yxm";
            this.goods_yxm.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "goods_validity";
            this.dataGridViewTextBoxColumn13.HeaderText = "有效期";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Visible = false;
            // 
            // textBox_input_code
            // 
            this.textBox_input_code.Location = new System.Drawing.Point(88, 20);
            this.textBox_input_code.MaxLength = 20;
            this.textBox_input_code.Name = "textBox_input_code";
            this.textBox_input_code.Size = new System.Drawing.Size(146, 21);
            this.textBox_input_code.TabIndex = 1;
            // 
            // textBox_goods_name
            // 
            this.textBox_goods_name.Location = new System.Drawing.Point(88, 50);
            this.textBox_goods_name.MaxLength = 25;
            this.textBox_goods_name.Name = "textBox_goods_name";
            this.textBox_goods_name.Size = new System.Drawing.Size(146, 21);
            this.textBox_goods_name.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "入库编号:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateInputDateTo);
            this.groupBox1.Controls.Add(this.dateInputDateFrom);
            this.groupBox1.Controls.Add(this.checkDate);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBox_maker_yxm);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_maker_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_goods_yxm);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.btnCheck);
            this.groupBox1.Controls.Add(this.textBox_input_code);
            this.groupBox1.Controls.Add(this.textBox_goods_name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(996, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "库存盘点";
            // 
            // dateInputDateTo
            // 
            this.dateInputDateTo.CustomFormat = "yyyy-MM-dd";
            this.dateInputDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateInputDateTo.Location = new System.Drawing.Point(245, 80);
            this.dateInputDateTo.Name = "dateInputDateTo";
            this.dateInputDateTo.Size = new System.Drawing.Size(92, 21);
            this.dateInputDateTo.TabIndex = 27;
            // 
            // dateInputDateFrom
            // 
            this.dateInputDateFrom.CustomFormat = "yyyy-MM-dd";
            this.dateInputDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateInputDateFrom.Location = new System.Drawing.Point(88, 80);
            this.dateInputDateFrom.Name = "dateInputDateFrom";
            this.dateInputDateFrom.Size = new System.Drawing.Size(92, 21);
            this.dateInputDateFrom.TabIndex = 26;
            // 
            // checkDate
            // 
            this.checkDate.AutoSize = true;
            this.checkDate.Checked = true;
            this.checkDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkDate.Location = new System.Drawing.Point(366, 84);
            this.checkDate.Name = "checkDate";
            this.checkDate.Size = new System.Drawing.Size(96, 16);
            this.checkDate.TabIndex = 28;
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
            this.label10.TabIndex = 30;
            this.label10.Text = "到:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 12);
            this.label11.TabIndex = 29;
            this.label11.Text = "入库日期:";
            // 
            // textBox_maker_yxm
            // 
            this.textBox_maker_yxm.Location = new System.Drawing.Point(620, 20);
            this.textBox_maker_yxm.MaxLength = 25;
            this.textBox_maker_yxm.Name = "textBox_maker_yxm";
            this.textBox_maker_yxm.Size = new System.Drawing.Size(122, 21);
            this.textBox_maker_yxm.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(510, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 25;
            this.label2.Text = "生产厂家音序码:";
            // 
            // textBox_maker_name
            // 
            this.textBox_maker_name.Location = new System.Drawing.Point(366, 20);
            this.textBox_maker_name.MaxLength = 25;
            this.textBox_maker_name.Name = "textBox_maker_name";
            this.textBox_maker_name.Size = new System.Drawing.Size(122, 21);
            this.textBox_maker_name.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "生产厂家:";
            // 
            // textBox_goods_yxm
            // 
            this.textBox_goods_yxm.Location = new System.Drawing.Point(366, 50);
            this.textBox_goods_yxm.MaxLength = 25;
            this.textBox_goods_yxm.Name = "textBox_goods_yxm";
            this.textBox_goods_yxm.Size = new System.Drawing.Size(122, 21);
            this.textBox_goods_yxm.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 12);
            this.label5.TabIndex = 23;
            this.label5.Text = "产品名称音序码:";
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
            // panel3
            // 
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(10, 657);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(996, 35);
            this.panel3.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(551, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 12);
            this.label9.TabIndex = 25;
            this.label9.Text = "近有效期六个月";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Green;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Location = new System.Drawing.Point(521, 9);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(15, 15);
            this.panel7.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(409, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 12);
            this.label8.TabIndex = 24;
            this.label8.Text = "近有效期三个月";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Yellow;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Location = new System.Drawing.Point(378, 9);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(15, 15);
            this.panel6.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(266, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 23;
            this.label7.Text = "近有效期一个月";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Bisque;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Location = new System.Drawing.Point(236, 9);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(15, 15);
            this.panel5.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "已经过有效期";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Location = new System.Drawing.Point(103, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(15, 15);
            this.panel4.TabIndex = 0;
            // 
            // StorageInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1016, 702);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Name = "StorageInventoryForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "库存盘点";
            this.Load += new System.EventHandler(this.StorageInventoryForm_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_input_code;
        private System.Windows.Forms.TextBox textBox_goods_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_maker_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_maker_yxm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_goods_yxm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn instorage_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsValidity;
        private System.Windows.Forms.DataGridViewTextBoxColumn maker_yxm;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_yxm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DateTimePicker dateInputDateTo;
        private System.Windows.Forms.DateTimePicker dateInputDateFrom;
        private System.Windows.Forms.CheckBox checkDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}