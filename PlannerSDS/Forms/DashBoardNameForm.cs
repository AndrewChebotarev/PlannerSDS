namespace PlannerSDS.Forms
{
    public partial class DashBoardNameForm : Form
    {
        private Label dashBoardNameSender;
        public DashBoardNameForm(object sender)
        {
            InitializeComponent();
            dashBoardNameSender = (Label)sender;
        }

        private void CancelDashBoardNameButton_Click(object sender, EventArgs e) => this.Close();

        private void ChangeDashBoardNameButton_Click(object sender, EventArgs e)
        {
            dashBoardNameSender.Text = dashBoardNameTextBox.Text;
            this.Close();
        }
    }
}
