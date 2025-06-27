
using Microsoft.EntityFrameworkCore;
using WinterCubeTimer.model;
using WinterCubeTimer.service;
using WinterCubeTimer.util;

namespace WinterCubeTimer.view {
    public partial class SolveTimeUserControl : UserControl {
        private SolveTime solveTime { get; set; }
        private ITimeService timeService;
        private WinterCubeTimerForm winterCubeTimerForm { get; set; }
        
        public SolveTimeUserControl(ITimeService timeService, WinterCubeTimerForm winterCubeTimerForm, SolveTime solveTime) {
            InitializeComponent();
            this.solveTime = solveTime;
            this.timeService = timeService;
            this.winterCubeTimerForm = winterCubeTimerForm;
        }
        private void TimeUserControl_Load(object sender, EventArgs e) {
            labelTime.Text = solveTime.solveTime;
            checkBoxIsPlusTwo.Checked = solveTime.isPlusTwo;
            checkBoxIsDNF.Checked = solveTime.isDnf;
        }
        private void TimeUserControl_MouseEnter(object sender, EventArgs e) {
            BackColor = Color.LightGray;
        }
        private void TimeUserControl_MouseLeave(object sender, EventArgs e) {
            BackColor = DefaultBackColor;
        }
        private void TimeUserControl_MouseClick(object sender, MouseEventArgs e) {
            StatsForm statsForm = new StatsForm(solveTime);
            statsForm.ShowDialog();
        }
        private void labelTime_MouseEnter(object sender, EventArgs e) {
            BackColor = Color.LightGray;
        }
        private void labelTime_MouseLeave(object sender, EventArgs e) {
            BackColor = DefaultBackColor;
        }
        private void labelTime_MouseClick(object sender, MouseEventArgs e) {
            StatsForm statsForm = new StatsForm(solveTime);
            statsForm.ShowDialog();
        }
        
        private async void buttonDelete_MouseClick(object sender, MouseEventArgs e) {
            await timeService.delete(solveTime.id);
            winterCubeTimerForm.flowLayoutPanelTimes.Controls.Remove(this);
            winterCubeTimerForm.updateStats(solveTime.solveSession);
            winterCubeTimerForm.displayStats();
        }

        private async void checkBoxIsPlusTwo_MouseClick(object sender, MouseEventArgs e) {
            if (checkBoxIsPlusTwo.Checked) {
                solveTime.solveTimeInMilliseconds = solveTime.solveInitialTimeInMilliseconds + 2000;
                solveTime.solveTime = Util.longMillisecondsToString(solveTime.solveTimeInMilliseconds) + " (+2)";
            }
            else {
                solveTime.solveTimeInMilliseconds = solveTime.solveInitialTimeInMilliseconds;
                solveTime.solveTime = Util.longMillisecondsToString(solveTime.solveTimeInMilliseconds);
            }
            solveTime.isPlusTwo = checkBoxIsPlusTwo.Checked;
            labelTime.Text = solveTime.solveTime;
            await timeService.updateIsPlusTwo(solveTime.id, solveTime.isPlusTwo);
            winterCubeTimerForm.updateStats(solveTime.solveSession);
            winterCubeTimerForm.displayStats();
        }

        private void checkBoxIsDNF_MouseClick(object sender, MouseEventArgs e) {
            solveTime.isDnf = checkBoxIsDNF.Checked;
            timeService.updateIsDnf(solveTime.id, solveTime.isDnf);
            winterCubeTimerForm.updateStats(solveTime.solveSession);
            winterCubeTimerForm.displayStats();
        }
    }
}