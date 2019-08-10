using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        { 
            //int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int[] nums = { -1, 0, 0, 0, 0, 3, 3 };
            //int[] nums = { 1, 1, 2 };
            //int[] nums = { 0, 0, 0, 0, 3 };  
            int[] prices = { 7, 1, 5, 3, 6, 4 };

            ArrayProblems array = new ArrayProblems();

            //Console.WriteLine(sl.RemoveDuplicates(nums).Count());
            //Console.WriteLine("--------------");
            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(array.MaxProfit(prices));


        }

    }

    public class ArrayProblems
    {
        /// <summary>
        /// Remove Duplicates from Sorted Array
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int[] RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
            {
                int[] nums1 = { 0 };
                //return 0;
                return nums1;
            }


            int j = 0;
            int swap = nums[0];

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= swap)
                {
                    nums[j] = nums[i];
                    j++;
                    swap = nums[i] + 1;
                }

                //if (j < nums[i])
                //    j = nums[i];
            }

            return nums;
        }

        /// <summary>
        /// Rotate Array
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        public void Rotate(int[] nums, int k)
        {

        }
    }
}
