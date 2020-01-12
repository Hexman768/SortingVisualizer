using System.Drawing;

namespace SortingVisualizer.SortingEngines
{
    public class GnomeSortEngine : BaseSortingEngine
    {
        public GnomeSortEngine(int[] array, Graphics g, int maxValue)
        {
            this.array = array;
            this.g = g;
            this.maxValue = maxValue;
        }

        public override void Sort()
        {
            int i = 0;
            int n = array.Length;

            while (i < n)
            {
                if (i == 0)
                {
                    i++;
                }

                if (array[i] >= array[i - 1])
                {
                    i++;
                }
                else
                {
                    Swap(i, i - 1);
                    i--;
                }
            }
            return;
        }
    }
}
