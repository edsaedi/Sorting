using Sorting;
using System;
using Xunit;

namespace SortTest
{
    public class UnitTest1
    {
        [Fact]
        public void BubbleSort()
        {
            for (int x = 0; x < 100; x++)
            {
                var nums = Randomize();
                Sorts<int>.BubbleSort(nums);
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    Assert.True(nums[i] <= nums[i + 1]);
                }
            }
        }

        [Fact]
        public void SelectionSort()
        {
            for (int x = 0; x < 100; x++)
            {
                var nums = Randomize();
                Sorts<int>.SelectionSort(nums);
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    Assert.True(nums[i] <= nums[i + 1]);
                }
            }
        }

        [Fact]
        public void InsertionSort()
        {
            for (int x = 0; x < 100; x++)
            {
                var nums = Randomize();
                Sorts<int>.InsertionSort(nums);
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    Assert.True(nums[i] <= nums[i + 1]);
                }
            }
        }

        public int[] Randomize()
        {
            int[] temp = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Random rand = new Random();
                temp[i] = rand.Next(0, 10);
            }
            return temp;
        }
    }
}
