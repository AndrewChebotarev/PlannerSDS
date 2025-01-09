namespace PlannerSDS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.Resize += Form1_Resize; // Подписываемся на событие изменения размера формы

            panel = panel1;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            // Устанавливаем высоту всех панелей на контроле
            foreach (Control control in this.tabPage1.Controls)
            {
                if (control is Panel panel)
                {
                    panel.Height = this.ClientSize.Height; // Устанавливаем высоту панели равной высоте клиентской области формы
                }
            }
        }

        private Panel panel;

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel == panel1)
            {
                button1.Location = new Point(308, button1.Location.Y);
            }
            else
            {
                button1.Location = new Point(panel.Location.X + 600, button1.Location.Y);
            }

            // Создаем новую панель
            Panel newPanel = new Panel();
            newPanel.Size = panel1.Size; // Копируем размер

            if (panel == panel1)
            {
                newPanel.Location = new Point(8, panel.Location.Y); // Устанавливаем новое местоположение
            }
            else
            {
                newPanel.Location = new Point(panel.Location.X + 300, panel.Location.Y); // Устанавливаем новое местоположение
            }
            newPanel.BackColor = panel1.BackColor; // Копируем цвет фона
            newPanel.Visible = true;
            newPanel.AutoScroll = true;

            newPanel.Height = this.ClientSize.Height; // Устанавливаем высоту панели равной высоте клиентской области формы

            // Учитываем позицию прокрутки
            Point scrollPosition = panel1.AutoScrollPosition;

            // Копируем дочерние элементы
            foreach (Control control in panel1.Controls)
            {
                Control newControl = (Control)control.Clone();
                
                // Клонируем элемент управления
                if (newControl is Label)
                {
                    newControl.Click += label3_Click;
                }
                                                               // Корректируем местоположение с учетом позиции прокрутки
                newControl.Location = new Point(control.Location.X - scrollPosition.X, control.Location.Y - scrollPosition.Y);
                newPanel.Controls.Add(newControl); // Добавляем новый элемент в новую панель
            }

            // Добавляем новую панель на форму
            this.tabPage1.Controls.Add(newPanel);

            panel = newPanel;
        }

        Label labelttt;

        public void label3_Click(object sender, EventArgs e)
        {
            Label label = sender as Label;

            string newText = Microsoft.VisualBasic.Interaction.InputBox("Введите новый текст:", "Изменить текст метки", label.Text);

            // Проверка, не пустой ли текст
            if (!string.IsNullOrEmpty(newText))
            {
                label.Text = newText; // Изменение текста метки
            }

            Label label2 = new();

            label2.Text = "+ Добавить задачу";

            if (labelttt == null)
                labelttt = label;

            label2.Location = new Point(labelttt.Location.X, labelttt.Location.Y + 40);

            Control control = label.Parent;

            control.Controls.Add(label2);

            labelttt = label2;
        }
    }

    public static class ControlExtensions
    {
        public static Control Clone(this Control control)
        {
            // Создаем новый экземпляр элемента управления того же типа
            Control clone = (Control)Activator.CreateInstance(control.GetType());

            // Копируем основные свойства
            clone.Size = control.Size;
            clone.Location = control.Location;
            clone.BackColor = control.BackColor;
            clone.Text = control.Text; // Например, для кнопок

            // Копируйте дополнительные свойства по мере необходимости
            if (control is TextBox textBox)
            {
                ((TextBox)clone).Text = textBox.Text;
            }
            // Добавьте дополнительные проверки для других типов элементов управления

            return clone;
        }
    }
}
