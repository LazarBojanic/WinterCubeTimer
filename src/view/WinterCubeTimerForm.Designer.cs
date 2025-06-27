namespace WinterCubeTimer.view {
    partial class WinterCubeTimerForm {
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
            components = new System.ComponentModel.Container();
            labelTimer = new System.Windows.Forms.Label();
            timerSolve = new System.Windows.Forms.Timer(components);
            panelTimer = new System.Windows.Forms.Panel();
            panelTimerAndButtons = new System.Windows.Forms.Panel();
            checkBoxInspectionEnabled = new System.Windows.Forms.CheckBox();
            buttonSolveCube = new System.Windows.Forms.Button();
            buttonNewScramble = new System.Windows.Forms.Button();
            labelScramble = new System.Windows.Forms.Label();
            buttonExportCubeState = new System.Windows.Forms.Button();
            panelTurns = new System.Windows.Forms.Panel();
            buttonLeftTurn = new System.Windows.Forms.Button();
            buttonFrontTurn = new System.Windows.Forms.Button();
            buttonDownTurn = new System.Windows.Forms.Button();
            buttonUpTurn = new System.Windows.Forms.Button();
            buttonBackTurn = new System.Windows.Forms.Button();
            buttonRightTurn = new System.Windows.Forms.Button();
            panelCube = new System.Windows.Forms.Panel();
            panelDown = new System.Windows.Forms.Panel();
            panelDown8 = new System.Windows.Forms.Panel();
            panelDown0 = new System.Windows.Forms.Panel();
            panelDown7 = new System.Windows.Forms.Panel();
            panelDown1 = new System.Windows.Forms.Panel();
            panelDown6 = new System.Windows.Forms.Panel();
            panelDown2 = new System.Windows.Forms.Panel();
            panelDown5 = new System.Windows.Forms.Panel();
            panelDown3 = new System.Windows.Forms.Panel();
            panelDown4 = new System.Windows.Forms.Panel();
            panelBack = new System.Windows.Forms.Panel();
            panelBack8 = new System.Windows.Forms.Panel();
            panelBack0 = new System.Windows.Forms.Panel();
            panelBack7 = new System.Windows.Forms.Panel();
            panelBack1 = new System.Windows.Forms.Panel();
            panelBack6 = new System.Windows.Forms.Panel();
            panelBack2 = new System.Windows.Forms.Panel();
            panelBack5 = new System.Windows.Forms.Panel();
            panelBack3 = new System.Windows.Forms.Panel();
            panelBack4 = new System.Windows.Forms.Panel();
            panelRight = new System.Windows.Forms.Panel();
            panelRight8 = new System.Windows.Forms.Panel();
            panelRight0 = new System.Windows.Forms.Panel();
            panelRight7 = new System.Windows.Forms.Panel();
            panelRight1 = new System.Windows.Forms.Panel();
            panelRight6 = new System.Windows.Forms.Panel();
            panelRight2 = new System.Windows.Forms.Panel();
            panelRight5 = new System.Windows.Forms.Panel();
            panelRight3 = new System.Windows.Forms.Panel();
            panelRight4 = new System.Windows.Forms.Panel();
            panelUp = new System.Windows.Forms.Panel();
            panelUp8 = new System.Windows.Forms.Panel();
            panelUp0 = new System.Windows.Forms.Panel();
            panelUp7 = new System.Windows.Forms.Panel();
            panelUp1 = new System.Windows.Forms.Panel();
            panelUp6 = new System.Windows.Forms.Panel();
            panelUp2 = new System.Windows.Forms.Panel();
            panelUp5 = new System.Windows.Forms.Panel();
            panelUp3 = new System.Windows.Forms.Panel();
            panelUp4 = new System.Windows.Forms.Panel();
            panelFront = new System.Windows.Forms.Panel();
            panelFront8 = new System.Windows.Forms.Panel();
            panelFront0 = new System.Windows.Forms.Panel();
            panelFront7 = new System.Windows.Forms.Panel();
            panelFront1 = new System.Windows.Forms.Panel();
            panelFront6 = new System.Windows.Forms.Panel();
            panelFront2 = new System.Windows.Forms.Panel();
            panelFront5 = new System.Windows.Forms.Panel();
            panelFront3 = new System.Windows.Forms.Panel();
            panelFront4 = new System.Windows.Forms.Panel();
            panelLeft = new System.Windows.Forms.Panel();
            panelLeft8 = new System.Windows.Forms.Panel();
            panelLeft7 = new System.Windows.Forms.Panel();
            panelLeft6 = new System.Windows.Forms.Panel();
            panelLeft5 = new System.Windows.Forms.Panel();
            panelLeft4 = new System.Windows.Forms.Panel();
            panelLeft3 = new System.Windows.Forms.Panel();
            panelLeft2 = new System.Windows.Forms.Panel();
            panelLeft1 = new System.Windows.Forms.Panel();
            panelLeft0 = new System.Windows.Forms.Panel();
            flowLayoutPanelTimes = new System.Windows.Forms.FlowLayoutPanel();
            panelStats = new System.Windows.Forms.Panel();
            labelBestTimeOverall = new System.Windows.Forms.Label();
            labelAverageOfTwelve = new System.Windows.Forms.Label();
            labelAverageOfFive = new System.Windows.Forms.Label();
            comboBoxSession = new System.Windows.Forms.ComboBox();
            buttonSelectSession = new System.Windows.Forms.Button();
            buttonDeleteAllFromSession = new System.Windows.Forms.Button();
            timerInspection = new System.Windows.Forms.Timer(components);
            panelTimer.SuspendLayout();
            panelTimerAndButtons.SuspendLayout();
            panelTurns.SuspendLayout();
            panelCube.SuspendLayout();
            panelDown.SuspendLayout();
            panelBack.SuspendLayout();
            panelRight.SuspendLayout();
            panelUp.SuspendLayout();
            panelFront.SuspendLayout();
            panelLeft.SuspendLayout();
            panelStats.SuspendLayout();
            SuspendLayout();
            // 
            // labelTimer
            // 
            labelTimer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            labelTimer.AutoSize = true;
            labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F);
            labelTimer.Location = new System.Drawing.Point(306, 155);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new System.Drawing.Size(521, 108);
            labelTimer.TabIndex = 0;
            labelTimer.Text = "00 : 00 . 00";
            labelTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerSolve
            // 
            timerSolve.Interval = 10;
            timerSolve.Tick += timerSolve_Tick;
            // 
            // panelTimer
            // 
            panelTimer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelTimer.Controls.Add(panelTimerAndButtons);
            panelTimer.Controls.Add(panelTurns);
            panelTimer.Controls.Add(panelCube);
            panelTimer.Location = new System.Drawing.Point(360, 12);
            panelTimer.Name = "panelTimer";
            panelTimer.Size = new System.Drawing.Size(1141, 782);
            panelTimer.TabIndex = 2;
            // 
            // panelTimerAndButtons
            // 
            panelTimerAndButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelTimerAndButtons.Controls.Add(checkBoxInspectionEnabled);
            panelTimerAndButtons.Controls.Add(buttonSolveCube);
            panelTimerAndButtons.Controls.Add(buttonNewScramble);
            panelTimerAndButtons.Controls.Add(labelScramble);
            panelTimerAndButtons.Controls.Add(buttonExportCubeState);
            panelTimerAndButtons.Controls.Add(labelTimer);
            panelTimerAndButtons.Location = new System.Drawing.Point(3, 3);
            panelTimerAndButtons.Name = "panelTimerAndButtons";
            panelTimerAndButtons.Size = new System.Drawing.Size(1132, 428);
            panelTimerAndButtons.TabIndex = 13;
            // 
            // checkBoxInspectionEnabled
            // 
            checkBoxInspectionEnabled.Appearance = System.Windows.Forms.Appearance.Button;
            checkBoxInspectionEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            checkBoxInspectionEnabled.Location = new System.Drawing.Point(3, 3);
            checkBoxInspectionEnabled.Name = "checkBoxInspectionEnabled";
            checkBoxInspectionEnabled.Size = new System.Drawing.Size(163, 70);
            checkBoxInspectionEnabled.TabIndex = 10;
            checkBoxInspectionEnabled.Text = "Inspection On/Off";
            checkBoxInspectionEnabled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            checkBoxInspectionEnabled.UseVisualStyleBackColor = true;
            checkBoxInspectionEnabled.CheckedChanged += checkBoxInspectionEnabled_CheckedChanged;
            // 
            // buttonSolveCube
            // 
            buttonSolveCube.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
            buttonSolveCube.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            buttonSolveCube.Location = new System.Drawing.Point(966, 355);
            buttonSolveCube.Name = "buttonSolveCube";
            buttonSolveCube.Size = new System.Drawing.Size(163, 70);
            buttonSolveCube.TabIndex = 12;
            buttonSolveCube.Text = "Solve Cube";
            buttonSolveCube.UseVisualStyleBackColor = true;
            buttonSolveCube.MouseClick += buttonSolveCube_MouseClick;
            // 
            // buttonNewScramble
            // 
            buttonNewScramble.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            buttonNewScramble.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            buttonNewScramble.Location = new System.Drawing.Point(966, 3);
            buttonNewScramble.Name = "buttonNewScramble";
            buttonNewScramble.Size = new System.Drawing.Size(163, 70);
            buttonNewScramble.TabIndex = 8;
            buttonNewScramble.Text = "New Scramble";
            buttonNewScramble.UseVisualStyleBackColor = true;
            buttonNewScramble.MouseClick += buttonNewScramble_MouseClick;
            // 
            // labelScramble
            // 
            labelScramble.Anchor = System.Windows.Forms.AnchorStyles.Top;
            labelScramble.AutoSize = true;
            labelScramble.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            labelScramble.Location = new System.Drawing.Point(487, 86);
            labelScramble.Name = "labelScramble";
            labelScramble.Size = new System.Drawing.Size(152, 37);
            labelScramble.TabIndex = 1;
            labelScramble.Text = "Scramble";
            labelScramble.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonExportCubeState
            // 
            buttonExportCubeState.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
            buttonExportCubeState.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            buttonExportCubeState.Location = new System.Drawing.Point(3, 355);
            buttonExportCubeState.Name = "buttonExportCubeState";
            buttonExportCubeState.Size = new System.Drawing.Size(163, 70);
            buttonExportCubeState.TabIndex = 11;
            buttonExportCubeState.Text = "Export Cube State";
            buttonExportCubeState.UseVisualStyleBackColor = true;
            buttonExportCubeState.MouseClick += buttonExportCubeState_MouseClick;
            // 
            // panelTurns
            // 
            panelTurns.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
            panelTurns.Controls.Add(buttonLeftTurn);
            panelTurns.Controls.Add(buttonFrontTurn);
            panelTurns.Controls.Add(buttonDownTurn);
            panelTurns.Controls.Add(buttonUpTurn);
            panelTurns.Controls.Add(buttonBackTurn);
            panelTurns.Controls.Add(buttonRightTurn);
            panelTurns.Location = new System.Drawing.Point(3, 437);
            panelTurns.Name = "panelTurns";
            panelTurns.Size = new System.Drawing.Size(456, 342);
            panelTurns.TabIndex = 9;
            // 
            // buttonLeftTurn
            // 
            buttonLeftTurn.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
            buttonLeftTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            buttonLeftTurn.Location = new System.Drawing.Point(3, 117);
            buttonLeftTurn.Name = "buttonLeftTurn";
            buttonLeftTurn.Size = new System.Drawing.Size(108, 108);
            buttonLeftTurn.TabIndex = 2;
            buttonLeftTurn.TabStop = false;
            buttonLeftTurn.Text = "Left";
            buttonLeftTurn.UseVisualStyleBackColor = true;
            buttonLeftTurn.MouseDown += buttonLeftTurn_MouseDown;
            // 
            // buttonFrontTurn
            // 
            buttonFrontTurn.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
            buttonFrontTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            buttonFrontTurn.Location = new System.Drawing.Point(117, 117);
            buttonFrontTurn.Name = "buttonFrontTurn";
            buttonFrontTurn.Size = new System.Drawing.Size(108, 108);
            buttonFrontTurn.TabIndex = 3;
            buttonFrontTurn.TabStop = false;
            buttonFrontTurn.Text = "Front";
            buttonFrontTurn.UseVisualStyleBackColor = true;
            buttonFrontTurn.MouseDown += buttonFrontTurn_MouseDown;
            // 
            // buttonDownTurn
            // 
            buttonDownTurn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            buttonDownTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            buttonDownTurn.Location = new System.Drawing.Point(117, 231);
            buttonDownTurn.Name = "buttonDownTurn";
            buttonDownTurn.Size = new System.Drawing.Size(108, 108);
            buttonDownTurn.TabIndex = 7;
            buttonDownTurn.TabStop = false;
            buttonDownTurn.Text = "Down";
            buttonDownTurn.UseVisualStyleBackColor = true;
            buttonDownTurn.MouseDown += buttonDownTurn_MouseDown;
            // 
            // buttonUpTurn
            // 
            buttonUpTurn.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
            buttonUpTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            buttonUpTurn.Location = new System.Drawing.Point(117, 3);
            buttonUpTurn.Name = "buttonUpTurn";
            buttonUpTurn.Size = new System.Drawing.Size(108, 108);
            buttonUpTurn.TabIndex = 4;
            buttonUpTurn.TabStop = false;
            buttonUpTurn.Text = "Up";
            buttonUpTurn.UseVisualStyleBackColor = true;
            buttonUpTurn.MouseDown += buttonUpTurn_MouseDown;
            // 
            // buttonBackTurn
            // 
            buttonBackTurn.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
            buttonBackTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            buttonBackTurn.Location = new System.Drawing.Point(345, 117);
            buttonBackTurn.Name = "buttonBackTurn";
            buttonBackTurn.Size = new System.Drawing.Size(108, 108);
            buttonBackTurn.TabIndex = 6;
            buttonBackTurn.TabStop = false;
            buttonBackTurn.Text = "Back";
            buttonBackTurn.UseVisualStyleBackColor = true;
            buttonBackTurn.MouseDown += buttonBackTurn_MouseDown;
            // 
            // buttonRightTurn
            // 
            buttonRightTurn.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
            buttonRightTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            buttonRightTurn.Location = new System.Drawing.Point(231, 117);
            buttonRightTurn.Name = "buttonRightTurn";
            buttonRightTurn.Size = new System.Drawing.Size(108, 108);
            buttonRightTurn.TabIndex = 5;
            buttonRightTurn.TabStop = false;
            buttonRightTurn.Text = "Right";
            buttonRightTurn.UseVisualStyleBackColor = true;
            buttonRightTurn.MouseDown += buttonRightTurn_MouseDown;
            // 
            // panelCube
            // 
            panelCube.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
            panelCube.Controls.Add(panelDown);
            panelCube.Controls.Add(panelBack);
            panelCube.Controls.Add(panelRight);
            panelCube.Controls.Add(panelUp);
            panelCube.Controls.Add(panelFront);
            panelCube.Controls.Add(panelLeft);
            panelCube.Location = new System.Drawing.Point(682, 437);
            panelCube.Name = "panelCube";
            panelCube.Size = new System.Drawing.Size(456, 342);
            panelCube.TabIndex = 1;
            // 
            // panelDown
            // 
            panelDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelDown.BackColor = System.Drawing.Color.Black;
            panelDown.Controls.Add(panelDown8);
            panelDown.Controls.Add(panelDown0);
            panelDown.Controls.Add(panelDown7);
            panelDown.Controls.Add(panelDown1);
            panelDown.Controls.Add(panelDown6);
            panelDown.Controls.Add(panelDown2);
            panelDown.Controls.Add(panelDown5);
            panelDown.Controls.Add(panelDown3);
            panelDown.Controls.Add(panelDown4);
            panelDown.Location = new System.Drawing.Point(117, 231);
            panelDown.Name = "panelDown";
            panelDown.Size = new System.Drawing.Size(108, 108);
            panelDown.TabIndex = 1;
            // 
            // panelDown8
            // 
            panelDown8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelDown8.Location = new System.Drawing.Point(75, 75);
            panelDown8.Name = "panelDown8";
            panelDown8.Size = new System.Drawing.Size(30, 30);
            panelDown8.TabIndex = 8;
            // 
            // panelDown0
            // 
            panelDown0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelDown0.Location = new System.Drawing.Point(3, 3);
            panelDown0.Name = "panelDown0";
            panelDown0.Size = new System.Drawing.Size(30, 30);
            panelDown0.TabIndex = 0;
            // 
            // panelDown7
            // 
            panelDown7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelDown7.Location = new System.Drawing.Point(39, 75);
            panelDown7.Name = "panelDown7";
            panelDown7.Size = new System.Drawing.Size(30, 30);
            panelDown7.TabIndex = 7;
            // 
            // panelDown1
            // 
            panelDown1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelDown1.Location = new System.Drawing.Point(39, 3);
            panelDown1.Name = "panelDown1";
            panelDown1.Size = new System.Drawing.Size(30, 30);
            panelDown1.TabIndex = 1;
            // 
            // panelDown6
            // 
            panelDown6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelDown6.Location = new System.Drawing.Point(3, 75);
            panelDown6.Name = "panelDown6";
            panelDown6.Size = new System.Drawing.Size(30, 30);
            panelDown6.TabIndex = 6;
            // 
            // panelDown2
            // 
            panelDown2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelDown2.Location = new System.Drawing.Point(75, 3);
            panelDown2.Name = "panelDown2";
            panelDown2.Size = new System.Drawing.Size(30, 30);
            panelDown2.TabIndex = 2;
            // 
            // panelDown5
            // 
            panelDown5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelDown5.Location = new System.Drawing.Point(75, 39);
            panelDown5.Name = "panelDown5";
            panelDown5.Size = new System.Drawing.Size(30, 30);
            panelDown5.TabIndex = 5;
            // 
            // panelDown3
            // 
            panelDown3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelDown3.Location = new System.Drawing.Point(3, 39);
            panelDown3.Name = "panelDown3";
            panelDown3.Size = new System.Drawing.Size(30, 30);
            panelDown3.TabIndex = 3;
            // 
            // panelDown4
            // 
            panelDown4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelDown4.Location = new System.Drawing.Point(39, 39);
            panelDown4.Name = "panelDown4";
            panelDown4.Size = new System.Drawing.Size(30, 30);
            panelDown4.TabIndex = 4;
            // 
            // panelBack
            // 
            panelBack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelBack.BackColor = System.Drawing.Color.Black;
            panelBack.Controls.Add(panelBack8);
            panelBack.Controls.Add(panelBack0);
            panelBack.Controls.Add(panelBack7);
            panelBack.Controls.Add(panelBack1);
            panelBack.Controls.Add(panelBack6);
            panelBack.Controls.Add(panelBack2);
            panelBack.Controls.Add(panelBack5);
            panelBack.Controls.Add(panelBack3);
            panelBack.Controls.Add(panelBack4);
            panelBack.Location = new System.Drawing.Point(345, 117);
            panelBack.Name = "panelBack";
            panelBack.Size = new System.Drawing.Size(108, 108);
            panelBack.TabIndex = 5;
            // 
            // panelBack8
            // 
            panelBack8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelBack8.Location = new System.Drawing.Point(75, 75);
            panelBack8.Name = "panelBack8";
            panelBack8.Size = new System.Drawing.Size(30, 30);
            panelBack8.TabIndex = 8;
            // 
            // panelBack0
            // 
            panelBack0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelBack0.Location = new System.Drawing.Point(3, 3);
            panelBack0.Name = "panelBack0";
            panelBack0.Size = new System.Drawing.Size(30, 30);
            panelBack0.TabIndex = 0;
            // 
            // panelBack7
            // 
            panelBack7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelBack7.Location = new System.Drawing.Point(39, 75);
            panelBack7.Name = "panelBack7";
            panelBack7.Size = new System.Drawing.Size(30, 30);
            panelBack7.TabIndex = 7;
            // 
            // panelBack1
            // 
            panelBack1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelBack1.Location = new System.Drawing.Point(39, 3);
            panelBack1.Name = "panelBack1";
            panelBack1.Size = new System.Drawing.Size(30, 30);
            panelBack1.TabIndex = 1;
            // 
            // panelBack6
            // 
            panelBack6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelBack6.Location = new System.Drawing.Point(3, 75);
            panelBack6.Name = "panelBack6";
            panelBack6.Size = new System.Drawing.Size(30, 30);
            panelBack6.TabIndex = 6;
            // 
            // panelBack2
            // 
            panelBack2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelBack2.Location = new System.Drawing.Point(75, 3);
            panelBack2.Name = "panelBack2";
            panelBack2.Size = new System.Drawing.Size(30, 30);
            panelBack2.TabIndex = 2;
            // 
            // panelBack5
            // 
            panelBack5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelBack5.Location = new System.Drawing.Point(75, 39);
            panelBack5.Name = "panelBack5";
            panelBack5.Size = new System.Drawing.Size(30, 30);
            panelBack5.TabIndex = 5;
            // 
            // panelBack3
            // 
            panelBack3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelBack3.Location = new System.Drawing.Point(3, 39);
            panelBack3.Name = "panelBack3";
            panelBack3.Size = new System.Drawing.Size(30, 30);
            panelBack3.TabIndex = 3;
            // 
            // panelBack4
            // 
            panelBack4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelBack4.Location = new System.Drawing.Point(39, 39);
            panelBack4.Name = "panelBack4";
            panelBack4.Size = new System.Drawing.Size(30, 30);
            panelBack4.TabIndex = 4;
            // 
            // panelRight
            // 
            panelRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelRight.BackColor = System.Drawing.Color.Black;
            panelRight.Controls.Add(panelRight8);
            panelRight.Controls.Add(panelRight0);
            panelRight.Controls.Add(panelRight7);
            panelRight.Controls.Add(panelRight1);
            panelRight.Controls.Add(panelRight6);
            panelRight.Controls.Add(panelRight2);
            panelRight.Controls.Add(panelRight5);
            panelRight.Controls.Add(panelRight3);
            panelRight.Controls.Add(panelRight4);
            panelRight.Location = new System.Drawing.Point(231, 117);
            panelRight.Name = "panelRight";
            panelRight.Size = new System.Drawing.Size(108, 108);
            panelRight.TabIndex = 3;
            // 
            // panelRight8
            // 
            panelRight8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelRight8.Location = new System.Drawing.Point(75, 75);
            panelRight8.Name = "panelRight8";
            panelRight8.Size = new System.Drawing.Size(30, 30);
            panelRight8.TabIndex = 8;
            // 
            // panelRight0
            // 
            panelRight0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelRight0.Location = new System.Drawing.Point(3, 3);
            panelRight0.Name = "panelRight0";
            panelRight0.Size = new System.Drawing.Size(30, 30);
            panelRight0.TabIndex = 0;
            // 
            // panelRight7
            // 
            panelRight7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelRight7.Location = new System.Drawing.Point(39, 75);
            panelRight7.Name = "panelRight7";
            panelRight7.Size = new System.Drawing.Size(30, 30);
            panelRight7.TabIndex = 7;
            // 
            // panelRight1
            // 
            panelRight1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelRight1.Location = new System.Drawing.Point(39, 3);
            panelRight1.Name = "panelRight1";
            panelRight1.Size = new System.Drawing.Size(30, 30);
            panelRight1.TabIndex = 1;
            // 
            // panelRight6
            // 
            panelRight6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelRight6.Location = new System.Drawing.Point(3, 75);
            panelRight6.Name = "panelRight6";
            panelRight6.Size = new System.Drawing.Size(30, 30);
            panelRight6.TabIndex = 6;
            // 
            // panelRight2
            // 
            panelRight2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelRight2.Location = new System.Drawing.Point(75, 3);
            panelRight2.Name = "panelRight2";
            panelRight2.Size = new System.Drawing.Size(30, 30);
            panelRight2.TabIndex = 2;
            // 
            // panelRight5
            // 
            panelRight5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelRight5.Location = new System.Drawing.Point(75, 39);
            panelRight5.Name = "panelRight5";
            panelRight5.Size = new System.Drawing.Size(30, 30);
            panelRight5.TabIndex = 5;
            // 
            // panelRight3
            // 
            panelRight3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelRight3.Location = new System.Drawing.Point(3, 39);
            panelRight3.Name = "panelRight3";
            panelRight3.Size = new System.Drawing.Size(30, 30);
            panelRight3.TabIndex = 3;
            // 
            // panelRight4
            // 
            panelRight4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelRight4.Location = new System.Drawing.Point(39, 39);
            panelRight4.Name = "panelRight4";
            panelRight4.Size = new System.Drawing.Size(30, 30);
            panelRight4.TabIndex = 4;
            // 
            // panelUp
            // 
            panelUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelUp.BackColor = System.Drawing.Color.Black;
            panelUp.Controls.Add(panelUp8);
            panelUp.Controls.Add(panelUp0);
            panelUp.Controls.Add(panelUp7);
            panelUp.Controls.Add(panelUp1);
            panelUp.Controls.Add(panelUp6);
            panelUp.Controls.Add(panelUp2);
            panelUp.Controls.Add(panelUp5);
            panelUp.Controls.Add(panelUp3);
            panelUp.Controls.Add(panelUp4);
            panelUp.Location = new System.Drawing.Point(117, 3);
            panelUp.Name = "panelUp";
            panelUp.Size = new System.Drawing.Size(108, 108);
            panelUp.TabIndex = 0;
            // 
            // panelUp8
            // 
            panelUp8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelUp8.Location = new System.Drawing.Point(75, 75);
            panelUp8.Name = "panelUp8";
            panelUp8.Size = new System.Drawing.Size(30, 30);
            panelUp8.TabIndex = 8;
            // 
            // panelUp0
            // 
            panelUp0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelUp0.Location = new System.Drawing.Point(3, 3);
            panelUp0.Name = "panelUp0";
            panelUp0.Size = new System.Drawing.Size(30, 30);
            panelUp0.TabIndex = 0;
            // 
            // panelUp7
            // 
            panelUp7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelUp7.Location = new System.Drawing.Point(39, 75);
            panelUp7.Name = "panelUp7";
            panelUp7.Size = new System.Drawing.Size(30, 30);
            panelUp7.TabIndex = 7;
            // 
            // panelUp1
            // 
            panelUp1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelUp1.Location = new System.Drawing.Point(39, 3);
            panelUp1.Name = "panelUp1";
            panelUp1.Size = new System.Drawing.Size(30, 30);
            panelUp1.TabIndex = 1;
            // 
            // panelUp6
            // 
            panelUp6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelUp6.Location = new System.Drawing.Point(3, 75);
            panelUp6.Name = "panelUp6";
            panelUp6.Size = new System.Drawing.Size(30, 30);
            panelUp6.TabIndex = 6;
            // 
            // panelUp2
            // 
            panelUp2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelUp2.Location = new System.Drawing.Point(75, 3);
            panelUp2.Name = "panelUp2";
            panelUp2.Size = new System.Drawing.Size(30, 30);
            panelUp2.TabIndex = 2;
            // 
            // panelUp5
            // 
            panelUp5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelUp5.Location = new System.Drawing.Point(75, 39);
            panelUp5.Name = "panelUp5";
            panelUp5.Size = new System.Drawing.Size(30, 30);
            panelUp5.TabIndex = 5;
            // 
            // panelUp3
            // 
            panelUp3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelUp3.Location = new System.Drawing.Point(3, 39);
            panelUp3.Name = "panelUp3";
            panelUp3.Size = new System.Drawing.Size(30, 30);
            panelUp3.TabIndex = 3;
            // 
            // panelUp4
            // 
            panelUp4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelUp4.Location = new System.Drawing.Point(39, 39);
            panelUp4.Name = "panelUp4";
            panelUp4.Size = new System.Drawing.Size(30, 30);
            panelUp4.TabIndex = 4;
            // 
            // panelFront
            // 
            panelFront.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelFront.BackColor = System.Drawing.Color.Black;
            panelFront.Controls.Add(panelFront8);
            panelFront.Controls.Add(panelFront0);
            panelFront.Controls.Add(panelFront7);
            panelFront.Controls.Add(panelFront1);
            panelFront.Controls.Add(panelFront6);
            panelFront.Controls.Add(panelFront2);
            panelFront.Controls.Add(panelFront5);
            panelFront.Controls.Add(panelFront3);
            panelFront.Controls.Add(panelFront4);
            panelFront.Location = new System.Drawing.Point(117, 117);
            panelFront.Name = "panelFront";
            panelFront.Size = new System.Drawing.Size(108, 108);
            panelFront.TabIndex = 4;
            // 
            // panelFront8
            // 
            panelFront8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelFront8.Location = new System.Drawing.Point(75, 75);
            panelFront8.Name = "panelFront8";
            panelFront8.Size = new System.Drawing.Size(30, 30);
            panelFront8.TabIndex = 8;
            // 
            // panelFront0
            // 
            panelFront0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelFront0.Location = new System.Drawing.Point(3, 3);
            panelFront0.Name = "panelFront0";
            panelFront0.Size = new System.Drawing.Size(30, 30);
            panelFront0.TabIndex = 0;
            // 
            // panelFront7
            // 
            panelFront7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelFront7.Location = new System.Drawing.Point(39, 75);
            panelFront7.Name = "panelFront7";
            panelFront7.Size = new System.Drawing.Size(30, 30);
            panelFront7.TabIndex = 7;
            // 
            // panelFront1
            // 
            panelFront1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelFront1.Location = new System.Drawing.Point(39, 3);
            panelFront1.Name = "panelFront1";
            panelFront1.Size = new System.Drawing.Size(30, 30);
            panelFront1.TabIndex = 1;
            // 
            // panelFront6
            // 
            panelFront6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelFront6.Location = new System.Drawing.Point(3, 75);
            panelFront6.Name = "panelFront6";
            panelFront6.Size = new System.Drawing.Size(30, 30);
            panelFront6.TabIndex = 6;
            // 
            // panelFront2
            // 
            panelFront2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelFront2.Location = new System.Drawing.Point(75, 3);
            panelFront2.Name = "panelFront2";
            panelFront2.Size = new System.Drawing.Size(30, 30);
            panelFront2.TabIndex = 2;
            // 
            // panelFront5
            // 
            panelFront5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelFront5.Location = new System.Drawing.Point(75, 39);
            panelFront5.Name = "panelFront5";
            panelFront5.Size = new System.Drawing.Size(30, 30);
            panelFront5.TabIndex = 5;
            // 
            // panelFront3
            // 
            panelFront3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelFront3.Location = new System.Drawing.Point(3, 39);
            panelFront3.Name = "panelFront3";
            panelFront3.Size = new System.Drawing.Size(30, 30);
            panelFront3.TabIndex = 3;
            // 
            // panelFront4
            // 
            panelFront4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelFront4.Location = new System.Drawing.Point(39, 39);
            panelFront4.Name = "panelFront4";
            panelFront4.Size = new System.Drawing.Size(30, 30);
            panelFront4.TabIndex = 4;
            // 
            // panelLeft
            // 
            panelLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelLeft.BackColor = System.Drawing.Color.Black;
            panelLeft.Controls.Add(panelLeft8);
            panelLeft.Controls.Add(panelLeft7);
            panelLeft.Controls.Add(panelLeft6);
            panelLeft.Controls.Add(panelLeft5);
            panelLeft.Controls.Add(panelLeft4);
            panelLeft.Controls.Add(panelLeft3);
            panelLeft.Controls.Add(panelLeft2);
            panelLeft.Controls.Add(panelLeft1);
            panelLeft.Controls.Add(panelLeft0);
            panelLeft.Location = new System.Drawing.Point(3, 117);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new System.Drawing.Size(108, 108);
            panelLeft.TabIndex = 2;
            // 
            // panelLeft8
            // 
            panelLeft8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelLeft8.Location = new System.Drawing.Point(75, 75);
            panelLeft8.Name = "panelLeft8";
            panelLeft8.Size = new System.Drawing.Size(30, 30);
            panelLeft8.TabIndex = 8;
            // 
            // panelLeft7
            // 
            panelLeft7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelLeft7.Location = new System.Drawing.Point(39, 75);
            panelLeft7.Name = "panelLeft7";
            panelLeft7.Size = new System.Drawing.Size(30, 30);
            panelLeft7.TabIndex = 7;
            // 
            // panelLeft6
            // 
            panelLeft6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelLeft6.Location = new System.Drawing.Point(3, 75);
            panelLeft6.Name = "panelLeft6";
            panelLeft6.Size = new System.Drawing.Size(30, 30);
            panelLeft6.TabIndex = 6;
            // 
            // panelLeft5
            // 
            panelLeft5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelLeft5.Location = new System.Drawing.Point(75, 39);
            panelLeft5.Name = "panelLeft5";
            panelLeft5.Size = new System.Drawing.Size(30, 30);
            panelLeft5.TabIndex = 5;
            // 
            // panelLeft4
            // 
            panelLeft4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelLeft4.Location = new System.Drawing.Point(39, 39);
            panelLeft4.Name = "panelLeft4";
            panelLeft4.Size = new System.Drawing.Size(30, 30);
            panelLeft4.TabIndex = 4;
            // 
            // panelLeft3
            // 
            panelLeft3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelLeft3.Location = new System.Drawing.Point(3, 39);
            panelLeft3.Name = "panelLeft3";
            panelLeft3.Size = new System.Drawing.Size(30, 30);
            panelLeft3.TabIndex = 3;
            // 
            // panelLeft2
            // 
            panelLeft2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelLeft2.Location = new System.Drawing.Point(75, 3);
            panelLeft2.Name = "panelLeft2";
            panelLeft2.Size = new System.Drawing.Size(30, 30);
            panelLeft2.TabIndex = 2;
            // 
            // panelLeft1
            // 
            panelLeft1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelLeft1.Location = new System.Drawing.Point(39, 3);
            panelLeft1.Name = "panelLeft1";
            panelLeft1.Size = new System.Drawing.Size(30, 30);
            panelLeft1.TabIndex = 1;
            // 
            // panelLeft0
            // 
            panelLeft0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            panelLeft0.Location = new System.Drawing.Point(3, 3);
            panelLeft0.Name = "panelLeft0";
            panelLeft0.Size = new System.Drawing.Size(30, 30);
            panelLeft0.TabIndex = 0;
            // 
            // flowLayoutPanelTimes
            // 
            flowLayoutPanelTimes.AutoScroll = true;
            flowLayoutPanelTimes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            flowLayoutPanelTimes.Location = new System.Drawing.Point(12, 12);
            flowLayoutPanelTimes.Name = "flowLayoutPanelTimes";
            flowLayoutPanelTimes.Size = new System.Drawing.Size(342, 576);
            flowLayoutPanelTimes.TabIndex = 3;
            // 
            // panelStats
            // 
            panelStats.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
            panelStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelStats.Controls.Add(labelBestTimeOverall);
            panelStats.Controls.Add(labelAverageOfTwelve);
            panelStats.Controls.Add(labelAverageOfFive);
            panelStats.Location = new System.Drawing.Point(12, 671);
            panelStats.Name = "panelStats";
            panelStats.Size = new System.Drawing.Size(342, 123);
            panelStats.TabIndex = 4;
            // 
            // labelBestTime
            // 
            labelBestTimeOverall.AutoSize = true;
            labelBestTimeOverall.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            labelBestTimeOverall.Location = new System.Drawing.Point(15, 83);
            labelBestTimeOverall.Name = "labelBestTimeOverall";
            labelBestTimeOverall.Size = new System.Drawing.Size(99, 24);
            labelBestTimeOverall.TabIndex = 2;
            labelBestTimeOverall.Text = "Best Time:";
            // 
            // labelAverageOfTwelve
            // 
            labelAverageOfTwelve.AutoSize = true;
            labelAverageOfTwelve.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            labelAverageOfTwelve.Location = new System.Drawing.Point(15, 49);
            labelAverageOfTwelve.Name = "labelAverageOfTwelve";
            labelAverageOfTwelve.Size = new System.Drawing.Size(59, 24);
            labelAverageOfTwelve.TabIndex = 1;
            labelAverageOfTwelve.Text = "Ao12:";
            // 
            // labelAverageOfFive
            // 
            labelAverageOfFive.AutoSize = true;
            labelAverageOfFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            labelAverageOfFive.Location = new System.Drawing.Point(15, 15);
            labelAverageOfFive.Name = "labelAverageOfFive";
            labelAverageOfFive.Size = new System.Drawing.Size(49, 24);
            labelAverageOfFive.TabIndex = 0;
            labelAverageOfFive.Text = "Ao5:";
            // 
            // comboBoxSession
            // 
            comboBoxSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            comboBoxSession.FormattingEnabled = true;
            comboBoxSession.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            comboBoxSession.Location = new System.Drawing.Point(12, 603);
            comboBoxSession.Name = "comboBoxSession";
            comboBoxSession.Size = new System.Drawing.Size(80, 39);
            comboBoxSession.TabIndex = 5;
            comboBoxSession.TabStop = false;
            // 
            // buttonSelectSession
            // 
            buttonSelectSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            buttonSelectSession.Location = new System.Drawing.Point(98, 594);
            buttonSelectSession.Name = "buttonSelectSession";
            buttonSelectSession.Size = new System.Drawing.Size(89, 59);
            buttonSelectSession.TabIndex = 9;
            buttonSelectSession.TabStop = false;
            buttonSelectSession.Text = "Select";
            buttonSelectSession.UseVisualStyleBackColor = true;
            buttonSelectSession.MouseClick += buttonSelectSession_MouseClick;
            // 
            // buttonDeleteAllFromSession
            // 
            buttonDeleteAllFromSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            buttonDeleteAllFromSession.Location = new System.Drawing.Point(193, 594);
            buttonDeleteAllFromSession.Name = "buttonDeleteAllFromSession";
            buttonDeleteAllFromSession.Size = new System.Drawing.Size(161, 59);
            buttonDeleteAllFromSession.TabIndex = 10;
            buttonDeleteAllFromSession.TabStop = false;
            buttonDeleteAllFromSession.Text = "Delete All From Session";
            buttonDeleteAllFromSession.UseVisualStyleBackColor = true;
            buttonDeleteAllFromSession.MouseClick += buttonDeleteAllFromSession_MouseClick;
            // 
            // timerInspection
            // 
            timerInspection.Tick += timerInspection_Tick;
            // 
            // WinterCubeTimerForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1513, 806);
            Controls.Add(buttonDeleteAllFromSession);
            Controls.Add(buttonSelectSession);
            Controls.Add(comboBoxSession);
            Controls.Add(panelStats);
            Controls.Add(flowLayoutPanelTimes);
            Controls.Add(panelTimer);
            KeyPreview = true;
            MinimumSize = new System.Drawing.Size(1529, 845);
            Name = "WinterCubeTimerForm";
            Text = "Winter Cube Timer";
            FormClosing += WinterCubeTimerForm_FormClosing;
            Load += WinterCubeTimerForm_Load;
            KeyDown += WinterCubeTimerForm_KeyDown;
            KeyUp += WinterCubeTimerForm_KeyUp;
            panelTimer.ResumeLayout(false);
            panelTimerAndButtons.ResumeLayout(false);
            panelTimerAndButtons.PerformLayout();
            panelTurns.ResumeLayout(false);
            panelCube.ResumeLayout(false);
            panelDown.ResumeLayout(false);
            panelBack.ResumeLayout(false);
            panelRight.ResumeLayout(false);
            panelUp.ResumeLayout(false);
            panelFront.ResumeLayout(false);
            panelLeft.ResumeLayout(false);
            panelStats.ResumeLayout(false);
            panelStats.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelTimer;
        private System.Windows.Forms.Timer timerSolve;
        private Panel panelTimer;
        private Label labelScramble;
        private Panel panelCube;
        private Panel panelLeft;
        private Panel panelUp;
        private Panel panelFront;
        private Panel panelDown;
        private Panel panelBack;
        private Panel panelRight;
        private Panel panelLeft8;
        private Panel panelLeft7;
        private Panel panelLeft6;
        private Panel panelLeft5;
        private Panel panelLeft4;
        private Panel panelLeft3;
        private Panel panelLeft2;
        private Panel panelLeft1;
        private Panel panelLeft0;
        private Panel panelDown8;
        private Panel panelDown0;
        private Panel panelDown7;
        private Panel panelDown1;
        private Panel panelDown6;
        private Panel panelDown2;
        private Panel panelDown5;
        private Panel panelDown3;
        private Panel panelDown4;
        private Panel panelBack8;
        private Panel panelBack0;
        private Panel panelBack7;
        private Panel panelBack1;
        private Panel panelBack6;
        private Panel panelBack2;
        private Panel panelBack5;
        private Panel panelBack3;
        private Panel panelBack4;
        private Panel panelRight8;
        private Panel panelRight0;
        private Panel panelRight7;
        private Panel panelRight1;
        private Panel panelRight6;
        private Panel panelRight2;
        private Panel panelRight5;
        private Panel panelRight3;
        private Panel panelRight4;
        private Panel panelUp8;
        private Panel panelUp0;
        private Panel panelUp7;
        private Panel panelUp1;
        private Panel panelUp6;
        private Panel panelUp2;
        private Panel panelUp5;
        private Panel panelUp3;
        private Panel panelUp4;
        private Panel panelFront8;
        private Panel panelFront0;
        private Panel panelFront7;
        private Panel panelFront1;
        private Panel panelFront6;
        private Panel panelFront2;
        private Panel panelFront5;
        private Panel panelFront3;
        private Panel panelFront4;
        private Button buttonDownTurn;
        private Button buttonBackTurn;
        private Button buttonRightTurn;
        private Button buttonUpTurn;
        private Button buttonFrontTurn;
        private Button buttonLeftTurn;
        public FlowLayoutPanel flowLayoutPanelTimes;
        private Panel panelStats;
        private Label labelBestTimeOverall;
        private Label labelAverageOfTwelve;
        private Label labelAverageOfFive;
        private ComboBox comboBoxSession;
        private Button buttonNewScramble;
        private Button buttonSelectSession;
        private Panel panelTurns;
        private Button buttonDeleteAllFromSession;
        private CheckBox checkBoxInspectionEnabled;
        private System.Windows.Forms.Timer timerInspection;
        private Button buttonExportCubeState;
        private Button buttonSolveCube;
        private Panel panelTimerAndButtons;
    }
}