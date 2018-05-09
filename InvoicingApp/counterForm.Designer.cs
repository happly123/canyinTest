namespace InvoicingApp
{
    partial class counterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(counterForm));
            this.dataGridView_Counter = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.counter_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.counter_manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.counter_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_counter_code = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Counter)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Counter
            // 
            this.dataGridView_Counter.AllowUserToAddRows = false;
            this.dataGridView_Counter.AllowUserToDeleteRows = false;
            this.dataGridView_Counter.AllowUserToResizeRows = false;
            this.dataGridView_Counter.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Counter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_Counter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_Counter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.counter_code,
            this.counter_manager,
            this.counter_type});
            this.dataGridView_Counter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Counter.Location = new System.Drawing.Point(0, 5);
            this.dataGridView_Counter.MultiSelect = false;
            this.dataGridView_Counter.Name = "dataGridView_Counter";
            this.dataGridView_Counter.RowHeadersVisible = false;
            this.dataGridView_Counter.RowTemplate.Height = 23;
            this.dataGridView_Counter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Counter.Size = new System.Drawing.Size(418, 341);
            this.dataGridView_Counter.TabIndex = 0;
            this.dataGridView_Counter.TabStop = false;
            this.dataGridView_Counter.Sorted += new System.EventHandler(this.dataGridView_Counter_Sorted);
            this.dataGridView_Counter.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Counter_CellDoubleClick);
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
            // counter_code
            // 
            this.counter_code.DataPropertyName = "counter_code";
            this.counter_code.HeaderText = "货位编号";
            this.counter_code.Name = "counter_code";
            this.counter_code.ReadOnly = true;
            this.counter_code.Width = 120;
            // 
            // counter_manager
            // 
            this.counter_manager.DataPropertyName = "counter_manager";
            this.counter_manager.HeaderText = "负责人";
            this.counter_manager.Name = "counter_manager";
            this.counter_manager.ReadOnly = true;
            this.counter_manager.Width = 120;
            // 
            // counter_type
            // 
            this.counter_type.DataPropertyName = "counter_type";
            this.counter_type.HeaderText = "存货种类";
            this.counter_type.Name = "counter_type";
            this.counter_type.ReadOnly = true;
            this.counter_type.Width = 120;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Image = global::InvoicingApp.Properties.Resources.Ok;
            this.btnConfirm.Location = new System.Drawing.Point(248, 13);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "确定(&O)";
            this.btnConfirm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "货位编号:";
            // 
            // textBox_counter_code
            // 
            this.textBox_counter_code.Location = new System.Drawing.Point(88, 20);
            this.textBox_counter_code.MaxLength = 20;
            this.textBox_counter_code.Name = "textBox_counter_code";
            this.textBox_counter_code.Size = new System.Drawing.Size(129, 21);
            this.textBox_counter_code.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::InvoicingApp.Properties.Resources.Search;
            this.btnSearch.Location = new System.Drawing.Point(248, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查询(&Q)";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.textBox_counter_code);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // btnReset
            // 
            this.btnReset.Image = global::InvoicingApp.Properties.Resources.Reset;
            this.btnReset.Location = new System.Drawing.Point(330, 19);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "重置(&R)";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::InvoicingApp.Properties.Resources.Close;
            this.btnCancel.Location = new System.Drawing.Point(330, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "关闭(&C)";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Image = global::InvoicingApp.Properties.Resources.Add;
            this.btnInsert.Location = new System.Drawing.Point(16, 13);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "增加(&A)";
            this.btnInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(5, 407);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel1.Size = new System.Drawing.Size(418, 48);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView_Counter);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(5, 61);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel2.Size = new System.Drawing.Size(418, 346);
            this.panel2.TabIndex = 2;
            // 
            // counterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(428, 460);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "counterForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "货位列表";
            this.Load += new System.EventHandler(this.counterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Counter)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Counter;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_counter_code;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn counter_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn counter_manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn counter_type;
    }
}