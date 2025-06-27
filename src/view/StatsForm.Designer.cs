namespace WinterCubeTimer.view {
    partial class StatsForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            labelSession = new System.Windows.Forms.Label();
            labelTime = new System.Windows.Forms.Label();
            labelScramble = new System.Windows.Forms.Label();
            labelDate = new System.Windows.Forms.Label();
            textBoxScramble = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // labelSession
            // 
            labelSession.AutoSize = true;
            labelSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            labelSession.Location = new System.Drawing.Point(12, 24);
            labelSession.Name = "labelSession";
            labelSession.Size = new System.Drawing.Size(87, 24);
            labelSession.TabIndex = 1;
            labelSession.Text = "Session: ";
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            labelTime.Location = new System.Drawing.Point(12, 99);
            labelTime.Name = "labelTime";
            labelTime.Size = new System.Drawing.Size(63, 24);
            labelTime.TabIndex = 2;
            labelTime.Text = "Time: ";
            // 
            // labelScramble
            // 
            labelScramble.AutoSize = true;
            labelScramble.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            labelScramble.Location = new System.Drawing.Point(12, 174);
            labelScramble.Name = "labelScramble";
            labelScramble.Size = new System.Drawing.Size(100, 24);
            labelScramble.TabIndex = 6;
            labelScramble.Text = "Scramble: ";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            labelDate.Location = new System.Drawing.Point(12, 249);
            labelDate.Name = "labelDate";
            labelDate.Size = new System.Drawing.Size(58, 24);
            labelDate.TabIndex = 7;
            labelDate.Text = "Date: ";
            // 
            // textBoxScramble
            // 
            textBoxScramble.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            textBoxScramble.Location = new System.Drawing.Point(123, 167);
            textBoxScramble.Name = "textBoxScramble";
            textBoxScramble.ReadOnly = true;
            textBoxScramble.Size = new System.Drawing.Size(661, 35);
            textBoxScramble.TabIndex = 8;
            // 
            // StatsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(796, 302);
            Controls.Add(textBoxScramble);
            Controls.Add(labelDate);
            Controls.Add(labelScramble);
            Controls.Add(labelTime);
            Controls.Add(labelSession);
            MinimumSize = new System.Drawing.Size(718, 341);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Stats";
            Load += StatsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelSession;
        private Label labelTime;
        private Label labelScramble;
        private Label labelDate;
        private TextBox textBoxScramble;
    }
}