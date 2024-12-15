namespace WindowsFormsApp1
{
    partial class CommunityMembership
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
            System.Windows.Forms.Label descriptionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommunityMembership));
            communitymembershipPictureBox = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            descriptiontitleLabel = new System.Windows.Forms.Label();
            subscribeButton = new System.Windows.Forms.Button();
            descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)communitymembershipPictureBox).BeginInit();
            SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            descriptionLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 6.428571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            descriptionLabel.Location = new System.Drawing.Point(347, 125);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(427, 248);
            descriptionLabel.TabIndex = 4;
            descriptionLabel.Text = resources.GetString("descriptionLabel.Text");
            // 
            // communitymembershipPictureBox
            // 
            communitymembershipPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            communitymembershipPictureBox.Image = (System.Drawing.Image)resources.GetObject("communitymembershipPictureBox.Image");
            communitymembershipPictureBox.Location = new System.Drawing.Point(29, 21);
            communitymembershipPictureBox.Name = "communitymembershipPictureBox";
            communitymembershipPictureBox.Size = new System.Drawing.Size(288, 271);
            communitymembershipPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            communitymembershipPictureBox.TabIndex = 0;
            communitymembershipPictureBox.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.0714283F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            label1.Location = new System.Drawing.Point(398, 47);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(0, 32);
            label1.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.0714283F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            label2.Location = new System.Drawing.Point(347, 21);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(309, 32);
            label2.TabIndex = 2;
            label2.Text = "Community membership";
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(347, 59);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(140, 20);
            label3.TabIndex = 3;
            label3.Text = "£18.50 every month";
            // 
            // descriptiontitleLabel
            // 
            descriptiontitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            descriptiontitleLabel.AutoSize = true;
            descriptiontitleLabel.Location = new System.Drawing.Point(347, 91);
            descriptiontitleLabel.Name = "descriptiontitleLabel";
            descriptiontitleLabel.Size = new System.Drawing.Size(414, 20);
            descriptiontitleLabel.TabIndex = 5;
            descriptiontitleLabel.Text = "Access to our space and full programme of events for £18.50\r\n";
            // 
            // subscribeButton
            // 
            subscribeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            subscribeButton.BackgroundImage = (System.Drawing.Image)resources.GetObject("subscribeButton.BackgroundImage");
            subscribeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            subscribeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(255, 255, 192);
            subscribeButton.FlatAppearance.BorderSize = 0;
            subscribeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            subscribeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            subscribeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            subscribeButton.Location = new System.Drawing.Point(466, 378);
            subscribeButton.Name = "subscribeButton";
            subscribeButton.Size = new System.Drawing.Size(160, 60);
            subscribeButton.TabIndex = 6;
            subscribeButton.Text = "Subscribe";
            subscribeButton.UseVisualStyleBackColor = false;
            // 
            // CommunityMembership
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(238, 225, 219);
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(subscribeButton);
            Controls.Add(descriptiontitleLabel);
            Controls.Add(descriptionLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(communitymembershipPictureBox);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "CommunityMembership";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)communitymembershipPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox communitymembershipPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label descriptiontitleLabel;
        private System.Windows.Forms.Button subscribeButton;
    }
}