namespace InvoicingApp
{
    partial class CheckRecordSelectForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkDate = new System.Windows.Forms.CheckBox();
            this.dtp_input_checktime_End = new System.Windows.Forms.DateTimePicker();
            this.dtp_input_checktime_Start = new System.Windows.Forms.DateTimePicker();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txt_goods_yxm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_goods_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRecordValidate = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sn_sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maker_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input_standard_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input_batch_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input_quality_reg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_reg_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_validity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quality_info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input_check_persion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.check_info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input_checktime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_licence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecordValidate)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkDate);
            this.groupBox1.Controls.Add(this.dtp_input_checktime_End);
            this.groupBox1.Controls.Add(this.dtp_input_checktime_Start);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.txt_goods_yxm);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_goods_name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(994, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "验收记录查询";
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
            // dtp_input_checktime_End
            // 
            this.dtp_input_checktime_End.CustomFormat = "yyyy-MM-dd";
            this.dtp_input_checktime_End.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_input_checktime_End.Location = new System.Drawing.Point(245, 20);
            this.dtp_input_checktime_End.Name = "dtp_input_checktime_End";
            this.dtp_input_checktime_End.Size = new System.Drawing.Size(92, 21);
            this.dtp_input_checktime_End.TabIndex = 1;
            // 
            // dtp_input_checktime_Start
            // 
            this.dtp_input_checktime_Start.CustomFormat = "yyyy-MM-dd";
            this.dtp_input_checktime_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_input_checktime_Start.Location = new System.Drawing.Point(88, 20);
            this.dtp_input_checktime_Start.Name = "dtp_input_checktime_Start";
            this.dtp_input_checktime_Start.Size = new System.Drawing.Size(92, 21);
            this.dtp_input_checktime_Start.TabIndex = 0;
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
            // btnPrint
            // 
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
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
            // txt_goods_yxm
            // 
            this.txt_goods_yxm.Location = new System.Drawing.Point(445, 51);
            this.txt_goods_yxm.Name = "txt_goods_yxm";
            this.txt_goods_yxm.Size = new System.Drawing.Size(117, 21);
            this.txt_goods_yxm.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "产品音序码:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "产品名称:";
            // 
            // txt_goods_name
            // 
            this.txt_goods_name.Location = new System.Drawing.Point(88, 51);
            this.txt_goods_name.Name = "txt_goods_name";
            this.txt_goods_name.Size = new System.Drawing.Size(249, 21);
            this.txt_goods_name.TabIndex = 3;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "验收日期:";
            // 
            // dgvRecordValidate
            // 
            this.dgvRecordValidate.AllowUserToAddRows = false;
            this.dgvRecordValidate.AllowUserToDeleteRows = false;
            this.dgvRecordValidate.AllowUserToOrderColumns = true;
            this.dgvRecordValidate.AllowUserToResizeRows = false;
            this.dgvRecordValidate.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecordValidate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRecordValidate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRecordValidate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.goods_name,
            this.goods_type,
            this.sn_sl,
            this.maker_name,
            this.input_standard_count,
            this.input_batch_num,
            this.input_quality_reg,
            this.goods_reg_num,
            this.goods_validity,
            this.quality_info,
            this.input_check_persion,
            this.check_info,
            this.input_checktime,
            this.supplier_name,
            this.supplier_licence});
            this.dgvRecordValidate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecordValidate.Location = new System.Drawing.Point(0, 5);
            this.dgvRecordValidate.Name = "dgvRecordValidate";
            this.dgvRecordValidate.RowHeadersVisible = false;
            this.dgvRecordValidate.RowTemplate.Height = 23;
            this.dgvRecordValidate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecordValidate.Size = new System.Drawing.Size(994, 590);
            this.dgvRecordValidate.TabIndex = 3;
            this.dgvRecordValidate.TabStop = false;
            this.dgvRecordValidate.Sorted += new System.EventHandler(this.dgvRecordValidate_Sorted);
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
            // goods_type
            // 
            this.goods_type.DataPropertyName = "goods_type";
            this.goods_type.HeaderText = "规格型号";
            this.goods_type.Name = "goods_type";
            this.goods_type.ReadOnly = true;
            // 
            // sn_sl
            // 
            this.sn_sl.DataPropertyName = "sn_sl";
            this.sn_sl.HeaderText = "供货单位(以及供货单位许可证号)";
            this.sn_sl.Name = "sn_sl";
            this.sn_sl.ReadOnly = true;
            this.sn_sl.Width = 210;
            // 
            // maker_name
            // 
            this.maker_name.DataPropertyName = "maker_name";
            this.maker_name.HeaderText = "生产厂家";
            this.maker_name.Name = "maker_name";
            this.maker_name.ReadOnly = true;
            // 
            // input_standard_count
            // 
            this.input_standard_count.DataPropertyName = "input_standard_count";
            this.input_standard_count.HeaderText = "数量";
            this.input_standard_count.Name = "input_standard_count";
            this.input_standard_count.ReadOnly = true;
            // 
            // input_batch_num
            // 
            this.input_batch_num.DataPropertyName = "input_batch_num";
            this.input_batch_num.HeaderText = "批号/设备号";
            this.input_batch_num.Name = "input_batch_num";
            this.input_batch_num.ReadOnly = true;
            // 
            // input_quality_reg
            // 
            this.input_quality_reg.DataPropertyName = "input_quality_reg";
            this.input_quality_reg.HeaderText = "灭菌批号";
            this.input_quality_reg.Name = "input_quality_reg";
            this.input_quality_reg.ReadOnly = true;
            // 
            // goods_reg_num
            // 
            this.goods_reg_num.DataPropertyName = "goods_reg_num";
            this.goods_reg_num.HeaderText = "注册证号";
            this.goods_reg_num.Name = "goods_reg_num";
            this.goods_reg_num.ReadOnly = true;
            // 
            // goods_validity
            // 
            this.goods_validity.DataPropertyName = "goods_validity";
            this.goods_validity.HeaderText = "有效期(月)";
            this.goods_validity.Name = "goods_validity";
            this.goods_validity.ReadOnly = true;
            // 
            // quality_info
            // 
            this.quality_info.DataPropertyName = "quality_info";
            this.quality_info.HeaderText = "质量状况";
            this.quality_info.Name = "quality_info";
            this.quality_info.ReadOnly = true;
            // 
            // input_check_persion
            // 
            this.input_check_persion.DataPropertyName = "input_check_persion";
            this.input_check_persion.HeaderText = "验收人";
            this.input_check_persion.Name = "input_check_persion";
            this.input_check_persion.ReadOnly = true;
            // 
            // check_info
            // 
            this.check_info.DataPropertyName = "check_info";
            this.check_info.HeaderText = "验收情况";
            this.check_info.Name = "check_info";
            this.check_info.ReadOnly = true;
            // 
            // input_checktime
            // 
            this.input_checktime.DataPropertyName = "input_checktime";
            this.input_checktime.HeaderText = "验收日期";
            this.input_checktime.Name = "input_checktime";
            this.input_checktime.ReadOnly = true;
            // 
            // supplier_name
            // 
            this.supplier_name.DataPropertyName = "supplier_name";
            this.supplier_name.HeaderText = "供货单位";
            this.supplier_name.Name = "supplier_name";
            this.supplier_name.Visible = false;
            // 
            // supplier_licence
            // 
            this.supplier_licence.DataPropertyName = "supplier_licence";
            this.supplier_licence.HeaderText = "供货单位许可证号";
            this.supplier_licence.Name = "supplier_licence";
            this.supplier_licence.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvRecordValidate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 97);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel1.Size = new System.Drawing.Size(994, 595);
            this.panel1.TabIndex = 4;
            // 
            // CheckRecordSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1014, 702);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CheckRecordSelectForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "验收记录查询";
            this.Load += new System.EventHandler(this.CheckRecordSelectForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecordValidate)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvRecordValidate;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_goods_name;
        private System.Windows.Forms.TextBox txt_goods_yxm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtp_input_checktime_Start;
        private System.Windows.Forms.DateTimePicker dtp_input_checktime_End;
        private System.Windows.Forms.CheckBox checkDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn sn_sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn maker_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn input_standard_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn input_batch_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn input_quality_reg;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_reg_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_validity;
        private System.Windows.Forms.DataGridViewTextBoxColumn quality_info;
        private System.Windows.Forms.DataGridViewTextBoxColumn input_check_persion;
        private System.Windows.Forms.DataGridViewTextBoxColumn check_info;
        private System.Windows.Forms.DataGridViewTextBoxColumn input_checktime;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_licence;
    }
}