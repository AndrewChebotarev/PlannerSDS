namespace PlannerSDS.Forms
{
    public partial class MainForm : Form
    {
        private NewTask? newTask;
        private NewDashBoard? newDashBoard;

        public MainForm()
        {
            InitializeComponent();
            InitClasses();
        }
        private void InitClasses()
        {
            newTask = new();
            newDashBoard = new(this);
        }
        private void FormResize(object? sender, EventArgs e)
        {
            new FormResize(dashBoardTabPage, ClientSize);

            if (newDashBoard == null)
                throw new ArgumentNullException(nameof(newDashBoard), "NewDashBoard cannot be null.");

            newDashBoard.ChangeSize(ClientSize);
        }
        private void NewDashBoard_Click(object? sender, EventArgs e)
        {
            if (sender == null)
                throw new ArgumentNullException(nameof(sender), "Sender cannot be null.");

            newDashBoard?.CreateNewDashBoard(sender, e);
        }
        public void NewTask_Click(object? sender, EventArgs e)
        {
            if (sender == null)
                throw new ArgumentNullException(nameof(sender), "Sender cannot be null.");

            newTask?.CreateNewTask(sender, e);
        }

        public void ChangeDashBoardName_Click(object? sender, EventArgs e)
        {
            if (sender == null)
                throw new ArgumentNullException(nameof(sender), "Sender cannot be null.");

            DashBoardNameForm dashBoardNameForm = new();
            dashBoardNameForm.ShowDialog();
        }
    }
}
