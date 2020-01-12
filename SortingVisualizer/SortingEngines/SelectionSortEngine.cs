using System.Drawing;

namespace SortingVisualizer.SortingEngines
{
    public class SelectionSortEngine : BaseSortingEngine
    {
        public SelectionSortEngine(int[] array, Graphics g, int maxValue)
        {
            this.array = array;
            this.g = g;
            this.maxValue = maxValue;
        }

        public override void Sort()
        {
            int low;
            for (int i = 0; i < array.Length - 1; i++)
            {
                low = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[low])
                    {
                        low = j;
                    }
                }
                DelayedSwap(10, low, i);
            }
        }
    }
}
