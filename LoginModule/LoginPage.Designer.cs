namespace WindowsFormsApp1.LoginModule
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            emailTextBox = new System.Windows.Forms.TextBox();
            passwordTextBox = new System.Windows.Forms.TextBox();
            loginButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // emailTextBox
            // 
            emailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            emailTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            emailTextBox.Location = new System.Drawing.Point(313, 266);
            emailTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.PlaceholderText = "Email";
            emailTextBox.Size = new System.Drawing.Size(289, 25);
            emailTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            passwordTextBox.Location = new System.Drawing.Point(313, 396);
            passwordTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PlaceholderText = "Password";
            passwordTextBox.Size = new System.Drawing.Size(289, 25);
            passwordTextBox.TabIndex = 3;
            // 
            // loginButton
            // 
            loginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            loginButton.BackColor = System.Drawing.Color.Transparent;
            loginButton.BackgroundImage = (System.Drawing.Image)resources.GetObject("loginButton.BackgroundImage");
            loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            loginButton.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            loginButton.Location = new System.Drawing.Point(392, 491);
            loginButton.Name = "loginButton";
            loginButton.Size = new System.Drawing.Size(130, 50);
            loginButton.TabIndex = 15;
            loginButton.Text = "login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Salmon;
            ClientSize = new System.Drawing.Size(914, 643);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(emailTextBox);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "LoginPage";
            Text = "LoginPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
    }
}