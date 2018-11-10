using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public static class Sorts<T> where T : IComparable<T>
    {
        public static T[] BubbleSort(T[] array)
        {
            bool sorting;
            do
            {
                sorting = false;
                for (int i = 0; i < array.Length - 1; i++)
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

            return array;
        }

        public static T[] SelectionSort(T[] array)
        {
            //move current position up each index
            for (int curr = 0; curr < array.Length; curr++)
            {
                //find the smallest from start to end
                int min = curr;
                for (int i = curr + 1; i < array.Length; i++)
                {
                    if (array[i].CompareTo(array[min]) < 0)
                    {
                        min = i;
                    }
                }

                if (min != curr)
                {
                    var temp = array[curr];
                    array[curr] = array[min];
                    array[min] = temp;
                }
            }

            return array;
        }

        public static T[] InsertionSort(T[] array)
        {
            for (int x = 1; x < array.Length; x++)
            {
                for (int i = x; array[i].CompareTo(array[i - 1]) < 0; i--)
                {
                    var temp = array[i + 1];
                }
            }
            return array;
        }
    }
}
