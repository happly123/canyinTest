namespace InvoicingApp
{
    partial class sellStorageDialogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sellStorageDialogForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.textBox_customer_yxm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBox_customer_name = new System.Windows.Forms.TextBox();
            this.textBox_output_code = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvOutput_storage = new System.Windows.Forms.DataGridView();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.output_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.output_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reloutput_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.output_instorage_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.output_checktime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.output_oper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.output_quality_persion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.output_check_persion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.output_issued = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.output_packing_out = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.output_packing_mid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.output_packing_in = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.output_remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.output_backreason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.output_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input_goods_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operate_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_yxm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input_maketime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input_instorage_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input_batch_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input_quality_reg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput_storage)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.textBox_customer_yxm);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.textBox_customer_name);
            this.groupBox1.Controls.Add(this.textBox_output_code);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // btnClear
            // 
            this.btnClear.Image = global::InvoicingApp.Properties.Resources.Reset;
            this.btnClear.Location = new System.Drawing.Point(675, 20);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "重置(&R)";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // textBox_customer_yxm
            // 
            this.textBox_customer_yxm.Location = new System.Drawing.Point(481, 20);
            this.textBox_customer_yxm.MaxLength = 25;
            this.textBox_customer_yxm.Name = "textBox_customer_yxm";
            this.textBox_customer_yxm.Size = new System.Drawing.Size(90, 21);
            this.textBox_customer_yxm.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "音序码:";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::InvoicingApp.Properties.Resources.Search;
            this.btnSearch.Location = new System.Drawing.Point(594, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "查询(&Q)";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textBox_customer_name
            // 
            this.textBox_customer_name.Location = new System.Drawing.Point(304, 20);
            this.textBox_customer_name.MaxLength = 25;
            this.textBox_customer_name.Name = "textBox_customer_name";
            this.textBox_customer_name.Size = new System.Drawing.Size(93, 21);
            this.textBox_customer_name.TabIndex = 2;
            // 
            // textBox_output_code
            // 
            this.textBox_output_code.Location = new System.Drawing.Point(88, 20);
            this.textBox_output_code.MaxLength = 20;
            this.textBox_output_code.Name = "textBox_output_code";
            this.textBox_output_code.Size = new System.Drawing.Size(120, 21);
            this.textBox_output_code.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "客户名称:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "出库编号:";
            // 
            // dgvOutput_storage
            // 
            this.dgvOutput_storage.AllowUserToAddRows = false;
            this.dgvOutput_storage.AllowUserToDeleteRows = false;
            this.dgvOutput_storage.AllowUserToResizeRows = false;
            this.dgvOutput_storage.BackgroundColor = System.Drawing.Color.White;
            this.dgvOutput_storage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvOutput_storage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOutput_storage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.output_code,
            this.customer_name,
            this.goods_name,
            this.supplier_name,
            this.output_count,
            this.reloutput_count,
            this.output_instorage_date,
            this.output_checktime,
            this.output_oper,
            this.output_quality_persion,
            this.output_check_persion,
            this.input_code,
            this.output_issued,
            this.customer_code,
            this.output_packing_out,
            this.output_packing_mid,
            this.output_packing_in,
            this.output_remark,
            this.output_backreason,
            this.output_type,
            this.input_goods_code,
            this.operate_type,
            this.customer_yxm,
            this.input_maketime,
            this.input_instorage_date,
            this.input_batch_num,
            this.input_quality_reg,
            this.customer_tel});
            this.dgvOutput_storage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOutput_storage.Location = new System.Drawing.Point(0, 5);
            this.dgvOutput_storage.MultiSelect = false;
            this.dgvOutput_storage.Name = "dgvOutput_storage";
            this.dgvOutput_storage.ReadOnly = true;
            this.dgvOutput_storage.RowHeadersVisible = false;
            this.dgvOutput_storage.RowTemplate.Height = 23;
            this.dgvOutput_storage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOutput_storage.Size = new System.Drawing.Size(768, 366);
            this.dgvOutput_storage.TabIndex = 0;
            this.dgvOutput_storage.TabStop = false;
            this.dgvOutput_storage.Sorted += new System.EventHandler(this.dgvOutput_storage_Sorted);
            this.dgvOutput_storage.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOutput_storage_CellDoubleClick);
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Image = global::InvoicingApp.Properties.Resources.Ok;
            this.btn_Confirm.Location = new System.Drawing.Point(594, 14);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_Confirm.TabIndex = 0;
            this.btn_Confirm.Text = "确定(&O)";
            this.btn_Confirm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::InvoicingApp.Properties.Resources.Close;
            this.btnCancel.Location = new System.Drawing.Point(675, 14);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "关闭(&C)";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_Confirm);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(5, 436);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 47);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(14, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "注意:已全部退货的销售单不显示";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvOutput_storage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(5, 65);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel2.Size = new System.Drawing.Size(768, 371);
            this.panel2.TabIndex = 2;
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
            this.output_code.Width = 136;
            // 
            // customer_name
            // 
            this.customer_name.DataPropertyName = "customer_name";
            this.customer_name.HeaderText = "客户名称";
            this.customer_name.Name = "customer_name";
            this.customer_name.ReadOnly = true;
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
            this.supplier_name.HeaderText = "供货商名称";
            this.supplier_name.Name = "supplier_name";
            this.supplier_name.ReadOnly = true;
            // 
            // output_count
            // 
            this.output_count.DataPropertyName = "output_count";
            this.output_count.HeaderText = "销售数量";
            this.output_count.Name = "output_count";
            this.output_count.ReadOnly = true;
            this.output_count.Visible = false;
            // 
            // reloutput_count
            // 
            this.reloutput_count.DataPropertyName = "reloutput_count";
            this.reloutput_count.HeaderText = "剩余数量";
            this.reloutput_count.Name = "reloutput_count";
            this.reloutput_count.ReadOnly = true;
            // 
            // output_instorage_date
            // 
            this.output_instorage_date.DataPropertyName = "output_instorage_date";
            this.output_instorage_date.HeaderText = "销售日期";
            this.output_instorage_date.Name = "output_instorage_date";
            this.output_instorage_date.ReadOnly = true;
            // 
            // output_checktime
            // 
            this.output_checktime.DataPropertyName = "output_checktime";
            this.output_checktime.HeaderText = "验收日期";
            this.output_checktime.Name = "output_checktime";
            this.output_checktime.ReadOnly = true;
            // 
            // output_oper
            // 
            this.output_oper.DataPropertyName = "output_oper";
            this.output_oper.HeaderText = "业务员";
            this.output_oper.Name = "output_oper";
            this.output_oper.ReadOnly = true;
            // 
            // output_quality_persion
            // 
            this.output_quality_persion.DataPropertyName = "output_quality_persion";
            this.output_quality_persion.HeaderText = "质管员";
            this.output_quality_persion.Name = "output_quality_persion";
            this.output_quality_persion.ReadOnly = true;
            // 
            // output_check_persion
            // 
            this.output_check_persion.DataPropertyName = "output_check_persion";
            this.output_check_persion.HeaderText = "验收人";
            this.output_check_persion.Name = "output_check_persion";
            this.output_check_persion.ReadOnly = true;
            this.output_check_persion.Visible = false;
            // 
            // input_code
            // 
            this.input_code.DataPropertyName = "input_code";
            this.input_code.HeaderText = "入库编号";
            this.input_code.Name = "input_code";
            this.input_code.ReadOnly = true;
            this.input_code.Visible = false;
            // 
            // output_issued
            // 
            this.output_issued.DataPropertyName = "output_issued";
            this.output_issued.HeaderText = "经办人";
            this.output_issued.Name = "output_issued";
            this.output_issued.ReadOnly = true;
            this.output_issued.Visible = false;
            // 
            // customer_code
            // 
            this.customer_code.DataPropertyName = "customer_code";
            this.customer_code.HeaderText = "客户编号";
            this.customer_code.Name = "customer_code";
            this.customer_code.ReadOnly = true;
            this.customer_code.Visible = false;
            this.customer_code.Width = 136;
            // 
            // output_packing_out
            // 
            this.output_packing_out.DataPropertyName = "output_packing_out";
            this.output_packing_out.HeaderText = "包装情况(外)";
            this.output_packing_out.Name = "output_packing_out";
            this.output_packing_out.ReadOnly = true;
            this.output_packing_out.Visible = false;
            // 
            // output_packing_mid
            // 
            this.output_packing_mid.DataPropertyName = "output_packing_mid";
            this.output_packing_mid.HeaderText = "包装情况(中)";
            this.output_packing_mid.Name = "output_packing_mid";
            this.output_packing_mid.ReadOnly = true;
            this.output_packing_mid.Visible = false;
            // 
            // output_packing_in
            // 
            this.output_packing_in.DataPropertyName = "output_packing_in";
            this.output_packing_in.HeaderText = "包装情况(内)";
            this.output_packing_in.Name = "output_packing_in";
            this.output_packing_in.ReadOnly = true;
            this.output_packing_in.Visible = false;
            // 
            // output_remark
            // 
            this.output_remark.DataPropertyName = "output_remark";
            this.output_remark.HeaderText = "备注";
            this.output_remark.Name = "output_remark";
            this.output_remark.ReadOnly = true;
            this.output_remark.Visible = false;
            // 
            // output_backreason
            // 
            this.output_backreason.DataPropertyName = "output_backreason";
            this.output_backreason.HeaderText = "退货原因";
            this.output_backreason.Name = "output_backreason";
            this.output_backreason.ReadOnly = true;
            this.output_backreason.Visible = false;
            // 
            // output_type
            // 
            this.output_type.DataPropertyName = "output_type";
            this.output_type.HeaderText = "出库标识";
            this.output_type.Name = "output_type";
            this.output_type.ReadOnly = true;
            this.output_type.Visible = false;
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
            this.operate_type.HeaderText = "出库操作标识";
            this.operate_type.Name = "operate_type";
            this.operate_type.ReadOnly = true;
            this.operate_type.Visible = false;
            // 
            // customer_yxm
            // 
            this.customer_yxm.DataPropertyName = "customer_yxm";
            this.customer_yxm.HeaderText = "音序码";
            this.customer_yxm.Name = "customer_yxm";
            this.customer_yxm.ReadOnly = true;
            this.customer_yxm.Visible = false;
            // 
            // input_maketime
            // 
            this.input_maketime.DataPropertyName = "input_maketime";
            this.input_maketime.HeaderText = "生产日期";
            this.input_maketime.Name = "input_maketime";
            this.input_maketime.ReadOnly = true;
            this.input_maketime.Visible = false;
            // 
            // input_instorage_date
            // 
            this.input_instorage_date.DataPropertyName = "input_instorage_date";
            this.input_instorage_date.HeaderText = "入库日期";
            this.input_instorage_date.Name = "input_instorage_date";
            this.input_instorage_date.ReadOnly = true;
            this.input_instorage_date.Visible = false;
            // 
            // input_batch_num
            // 
            this.input_batch_num.DataPropertyName = "input_batch_num";
            this.input_batch_num.HeaderText = "批号";
            this.input_batch_num.Name = "input_batch_num";
            this.input_batch_num.ReadOnly = true;
            this.input_batch_num.Visible = false;
            // 
            // input_quality_reg
            // 
            this.input_quality_reg.DataPropertyName = "input_quality_reg";
            this.input_quality_reg.HeaderText = "合格证";
            this.input_quality_reg.Name = "input_quality_reg";
            this.input_quality_reg.ReadOnly = true;
            // 
            // customer_tel
            // 
            this.customer_tel.DataPropertyName = "customer_tel";
            this.customer_tel.HeaderText = "客户电话";
            this.customer_tel.Name = "customer_tel";
            this.customer_tel.ReadOnly = true;
            this.customer_tel.Visible = false;
            // 
            // sellStorageDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(778, 488);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(784, 520);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(784, 520);
            this.Name = "sellStorageDialogForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "销售出库列表";
            this.Load += new System.EventHandler(this.sellStorageDialogForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput_storage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvOutput_storage;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBox_customer_name;
        private System.Windows.Forms.TextBox textBox_output_code;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox textBox_customer_yxm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn output_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn output_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn reloutput_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn output_instorage_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn output_checktime;
        private System.Windows.Forms.DataGridViewTextBoxColumn output_oper;
        private System.Windows.Forms.DataGridViewTextBoxColumn output_quality_persion;
        private System.Windows.Forms.DataGridViewTextBoxColumn output_check_persion;
        private System.Windows.Forms.DataGridViewTextBoxColumn input_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn output_issued;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn output_packing_out;
        private System.Windows.Forms.DataGridViewTextBoxColumn output_packing_mid;
        private System.Windows.Forms.DataGridViewTextBoxColumn output_packing_in;
        private System.Windows.Forms.DataGridViewTextBoxColumn output_remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn output_backreason;
        private System.Windows.Forms.DataGridViewTextBoxColumn output_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn input_goods_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn operate_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_yxm;
        private System.Windows.Forms.DataGridViewTextBoxColumn input_maketime;
        private System.Windows.Forms.DataGridViewTextBoxColumn input_instorage_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn input_batch_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn input_quality_reg;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_tel;
    }
}