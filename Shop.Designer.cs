namespace WindowsFormsApp1
{
    partial class Shop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shop));
            System.Windows.Forms.Button item_3_Button;
            item_1_Button = new System.Windows.Forms.Button();
            item_2_Button = new System.Windows.Forms.Button();
            item_3_Button = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // item_1_Button
            // 
            item_1_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            item_1_Button.BackgroundImage = (System.Drawing.Image)resources.GetObject("item_1_Button.BackgroundImage");
            item_1_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            item_1_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(255, 255, 192);
            item_1_Button.FlatAppearance.BorderSize = 0;
            item_1_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            item_1_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            item_1_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            item_1_Button.Location = new System.Drawing.Point(83, 329);
            item_1_Button.Name = "item_1_Button";
            item_1_Button.Size = new System.Drawing.Size(160, 100);
            item_1_Button.TabIndex = 8;
            item_1_Button.Text = "Buy";
            item_1_Button.UseVisualStyleBackColor = false;
            // 
            // item_2_Button
            // 
            item_2_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            item_2_Button.BackgroundImage = (System.Drawing.Image)resources.GetObject("item_2_Button.BackgroundImage");
            item_2_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            item_2_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(255, 255, 192);
            item_2_Button.FlatAppearance.BorderSize = 0;
            item_2_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            item_2_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            item_2_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            item_2_Button.Location = new System.Drawing.Point(305, 329);
            item_2_Button.Name = "item_2_Button";
            item_2_Button.Size = new System.Drawing.Size(160, 100);
            item_2_Button.TabIndex = 9;
            item_2_Button.Text = "Buy";
            item_2_Button.UseVisualStyleBackColor = false;
            // 
            // item_3_Button
            // 
            item_3_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            item_3_Button.BackgroundImage = (System.Drawing.Image)resources.GetObject("item_3_Button.BackgroundImage");
            item_3_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            item_3_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(255, 255, 192);
            item_3_Button.FlatAppearance.BorderSize = 0;
            item_3_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            item_3_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            item_3_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            item_3_Button.Location = new System.Drawing.Point(525, 329);
            item_3_Button.Name = "item_3_Button";
            item_3_Button.Size = new System.Drawing.Size(160, 100);
            item_3_Button.TabIndex = 10;
            item_3_Button.Text = "Buy";
            item_3_Button.UseVisualStyleBackColor = false;
            // 
            // Shop
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(238, 225, 219);
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(item_3_Button);
            Controls.Add(item_2_Button);
            Controls.Add(item_1_Button);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Shop";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button item_1_Button;
        private System.Windows.Forms.Button item_2_Button;
    }
}