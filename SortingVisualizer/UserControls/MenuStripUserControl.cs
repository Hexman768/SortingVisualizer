using System;
using System.Windows.Forms;

namespace SortingVisualizer.UserControls
{
    public partial class MenuStripUserControl : UserControl
    {
        public MenuStripUserControl()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string title = "About SortingVisualizer";
            string message = "Created by: Zachary Pedigo\nVersion: 1.0\n" + "Date: " + DateTime.Now + "\n" + "OS: "
                + Environment.OSVersion + "\nLicense: GNU General Public License v3.0";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
