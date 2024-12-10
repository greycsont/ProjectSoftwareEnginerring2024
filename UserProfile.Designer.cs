namespace WindowsFormsApp1
{
    partial class UserProfile
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
            description_Text_Box = new System.Windows.Forms.TextBox();
            user_Name_Label = new System.Windows.Forms.Label();
            save_change_Button = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // description_Text_Box
            // 
            description_Text_Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            description_Text_Box.Location = new System.Drawing.Point(400, 170);
            description_Text_Box.MaximumSize = new System.Drawing.Size(300, 200);
            description_Text_Box.MinimumSize = new System.Drawing.Size(300, 200);
            description_Text_Box.Multiline = true;
            description_Text_Box.Name = "description_Text_Box";
            description_Text_Box.PlaceholderText = "Share your best with your firends";
            description_Text_Box.Size = new System.Drawing.Size(300, 200);
            description_Text_Box.TabIndex = 0;
            // 
            // user_Name_Label
            // 
            user_Name_Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            user_Name_Label.AutoSize = true;
            user_Name_Label.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.2142859F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            user_Name_Label.ForeColor = System.Drawing.SystemColors.Control;
            user_Name_Label.Location = new System.Drawing.Point(400, 65);
            user_Name_Label.Name = "user_Name_Label";
            user_Name_Label.Size = new System.Drawing.Size(106, 25);
            user_Name_Label.TabIndex = 1;
            user_Name_Label.Text = "userName";
            // 
            // save_change_Button
            // 
            save_change_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            save_change_Button.Location = new System.Drawing.Point(84, 343);
            save_change_Button.Name = "save_change_Button";
            save_change_Button.Size = new System.Drawing.Size(189, 27);
            save_change_Button.TabIndex = 2;
            save_change_Button.Text = "Save changes";
            save_change_Button.UseVisualStyleBackColor = true;
            save_change_Button.Click += save_change_Button_Click;
            // 
            // UserProfile
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(save_change_Button);
            Controls.Add(user_Name_Label);
            Controls.Add(description_Text_Box);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "UserProfile";
            Text = "UserProfile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox description_Text_Box;
        private System.Windows.Forms.Label user_Name_Label;
        private System.Windows.Forms.Button save_change_Button;
    }
}