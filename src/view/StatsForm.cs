using System.Globalization;
using WinterCubeTimer.model;

namespace WinterCubeTimer.view {
    public partial class StatsForm : Form {
        private SolveTime solveTime { get; set; }
        public StatsForm(SolveTime solveTime) {
            InitializeComponent();
            this.solveTime = solveTime;
        }
        private void StatsForm_Load(object sender, EventArgs e) {
            labelSession.Text = @"Session: " + solveTime.solveSession;
            labelTime.Text = @"Time: " + solveTime.solveTime;
            textBoxScramble.Text = solveTime.solveScramble;
            labelDate.Text = @"Date: " + solveTime.createdAt.ToString(CultureInfo.CurrentCulture);
        }
    }
}