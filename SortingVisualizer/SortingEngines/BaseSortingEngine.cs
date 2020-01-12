using System.Drawing;
using System.Threading;

namespace SortingVisualizer.SortingEngines
{
    public abstract class BaseSortingEngine
    {
        protected int[] array;
        protected Graphics g;
        protected int maxValue;

        protected Brush whiteBrush = new SolidBrush(Color.White);
        protected Brush blackBrush = new SolidBrush(Color.Black);

        /// <summary>
        /// This function sorts the array and keeps the main panel
        /// up-to-date.
        /// </summary>
        public abstract void Sort();

        /// <summary>
        /// This functions swaps two values in the array.
        /// </summary>
        /// <param name="a">Location of first value in the array.</param>
        /// <param name="b">Location of second value in the array.</param>
        protected void Swap(int a, int b)
        {
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;

            g.FillRectangle(blackBrush, a, 0, 1, maxValue);
            g.FillRectangle(blackBrush, b, 0, 1, maxValue);

            g.FillRectangle(whiteBrush, a, maxValue - array[a], 1, maxValue);
            g.FillRectangle(whiteBrush, b, maxValue - array[b], 1, maxValue);
        }

        /// <summary>
        /// This function is a helper function that assists in the
        /// visualization of the sort by adding a delay with the
        /// given offset before performing the swap.
        /// </summary>
        /// <param name="offset">Offset in ms.</param>
        /// <param name="a">Location of first value in the array.</param>
        /// <param name="b">Location of second value in the array.</param>
        protected void DelayedSwap(int offset, int a, int b)
        {
            Thread.Sleep(offset);
            Swap(a, b);
        }

        /// <summary>
        /// This function checks the array to ensure that it is sorted.
        /// </summary>
        /// <returns>Boolean value indicating the status of the array.</returns>
        protected bool isItSorted()
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
