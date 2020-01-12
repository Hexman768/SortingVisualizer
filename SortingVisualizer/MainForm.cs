using System;
using System.Windows.Forms;

namespace SortingVisualizer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            visualUsrCtrl.ResetArray();
        }
    }
}
