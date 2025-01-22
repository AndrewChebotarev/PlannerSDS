namespace PlannerSDS.DashBoardTabPage
{
    public class NewDashBoard
    {
        private MainForm mainForm;
        private Panel initPanel;
        private Panel oldPanel;
        private TabPage dashBoardTabPage;
        private Size ClientSize;
        private int countNewPanel = 0;

        private int firstLocationX = 8;
        private int firstStepForButtonX = 300;
        private int nextStepsForButtonX = 600;
        private int nextStepsForPanelX = 300;

        public NewDashBoard(MainForm mainForm)
        {
            this.mainForm = mainForm;
            this.initPanel = mainForm.initPanel;
            this.oldPanel = mainForm.initPanel;
            this.dashBoardTabPage = mainForm.dashBoardTabPage;
            this.ClientSize = mainForm.ClientSize;
        }

        public void ChangeSize(Size newSize) => ClientSize = newSize;
        public void CreateNewDashBoard(object sender, EventArgs e)
        {
            countNewPanel++;
            NewLocationAddDashBoardButton(sender);
            Panel newPanel = CreateNewDashBoardPanel();

            this.dashBoardTabPage.Controls.Add(newPanel);
            oldPanel = newPanel;
        }

        private void NewLocationAddDashBoardButton(object sender)
        {
            if (sender is Button addDashBoardButton)
            {
                if (initPanel == oldPanel)
                    addDashBoardButton.Location = new Point(firstLocationX + firstStepForButtonX, addDashBoardButton.Location.Y);
                else
                    addDashBoardButton.Location = new Point(oldPanel.Location.X + nextStepsForButtonX, addDashBoardButton.Location.Y);
            }
            else
                throw new ArgumentException("sender must be a Button");
        }

        private Panel CreateNewDashBoardPanel()
        {
            Panel newPanel = new Panel();
            Point scrollPosition = oldPanel.AutoScrollPosition;

            newPanel = SetLocationPanel(newPanel);
            newPanel = SetParametersPanel(newPanel);
            newPanel = CopyChildrenUIPanel(newPanel, scrollPosition);

            return newPanel;
        }

        private Panel SetLocationPanel(Panel newPanel)
        {
            if (initPanel == oldPanel)
                newPanel.Location = new Point(firstLocationX, initPanel.Location.Y);
            else
                newPanel.Location = new Point(oldPanel.Location.X + nextStepsForPanelX, initPanel.Location.Y);

            return newPanel;
        }

        private Panel SetParametersPanel(Panel newPanel)
        {

            newPanel.Name = "DashBoard" + countNewPanel.ToString();
            newPanel.Size = oldPanel.Size;
            newPanel.BackColor = oldPanel.BackColor;
            newPanel.Visible = true;
            newPanel.AutoScroll = true;
            newPanel.Height = this.ClientSize.Height;

            return newPanel;
        }

        private Panel CopyChildrenUIPanel(Panel newPanel, Point scrollPosition)
        {
            foreach (Control control in oldPanel.Controls)
            {
                Control newControl = (Control)control.Clone();

                newControl.Name = control.Name;

                if (newControl is Label && newControl.Name == "dashBoardNameLabel")
                    newControl.Click += mainForm.ChangeDashBoardName_Click;
                if (newControl is Label && newControl.Name == "newTaskLabel")
                    newControl.Click += mainForm.NewTask_Click;


                newControl.Location = new Point(control.Location.X - scrollPosition.X, control.Location.Y - scrollPosition.Y);
                newPanel.Controls.Add(newControl);
            }

            return newPanel;
        }
    }
}
