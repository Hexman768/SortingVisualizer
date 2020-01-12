using System.Drawing;

namespace SortingVisualizer.SortingEngines
{
    public class InsertionSortEngine : BaseSortingEngine
    {
        public InsertionSortEngine(int[] array, Graphics g, int maxValue)
        {
            this.array = array;
            this.g = g;
            this.maxValue = maxValue;
        }

        public override void Sort()
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        Swap(j - 1, j);
                    }
                }
            }
        }
    }
}
