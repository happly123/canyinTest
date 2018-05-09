namespace InvoicingApp
{
    partial class DamageSelectForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkDate = new System.Windows.Forms.CheckBox();
            this.dtp_lose_datetime_End = new System.Windows.Forms.DateTimePicker();
            this.dtp_lose_datetime_Start = new System.Windows.Forms.DateTimePicker();
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_goods_name = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvLose = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lose_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_reg_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maker_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lose_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lose_datetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLose)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 60);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkDate);
            this.groupBox1.Controls.Add(this.dtp_lose_datetime_End);
            this.groupBox1.Controls.Add(this.dtp_lose_datetime_Start);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_goods_name);
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(994, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "报损查询";
            // 
            // checkDate
            // 
            this.checkDate.AutoSize = true;
            this.checkDate.Checked = true;
            this.checkDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkDate.Location = new System.Drawing.Point(603, 22);
            this.checkDate.Name = "checkDate";
            this.checkDate.Size = new System.Drawing.Size(96, 16);
            this.checkDate.TabIndex = 4;
            this.checkDate.Text = "是否选择日期";
            this.checkDate.UseVisualStyleBackColor = true;
            this.checkDate.CheckedChanged += new System.EventHandler(this.checkDate_CheckedChanged);
            // 
            // dtp_lose_datetime_End
            // 
            this.dtp_lose_datetime_End.CustomFormat = "yyyy-MM-dd";
            this.dtp_lose_datetime_End.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_lose_datetime_End.Location = new System.Drawing.Point(489, 20);
            this.dtp_lose_datetime_End.Name = "dtp_lose_datetime_End";
            this.dtp_lose_datetime_End.Size = new System.Drawing.Size(92, 21);
            this.dtp_lose_datetime_End.TabIndex = 3;
            // 
            // dtp_lose_datetime_Start
            // 
            this.dtp_lose_datetime_Start.CustomFormat = "yyyy-MM-dd";
            this.dtp_lose_datetime_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_lose_datetime_Start.Location = new System.Drawing.Point(330, 20);
            this.dtp_lose_datetime_Start.Name = "dtp_lose_datetime_Start";
            this.dtp_lose_datetime_Start.Size = new System.Drawing.Size(92, 21);
            this.dtp_lose_datetime_Start.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.Image = global::InvoicingApp.Properties.Resources.Reset;
            this.btnClear.Location = new System.Drawing.Point(896, 19);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "重置(&R)";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "到:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "报损日期:";
            // 
            // txt_goods_name
            // 
            this.txt_goods_name.Location = new System.Drawing.Point(88, 20);
            this.txt_goods_name.Name = "txt_goods_name";
            this.txt_goods_name.Size = new System.Drawing.Size(146, 21);
            this.txt_goods_name.TabIndex = 1;
            // 
            // btnFind
            // 
            this.btnFind.Image = global::InvoicingApp.Properties.Resources.Search;
            this.btnFind.Location = new System.Drawing.Point(815, 19);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 5;
            this.btnFind.Text = "查询(&Q)";
            this.btnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "产品名称:";
            // 
            // dgvLose
            // 
            this.dgvLose.AllowUserToAddRows = false;
            this.dgvLose.AllowUserToDeleteRows = false;
            this.dgvLose.AllowUserToResizeRows = false;
            this.dgvLose.BackgroundColor = System.Drawing.Color.White;
            this.dgvLose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLose.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLose.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.lose_code,
            this.goods_name,
            this.goods_type,
            this.goods_reg_num,
            this.maker_name,
            this.lose_count,
            this.goods_unit,
            this.lose_datetime});
            this.dgvLose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLose.Location = new System.Drawing.Point(0, 5);
            this.dgvLose.Name = "dgvLose";
            this.dgvLose.RowHeadersVisible = false;
            this.dgvLose.RowTemplate.Height = 23;
            this.dgvLose.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLose.Size = new System.Drawing.Size(994, 617);
            this.dgvLose.TabIndex = 6;
            this.dgvLose.TabStop = false;
            this.dgvLose.Sorted += new System.EventHandler(this.dgvLose_Sorted);
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
            // lose_code
            // 
            this.lose_code.DataPropertyName = "lose_code";
            this.lose_code.HeaderText = "报损编号";
            this.lose_code.Name = "lose_code";
            this.lose_code.ReadOnly = true;
            this.lose_code.Width = 130;
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
            // goods_reg_num
            // 
            this.goods_reg_num.DataPropertyName = "goods_reg_num";
            this.goods_reg_num.HeaderText = "产品注册证号";
            this.goods_reg_num.Name = "goods_reg_num";
            this.goods_reg_num.ReadOnly = true;
            // 
            // maker_name
            // 
            this.maker_name.DataPropertyName = "maker_name";
            this.maker_name.HeaderText = "生产厂家";
            this.maker_name.Name = "maker_name";
            this.maker_name.ReadOnly = true;
            // 
            // lose_count
            // 
            this.lose_count.DataPropertyName = "lose_count";
            this.lose_count.HeaderText = "报损数量";
            this.lose_count.Name = "lose_count";
            this.lose_count.ReadOnly = true;
            // 
            // goods_unit
            // 
            this.goods_unit.DataPropertyName = "goods_unit";
            this.goods_unit.HeaderText = "计量单位";
            this.goods_unit.Name = "goods_unit";
            this.goods_unit.ReadOnly = true;
            // 
            // lose_datetime
            // 
            this.lose_datetime.DataPropertyName = "lose_datetime";
            this.lose_datetime.HeaderText = "报损日期";
            this.lose_datetime.Name = "lose_datetime";
            this.lose_datetime.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvLose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(10, 70);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel2.Size = new System.Drawing.Size(994, 622);
            this.panel2.TabIndex = 7;
            // 
            // DamageSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1014, 702);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DamageSelectForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "报损查询";
            this.Load += new System.EventHandler(this.DamageSelectForm_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLose)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_goods_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DateTimePicker dtp_lose_datetime_Start;
        private System.Windows.Forms.CheckBox checkDate;
        private System.Windows.Forms.DateTimePicker dtp_lose_datetime_End;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn lose_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_reg_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn maker_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn lose_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn lose_datetime;
    }
}