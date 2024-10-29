namespace MyWindowsFormsApp
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.GUI_TextBox_Password = new System.Windows.Forms.TextBox();
            this.GUI_TextBox_Email = new System.Windows.Forms.TextBox();
            this.GUI_TEXT_email = new System.Windows.Forms.Label();
            this.GUI_TEXT_passoword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GUI_TextBox_Password
            // 
            this.GUI_TextBox_Password.Location = new System.Drawing.Point(273, 254);
            this.GUI_TextBox_Password.Name = "GUI_TextBox_Password";
            this.GUI_TextBox_Password.PasswordChar = '*';
            this.GUI_TextBox_Password.Size = new System.Drawing.Size(205, 23);
            this.GUI_TextBox_Password.TabIndex = 1;
            this.GUI_TextBox_Password.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // GUI_TextBox_Email
            // 
            this.GUI_TextBox_Email.Location = new System.Drawing.Point(273, 163);
            this.GUI_TextBox_Email.Name = "GUI_TextBox_Email";
            this.GUI_TextBox_Email.Size = new System.Drawing.Size(205, 23);
            this.GUI_TextBox_Email.TabIndex = 2;
            // 
            // GUI_TEXT_email
            // 
            this.GUI_TEXT_email.AutoSize = true;
            this.GUI_TEXT_email.Location = new System.Drawing.Point(211, 172);
            this.GUI_TEXT_email.Name = "GUI_TEXT_email";
            this.GUI_TEXT_email.Size = new System.Drawing.Size(56, 14);
            this.GUI_TEXT_email.TabIndex = 3;
            this.GUI_TEXT_email.Text = "Email :";
            this.GUI_TEXT_email.Click += new System.EventHandler(this.label1_Click);
            // 
            // GUI_TEXT_passoword
            // 
            this.GUI_TEXT_passoword.AutoSize = true;
            this.GUI_TEXT_passoword.Location = new System.Drawing.Point(190, 263);
            this.GUI_TEXT_passoword.Name = "GUI_TEXT_passoword";
            this.GUI_TEXT_passoword.Size = new System.Drawing.Size(77, 14);
            this.GUI_TEXT_passoword.TabIndex = 4;
            this.GUI_TEXT_passoword.Text = "Password :";
            this.GUI_TEXT_passoword.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GUI_TEXT_passoword);
            this.Controls.Add(this.GUI_TEXT_email);
            this.Controls.Add(this.GUI_TextBox_Email);
            this.Controls.Add(this.GUI_TextBox_Password);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox GUI_TextBox_Password;
        private System.Windows.Forms.TextBox GUI_TextBox_Email;
        private System.Windows.Forms.Label GUI_TEXT_email;
        private System.Windows.Forms.Label GUI_TEXT_passoword;
    }
}

