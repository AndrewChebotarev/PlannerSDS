namespace PlannerSDS.Forms
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
            newDashBoardButton = new Button();
            initPanel = new Panel();
            newTaskLabel = new Label();
            lineLabel = new Label();
            dashBoardNameLabel = new Label();
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
            dashBoardTabPage.Controls.Add(newDashBoardButton);
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
            // newDashBoardButton
            // 
            newDashBoardButton.BackColor = Color.SkyBlue;
            newDashBoardButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            newDashBoardButton.Location = new Point(58, 3);
            newDashBoardButton.Name = "newDashBoardButton";
            newDashBoardButton.Size = new Size(163, 40);
            newDashBoardButton.TabIndex = 0;
            newDashBoardButton.Text = "Добавить раздел";
            newDashBoardButton.UseVisualStyleBackColor = false;
            newDashBoardButton.Click += NewDashBoard_Click;
            // 
            // initPanel
            // 
            initPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            initPanel.AutoSize = true;
            initPanel.BackColor = Color.SkyBlue;
            initPanel.Controls.Add(newTaskLabel);
            initPanel.Controls.Add(lineLabel);
            initPanel.Controls.Add(dashBoardNameLabel);
            initPanel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            initPanel.Location = new Point(8, 6);
            initPanel.Name = "initPanel";
            initPanel.Size = new Size(285, 486);
            initPanel.TabIndex = 1;
            initPanel.Visible = false;
            // 
            // newTaskLabel
            // 
            newTaskLabel.AutoSize = true;
            newTaskLabel.Location = new Point(3, 62);
            newTaskLabel.Name = "newTaskLabel";
            newTaskLabel.Size = new Size(148, 20);
            newTaskLabel.TabIndex = 4;
            newTaskLabel.Text = "+ Добавить задачу";
            newTaskLabel.Click += NewTask_Click;
            // 
            // lineLabel
            // 
            lineLabel.AutoSize = true;
            lineLabel.Location = new Point(3, 37);
            lineLabel.Name = "lineLabel";
            lineLabel.Size = new Size(279, 20);
            lineLabel.TabIndex = 3;
            lineLabel.Text = "---------------------------------------------";
            // 
            // dashBoardNameLabel
            // 
            dashBoardNameLabel.AutoSize = true;
            dashBoardNameLabel.Location = new Point(20, 11);
            dashBoardNameLabel.Name = "dashBoardNameLabel";
            dashBoardNameLabel.Size = new Size(140, 20);
            dashBoardNameLabel.TabIndex = 2;
            dashBoardNameLabel.Text = "Название раздела";
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
        private Button newDashBoardButton;
        public Panel initPanel;
        private Label dashBoardNameLabel;
        private Label newTaskLabel;
        private Label lineLabel;
    }
}
