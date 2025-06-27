namespace WinterCubeTimer.view {
    partial class SolutionForm {
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
            textBoxSolution = new TextBox();
            panelSolution = new Panel();
            labelSolution = new Label();
            buttonOK = new Button();
            panelSolution.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxSolution
            // 
            textBoxSolution.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSolution.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSolution.Location = new Point(3, 67);
            textBoxSolution.Name = "textBoxSolution";
            textBoxSolution.ReadOnly = true;
            textBoxSolution.Size = new Size(902, 47);
            textBoxSolution.TabIndex = 0;
            // 
            // panelSolution
            // 
            panelSolution.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelSolution.Controls.Add(buttonOK);
            panelSolution.Controls.Add(labelSolution);
            panelSolution.Controls.Add(textBoxSolution);
            panelSolution.Location = new Point(12, 12);
            panelSolution.Name = "panelSolution";
            panelSolution.Size = new Size(908, 199);
            panelSolution.TabIndex = 3;
            // 
            // labelSolution
            // 
            labelSolution.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelSolution.AutoSize = true;
            labelSolution.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelSolution.Location = new Point(407, 18);
            labelSolution.Name = "labelSolution";
            labelSolution.Size = new Size(94, 24);
            labelSolution.TabIndex = 1;
            labelSolution.Text = "Solution:";
            labelSolution.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonOK
            // 
            buttonOK.DialogResult = DialogResult.OK;
            buttonOK.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOK.Location = new Point(397, 131);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(115, 53);
            buttonOK.TabIndex = 2;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            // 
            // SolutionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 223);
            Controls.Add(panelSolution);
            Name = "SolutionForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Solution";
            Load += SolutionForm_Load;
            panelSolution.ResumeLayout(false);
            panelSolution.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxSolution;
        private Panel panelSolution;
        private Label labelSolution;
        private Button buttonOK;
    }
}