using System.Drawing;

namespace SortingVisualizer.SortingEngines
{
    public class BubbleSortEngine : BaseSortingEngine
    {
        private bool isSorted;

        public BubbleSortEngine(int[] array, Graphics g, int maxValue)
        {
            this.array = array;
            this.g = g;
            this.maxValue = maxValue;
        }

        public override void Sort()
        {
            while (!isSorted)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(i, i + 1);
                    }
                }

                isSorted = isItSorted();
            }
        }
    }
}
