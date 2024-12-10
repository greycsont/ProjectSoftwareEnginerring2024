namespace WindowsFormsApp1.LoginModule
{
    partial class registerPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registerPage));
            first_name_Text_Box = new System.Windows.Forms.TextBox();
            email_Text_Box = new System.Windows.Forms.TextBox();
            last_name_Text_Box = new System.Windows.Forms.TextBox();
            password_Text_Box = new System.Windows.Forms.TextBox();
            registerButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // first_name_Text_Box
            // 
            first_name_Text_Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            first_name_Text_Box.ForeColor = System.Drawing.SystemColors.WindowText;
            first_name_Text_Box.Location = new System.Drawing.Point(313, 237);
            first_name_Text_Box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            first_name_Text_Box.Name = "first_name_Text_Box";
            first_name_Text_Box.PlaceholderText = "First name";
            first_name_Text_Box.Size = new System.Drawing.Size(125, 25);
            first_name_Text_Box.TabIndex = 3;
            // 
            // email_Text_Box
            // 
            email_Text_Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            email_Text_Box.ForeColor = System.Drawing.SystemColors.WindowText;
            email_Text_Box.Location = new System.Drawing.Point(313, 324);
            email_Text_Box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            email_Text_Box.Name = "email_Text_Box";
            email_Text_Box.PlaceholderText = "Email";
            email_Text_Box.Size = new System.Drawing.Size(289, 25);
            email_Text_Box.TabIndex = 4;
            // 
            // last_name_Text_Box
            // 
            last_name_Text_Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            last_name_Text_Box.ForeColor = System.Drawing.SystemColors.WindowText;
            last_name_Text_Box.Location = new System.Drawing.Point(477, 237);
            last_name_Text_Box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            last_name_Text_Box.Name = "last_name_Text_Box";
            last_name_Text_Box.PlaceholderText = "Last name";
            last_name_Text_Box.Size = new System.Drawing.Size(125, 25);
            last_name_Text_Box.TabIndex = 5;
            // 
            // password_Text_Box
            // 
            password_Text_Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            password_Text_Box.ForeColor = System.Drawing.SystemColors.WindowText;
            password_Text_Box.Location = new System.Drawing.Point(313, 405);
            password_Text_Box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            password_Text_Box.Name = "password_Text_Box";
            password_Text_Box.PlaceholderText = "Password";
            password_Text_Box.Size = new System.Drawing.Size(289, 25);
            password_Text_Box.TabIndex = 6;
            // 
            // registerButton
            // 
            registerButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            registerButton.BackColor = System.Drawing.Color.Transparent;
            registerButton.BackgroundImage = (System.Drawing.Image)resources.GetObject("registerButton.BackgroundImage");
            registerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            registerButton.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            registerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            registerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            registerButton.Location = new System.Drawing.Point(392, 491);
            registerButton.Name = "registerButton";
            registerButton.Size = new System.Drawing.Size(130, 50);
            registerButton.TabIndex = 16;
            registerButton.Text = "register";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // registerPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Salmon;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(914, 643);
            Controls.Add(registerButton);
            Controls.Add(password_Text_Box);
            Controls.Add(last_name_Text_Box);
            Controls.Add(email_Text_Box);
            Controls.Add(first_name_Text_Box);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "registerPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox first_name_Text_Box;
        private System.Windows.Forms.TextBox email_Text_Box;
        private System.Windows.Forms.TextBox last_name_Text_Box;
        private System.Windows.Forms.TextBox password_Text_Box;
        private System.Windows.Forms.Button registerButton;
    }
}