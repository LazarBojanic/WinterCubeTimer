
namespace WinterCubeTimer.view {
    public partial class SolutionForm : Form {
        private string solution { get; set; }
        public SolutionForm(string solution) {
            InitializeComponent();
            this.solution = solution;
        }
        private void SolutionForm_Load(object sender, EventArgs e) {
            textBoxSolution.Text = solution;
        }
    }
}
