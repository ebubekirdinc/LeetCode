using System;
using System.Linq;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            //int[] nums = { 1, 2 };
            //int[] nums = { 1, 1, 2 };
            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
            int[] prices = { 7, 1, 5, 3, 6, 4 };

            ArrayProblems array = new ArrayProblems();
            array.Rotate(nums, 3);

            //Console.WriteLine(sl.RemoveDuplicates(nums).Count());
            //Console.WriteLine("--------------");
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }



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
        /// Best Time to Buy and Sell Stock II
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public int MaxProfit(int[] prices)
        {
            int profit = 0;
            for (int i = 1; i < prices.Count(); i++)
            {
                if (prices[i] > prices[i - 1])
                {
                    profit += prices[i] - prices[i - 1];
                }
            }

            return profit;
        }

        /// <summary>
        /// Given an array, rotate the array to the right by k steps, where k is non-negative.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        public int[] Rotate(int[] nums, int k)
        {
            if (nums.Length == 1)
                return nums;

            int swap = 0;
            int swap1 = 0;
            int j = 0;
            int s = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (s + k < nums.Length)
                {
                    swap1 = nums[s + k];
                    nums[s + k] = swap == 0 ? nums[s] : swap;
                    swap = swap1;
                    s = s + k;
                }
                else
                {
                    swap1 = j == 0 ? nums[s + k - nums.Length] : nums[s + k];
                    nums[s + k - nums.Length] = swap == 0 ? nums[s] : swap;
                    swap = swap1;
                    s = j == 0 ? s + k - nums.Length : s + k;
                    j++;
                }



            }


            return nums;
        }
    }
}
