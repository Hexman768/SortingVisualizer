using System.Drawing;

namespace SortingVisualizer.SortingEngines
{
    public class CocktailSortEngine : BaseSortingEngine
    {
        public CocktailSortEngine(int[] array, Graphics g, int maxValue)
        {
            this.array = array;
            this.g = g;
            this.maxValue = maxValue;
        }

        public override void Sort()
        {
            bool isSwapped = true;
            int start = 0;
            int end = array.Length;

            while (isSwapped == true)
            {
                isSwapped = false;

                for (int i = start; i < end - 1; ++i)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(i, i + 1);
                        isSwapped = true;
                    }
                }

                if (isSwapped == false)
                    break;

                isSwapped = false;
                end = end - 1;

                for (int i = end - 1; i >= start; i--)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(i, i + 1);
                        isSwapped = true;
                    }
                }

                start = start + 1;
            }
        }
    }
}
