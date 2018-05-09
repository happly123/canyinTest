namespace InvoicingApp
{
    partial class LogOnForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogOnForm));
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogOn = new System.Windows.Forms.Button();
            this.cmbUserName = new System.Windows.Forms.ComboBox();
            this.radioJxCompany = new System.Windows.Forms.RadioButton();
            this.radioYpCompany = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(287, 189);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(56, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "密  码：";
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(209, 152);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.Size = new System.Drawing.Size(134, 21);
            this.txtPassWord.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "用户名：";
            // 
            // btnLogOn
            // 
            this.btnLogOn.Location = new System.Drawing.Point(209, 189);
            this.btnLogOn.Name = "btnLogOn";
            this.btnLogOn.Size = new System.Drawing.Size(56, 23);
            this.btnLogOn.TabIndex = 3;
            this.btnLogOn.Text = "登录";
            this.btnLogOn.UseVisualStyleBackColor = true;
            this.btnLogOn.Click += new System.EventHandler(this.btnLogOn_Click);
            // 
            // cmbUserName
            // 
            this.cmbUserName.FormattingEnabled = true;
            this.cmbUserName.Location = new System.Drawing.Point(209, 110);
            this.cmbUserName.Name = "cmbUserName";
            this.cmbUserName.Size = new System.Drawing.Size(134, 20);
            this.cmbUserName.TabIndex = 1;
            this.cmbUserName.TextChanged += new System.EventHandler(this.cmbUserName_TextChanged);
            // 
            // radioJxCompany
            // 
            this.radioJxCompany.AutoSize = true;
            this.radioJxCompany.Checked = true;
            this.radioJxCompany.Location = new System.Drawing.Point(149, 81);
            this.radioJxCompany.Name = "radioJxCompany";
            this.radioJxCompany.Size = new System.Drawing.Size(71, 16);
            this.radioJxCompany.TabIndex = 17;
            this.radioJxCompany.TabStop = true;
            this.radioJxCompany.Text = "经销企业";
            this.radioJxCompany.UseVisualStyleBackColor = true;
            // 
            // radioYpCompany
            // 
            this.radioYpCompany.AutoSize = true;
            this.radioYpCompany.Location = new System.Drawing.Point(272, 81);
            this.radioYpCompany.Name = "radioYpCompany";
            this.radioYpCompany.Size = new System.Drawing.Size(71, 16);
            this.radioYpCompany.TabIndex = 18;
            this.radioYpCompany.Text = "验配企业";
            this.radioYpCompany.UseVisualStyleBackColor = true;
            // 
            // LogOnForm
            // 
            this.AcceptButton = this.btnLogOn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(240)))), ((int)(((byte)(253)))));
            this.BackgroundImage = global::InvoicingApp.Properties.Resources.loginBG;
            this.ClientSize = new System.Drawing.Size(384, 238);
            this.Controls.Add(this.radioYpCompany);
            this.Controls.Add(this.radioJxCompany);
            this.Controls.Add(this.cmbUserName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogOn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(392, 272);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(392, 272);
            this.Name = "LogOnForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户登录";
            this.Load += new System.EventHandler(this.LogOnForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogOn;
        private System.Windows.Forms.ComboBox cmbUserName;
        private System.Windows.Forms.RadioButton radioJxCompany;
        private System.Windows.Forms.RadioButton radioYpCompany;

    }
}

