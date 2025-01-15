namespace PlannerSDS
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tabControl1 = new TabControl();
            dashBoardTabPage = new TabPage();
            button1 = new Button();
            initPanel = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            dashBoardTabPage.SuspendLayout();
            initPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(dashBoardTabPage);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.HotTrack = true;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1057, 533);
            tabControl1.TabIndex = 0;
            // 
            // dashBoardTabPage
            // 
            dashBoardTabPage.AutoScroll = true;
            dashBoardTabPage.BackColor = Color.Transparent;
            dashBoardTabPage.Controls.Add(button1);
            dashBoardTabPage.Controls.Add(initPanel);
            dashBoardTabPage.ForeColor = SystemColors.ActiveCaptionText;
            dashBoardTabPage.ImeMode = ImeMode.NoControl;
            dashBoardTabPage.Location = new Point(4, 29);
            dashBoardTabPage.Name = "dashBoardTabPage";
            dashBoardTabPage.Padding = new Padding(3);
            dashBoardTabPage.Size = new Size(1049, 500);
            dashBoardTabPage.TabIndex = 0;
            dashBoardTabPage.Text = "DashBoard";
            dashBoardTabPage.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.SkyBlue;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(58, 3);
            button1.Name = "button1";
            button1.Size = new Size(163, 40);
            button1.TabIndex = 0;
            button1.Text = "Добавить раздел";
            button1.UseVisualStyleBackColor = false;
            button1.Click += NewDashBoard_Click;
            // 
            // initPanel
            // 
            initPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            initPanel.AutoSize = true;
            initPanel.BackColor = Color.SkyBlue;
            initPanel.Controls.Add(label3);
            initPanel.Controls.Add(label2);
            initPanel.Controls.Add(label1);
            initPanel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            initPanel.Location = new Point(8, 6);
            initPanel.Name = "initPanel";
            initPanel.Size = new Size(285, 486);
            initPanel.TabIndex = 1;
            initPanel.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 62);
            label3.Name = "label3";
            label3.Size = new Size(148, 20);
            label3.TabIndex = 4;
            label3.Text = "+ Добавить задачу";
            label3.Click += NewTask_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 37);
            label2.Name = "label2";
            label2.Size = new Size(279, 20);
            label2.TabIndex = 3;
            label2.Text = "---------------------------------------------";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 11);
            label1.Name = "label1";
            label1.Size = new Size(140, 20);
            label1.TabIndex = 2;
            label1.Text = "Название раздела";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1049, 500);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Diagram";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoScroll = true;
            AutoSize = true;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1057, 533);
            Controls.Add(tabControl1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            RightToLeft = RightToLeft.No;
            Text = "PlannerSDS";
            WindowState = FormWindowState.Maximized;
            Resize += FormResize;
            tabControl1.ResumeLayout(false);
            dashBoardTabPage.ResumeLayout(false);
            dashBoardTabPage.PerformLayout();
            initPanel.ResumeLayout(false);
            initPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        public TabPage dashBoardTabPage;
        private TabPage tabPage2;
        private Button button1;
        public Panel initPanel;
        private Label label1;
        private Label label3;
        private Label label2;
    }
}
