using WinterCubeTimer.model;
using WinterCubeTimer.util;
using System.Diagnostics;
using Kociemba;
using WinterCubeTimer.service;

namespace WinterCubeTimer.view {
    public partial class WinterCubeTimerForm : Form {
        public enum TimerStates {
            IDLE,
            INSPECTION,
            SOLVING,
            STOPPED
        }
        private bool isPlusTwoInInspection;
        private int currentSession = 1;
        private TimerStates timerState = TimerStates.IDLE;
        private List<string> scramble;
        private Cube initialCube;
        private Cube cubeToTurn;
        private Cube scrambledCube;
        private List<SolveTime> timeList { get; set; }
        private List<SolveTimeUserControl> solveTimeUserControlList { get; set; }
        private Stopwatch solveStopwatch{ get; set; }
        private Stopwatch inspectionStopwatch{ get; set; }
        private SolveTime bestTimeOverall { get; set; }
        private SolveTime bestTimeForLatestAverage { get; set; }
        private List<SolveTime> timeListAverageOfFive { get; set; }
        private List<SolveTime> timeListAverageOfTwelve { get; set; }
        private long averageOfFiveInMilliseconds{ get; set; }
        private long averageOfTwelveInMilliseconds{ get; set; }
        private string bestTimeOverallString { get; set; }
        private string bestTimeForLatestAverageString { get; set; }
        private string averageOfFiveString { get; set; }
        private string averageOfTwelveString { get; set; }
        private bool localInspectionEnabled {get; set;} 
        private ITimeService timeService;
        
        public WinterCubeTimerForm(ITimeService timeService) {
            InitializeComponent();
            this.timeService = timeService;
            generateScramble();
            validateTables();
            
            solveTimeUserControlList = new List<SolveTimeUserControl>();
            localInspectionEnabled = Config.getInstance().inspectionEnabled;
            isPlusTwoInInspection = false;
        }
        
        private async void WinterCubeTimerForm_Load(object sender, EventArgs e) {
            checkBoxInspectionEnabled.Checked = localInspectionEnabled;
            comboBoxSession.SelectedIndex = 0;
            await fillTimesPanel(currentSession);
            await displayScramble();
            await updateStats(currentSession);
            displayStats();
        }
        
        public static void validateTables() {
            try {
                Directory.CreateDirectory(Util.TABLES_DIRECTORY);
                string[] requiredFiles = [
                    "flip",
                    "FRtoBR",
                    "MergeURtoULandUBtoDF",
                    "Slice_Flip_Prun",
                    "Slice_Twist_Prun",
                    "Slice_URFtoDLF_Parity_Prun",
                    "Slice_URtoDF_Parity_Prun",
                    "twist",
                    "UBtoDF",
                    "URFtoDLF",
                    "URtoDF",
                    "URtoUL"
                ];
                bool tablesMissing = false;
                foreach (string file in requiredFiles) {
                    if (!File.Exists(Path.Combine(Util.TABLES_DIRECTORY, file))) {
                        tablesMissing = true;
                        break;
                    }
                }
                if (tablesMissing) {
                    Console.WriteLine(@"Generating Kociemba pruning tables...");
                    string dummyInfo;
                    SearchRunTime.solution(
                        Tools.randomCube(),
                        out dummyInfo,
                        22,
                        6000L,
                        false,
                        true
                    );
                    Console.WriteLine(@"Kociemba pruning tables generated successfully.");
                }
                else {
                    Console.WriteLine(@"Kociemba pruning tables already exist.");
                }
            }
            catch (Exception ex) {
                Console.WriteLine(@"Error while initializing Kociemba tables: " + ex.Message);
                throw;
            }
        }

        public async Task updateStats(int session) {
            int numberOfSolvesBySession = await timeService.getNumberOfSolvesBySession(session);
            bestTimeOverall = new SolveTime();
            timeListAverageOfFive = [];
            timeListAverageOfTwelve = [];
            if (numberOfSolvesBySession >= 1) {
                bestTimeOverall = await timeService.getBestTimeBySession(session);
                bestTimeOverallString = "Best Time: " + Util.longMillisecondsToString(bestTimeOverall.solveInitialTimeInMilliseconds);
            }
            else {
                bestTimeOverallString = "Best Time:";
            }
            if (numberOfSolvesBySession >= 5) {
                timeListAverageOfFive = await timeService.getLatestXSolveTimeListOrderByCreatedTime(5, session);
                averageOfFiveInMilliseconds = timeService.calculateAverage(timeListAverageOfFive);
                averageOfFiveString = "Ao5: " + Util.longMillisecondsToString(averageOfFiveInMilliseconds);
            }
            else {
                averageOfFiveString = "Ao5:";
            }

            if (numberOfSolvesBySession >= 12) {
                timeListAverageOfTwelve = await timeService.getLatestXSolveTimeListOrderByCreatedTime(12, session);
                averageOfTwelveInMilliseconds = timeService.calculateAverage(timeListAverageOfTwelve);
                averageOfTwelveString = "Ao12: " + Util.longMillisecondsToString(averageOfTwelveInMilliseconds);
            }
            else {
                averageOfTwelveString = "Ao12:";
            }
        }

