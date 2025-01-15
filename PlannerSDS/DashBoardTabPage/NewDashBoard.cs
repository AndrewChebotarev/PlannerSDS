using System.Windows.Forms;

namespace PlannerSDS.DashBoardTabPage
{
    public class NewDashBoard
    {
        private MainForm mainForm;
        private Panel initPanel;
        private Panel oldPanel;
        private TabPage dashBoardTabPage;
        private Size ClientSize;

        public NewDashBoard(MainForm mainForm)
        {
            this.mainForm = mainForm;
            this.initPanel = mainForm.initPanel;
            this.oldPanel = mainForm.initPanel;
            this.dashBoardTabPage = mainForm.dashBoardTabPage;
            this.ClientSize = mainForm.ClientSize;
        }
        public void CreateNewDashBoard(object sender, EventArgs e)
        {
            Button button1 = sender as Button;

            if (initPanel == oldPanel)
            {
                button1.Location = new Point(308, button1.Location.Y);
            }
            else
            {
                button1.Location = new Point(initPanel.Location.X + 600, button1.Location.Y);
            }

            // Создаем новую панель
            Panel newPanel = new Panel();
            newPanel.Size = oldPanel.Size; // Копируем размер

            if (initPanel == oldPanel)
            {
                newPanel.Location = new Point(8, initPanel.Location.Y); // Устанавливаем новое местоположение
            }
            else
            {
                newPanel.Location = new Point(initPanel.Location.X + 300, initPanel.Location.Y); // Устанавливаем новое местоположение
            }
            newPanel.BackColor = oldPanel.BackColor; // Копируем цвет фона
            newPanel.Visible = true;
            newPanel.AutoScroll = true;

            newPanel.Height = this.ClientSize.Height; // Устанавливаем высоту панели равной высоте клиентской области формы

            // Учитываем позицию прокрутки
            Point scrollPosition = oldPanel.AutoScrollPosition;

            // Копируем дочерние элементы
            foreach (Control control in oldPanel.Controls)
            {
                Control newControl = (Control)control.Clone();

                // Клонируем элемент управления
                if (newControl is Label)
                {
                    newControl.Click += mainForm.NewTask_Click;
                }
                // Корректируем местоположение с учетом позиции прокрутки
                newControl.Location = new Point(control.Location.X - scrollPosition.X, control.Location.Y - scrollPosition.Y);
                newPanel.Controls.Add(newControl); // Добавляем новый элемент в новую панель
            }

            // Добавляем новую панель на форму
            this.dashBoardTabPage.Controls.Add(newPanel);

            oldPanel = newPanel;
        }
    }
}
