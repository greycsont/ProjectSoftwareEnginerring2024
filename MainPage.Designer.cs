namespace WindowsFormsApp1
{
    partial class MainPage
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
            today_eventsLabel = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // today_eventsLabel
            // 
            today_eventsLabel.AutoSize = true;
            today_eventsLabel.Font = new System.Drawing.Font("SimSun", 23.78571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            today_eventsLabel.Location = new System.Drawing.Point(22, 26);
            today_eventsLabel.Name = "today_eventsLabel";
            today_eventsLabel.Size = new System.Drawing.Size(283, 37);
            today_eventsLabel.TabIndex = 2;
            today_eventsLabel.Text = "Today's events";
            // 
            // MainPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlLight;
            ClientSize = new System.Drawing.Size(914, 643);
            Controls.Add(today_eventsLabel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "MainPage";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label today_eventsLabel;
    }
}