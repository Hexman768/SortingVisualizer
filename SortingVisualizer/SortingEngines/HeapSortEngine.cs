using System.Drawing;

namespace SortingVisualizer.SortingEngines
{
    public class HeapSortEngine : BaseSortingEngine
    {
        public HeapSortEngine(int[] array, Graphics g, int maxValue)
        {
            this.array = array;
            this.g = g;
            this.maxValue = maxValue;
        }

        public override void Sort()
        {
            int n = array.Length;
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                heapify(n, i);
            }
            for (int i = n - 1; i >= 0; i--)
            {
                DelayedSwap(5, 0, i);
                heapify(i, 0);
            }
        }

        private void heapify(int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left < n && array[left] > array[largest])
                largest = left;
            if (right < n && array[right] > array[largest])
                largest = right;
            if (largest != i)
            {
                int swap = array[i];
                array[i] = array[largest];
                array[largest] = swap;
                heapify(n, largest);
            }
        }
    }
}
