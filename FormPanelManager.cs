using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class FormPanelManager
    {
        public static void LoadForm (Panel container, Form form)
        {
            if (container.Controls.Count > 0)
            {
                container.Controls.RemoveAt(0);
            }
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            container.Controls.Add(form);
            container.Tag = form;
            form.Show();
        }
    }
}