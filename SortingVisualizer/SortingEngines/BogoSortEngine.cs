using System;
using System.Drawing;

namespace SortingVisualizer.SortingEngines
{
    public class BogoSortEngine : BaseSortingEngine
    {
        public BogoSortEngine(int[] array, Graphics g, int maxValue)
        {
            this.array = array;
            this.g = g;
            this.maxValue = maxValue;
        }

        public override void Sort()
        {
            while (!IsSorted())
            {
                Shuffle();
            }
        }

        private void Shuffle()
        {
            Random r = new Random();
            for (int n = array.Length - 1; n > 0; --n)
            {
                int k = r.Next(n + 1);
                Swap(n, k);
            }
        }

        private bool IsSorted()
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
