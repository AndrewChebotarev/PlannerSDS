namespace PlannerSDS.HelpClasses
{
    public class FormResize
    {
        public FormResize(TabPage tabPage, Size ClientSize) 
        {
            foreach (Control control in tabPage.Controls)
                if (control is Panel panel)
                    panel.Height = ClientSize.Height;
        }
    }
}
