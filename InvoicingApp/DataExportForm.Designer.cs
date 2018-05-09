namespace InvoicingApp
{
    partial class DataExportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataExportForm));
            this.panelExport = new System.Windows.Forms.Panel();
            this.passWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.dateExportTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExportCal = new System.Windows.Forms.Button();
            this.dateExportFrom = new System.Windows.Forms.DateTimePicker();
            this.panelExport.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelExport
            // 
            this.panelExport.Controls.Add(this.passWord);
            this.panelExport.Controls.Add(this.label1);
            this.panelExport.Controls.Add(this.checkBox1);
            this.panelExport.Controls.Add(this.btnExport);
            this.panelExport.Controls.Add(this.dateExportTo);
            this.panelExport.Controls.Add(this.label3);
            this.panelExport.Controls.Add(this.label2);
            this.panelExport.Controls.Add(this.btnExportCal);
            this.panelExport.Controls.Add(this.dateExportFrom);
            this.panelExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelExport.Location = new System.Drawing.Point(0, 0);
            this.panelExport.Name = "panelExport";
            this.panelExport.Size = new System.Drawing.Size(330, 111);
            this.panelExport.TabIndex = 15;
            // 
            // passWord
            // 
            this.passWord.Location = new System.Drawing.Point(146, 85);
            this.passWord.MaxLength = 20;
            this.passWord.Name = "passWord";
            this.passWord.PasswordChar = '*';
            this.passWord.Size = new System.Drawing.Size(169, 21);
            this.passWord.TabIndex = 8;
            this.passWord.Text = "yjjyjjyjj";
            this.passWord.UseSystemPasswordChar = true;
            this.passWord.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "密码:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(14, 85);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "是否压缩";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnExport
            // 
            this.btnExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExport.Image = global::InvoicingApp.Properties.Resources.Ok;
            this.btnExport.Location = new System.Drawing.Point(240, 17);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "导出(&O)";
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // dateExportTo
            // 
            this.dateExportTo.CustomFormat = "yyyy-MM-dd";
            this.dateExportTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateExportTo.Location = new System.Drawing.Point(98, 60);
            this.dateExportTo.Name = "dateExportTo";
            this.dateExportTo.Size = new System.Drawing.Size(97, 21);
            this.dateExportTo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "结束日期:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "开始日期:";
            // 
            // btnExportCal
            // 
            this.btnExportCal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExportCal.Image = global::InvoicingApp.Properties.Resources.Close;
            this.btnExportCal.Location = new System.Drawing.Point(240, 58);
            this.btnExportCal.Name = "btnExportCal";
            this.btnExportCal.Size = new System.Drawing.Size(75, 23);
            this.btnExportCal.TabIndex = 1;
            this.btnExportCal.Text = "关闭(&C)";
            this.btnExportCal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportCal.UseVisualStyleBackColor = true;
            this.btnExportCal.Click += new System.EventHandler(this.btnExportCal_Click);
            // 
            // dateExportFrom
            // 
            this.dateExportFrom.CustomFormat = "yyyy-MM-dd";
            this.dateExportFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateExportFrom.Location = new System.Drawing.Point(98, 18);
            this.dateExportFrom.Name = "dateExportFrom";
            this.dateExportFrom.Size = new System.Drawing.Size(97, 21);
            this.dateExportFrom.TabIndex = 0;
            // 
            // DataExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 111);
            this.Controls.Add(this.panelExport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataExportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "数据申报";
            this.panelExport.ResumeLayout(false);
            this.panelExport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelExport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DateTimePicker dateExportTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExportCal;
        private System.Windows.Forms.DateTimePicker dateExportFrom;
        private System.Windows.Forms.TextBox passWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}