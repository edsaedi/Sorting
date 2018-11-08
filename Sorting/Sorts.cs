using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public static class Sorts<T> where T : IComparable<T>
    {
        public static void BubbleSort(T[] array)
        {
            bool sorting;
            do
            {
                sorting = false;
                for (int i = 0; i < array.Length-1; i++)
                {
                    if (array[i].CompareTo(array[i + 1]) > 0)
                    {
                        var temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                        sorting = true;
                    }
                }
            } while (sorting);
        }
    }
}
