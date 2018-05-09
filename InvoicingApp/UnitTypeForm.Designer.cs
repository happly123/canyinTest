namespace InvoicingApp
{
    partial class UnitTypeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnitTypeForm));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_unit_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_unit_yxm = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvUnit = new System.Windows.Forms.DataGridView();
            this.unit_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_yxm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Image = global::InvoicingApp.Properties.Resources.Cancel;
            this.btnExit.Location = new System.Drawing.Point(348, 64);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "取消(&C)";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::InvoicingApp.Properties.Resources.Save;
            this.btnSave.Location = new System.Drawing.Point(267, 64);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = global::InvoicingApp.Properties.Resources.Edit;
            this.btnUpdate.Location = new System.Drawing.Point(87, 64);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "修改(&M)";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dgvUnit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 416);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_unit_name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_unit_yxm);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 324);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 92);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "计量单位信息维护";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(195, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 21;
            this.label8.Text = "*";
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::InvoicingApp.Properties.Resources.Delete;
            this.btnDelete.Location = new System.Drawing.Point(168, 64);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "删除(&D)";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "计量单位:";
            // 
            // txt_unit_name
            // 
            this.txt_unit_name.Location = new System.Drawing.Point(85, 20);
            this.txt_unit_name.MaxLength = 25;
            this.txt_unit_name.Name = "txt_unit_name";
            this.txt_unit_name.Size = new System.Drawing.Size(110, 21);
            this.txt_unit_name.TabIndex = 1;
            this.txt_unit_name.TextChanged += new System.EventHandler(this.txt_unit_name_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "音序码:";
            // 
            // txt_unit_yxm
            // 
            this.txt_unit_yxm.Location = new System.Drawing.Point(280, 20);
            this.txt_unit_yxm.MaxLength = 25;
            this.txt_unit_yxm.Name = "txt_unit_yxm";
            this.txt_unit_yxm.ReadOnly = true;
            this.txt_unit_yxm.Size = new System.Drawing.Size(118, 21);
            this.txt_unit_yxm.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::InvoicingApp.Properties.Resources.Add;
            this.btnAdd.Location = new System.Drawing.Point(6, 64);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "增加(&A)";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvUnit
            // 
            this.dgvUnit.AllowUserToAddRows = false;
            this.dgvUnit.AllowUserToDeleteRows = false;
            this.dgvUnit.AllowUserToResizeRows = false;
            this.dgvUnit.BackgroundColor = System.Drawing.Color.White;
            this.dgvUnit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUnit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.unit_code,
            this.index,
            this.unit_name,
            this.unit_yxm});
            this.dgvUnit.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvUnit.Location = new System.Drawing.Point(0, 0);
            this.dgvUnit.MultiSelect = false;
            this.dgvUnit.Name = "dgvUnit";
            this.dgvUnit.RowHeadersVisible = false;
            this.dgvUnit.RowTemplate.Height = 23;
            this.dgvUnit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnit.Size = new System.Drawing.Size(429, 308);
            this.dgvUnit.StandardTab = true;
            this.dgvUnit.TabIndex = 1;
            this.dgvUnit.Sorted += new System.EventHandler(this.dgvUnit_Sorted);
            this.dgvUnit.SelectionChanged += new System.EventHandler(this.dgvUnit_SelectionChanged);
            // 
            // unit_code
            // 
            this.unit_code.DataPropertyName = "unit_code";
            this.unit_code.HeaderText = "序号1";
            this.unit_code.Name = "unit_code";
            this.unit_code.ReadOnly = true;
            this.unit_code.Visible = false;
            this.unit_code.Width = 124;
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
            // unit_name
            // 
            this.unit_name.DataPropertyName = "unit_name";
            this.unit_name.HeaderText = "计量单位";
            this.unit_name.Name = "unit_name";
            this.unit_name.ReadOnly = true;
            this.unit_name.Width = 124;
            // 
            // unit_yxm
            // 
            this.unit_yxm.DataPropertyName = "unit_yxm";
            this.unit_yxm.HeaderText = "音序码";
            this.unit_yxm.Name = "unit_yxm";
            this.unit_yxm.ReadOnly = true;
            this.unit_yxm.Width = 124;
            // 
            // UnitTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(449, 436);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(455, 468);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(455, 468);
            this.Name = "UnitTypeForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "计量单位";
            this.Load += new System.EventHandler(this.UnitTypeForm_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvUnit;
        private System.Windows.Forms.TextBox txt_unit_yxm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txt_unit_name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_yxm;
        private System.Windows.Forms.Label label8;
    }
}