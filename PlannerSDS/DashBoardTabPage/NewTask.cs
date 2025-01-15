namespace PlannerSDS.DashBoardTabPage
{
    public class NewTask
    {
        private Label? oldLabel;

        public void CreateNewTask(object sender, EventArgs e)
        {
            Label? clickLabel = sender as Label;
            ChangeTextOldLabel(clickLabel);
            CheckOldLabel(clickLabel);
            oldLabel = CreateNewLabel(clickLabel?.Parent);
        }

        private void ChangeTextOldLabel(Label? clickLabel)
        {
            string newText = Microsoft.VisualBasic.Interaction.InputBox(
                "Введите новый текст:",
                "Изменить текст метки",
                clickLabel?.Text ?? string.Empty
            );

            CheckTextOldLabel(clickLabel, newText);
        }

        private void CheckTextOldLabel(Label? clickLabel, string newText)
        {
            if (!string.IsNullOrEmpty(newText) && clickLabel != null)
                clickLabel.Text = newText;
        }

        private void CheckOldLabel(Label? clickLabel)
        {
            if (oldLabel == null && clickLabel != null)
                oldLabel = clickLabel;
        }

        private Label CreateNewLabel(Control? control)
        {
            Label newLabel = new();

            newLabel.Text = "+ Добавить задачу";

            if (oldLabel != null)
                newLabel.Location = new Point(oldLabel.Location.X, oldLabel.Location.Y + 40);
            else
                newLabel.Location = new Point(0, 0);

            control?.Controls.Add(newLabel);

            return newLabel;
        }
    }
}