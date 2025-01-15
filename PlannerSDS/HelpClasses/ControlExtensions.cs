namespace PlannerSDS.HelpClasses
{
    public static class ControlExtensions
    {
        public static Control Clone(this Control control)
        {
            if (control == null)
                throw new ArgumentNullException(nameof(control), "Control cannot be null.");
            
            Control? cloneControl = Activator.CreateInstance(control.GetType()) as Control;

            if (cloneControl == null)
                throw new InvalidOperationException($"Could not create an instance of {control.GetType()}.");

            CloneParameters(control, cloneControl);
            CheckForCertainControl(control, cloneControl);

            return cloneControl;
        }

        private static void CloneParameters(Control sourceControl, Control cloneControl)
        {
            cloneControl.Size = sourceControl.Size;
            cloneControl.Location = sourceControl.Location;
            cloneControl.BackColor = sourceControl.BackColor;
            cloneControl.Text = sourceControl.Text;
        }

        private static void CheckForCertainControl(Control sourceControl, Control cloneControl)
        {
            if (sourceControl is TextBox textBox)
                ((TextBox)cloneControl).Text = textBox.Text;
        }
    }
}