        public void displayStats() {
            labelBestTimeOverall.Text = bestTimeOverallString;
            labelAverageOfFive.Text = averageOfFiveString;
            labelAverageOfTwelve.Text = averageOfTwelveString;
        }

        private async void WinterCubeTimerForm_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Space) {
                if (localInspectionEnabled) {
                    if (timerState == TimerStates.IDLE) {
                        labelTimer.ForeColor = Color.MediumVioletRed;
                    }
                    else if (timerState == TimerStates.INSPECTION) {
                        labelTimer.ForeColor = Color.Lime;
                    }
                    else if (timerState == TimerStates.SOLVING) {
                        timerState = TimerStates.STOPPED;
                        await endSolve(isPlusTwoInInspection, false);
                    }
                }
                else {
                    if (timerState == TimerStates.IDLE) {
                        labelTimer.ForeColor = Color.Lime;
                    }
                    else if (timerState == TimerStates.SOLVING) {
                        timerState = TimerStates.STOPPED;
                        await endSolve(isPlusTwoInInspection, false);
                    }
                }
            }
        }

        private void WinterCubeTimerForm_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Space) {
                if (localInspectionEnabled) {
                    if (timerState == TimerStates.STOPPED) {
                        timerState = TimerStates.IDLE;
                    }
                    else if (timerState == TimerStates.IDLE) {
                        timerState = TimerStates.INSPECTION;
                        labelTimer.ForeColor = DefaultForeColor;
                        beginInspection();
                    }
                    else if (timerState == TimerStates.INSPECTION) {
                        timerState = TimerStates.SOLVING;
                        labelTimer.ForeColor = DefaultForeColor;
                        endInspection();
                        beginSolve();
                    }
                }
                else {
                    if (timerState == TimerStates.STOPPED) {
                        timerState = TimerStates.IDLE;
                    }
                    else if (timerState == TimerStates.IDLE) {
                        timerState = TimerStates.SOLVING;
                        labelTimer.ForeColor = DefaultForeColor;
                        beginSolve();
                    }
                }
            }
        }

        public async Task fillTimesPanel(int session) {
            timeList = await timeService.getSolveTimeListBySession(session);
            foreach(SolveTime solveTime in timeList) {
                SolveTimeUserControl solveTimeUserControl = new SolveTimeUserControl(timeService, this, solveTime);
                solveTimeUserControl.Left = (flowLayoutPanelTimes.Width - solveTimeUserControl.Width) / 2;
                solveTimeUserControl.Show();
                solveTimeUserControlList.Add(solveTimeUserControl);
                flowLayoutPanelTimes.Controls.Add(solveTimeUserControl);
            }
        }

        public void beginInspection() {
            inspectionStopwatch = new Stopwatch();
            inspectionStopwatch.Start();
            timerInspection.Start();
        }

        public void endInspection() {
            inspectionStopwatch.Stop();
            timerInspection.Stop();
        }

        public void beginSolve() {
            solveStopwatch = new Stopwatch();
            solveStopwatch.Start();
            timerSolve.Start();
        }

        public async Task endSolve(bool isPlusTwo, bool isDNF) {
            solveStopwatch.Stop();
            timerSolve.Stop();
            long elapsedMilliseconds = solveStopwatch.ElapsedMilliseconds;
            string solveTimeString = Util.longMillisecondsToString(elapsedMilliseconds);
            SolveTime time = new SolveTime(currentSession, elapsedMilliseconds, elapsedMilliseconds, solveTimeString, isPlusTwo, isDNF, Util.turnSequenceListToString(scramble), DateTime.Now, DateTime.Now);
            SolveTime addedTime = await timeService.create(time);
            SolveTimeUserControl timeUserControl = new SolveTimeUserControl(timeService, this, addedTime);
            flowLayoutPanelTimes.Controls.Add(timeUserControl);
            await updateStats(currentSession);
            generateScramble();
            await displayScramble();
            displayStats();
            isPlusTwoInInspection = false;
            
        }

        private void timerSolve_Tick(object sender, EventArgs e) {
            long elapsedMilliseconds = solveStopwatch.ElapsedMilliseconds;
            labelTimer.Text = Util.longMillisecondsToString(elapsedMilliseconds);
            labelTimer.Left = (panelTimer.Width - labelTimer.Width) / 2;
        }

        private async void timerInspection_Tick(object sender, EventArgs e) {
            long elapsedMilliseconds = inspectionStopwatch.ElapsedMilliseconds;
            labelTimer.Text = (elapsedMilliseconds / 1000).ToString();
            if (elapsedMilliseconds / 1000 >= 15) {
                isPlusTwoInInspection = true;
                labelTimer.Text += " (+2)";
            }

            if (elapsedMilliseconds / 1000 >= 17) {
                endInspection();
                await endSolve(false, true);
                labelTimer.Text = "DNF";
                timerState = TimerStates.IDLE;
            }

            labelTimer.Left = (panelTimer.Width - labelTimer.Width) / 2;
            Thread.Sleep(150);
        }

        public async Task displayScramble() {
            labelScramble.Text = Util.turnSequenceListToString(scramble);
            labelScramble.Left = (panelTimer.Width - labelScramble.Width) / 2;
            await paintCube(scrambledCube);
            cubeToTurn = scrambledCube;
        }

        public void generateScramble() {
            scramble = timeService.generateScramble();
            initialCube = new Cube();
            scrambledCube = Cube.applyScramble(initialCube, scramble);
            cubeToTurn = scrambledCube;
        }
        
        public async Task paintCube(Cube cube) {
            foreach (Side side in cube.sides) {
                if (side.stickers[4].colorNameAsSide.Equals(Util.SIDE_UP)) {
                    panelUp.GetChildAtPoint(panelUp0.Location).BackColor = side.stickers[0].color;
                    panelUp.GetChildAtPoint(panelUp1.Location).BackColor = side.stickers[1].color;
                    panelUp.GetChildAtPoint(panelUp2.Location).BackColor = side.stickers[2].color;
                    panelUp.GetChildAtPoint(panelUp3.Location).BackColor = side.stickers[3].color;
                    panelUp.GetChildAtPoint(panelUp4.Location).BackColor = side.stickers[4].color;
                    panelUp.GetChildAtPoint(panelUp5.Location).BackColor = side.stickers[5].color;
                    panelUp.GetChildAtPoint(panelUp6.Location).BackColor = side.stickers[6].color;
                    panelUp.GetChildAtPoint(panelUp7.Location).BackColor = side.stickers[7].color;
                    panelUp.GetChildAtPoint(panelUp8.Location).BackColor = side.stickers[8].color;
                }

                if (side.stickers[4].colorNameAsSide.Equals(Util.SIDE_DOWN)) {
                    panelDown.GetChildAtPoint(panelDown0.Location).BackColor = side.stickers[0].color;
                    panelDown.GetChildAtPoint(panelDown1.Location).BackColor = side.stickers[1].color;
                    panelDown.GetChildAtPoint(panelDown2.Location).BackColor = side.stickers[2].color;
                    panelDown.GetChildAtPoint(panelDown3.Location).BackColor = side.stickers[3].color;
                    panelDown.GetChildAtPoint(panelDown4.Location).BackColor = side.stickers[4].color;
                    panelDown.GetChildAtPoint(panelDown5.Location).BackColor = side.stickers[5].color;
                    panelDown.GetChildAtPoint(panelDown6.Location).BackColor = side.stickers[6].color;
                    panelDown.GetChildAtPoint(panelDown7.Location).BackColor = side.stickers[7].color;
                    panelDown.GetChildAtPoint(panelDown8.Location).BackColor = side.stickers[8].color;
                }

                if (side.stickers[4].colorNameAsSide.Equals(Util.SIDE_LEFT)) {
                    panelLeft.GetChildAtPoint(panelLeft0.Location).BackColor = side.stickers[0].color;
                    panelLeft.GetChildAtPoint(panelLeft1.Location).BackColor = side.stickers[1].color;
                    panelLeft.GetChildAtPoint(panelLeft2.Location).BackColor = side.stickers[2].color;
                    panelLeft.GetChildAtPoint(panelLeft3.Location).BackColor = side.stickers[3].color;
                    panelLeft.GetChildAtPoint(panelLeft4.Location).BackColor = side.stickers[4].color;
                    panelLeft.GetChildAtPoint(panelLeft5.Location).BackColor = side.stickers[5].color;
                    panelLeft.GetChildAtPoint(panelLeft6.Location).BackColor = side.stickers[6].color;
                    panelLeft.GetChildAtPoint(panelLeft7.Location).BackColor = side.stickers[7].color;
                    panelLeft.GetChildAtPoint(panelLeft8.Location).BackColor = side.stickers[8].color;
                }

                if (side.stickers[4].colorNameAsSide.Equals(Util.SIDE_RIGHT)) {
                    panelRight.GetChildAtPoint(panelRight0.Location).BackColor = side.stickers[0].color;
                    panelRight.GetChildAtPoint(panelRight1.Location).BackColor = side.stickers[1].color;
                    panelRight.GetChildAtPoint(panelRight2.Location).BackColor = side.stickers[2].color;
                    panelRight.GetChildAtPoint(panelRight3.Location).BackColor = side.stickers[3].color;
                    panelRight.GetChildAtPoint(panelRight4.Location).BackColor = side.stickers[4].color;
                    panelRight.GetChildAtPoint(panelRight5.Location).BackColor = side.stickers[5].color;
                    panelRight.GetChildAtPoint(panelRight6.Location).BackColor = side.stickers[6].color;
                    panelRight.GetChildAtPoint(panelRight7.Location).BackColor = side.stickers[7].color;
                    panelRight.GetChildAtPoint(panelRight8.Location).BackColor = side.stickers[8].color;
                }

                if (side.stickers[4].colorNameAsSide.Equals(Util.SIDE_FRONT)) {
                    panelFront.GetChildAtPoint(panelFront0.Location).BackColor = side.stickers[0].color;
                    panelFront.GetChildAtPoint(panelFront1.Location).BackColor = side.stickers[1].color;
                    panelFront.GetChildAtPoint(panelFront2.Location).BackColor = side.stickers[2].color;
                    panelFront.GetChildAtPoint(panelFront3.Location).BackColor = side.stickers[3].color;
                    panelFront.GetChildAtPoint(panelFront4.Location).BackColor = side.stickers[4].color;
                    panelFront.GetChildAtPoint(panelFront5.Location).BackColor = side.stickers[5].color;
                    panelFront.GetChildAtPoint(panelFront6.Location).BackColor = side.stickers[6].color;
                    panelFront.GetChildAtPoint(panelFront7.Location).BackColor = side.stickers[7].color;
                    panelFront.GetChildAtPoint(panelFront8.Location).BackColor = side.stickers[8].color;
                }

                if (side.stickers[4].colorNameAsSide.Equals(Util.SIDE_BACK)) {
                    panelBack.GetChildAtPoint(panelBack0.Location).BackColor = side.stickers[0].color;
                    panelBack.GetChildAtPoint(panelBack1.Location).BackColor = side.stickers[1].color;
                    panelBack.GetChildAtPoint(panelBack2.Location).BackColor = side.stickers[2].color;
                    panelBack.GetChildAtPoint(panelBack3.Location).BackColor = side.stickers[3].color;
                    panelBack.GetChildAtPoint(panelBack4.Location).BackColor = side.stickers[4].color;
                    panelBack.GetChildAtPoint(panelBack5.Location).BackColor = side.stickers[5].color;
                    panelBack.GetChildAtPoint(panelBack6.Location).BackColor = side.stickers[6].color;
                    panelBack.GetChildAtPoint(panelBack7.Location).BackColor = side.stickers[7].color;
                    panelBack.GetChildAtPoint(panelBack8.Location).BackColor = side.stickers[8].color;
                }
            }
            await Task.Delay(1);
        }

        private async void buttonUpTurn_MouseDown(object sender, MouseEventArgs e) {
            string turn = "";
            if (e.Button == MouseButtons.Left) {
                turn = "U";
            }

            if (e.Button == MouseButtons.Right) {
                turn = "U'";
            }
            cubeToTurn = Cube.getTurnedCube(cubeToTurn, turn);
            await paintCube(cubeToTurn);
        }

        private async void buttonDownTurn_MouseDown(object sender, MouseEventArgs e) {
            string turn = "";
            if (e.Button == MouseButtons.Left) {
                turn = "D";
            }

            if (e.Button == MouseButtons.Right) {
                turn = "D'";
            }
            cubeToTurn = Cube.getTurnedCube(cubeToTurn, turn);
            await paintCube(cubeToTurn);
        }

        private async void buttonLeftTurn_MouseDown(object sender, MouseEventArgs e) {
            string turn = "";
            if (e.Button == MouseButtons.Left) {
                turn = "L";
            }

            if (e.Button == MouseButtons.Right) {
                turn = "L'";
            }
            cubeToTurn = Cube.getTurnedCube(cubeToTurn, turn);
            await paintCube(cubeToTurn);
        }

        private async void buttonRightTurn_MouseDown(object sender, MouseEventArgs e) {
            string turn = "";
            if (e.Button == MouseButtons.Left) {
                turn = "R";
            }

            if (e.Button == MouseButtons.Right) {
                turn = "R'";
            }
            cubeToTurn = Cube.getTurnedCube(cubeToTurn, turn);
            await paintCube(cubeToTurn);
        }

        private async void buttonFrontTurn_MouseDown(object sender, MouseEventArgs e) {
            string turn = "";
            if (e.Button == MouseButtons.Left) {
                turn = "F";
            }

            if (e.Button == MouseButtons.Right) {
                turn = "F'";
            }
            cubeToTurn = Cube.getTurnedCube(cubeToTurn, turn);
            await paintCube(cubeToTurn);
        }

        private async void buttonBackTurn_MouseDown(object sender, MouseEventArgs e) {
            string turn = "";
            if (e.Button == MouseButtons.Left) {
                turn = "B";
            }

            if (e.Button == MouseButtons.Right) {
                turn = "B'";
            }
            cubeToTurn = Cube.getTurnedCube(cubeToTurn, turn);
            await paintCube(cubeToTurn);
        }

        private void WinterCubeTimerForm_FormClosing(object sender, FormClosingEventArgs e) {
            foreach (Process process in Process.GetProcessesByName("WinterCubeTimer")) {
                Config.getInstance().save();
                process.Kill();
            }
        }

        private async void buttonSelectSession_MouseClick(object sender, MouseEventArgs e) {
            currentSession = Convert.ToInt32(comboBoxSession.Text);
            flowLayoutPanelTimes.Controls.Clear();
            await fillTimesPanel(currentSession);
            await updateStats(currentSession);
            displayStats();
        }

        private async void buttonNewScramble_MouseClick(object sender, MouseEventArgs e) {
            generateScramble();
            await displayScramble();
        }

        private async void buttonDeleteAllFromSession_MouseClick(object sender, MouseEventArgs e) {
            flowLayoutPanelTimes.Controls.Clear();
            await timeService.deleteAllBySession(currentSession);
            await updateStats(currentSession);
            displayStats();
        }

        private void checkBoxInspectionEnabled_CheckedChanged(object sender, EventArgs e) {
            localInspectionEnabled = checkBoxInspectionEnabled.Checked;
            Config.getInstance().inspectionEnabled = localInspectionEnabled;
            Config.getInstance().save();
        }

        private async Task<CubeState> exportCubeState() {
            List<Side> sides = cubeToTurn.sides;
            string cubeStateString = "";
            for (int i = 0; i < sides.Count; i++) {
                List<Sticker> stickers = sides[i].stickers;
                for (int j = 0; j < stickers.Count; j++) {
                    cubeStateString += stickers[j].colorNameAsSide;
                }
            }

            CubeState cubeState = new CubeState(Util.turnSequenceListToString(scramble), sides, cubeStateString);
            string cubeStateJson = Util.serialize(cubeState);
            await File.WriteAllTextAsync(Util.CUBE_STATE_FILENAME, cubeStateJson);
            return cubeState;
        }

        private async Task solveCube() {
            try {
                CubeState cubeState = await exportCubeState();
                string cubeStateString = cubeState.cubeStateString;
                string info;
                string solution = Search.solution(cubeStateString, out info, 22, 6000L, false);
                List<string> turns = Util.turnSequenceToList(solution);
                foreach (string turn in turns) {
                    cubeToTurn = Cube.getTurnedCube(cubeToTurn, turn);
                    await paintCube(cubeToTurn);
                    await Task.Delay(125);
                }

                using (SolutionForm solutionForm = new SolutionForm(solution)) {
                    solutionForm.ShowDialog();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(@"Failed to solve cube: " + ex.Message, @"Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async void buttonExportCubeState_MouseClick(object sender, MouseEventArgs e) {
            await exportCubeState();
        }

        private async void buttonSolveCube_MouseClick(object sender, MouseEventArgs e) {
            await solveCube();
        }
    }
}