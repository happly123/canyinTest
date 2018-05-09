namespace InvoicingApp
{
    partial class initStorageDialogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(initStorageDialogForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtGoods_nameSelect = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInput_codeSelect = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvInputStorage = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GOODS_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INPUT_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maker_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INPUT_STANDARD_COUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.input_batch_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INPUT_INSTORAGE_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INPUT_MAKETIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_validity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInputStorage)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 60);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtGoods_nameSelect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtInput_codeSelect);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 60);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // btnClear
            // 
            this.btnClear.Image = global::InvoicingApp.Properties.Resources.Reset;
            this.btnClear.Location = new System.Drawing.Point(540, 19);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "重置(&R)";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::InvoicingApp.Properties.Resources.Search;
            this.btnSearch.Location = new System.Drawing.Point(459, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查询(&Q)";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtGoods_nameSelect
            // 
            this.txtGoods_nameSelect.Location = new System.Drawing.Point(318, 20);
            this.txtGoods_nameSelect.Name = "txtGoods_nameSelect";
            this.txtGoods_nameSelect.Size = new System.Drawing.Size(135, 21);
            this.txtGoods_nameSelect.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "产品名称:";
            // 
            // txtInput_codeSelect
            // 
            this.txtInput_codeSelect.Location = new System.Drawing.Point(88, 20);
            this.txtInput_codeSelect.Name = "txtInput_codeSelect";
            this.txtInput_codeSelect.Size = new System.Drawing.Size(134, 21);
            this.txtInput_codeSelect.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "入库编号:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvInputStorage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(5, 65);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(635, 358);
            this.panel2.TabIndex = 1;
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
            this.index,
            this.GOODS_NAME,
            this.INPUT_CODE,
            this.input_type,
            this.goods_type,
            this.maker_name,
            this.INPUT_STANDARD_COUNT,
            this.input_batch_num,
            this.INPUT_INSTORAGE_DATE,
            this.INPUT_MAKETIME,
            this.goods_validity});
            this.dgvInputStorage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInputStorage.Location = new System.Drawing.Point(5, 5);
            this.dgvInputStorage.MultiSelect = false;
            this.dgvInputStorage.Name = "dgvInputStorage";
            this.dgvInputStorage.RowHeadersVisible = false;
            this.dgvInputStorage.RowTemplate.Height = 23;
            this.dgvInputStorage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInputStorage.Size = new System.Drawing.Size(625, 348);
            this.dgvInputStorage.TabIndex = 4;
            this.dgvInputStorage.TabStop = false;
            this.dgvInputStorage.Sorted += new System.EventHandler(this.dgvInputStorage_Sorted);
            this.dgvInputStorage.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btn_Confirm);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(5, 423);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(635, 62);
            this.panel3.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::InvoicingApp.Properties.Resources.Close;
            this.btnCancel.Location = new System.Drawing.Point(540, 20);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "关闭(&C)";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Image = global::InvoicingApp.Properties.Resources.Ok;
            this.btn_Confirm.Location = new System.Drawing.Point(459, 20);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_Confirm.TabIndex = 0;
            this.btn_Confirm.Text = "确定(&0)";
            this.btn_Confirm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btnCommit_Click);
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
            //GOODS_NAME
            //
            this.GOODS_NAME.DataPropertyName = "GOODS_NAME";
            this.GOODS_NAME.HeaderText = "产品名称";
            this.GOODS_NAME.Name = "GOODS_NAME";
            this.GOODS_NAME.ReadOnly = true;
            this.GOODS_NAME.Width = 100;
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
            this.input_type.DataPropertyName = "instorage_type";
            this.input_type.HeaderText = "入库类别";
            this.input_type.Name = "input_type";
            this.input_type.ReadOnly = true;
            this.input_type.Width = 80;
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
            // INPUT_STANDARD_COUNT
            // 
            this.INPUT_STANDARD_COUNT.DataPropertyName = "storage_count";
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
            // initStorageDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(645, 490);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(651, 522);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(651, 522);
            this.Name = "initStorageDialogForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "入库记录列表";
            this.Load += new System.EventHandler(this.initStorageDialogForm_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInputStorage)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGoods_nameSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInput_codeSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvInputStorage;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn GOODS_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn INPUT_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn input_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn maker_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn INPUT_STANDARD_COUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn input_batch_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn INPUT_INSTORAGE_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn INPUT_MAKETIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_validity;
    }
}