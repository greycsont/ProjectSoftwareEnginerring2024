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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Login = new System.Windows.Forms.Button();
            this.GUI_TextBox_Password = new System.Windows.Forms.TextBox();
            this.GUI_TextBox_Email = new System.Windows.Forms.TextBox();
            this.GUI_TEXT_email = new System.Windows.Forms.Label();
            this.GUI_TEXT_passoword = new System.Windows.Forms.Label();
            this.Register = new System.Windows.Forms.Button();
            this.forgot_password = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Source Han Sans SC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Login.Location = new System.Drawing.Point(553, 315);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 31);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            this.Login.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.button1_Click);
            // 
            // GUI_TextBox_Password
            // 
            this.GUI_TextBox_Password.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.GUI_TextBox_Password.Location = new System.Drawing.Point(497, 227);
            this.GUI_TextBox_Password.Name = "GUI_TextBox_Password";
            this.GUI_TextBox_Password.PasswordChar = '*';
            this.GUI_TextBox_Password.Size = new System.Drawing.Size(205, 23);
            this.GUI_TextBox_Password.TabIndex = 1;
            this.GUI_TextBox_Password.Text = "Password";
            this.GUI_TextBox_Password.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // GUI_TextBox_Email
            // 
            this.GUI_TextBox_Email.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.GUI_TextBox_Email.Location = new System.Drawing.Point(497, 130);
            this.GUI_TextBox_Email.Name = "GUI_TextBox_Email";
            this.GUI_TextBox_Email.Size = new System.Drawing.Size(205, 23);
            this.GUI_TextBox_Email.TabIndex = 2;
            this.GUI_TextBox_Email.Text = "Email / Username";
            this.GUI_TextBox_Email.TextChanged += new System.EventHandler(this.GUI_TextBox_Email_TextChanged);
            // 
            // GUI_TEXT_email
            // 
            this.GUI_TEXT_email.AutoSize = true;
            this.GUI_TEXT_email.Font = new System.Drawing.Font("Source Han Sans SC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GUI_TEXT_email.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GUI_TEXT_email.Location = new System.Drawing.Point(358, 133);
            this.GUI_TEXT_email.Name = "GUI_TEXT_email";
            this.GUI_TEXT_email.Size = new System.Drawing.Size(135, 20);
            this.GUI_TEXT_email.TabIndex = 3;
            this.GUI_TEXT_email.Text = "Email / User name :";
            this.GUI_TEXT_email.Click += new System.EventHandler(this.label1_Click);
            // 
            // GUI_TEXT_passoword
            // 
            this.GUI_TEXT_passoword.AutoSize = true;
            this.GUI_TEXT_passoword.Font = new System.Drawing.Font("Source Han Sans SC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GUI_TEXT_passoword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GUI_TEXT_passoword.Location = new System.Drawing.Point(414, 230);
            this.GUI_TEXT_passoword.Name = "GUI_TEXT_passoword";
            this.GUI_TEXT_passoword.Size = new System.Drawing.Size(79, 20);
            this.GUI_TEXT_passoword.TabIndex = 4;
            this.GUI_TEXT_passoword.Text = "Password :";
            this.GUI_TEXT_passoword.Click += new System.EventHandler(this.label2_Click);
            // 
            // Register
            // 
            this.Register.Font = new System.Drawing.Font("Source Han Sans SC", 7.714285F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Register.Location = new System.Drawing.Point(633, 423);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(155, 27);
            this.Register.TabIndex = 6;
            this.Register.Text = "Don\'t have an account?";
            this.Register.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.button2_Click);
            // 
            // forgot_password
            // 
            this.forgot_password.Font = new System.Drawing.Font("Source Han Sans SC", 7.714285F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.forgot_password.Location = new System.Drawing.Point(654, 390);
            this.forgot_password.Name = "forgot_password";
            this.forgot_password.Size = new System.Drawing.Size(134, 27);
            this.forgot_password.TabIndex = 7;
            this.forgot_password.Text = "Forgot password?";
            this.forgot_password.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.forgot_password.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.forgot_password);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.GUI_TEXT_passoword);
            this.Controls.Add(this.GUI_TEXT_email);
            this.Controls.Add(this.GUI_TextBox_Email);
            this.Controls.Add(this.GUI_TextBox_Password);
            this.Controls.Add(this.Login);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.TextBox GUI_TextBox_Password;
        private System.Windows.Forms.TextBox GUI_TextBox_Email;
        private System.Windows.Forms.Label GUI_TEXT_email;
        private System.Windows.Forms.Label GUI_TEXT_passoword;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Button forgot_password;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

