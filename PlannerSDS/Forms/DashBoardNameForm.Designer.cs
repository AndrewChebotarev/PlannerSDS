namespace PlannerSDS.Forms
{
    partial class DashBoardNameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoardNameForm));
            changeDashBoardNameButton = new Button();
            CancelDashBoardNameButton = new Button();
            dashBoardNameTextBox = new TextBox();
            SuspendLayout();
            // 
            // changeDashBoardNameButton
            // 
            changeDashBoardNameButton.Location = new Point(97, 45);
            changeDashBoardNameButton.Name = "changeDashBoardNameButton";
            changeDashBoardNameButton.Size = new Size(94, 29);
            changeDashBoardNameButton.TabIndex = 0;
            changeDashBoardNameButton.Text = "Изменить";
            changeDashBoardNameButton.UseVisualStyleBackColor = true;
            changeDashBoardNameButton.Click += ChangeDashBoardNameButton_Click;
            // 
            // CancelDashBoardNameButton
            // 
            CancelDashBoardNameButton.Location = new Point(221, 45);
            CancelDashBoardNameButton.Name = "CancelDashBoardNameButton";
            CancelDashBoardNameButton.Size = new Size(94, 29);
            CancelDashBoardNameButton.TabIndex = 1;
            CancelDashBoardNameButton.Text = "Отмена";
            CancelDashBoardNameButton.UseVisualStyleBackColor = true;
            CancelDashBoardNameButton.Click += CancelDashBoardNameButton_Click;
            // 
            // dashBoardNameTextBox
            // 
            dashBoardNameTextBox.Location = new Point(26, 12);
            dashBoardNameTextBox.Name = "dashBoardNameTextBox";
            dashBoardNameTextBox.Size = new Size(377, 27);
            dashBoardNameTextBox.TabIndex = 2;
            // 
            // DashBoardNameForm
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoScroll = true;
            ClientSize = new Size(427, 83);
            Controls.Add(dashBoardNameTextBox);
            Controls.Add(CancelDashBoardNameButton);
            Controls.Add(changeDashBoardNameButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "DashBoardNameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Название DashBoard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button changeDashBoardNameButton;
        private Button CancelDashBoardNameButton;
        private TextBox dashBoardNameTextBox;
    }
}