namespace InvoicingApp
{
    partial class FileUpLoadForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileUpLoadForm));
            this.btnSetAddress = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labAddress = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtAddress1 = new TCControl.TCTextBox();
            this.txtAddress2 = new TCControl.TCTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress3 = new TCControl.TCTextBox();
            this.txtAddress4 = new TCControl.TCTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labTarg = new System.Windows.Forms.Label();
            this.proBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnSetAddress
            // 
            this.btnSetAddress.Location = new System.Drawing.Point(63, 100);
            this.btnSetAddress.Name = "btnSetAddress";
            this.btnSetAddress.Size = new System.Drawing.Size(103, 23);
            this.btnSetAddress.TabIndex = 0;
            this.btnSetAddress.Text = "保存服务器地址";
            this.btnSetAddress.UseVisualStyleBackColor = true;
            this.btnSetAddress.Click += new System.EventHandler(this.btnSetAddress_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "当前服务器地址:";
            // 
            // labAddress
            // 
            this.labAddress.AutoSize = true;
            this.labAddress.Location = new System.Drawing.Point(135, 20);
            this.labAddress.Name = "labAddress";
            this.labAddress.Size = new System.Drawing.Size(83, 12);
            this.labAddress.TabIndex = 2;
            this.labAddress.Text = "192.168.12.12";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(181, 100);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "申报数据";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtAddress1
            // 
            this.txtAddress1.DateTimeFormate = TCControl.TCTextBox.FormatType.yyyyMMdd;
            this.txtAddress1.Encodeing = "GB2312";
            this.txtAddress1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtAddress1.IsAllowMinus = false;
            this.txtAddress1.Location = new System.Drawing.Point(25, 54);
            this.txtAddress1.MatchValue = "^[0-9]+[0-9]*[0-9-]*$";
            this.txtAddress1.MaxByteLength = 3;
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.PadLeftFirstIsZero = false;
            this.txtAddress1.Precision = 0;
            this.txtAddress1.Scale = 0;
            this.txtAddress1.Size = new System.Drawing.Size(45, 21);
            this.txtAddress1.TabIndex = 4;
            this.txtAddress1.TypeSet = TCControl.TCTextBox.Type.MatchDefine;
            this.txtAddress1.Value = "";
            this.txtAddress1.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txtAddress2
            // 
            this.txtAddress2.DateTimeFormate = TCControl.TCTextBox.FormatType.yyyyMMdd;
            this.txtAddress2.Encodeing = "GB2312";
            this.txtAddress2.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtAddress2.IsAllowMinus = false;
            this.txtAddress2.Location = new System.Drawing.Point(87, 54);
            this.txtAddress2.MatchValue = "^[0-9]+[0-9]*[0-9-]*$";
            this.txtAddress2.MaxByteLength = 3;
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.PadLeftFirstIsZero = false;
            this.txtAddress2.Precision = 0;
            this.txtAddress2.Scale = 0;
            this.txtAddress2.Size = new System.Drawing.Size(45, 21);
            this.txtAddress2.TabIndex = 5;
            this.txtAddress2.TypeSet = TCControl.TCTextBox.Type.MatchDefine;
            this.txtAddress2.Value = "";
            this.txtAddress2.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = ".";
            // 
            // txtAddress3
            // 
            this.txtAddress3.DateTimeFormate = TCControl.TCTextBox.FormatType.yyyyMMdd;
            this.txtAddress3.Encodeing = "GB2312";
            this.txtAddress3.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtAddress3.IsAllowMinus = false;
            this.txtAddress3.Location = new System.Drawing.Point(149, 54);
            this.txtAddress3.MatchValue = "^[0-9]+[0-9]*[0-9-]*$";
            this.txtAddress3.MaxByteLength = 3;
            this.txtAddress3.Name = "txtAddress3";
            this.txtAddress3.PadLeftFirstIsZero = false;
            this.txtAddress3.Precision = 0;
            this.txtAddress3.Scale = 0;
            this.txtAddress3.Size = new System.Drawing.Size(45, 21);
            this.txtAddress3.TabIndex = 8;
            this.txtAddress3.TypeSet = TCControl.TCTextBox.Type.MatchDefine;
            this.txtAddress3.Value = "";
            this.txtAddress3.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txtAddress4
            // 
            this.txtAddress4.DateTimeFormate = TCControl.TCTextBox.FormatType.yyyyMMdd;
            this.txtAddress4.Encodeing = "GB2312";
            this.txtAddress4.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtAddress4.IsAllowMinus = false;
            this.txtAddress4.Location = new System.Drawing.Point(211, 54);
            this.txtAddress4.MatchValue = "^[0-9]+[0-9]*[0-9-]*$";
            this.txtAddress4.MaxByteLength = 3;
            this.txtAddress4.Name = "txtAddress4";
            this.txtAddress4.PadLeftFirstIsZero = false;
            this.txtAddress4.Precision = 0;
            this.txtAddress4.Scale = 0;
            this.txtAddress4.Size = new System.Drawing.Size(45, 21);
            this.txtAddress4.TabIndex = 9;
            this.txtAddress4.TypeSet = TCControl.TCTextBox.Type.MatchDefine;
            this.txtAddress4.Value = "";
            this.txtAddress4.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = ".";
            // 
            // labTarg
            // 
            this.labTarg.AutoSize = true;
            this.labTarg.Location = new System.Drawing.Point(23, 143);
            this.labTarg.Name = "labTarg";
            this.labTarg.Size = new System.Drawing.Size(107, 12);
            this.labTarg.TabIndex = 11;
            this.labTarg.Text = "正在连接服务器...";
            this.labTarg.Visible = false;
            // 
            // proBar
            // 
            this.proBar.Location = new System.Drawing.Point(25, 167);
            this.proBar.Name = "proBar";
            this.proBar.Size = new System.Drawing.Size(231, 10);
            this.proBar.TabIndex = 12;
            this.proBar.Visible = false;
            // 
            // FileUpLoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 138);
            this.Controls.Add(this.proBar);
            this.Controls.Add(this.labTarg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAddress4);
            this.Controls.Add(this.txtAddress3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.labAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSetAddress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FileUpLoadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据申报";
            this.Load += new System.EventHandler(this.FileUpLoadForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSetAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labAddress;
        private System.Windows.Forms.Button btnSend;
        private TCControl.TCTextBox txtAddress1;
        private TCControl.TCTextBox txtAddress2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private TCControl.TCTextBox txtAddress3;
        private TCControl.TCTextBox txtAddress4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labTarg;
        private System.Windows.Forms.ProgressBar proBar;
    }
}