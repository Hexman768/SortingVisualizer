using SortingVisualizer.SortingEngines;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SortingVisualizer.UserControls
{
    public partial class VisualizerUserControl : UserControl
    {
        private int[] array;
        private Graphics g;

        public VisualizerUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Resets the array and repaints the <see cref="mainPanel"/>.
        /// </summary>
        public void ResetArray()
        {
            g = mainPanel.CreateGraphics();
            int entries = mainPanel.Width;
            int maxValue = mainPanel.Height;
            array = new int[entries];
            g.FillRectangle(new SolidBrush(Color.Black), 0, 0, entries, maxValue);
            Random rand = new Random();
            for (int i = 0; i < entries; i++)
            {
                array[i] = rand.Next(1, maxValue);
            }
            for (int i = 0; i < entries; i++)
            {
                g.FillRectangle(new SolidBrush(Color.White), i, maxValue - array[i], 1, maxValue);
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            ResetArray();
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            BaseSortingEngine se;
            switch (algorithmCBx.SelectedItem)
            {
                case "Bubble":
                    se = new BubbleSortEngine(array, g, mainPanel.Height);
                    break;
                case "Quick":
                    se = new QuickSortEngine(array, g, mainPanel.Height);
                    break;
                case "Selection":
                    se = new SelectionSortEngine(array, g, mainPanel.Height);
                    break;
                case "Insertion":
                    se = new InsertionSortEngine(array, g, mainPanel.Height);
                    break;
                case "Heap":
                    se = new HeapSortEngine(array, g, mainPanel.Height);
                    break;
                case "Cocktail":
                    se = new CocktailSortEngine(array, g, mainPanel.Height);
                    break;
                case "Gnome":
                    se = new GnomeSortEngine(array, g, mainPanel.Height);
                    break;
                case "Bogo":
                    se = new BogoSortEngine(array, g, mainPanel.Height);
                    break;
                default:
                    se = new BubbleSortEngine(array, g, mainPanel.Height);
                    break;
            }
            se.Sort();
        }
    }
}
