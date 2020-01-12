using System.Drawing;

namespace SortingVisualizer.SortingEngines
{
    public class QuickSortEngine : BaseSortingEngine
    {
        public QuickSortEngine(int[] array, Graphics g, int maxValue)
        {
            this.array = array;
            this.g = g;
            this.maxValue = maxValue;
        }

        public override void Sort()
        {
            QuickSort(1, array.Length - 1);
        }

        private void QuickSort(int low, int hi)
        {
            if (low < hi)
            {
                int p = Partition(low, hi);
                QuickSort(low, p - 1);
                QuickSort(p + 1, hi);
            }
        }

        private int Partition(int low, int hi)
        {
            int left, right;
            int middle = (low + hi) / 2;
            left = low;
            right = hi;
            int pivot = array[middle];

            DelayedSwap(2, low, middle);
            while (left < right)
            {
                while (array[left].CompareTo(pivot) <= 0 && left < right)
                {
                    left++;
                }
                while (array[right].CompareTo(pivot) > 0)
                {
                    right--;
                }
                if (left < right)
                {
                    DelayedSwap(2, left, right);
                }
            }
            DelayedSwap(2, low, right);
            return right;
        }
    }
}
