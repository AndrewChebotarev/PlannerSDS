namespace PlannerSDS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.Resize += Form1_Resize; // ������������� �� ������� ��������� ������� �����

            panel = panel1;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            // ������������� ������ ���� ������� �� ��������
            foreach (Control control in this.tabPage1.Controls)
            {
                if (control is Panel panel)
                {
                    panel.Height = this.ClientSize.Height; // ������������� ������ ������ ������ ������ ���������� ������� �����
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

            // ������� ����� ������
            Panel newPanel = new Panel();
            newPanel.Size = panel1.Size; // �������� ������

            if (panel == panel1)
            {
                newPanel.Location = new Point(8, panel.Location.Y); // ������������� ����� ��������������
            }
            else
            {
                newPanel.Location = new Point(panel.Location.X + 300, panel.Location.Y); // ������������� ����� ��������������
            }
            newPanel.BackColor = panel1.BackColor; // �������� ���� ����
            newPanel.Visible = true;
            newPanel.AutoScroll = true;

            newPanel.Height = this.ClientSize.Height; // ������������� ������ ������ ������ ������ ���������� ������� �����

            // ��������� ������� ���������
            Point scrollPosition = panel1.AutoScrollPosition;

            // �������� �������� ��������
            foreach (Control control in panel1.Controls)
            {
                Control newControl = (Control)control.Clone();
                
                // ��������� ������� ����������
                if (newControl is Label)
                {
                    newControl.Click += label3_Click;
                }
                                                               // ������������ �������������� � ������ ������� ���������
                newControl.Location = new Point(control.Location.X - scrollPosition.X, control.Location.Y - scrollPosition.Y);
                newPanel.Controls.Add(newControl); // ��������� ����� ������� � ����� ������
            }

            // ��������� ����� ������ �� �����
            this.tabPage1.Controls.Add(newPanel);

            panel = newPanel;
        }

        Label labelttt;

        public void label3_Click(object sender, EventArgs e)
        {
            Label label = sender as Label;

            string newText = Microsoft.VisualBasic.Interaction.InputBox("������� ����� �����:", "�������� ����� �����", label.Text);

            // ��������, �� ������ �� �����
            if (!string.IsNullOrEmpty(newText))
            {
                label.Text = newText; // ��������� ������ �����
            }

            Label label2 = new();

            label2.Text = "+ �������� ������";

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
            // ������� ����� ��������� �������� ���������� ���� �� ����
            Control clone = (Control)Activator.CreateInstance(control.GetType());

            // �������� �������� ��������
            clone.Size = control.Size;
            clone.Location = control.Location;
            clone.BackColor = control.BackColor;
            clone.Text = control.Text; // ��������, ��� ������

            // ��������� �������������� �������� �� ���� �������������
            if (control is TextBox textBox)
            {
                ((TextBox)clone).Text = textBox.Text;
            }
            // �������� �������������� �������� ��� ������ ����� ��������� ����������

            return clone;
        }
    }
}
