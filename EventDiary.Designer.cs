namespace WindowsFormsApp1
{
    partial class EventDiary
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
            event_diary_Label = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // event_diary_Label
            // 
            event_diary_Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            event_diary_Label.AutoSize = true;
            event_diary_Label.Font = new System.Drawing.Font("SimSun", 23.78571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            event_diary_Label.ForeColor = System.Drawing.SystemColors.Control;
            event_diary_Label.Location = new System.Drawing.Point(344, 21);
            event_diary_Label.Name = "event_diary_Label";
            event_diary_Label.Size = new System.Drawing.Size(226, 37);
            event_diary_Label.TabIndex = 1;
            event_diary_Label.Text = "Event diary";
            // 
            // EventDiary
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(88, 2, 48);
            ClientSize = new System.Drawing.Size(914, 643);
            Controls.Add(event_diary_Label);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "EventDiary";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label event_diary_Label;
    }
}