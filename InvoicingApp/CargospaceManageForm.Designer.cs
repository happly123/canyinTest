namespace InvoicingApp
{
    partial class CargospaceManageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CargospaceManageForm));
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtManagerSelect = new System.Windows.Forms.TextBox();
            this.txtTypeSelect = new System.Windows.Forms.TextBox();
            this.txtCodeSelect = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCounter = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.counter_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.counter_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.counter_manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCommit = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtManager = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCounter)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::InvoicingApp.Properties.Resources.Delete;
            this.btnDelete.Location = new System.Drawing.Point(168, 93);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "删除(&D)";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtManagerSelect
            // 
            this.txtManagerSelect.Location = new System.Drawing.Point(100, 50);
            this.txtManagerSelect.MaxLength = 25;
            this.txtManagerSelect.Name = "txtManagerSelect";
            this.txtManagerSelect.Size = new System.Drawing.Size(109, 21);
            this.txtManagerSelect.TabIndex = 3;
            this.txtManagerSelect.DoubleClick += new System.EventHandler(this.txtManager_DoubleClick);
            // 
            // txtTypeSelect
            // 
            this.txtTypeSelect.Location = new System.Drawing.Point(305, 20);
            this.txtTypeSelect.MaxLength = 25;
            this.txtTypeSelect.Name = "txtTypeSelect";
            this.txtTypeSelect.Size = new System.Drawing.Size(151, 21);
            this.txtTypeSelect.TabIndex = 2;
            // 
            // txtCodeSelect
            // 
            this.txtCodeSelect.Location = new System.Drawing.Point(100, 20);
            this.txtCodeSelect.MaxLength = 25;
            this.txtCodeSelect.Name = "txtCodeSelect";
            this.txtCodeSelect.Size = new System.Drawing.Size(109, 21);
            this.txtCodeSelect.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.txtTypeSelect);
            this.groupBox1.Controls.Add(this.txtManagerSelect);
            this.groupBox1.Controls.Add(this.btnSelect);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCodeSelect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "货位查询";
            // 
            // btnReset
            // 
            this.btnReset.Image = global::InvoicingApp.Properties.Resources.Reset;
            this.btnReset.Location = new System.Drawing.Point(381, 49);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "重置(&R)";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Image = global::InvoicingApp.Properties.Resources.Search;
            this.btnSelect.Location = new System.Drawing.Point(300, 49);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = "查询(&Q)";
            this.btnSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "货位负责人:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "存货种类:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "货位编号:";
            // 
            // dgvCounter
            // 
            this.dgvCounter.AllowUserToAddRows = false;
            this.dgvCounter.AllowUserToDeleteRows = false;
            this.dgvCounter.AllowUserToResizeRows = false;
            this.dgvCounter.BackgroundColor = System.Drawing.Color.White;
            this.dgvCounter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCounter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCounter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.counter_code,
            this.counter_type,
            this.counter_manager});
            this.dgvCounter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCounter.Location = new System.Drawing.Point(0, 5);
            this.dgvCounter.MultiSelect = false;
            this.dgvCounter.Name = "dgvCounter";
            this.dgvCounter.RowHeadersVisible = false;
            this.dgvCounter.RowTemplate.Height = 23;
            this.dgvCounter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCounter.Size = new System.Drawing.Size(481, 183);
            this.dgvCounter.StandardTab = true;
            this.dgvCounter.TabIndex = 2;
            this.dgvCounter.Sorted += new System.EventHandler(this.dgvCounter_Sorted);
            this.dgvCounter.SelectionChanged += new System.EventHandler(this.dgvCounter_SelectionChanged);
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
            // counter_code
            // 
            this.counter_code.DataPropertyName = "counter_code";
            this.counter_code.HeaderText = "货位编号";
            this.counter_code.Name = "counter_code";
            this.counter_code.ReadOnly = true;
            this.counter_code.Width = 110;
            // 
            // counter_type
            // 
            this.counter_type.DataPropertyName = "counter_type";
            this.counter_type.HeaderText = "存货种类";
            this.counter_type.Name = "counter_type";
            this.counter_type.ReadOnly = true;
            this.counter_type.Width = 180;
            // 
            // counter_manager
            // 
            this.counter_manager.DataPropertyName = "counter_manager";
            this.counter_manager.HeaderText = "货位负责人";
            this.counter_manager.Name = "counter_manager";
            this.counter_manager.ReadOnly = true;
            // 
            // btnCommit
            // 
            this.btnCommit.Image = global::InvoicingApp.Properties.Resources.Save;
            this.btnCommit.Location = new System.Drawing.Point(290, 93);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(75, 23);
            this.btnCommit.TabIndex = 6;
            this.btnCommit.Text = "保存(&S)";
            this.btnCommit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Image = global::InvoicingApp.Properties.Resources.Add;
            this.btnInsert.Location = new System.Drawing.Point(6, 93);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "增加(&A)";
            this.btnInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = global::InvoicingApp.Properties.Resources.Edit;
            this.btnUpdate.Location = new System.Drawing.Point(87, 93);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "修改(&M)";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtManager
            // 
            this.txtManager.Location = new System.Drawing.Point(100, 53);
            this.txtManager.MaxLength = 25;
            this.txtManager.Name = "txtManager";
            this.txtManager.ReadOnly = true;
            this.txtManager.Size = new System.Drawing.Size(109, 21);
            this.txtManager.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtManager, "双击选择负责人");
            this.txtManager.DoubleClick += new System.EventHandler(this.txtManager_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtType);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.txtCode);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnCommit);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtManager);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnInsert);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(10, 289);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 124);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "货位信息维护";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(209, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(414, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 27;
            this.label6.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(209, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 26;
            this.label5.Text = "*";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(305, 20);
            this.txtType.MaxLength = 25;
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(109, 21);
            this.txtType.TabIndex = 1;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(100, 20);
            this.txtCode.MaxLength = 25;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(109, 21);
            this.txtCode.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::InvoicingApp.Properties.Resources.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(371, 93);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(231, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "存货种类:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "货位编号:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 12);
            this.label9.TabIndex = 4;
            this.label9.Text = "货位负责人:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvCounter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 96);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.panel1.Size = new System.Drawing.Size(481, 193);
            this.panel1.TabIndex = 3;
            // 
            // CargospaceManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(501, 423);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CargospaceManageForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "货位管理";
            this.Load += new System.EventHandler(this.CargospaceManageForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCounter)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView dgvCounter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtManagerSelect;
        private System.Windows.Forms.TextBox txtTypeSelect;
        private System.Windows.Forms.TextBox txtCodeSelect;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtManager;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn counter_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn counter_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn counter_manager;
    }
}