namespace WindowsFormsApp1.LoginModule
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            LoginPanel = new System.Windows.Forms.Panel();
            forgotPasswordLinkLabel = new System.Windows.Forms.LinkLabel();
            registerLinkLabel = new System.Windows.Forms.LinkLabel();
            loginLinkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(0, 0);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(386, 537);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LoginPanel
            // 
            LoginPanel.Dock = System.Windows.Forms.DockStyle.Top;
            LoginPanel.Location = new System.Drawing.Point(386, 0);
            LoginPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new System.Drawing.Size(528, 460);
            LoginPanel.TabIndex = 1;
            // 
            // forgotPasswordLinkLabel
            // 
            forgotPasswordLinkLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            forgotPasswordLinkLabel.AutoSize = true;
            forgotPasswordLinkLabel.LinkColor = System.Drawing.Color.Black;
            forgotPasswordLinkLabel.Location = new System.Drawing.Point(778, 504);
            forgotPasswordLinkLabel.Name = "forgotPasswordLinkLabel";
            forgotPasswordLinkLabel.Size = new System.Drawing.Size(125, 20);
            forgotPasswordLinkLabel.TabIndex = 9;
            forgotPasswordLinkLabel.TabStop = true;
            forgotPasswordLinkLabel.Text = "forgot password?";
            forgotPasswordLinkLabel.VisitedLinkColor = System.Drawing.Color.Black;
            forgotPasswordLinkLabel.LinkClicked += forgotPasswordLinkLabel_LinkClicked;
            // 
            // registerLinkLabel
            // 
            registerLinkLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            registerLinkLabel.AutoSize = true;
            registerLinkLabel.LinkColor = System.Drawing.Color.Black;
            registerLinkLabel.Location = new System.Drawing.Point(842, 484);
            registerLinkLabel.Name = "registerLinkLabel";
            registerLinkLabel.Size = new System.Drawing.Size(59, 20);
            registerLinkLabel.TabIndex = 9;
            registerLinkLabel.TabStop = true;
            registerLinkLabel.Text = "register";
            registerLinkLabel.VisitedLinkColor = System.Drawing.Color.Black;
            registerLinkLabel.LinkClicked += registerLinkLabel_LinkClicked;
            // 
            // loginLinkLabel
            // 
            loginLinkLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            loginLinkLabel.AutoSize = true;
            loginLinkLabel.LinkColor = System.Drawing.Color.Black;
            loginLinkLabel.Location = new System.Drawing.Point(857, 464);
            loginLinkLabel.Name = "loginLinkLabel";
            loginLinkLabel.Size = new System.Drawing.Size(44, 20);
            loginLinkLabel.TabIndex = 9;
            loginLinkLabel.TabStop = true;
            loginLinkLabel.Text = "login";
            loginLinkLabel.VisitedLinkColor = System.Drawing.Color.Black;
            loginLinkLabel.LinkClicked += loginLinkLabel_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Salmon;
            ClientSize = new System.Drawing.Size(914, 537);
            Controls.Add(loginLinkLabel);
            Controls.Add(registerLinkLabel);
            Controls.Add(forgotPasswordLinkLabel);
            Controls.Add(LoginPanel);
            Controls.Add(pictureBox1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Login";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.LinkLabel forgotPasswordLinkLabel;
        private System.Windows.Forms.LinkLabel registerLinkLabel;
        private System.Windows.Forms.LinkLabel loginLinkLabel;
    }
}