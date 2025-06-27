namespace WinterCubeTimer.view {
    partial class SolveTimeUserControl {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.labelTime = new System.Windows.Forms.Label();
            this.checkBoxIsPlusTwo = new System.Windows.Forms.CheckBox();
            this.checkBoxIsDNF = new System.Windows.Forms.CheckBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTime.Location = new System.Drawing.Point(12, 24);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(56, 24);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "Time";
            this.labelTime.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelTime_MouseClick);
            this.labelTime.MouseEnter += new System.EventHandler(this.labelTime_MouseEnter);
            this.labelTime.MouseLeave += new System.EventHandler(this.labelTime_MouseLeave);
            // 
            // checkBoxIsPlusTwo
            // 
            this.checkBoxIsPlusTwo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBoxIsPlusTwo.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxIsPlusTwo.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxIsPlusTwo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxIsPlusTwo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxIsPlusTwo.Location = new System.Drawing.Point(153, 15);
            this.checkBoxIsPlusTwo.Name = "checkBoxIsPlusTwo";
            this.checkBoxIsPlusTwo.Size = new System.Drawing.Size(42, 42);
            this.checkBoxIsPlusTwo.TabIndex = 1;
            this.checkBoxIsPlusTwo.TabStop = false;
            this.checkBoxIsPlusTwo.Text = "+2";
            this.checkBoxIsPlusTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxIsPlusTwo.UseVisualStyleBackColor = true;
            this.checkBoxIsPlusTwo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBoxIsPlusTwo_MouseClick);
            // 
            // checkBoxIsDNF
            // 
            this.checkBoxIsDNF.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBoxIsDNF.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxIsDNF.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxIsDNF.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxIsDNF.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxIsDNF.Location = new System.Drawing.Point(201, 15);
            this.checkBoxIsDNF.Name = "checkBoxIsDNF";
            this.checkBoxIsDNF.Size = new System.Drawing.Size(42, 42);
            this.checkBoxIsDNF.TabIndex = 2;
            this.checkBoxIsDNF.TabStop = false;
            this.checkBoxIsDNF.Text = "DNF";
            this.checkBoxIsDNF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxIsDNF.UseVisualStyleBackColor = true;
            this.checkBoxIsDNF.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBoxIsDNF_MouseClick);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.Location = new System.Drawing.Point(249, 15);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(42, 42);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "X";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonDelete_MouseClick);
            // 
            // SolveTimeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.checkBoxIsDNF);
            this.Controls.Add(this.checkBoxIsPlusTwo);
            this.Controls.Add(this.labelTime);
            this.Name = "SolveTimeUserControl";
            this.Size = new System.Drawing.Size(300, 72);
            this.Load += new System.EventHandler(this.TimeUserControl_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TimeUserControl_MouseClick);
            this.MouseEnter += new System.EventHandler(this.TimeUserControl_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.TimeUserControl_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTime;
        private CheckBox checkBoxIsPlusTwo;
        private CheckBox checkBoxIsDNF;
        private Button buttonDelete;
    }
}
