namespace WindowsFormsApp1.LoginModule
{
    partial class forgotPasswordPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(forgotPasswordPage));
            registed_Email_TextBox = new System.Windows.Forms.TextBox();
            checkCodeButton = new System.Windows.Forms.Button();
            verification_code_Text_Box = new System.Windows.Forms.TextBox();
            new_password_Text_Box = new System.Windows.Forms.TextBox();
            confirm_new_password_Text_Box = new System.Windows.Forms.TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            confirmButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // registed_Email_TextBox
            // 
            registed_Email_TextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            registed_Email_TextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            registed_Email_TextBox.Location = new System.Drawing.Point(266, 176);
            registed_Email_TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            registed_Email_TextBox.Name = "registed_Email_TextBox";
            registed_Email_TextBox.PlaceholderText = "Email:";
            registed_Email_TextBox.Size = new System.Drawing.Size(381, 25);
            registed_Email_TextBox.TabIndex = 9;
            // 
            // checkCodeButton
            // 
            checkCodeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            checkCodeButton.Location = new System.Drawing.Point(542, 247);
            checkCodeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            checkCodeButton.Name = "checkCodeButton";
            checkCodeButton.Size = new System.Drawing.Size(105, 40);
            checkCodeButton.TabIndex = 10;
            checkCodeButton.Text = "get code";
            checkCodeButton.UseVisualStyleBackColor = true;
            checkCodeButton.Click += checkCodeButton_Click;
            // 
            // verification_code_Text_Box
            // 
            verification_code_Text_Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            verification_code_Text_Box.ForeColor = System.Drawing.SystemColors.WindowText;
            verification_code_Text_Box.Location = new System.Drawing.Point(266, 254);
            verification_code_Text_Box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            verification_code_Text_Box.Name = "verification_code_Text_Box";
            verification_code_Text_Box.PlaceholderText = "Verification code";
            verification_code_Text_Box.Size = new System.Drawing.Size(243, 25);
            verification_code_Text_Box.TabIndex = 11;
            // 
            // new_password_Text_Box
            // 
            new_password_Text_Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            new_password_Text_Box.ForeColor = System.Drawing.SystemColors.WindowText;
            new_password_Text_Box.Location = new System.Drawing.Point(266, 334);
            new_password_Text_Box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            new_password_Text_Box.Name = "new_password_Text_Box";
            new_password_Text_Box.PlaceholderText = "New password";
            new_password_Text_Box.Size = new System.Drawing.Size(381, 25);
            new_password_Text_Box.TabIndex = 12;
            // 
            // confirm_new_password_Text_Box
            // 
            confirm_new_password_Text_Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            confirm_new_password_Text_Box.ForeColor = System.Drawing.SystemColors.WindowText;
            confirm_new_password_Text_Box.Location = new System.Drawing.Point(266, 409);
            confirm_new_password_Text_Box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            confirm_new_password_Text_Box.Name = "confirm_new_password_Text_Box";
            confirm_new_password_Text_Box.PlaceholderText = "Confirm new password";
            confirm_new_password_Text_Box.Size = new System.Drawing.Size(381, 25);
            confirm_new_password_Text_Box.TabIndex = 13;
            // 
            // confirmButton
            // 
            confirmButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            confirmButton.BackColor = System.Drawing.Color.Transparent;
            confirmButton.BackgroundImage = (System.Drawing.Image)resources.GetObject("confirmButton.BackgroundImage");
            confirmButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            confirmButton.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            confirmButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            confirmButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            confirmButton.Location = new System.Drawing.Point(392, 491);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new System.Drawing.Size(130, 50);
            confirmButton.TabIndex = 14;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = false;
            confirmButton.Click += confirmButton_Click;
            // 
            // forgotPasswordPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Salmon;
            ClientSize = new System.Drawing.Size(914, 643);
            Controls.Add(confirmButton);
            Controls.Add(confirm_new_password_Text_Box);
            Controls.Add(new_password_Text_Box);
            Controls.Add(verification_code_Text_Box);
            Controls.Add(checkCodeButton);
            Controls.Add(registed_Email_TextBox);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "forgotPasswordPage";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox registed_Email_TextBox;
        private System.Windows.Forms.Button checkCodeButton;
        private System.Windows.Forms.TextBox verification_code_Text_Box;
        private System.Windows.Forms.TextBox new_password_Text_Box;
        private System.Windows.Forms.TextBox confirm_new_password_Text_Box;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button confirmButton;
    }
}