namespace InvoicingApp
{
    partial class DisqualificationManageForm
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_goods_yxm = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.textBox_goods_name = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_input_code = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView_Disqualification = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input_instorage_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_reg_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input_batch_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maker_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deal_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disqualification_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disqualificationNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.undeal_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.back = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destroy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_yxm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disqualification_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input_goods_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operate_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Disqualification)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_goods_yxm);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.textBox_goods_name);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_input_code);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(996, 87);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "产品管理查询";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(472, 52);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 16);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "是否选择日期";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(317, 50);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(133, 21);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(88, 50);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(133, 21);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "产品名称:";
            // 
            // btnPrint
            // 
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "入库编号:";
            // 
            // textBox_goods_yxm
            // 
            this.textBox_goods_yxm.Location = new System.Drawing.Point(558, 20);
            this.textBox_goods_yxm.MaxLength = 25;
            this.textBox_goods_yxm.Name = "textBox_goods_yxm";
            this.textBox_goods_yxm.Size = new System.Drawing.Size(100, 21);
            this.textBox_goods_yxm.TabIndex = 3;
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
            // textBox_goods_name
            // 
            this.textBox_goods_name.Location = new System.Drawing.Point(317, 20);
            this.textBox_goods_name.MaxLength = 25;
            this.textBox_goods_name.Name = "textBox_goods_name";
            this.textBox_goods_name.Size = new System.Drawing.Size(133, 21);
            this.textBox_goods_name.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::InvoicingApp.Properties.Resources.Search;
            this.btnSearch.Location = new System.Drawing.Point(734, 49);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "查询(&Q)";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "入库日期:";
            // 
            // textBox_input_code
            // 
            this.textBox_input_code.Location = new System.Drawing.Point(88, 20);
            this.textBox_input_code.MaxLength = 20;
            this.textBox_input_code.Name = "textBox_input_code";
            this.textBox_input_code.Size = new System.Drawing.Size(133, 21);
            this.textBox_input_code.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(472, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "产品音序码:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "到:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(996, 87);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(996, 682);
            this.panel2.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView_Disqualification);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 87);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel4.Size = new System.Drawing.Size(996, 595);
            this.panel4.TabIndex = 4;
            // 
            // dataGridView_Disqualification
            // 
            this.dataGridView_Disqualification.AllowUserToAddRows = false;
            this.dataGridView_Disqualification.AllowUserToDeleteRows = false;
            this.dataGridView_Disqualification.AllowUserToResizeRows = false;
            this.dataGridView_Disqualification.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Disqualification.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_Disqualification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_Disqualification.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.input_code,
            this.input_instorage_date,
            this.goods_name,
            this.goods_reg_num,
            this.input_batch_num,
            this.maker_name,
            this.goods_unit,
            this.deal_count,
            this.disqualification_count,
            this.disqualificationNum,
            this.undeal_count,
            this.back,
            this.destroy,
            this.edit,
            this.goods_yxm,
            this.disqualification_code,
            this.input_goods_code,
            this.operate_type});
            this.dataGridView_Disqualification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Disqualification.Location = new System.Drawing.Point(0, 5);
            this.dataGridView_Disqualification.MultiSelect = false;
            this.dataGridView_Disqualification.Name = "dataGridView_Disqualification";
            this.dataGridView_Disqualification.ReadOnly = true;
            this.dataGridView_Disqualification.RowHeadersVisible = false;
            this.dataGridView_Disqualification.RowTemplate.Height = 23;
            this.dataGridView_Disqualification.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Disqualification.Size = new System.Drawing.Size(996, 590);
            this.dataGridView_Disqualification.TabIndex = 1;
            this.dataGridView_Disqualification.TabStop = false;
            this.dataGridView_Disqualification.Sorted += new System.EventHandler(this.dataGridView_Disqualification_Sorted);
            this.dataGridView_Disqualification.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Disqualification_CellDoubleClick);
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
            this.input_code.Width = 136;
            // 
            // input_instorage_date
            // 
            this.input_instorage_date.DataPropertyName = "input_instorage_date";
            this.input_instorage_date.HeaderText = "入库日期";
            this.input_instorage_date.Name = "input_instorage_date";
            this.input_instorage_date.ReadOnly = true;
            // 
            // goods_name
            // 
            this.goods_name.DataPropertyName = "goods_name";
            this.goods_name.HeaderText = "产品名称";
            this.goods_name.Name = "goods_name";
            this.goods_name.ReadOnly = true;
            // 
            // goods_reg_num
            // 
            this.goods_reg_num.DataPropertyName = "goods_reg_num";
            this.goods_reg_num.HeaderText = "产品注册证号";
            this.goods_reg_num.Name = "goods_reg_num";
            this.goods_reg_num.ReadOnly = true;
            // 
            // input_batch_num
            // 
            this.input_batch_num.DataPropertyName = "input_batch_num";
            this.input_batch_num.HeaderText = "批号/设备号";
            this.input_batch_num.Name = "input_batch_num";
            this.input_batch_num.ReadOnly = true;
            // 
            // maker_name
            // 
            this.maker_name.DataPropertyName = "maker_name";
            this.maker_name.HeaderText = "生产厂家";
            this.maker_name.Name = "maker_name";
            this.maker_name.ReadOnly = true;
            this.maker_name.Width = 136;
            // 
            // goods_unit
            // 
            this.goods_unit.DataPropertyName = "goods_unit";
            this.goods_unit.HeaderText = "计量单位";
            this.goods_unit.Name = "goods_unit";
            this.goods_unit.ReadOnly = true;
            // 
            // deal_count
            // 
            this.deal_count.DataPropertyName = "deal_count";
            this.deal_count.HeaderText = "已处理数量";
            this.deal_count.Name = "deal_count";
            this.deal_count.ReadOnly = true;
            this.deal_count.Visible = false;
            this.deal_count.Width = 90;
            // 
            // disqualification_count
            // 
            this.disqualification_count.DataPropertyName = "disqualification_count";
            this.disqualification_count.HeaderText = "不合格数量1";
            this.disqualification_count.Name = "disqualification_count";
            this.disqualification_count.ReadOnly = true;
            this.disqualification_count.Visible = false;
            this.disqualification_count.Width = 90;
            // 
            // disqualificationNum
            // 
            this.disqualificationNum.DataPropertyName = "disqualificationNum";
            this.disqualificationNum.HeaderText = "不合格数量";
            this.disqualificationNum.Name = "disqualificationNum";
            this.disqualificationNum.ReadOnly = true;
            // 
            // undeal_count
            // 
            this.undeal_count.DataPropertyName = "undeal_count";
            this.undeal_count.HeaderText = "未处理数量";
            this.undeal_count.Name = "undeal_count";
            this.undeal_count.ReadOnly = true;
            this.undeal_count.Width = 90;
            // 
            // back
            // 
            this.back.DataPropertyName = "back";
            this.back.HeaderText = "返厂";
            this.back.Name = "back";
            this.back.ReadOnly = true;
            // 
            // destroy
            // 
            this.destroy.DataPropertyName = "destroy";
            this.destroy.HeaderText = "销毁";
            this.destroy.Name = "destroy";
            this.destroy.ReadOnly = true;
            // 
            // edit
            // 
            this.edit.DataPropertyName = "edit";
            this.edit.HeaderText = "维修";
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            // 
            // goods_yxm
            // 
            this.goods_yxm.DataPropertyName = "goods_yxm";
            this.goods_yxm.HeaderText = "产品音序码";
            this.goods_yxm.Name = "goods_yxm";
            this.goods_yxm.ReadOnly = true;
            this.goods_yxm.Visible = false;
            // 
            // disqualification_code
            // 
            this.disqualification_code.DataPropertyName = "disqualification_code";
            this.disqualification_code.HeaderText = "不合格产品编号";
            this.disqualification_code.Name = "disqualification_code";
            this.disqualification_code.ReadOnly = true;
            this.disqualification_code.Visible = false;
            // 
            // input_goods_code
            // 
            this.input_goods_code.DataPropertyName = "input_goods_code";
            this.input_goods_code.HeaderText = "产品编号";
            this.input_goods_code.Name = "input_goods_code";
            this.input_goods_code.ReadOnly = true;
            this.input_goods_code.Visible = false;
            // 
            // operate_type
            // 
            this.operate_type.DataPropertyName = "operate_type";
            this.operate_type.HeaderText = "操作标识";
            this.operate_type.Name = "operate_type";
            this.operate_type.ReadOnly = true;
            this.operate_type.Visible = false;
            // 
            // DisqualificationManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1016, 702);
            this.Controls.Add(this.panel2);
            this.Name = "DisqualificationManageForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "不合格产品管理";
            this.Load += new System.EventHandler(this.DisqualificationManageForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Disqualification)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_goods_yxm;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox textBox_goods_name;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_input_code;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView_Disqualification;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn input_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn input_instorage_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_reg_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn input_batch_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn maker_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn deal_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn disqualification_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn disqualificationNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn undeal_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn back;
        private System.Windows.Forms.DataGridViewTextBoxColumn destroy;
        private System.Windows.Forms.DataGridViewTextBoxColumn edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_yxm;
        private System.Windows.Forms.DataGridViewTextBoxColumn disqualification_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn input_goods_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn operate_type;

    }
}