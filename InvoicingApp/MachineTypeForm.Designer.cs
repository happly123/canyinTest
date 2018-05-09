namespace InvoicingApp
{
    partial class MachineTypeForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("医疗器械");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MachineTypeForm));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_apparatus_code = new TCControl.TCTextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmb_apparatus_type = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txt_apparatus_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tv_tc_apparatus = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.cmb_apparatus_type_Select = new System.Windows.Forms.ComboBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txt_apparatus_name_select = new System.Windows.Forms.TextBox();
            this.txt_apparatus_code_select = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::InvoicingApp.Properties.Resources.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(516, 58);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::InvoicingApp.Properties.Resources.Save;
            this.btnSave.Location = new System.Drawing.Point(435, 58);
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
            this.btnUpdate.Location = new System.Drawing.Point(89, 58);
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
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.tv_tc_apparatus);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(624, 384);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_apparatus_code);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.cmb_apparatus_type);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.txt_apparatus_name);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(5, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(614, 87);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "器械信息维护";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(591, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 12);
            this.label9.TabIndex = 21;
            this.label9.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(376, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(165, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 19;
            this.label7.Text = "*";
            // 
            // txt_apparatus_code
            // 
            this.txt_apparatus_code.DateTimeFormate = TCControl.TCTextBox.FormatType.yyyyMMdd;
            this.txt_apparatus_code.Encodeing = "GB2312";
            this.txt_apparatus_code.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txt_apparatus_code.IsAllowMinus = false;
            this.txt_apparatus_code.Location = new System.Drawing.Point(65, 22);
            this.txt_apparatus_code.MatchValue = "^[0-9]*$";
            this.txt_apparatus_code.MaxByteLength = 10;
            this.txt_apparatus_code.MaxLength = 10;
            this.txt_apparatus_code.Name = "txt_apparatus_code";
            this.txt_apparatus_code.PadLeftFirstIsZero = false;
            this.txt_apparatus_code.Precision = 0;
            this.txt_apparatus_code.Scale = 0;
            this.txt_apparatus_code.Size = new System.Drawing.Size(100, 21);
            this.txt_apparatus_code.TabIndex = 0;
            this.txt_apparatus_code.TypeSet = TCControl.TCTextBox.Type.MatchDefine;
            this.txt_apparatus_code.Value = "";
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::InvoicingApp.Properties.Resources.Delete;
            this.btnDelete.Location = new System.Drawing.Point(170, 58);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "删除(&D)";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmb_apparatus_type
            // 
            this.cmb_apparatus_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_apparatus_type.FormattingEnabled = true;
            this.cmb_apparatus_type.Items.AddRange(new object[] {
            "请选择管理类别...",
            "Ⅰ类",
            "Ⅱ类",
            "Ⅲ类"});
            this.cmb_apparatus_type.Location = new System.Drawing.Point(471, 22);
            this.cmb_apparatus_type.Name = "cmb_apparatus_type";
            this.cmb_apparatus_type.Size = new System.Drawing.Size(120, 20);
            this.cmb_apparatus_type.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "管理类别:";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::InvoicingApp.Properties.Resources.Add;
            this.btnAdd.Location = new System.Drawing.Point(8, 58);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "增加(&A)";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txt_apparatus_name
            // 
            this.txt_apparatus_name.Location = new System.Drawing.Point(276, 22);
            this.txt_apparatus_name.MaxLength = 25;
            this.txt_apparatus_name.Name = "txt_apparatus_name";
            this.txt_apparatus_name.Size = new System.Drawing.Size(100, 21);
            this.txt_apparatus_name.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "分类编号:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "分类名称:";
            // 
            // tv_tc_apparatus
            // 
            this.tv_tc_apparatus.ForeColor = System.Drawing.Color.Black;
            this.tv_tc_apparatus.HideSelection = false;
            this.tv_tc_apparatus.HotTracking = true;
            this.tv_tc_apparatus.Location = new System.Drawing.Point(210, 0);
            this.tv_tc_apparatus.Name = "tv_tc_apparatus";
            treeNode1.Name = "节点0";
            treeNode1.Text = "医疗器械";
            this.tv_tc_apparatus.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.tv_tc_apparatus.Size = new System.Drawing.Size(404, 284);
            this.tv_tc_apparatus.TabIndex = 0;
            this.tv_tc_apparatus.TabStop = false;
            this.tv_tc_apparatus.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_tc_apparatus_AfterSelect);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.cmb_apparatus_type_Select);
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.txt_apparatus_name_select);
            this.groupBox1.Controls.Add(this.txt_apparatus_code_select);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 281);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "器械查询";
            // 
            // btnReset
            // 
            this.btnReset.Image = global::InvoicingApp.Properties.Resources.Reset;
            this.btnReset.Location = new System.Drawing.Point(120, 197);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "重置(&R)";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cmb_apparatus_type_Select
            // 
            this.cmb_apparatus_type_Select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_apparatus_type_Select.FormattingEnabled = true;
            this.cmb_apparatus_type_Select.Items.AddRange(new object[] {
            "请选择管理类别...",
            "Ⅰ类",
            "Ⅱ类",
            "Ⅲ类"});
            this.cmb_apparatus_type_Select.Location = new System.Drawing.Point(77, 122);
            this.cmb_apparatus_type_Select.Name = "cmb_apparatus_type_Select";
            this.cmb_apparatus_type_Select.Size = new System.Drawing.Size(118, 20);
            this.cmb_apparatus_type_Select.TabIndex = 2;
            // 
            // btnFind
            // 
            this.btnFind.Image = global::InvoicingApp.Properties.Resources.Search;
            this.btnFind.Location = new System.Drawing.Point(10, 197);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "查询(&Q)";
            this.btnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txt_apparatus_name_select
            // 
            this.txt_apparatus_name_select.Location = new System.Drawing.Point(77, 70);
            this.txt_apparatus_name_select.Name = "txt_apparatus_name_select";
            this.txt_apparatus_name_select.Size = new System.Drawing.Size(118, 21);
            this.txt_apparatus_name_select.TabIndex = 1;
            // 
            // txt_apparatus_code_select
            // 
            this.txt_apparatus_code_select.Location = new System.Drawing.Point(77, 24);
            this.txt_apparatus_code_select.Name = "txt_apparatus_code_select";
            this.txt_apparatus_code_select.Size = new System.Drawing.Size(118, 21);
            this.txt_apparatus_code_select.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "管理类别:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "分类名称:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "分类编号:";
            // 
            // MachineTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(644, 404);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(650, 436);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(650, 436);
            this.Name = "MachineTypeForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "器械分类";
            this.Load += new System.EventHandler(this.MachineTypeForm_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView tv_tc_apparatus;
        private System.Windows.Forms.TextBox txt_apparatus_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txt_apparatus_name_select;
        private System.Windows.Forms.TextBox txt_apparatus_code_select;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmb_apparatus_type_Select;
        private System.Windows.Forms.ComboBox cmb_apparatus_type;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox2;
        private TCControl.TCTextBox txt_apparatus_code;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}