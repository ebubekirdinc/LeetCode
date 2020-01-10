using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace LeetCode
{
    public class ArrayProblems
    {
        /// <summary>
        /// Remove Duplicates from Sorted Array
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int[] RemoveDuplicatesFromSortedArray(int[] nums)
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
        public int BestTimetoBuyAndSellStock2(int[] prices)
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
        public int[] RotateArray(int[] nums, int k)
        {
            if (nums.Length == 1)
                return nums;

            int[] nums2 = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                int index = (i + k) % nums.Length;
                nums2[index] = nums[i];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = nums2[i];
            }

            return nums;
        }

        public bool ContainsDuplicate(int[] nums)
        {
            // Linq solution
            var newNums = nums.Distinct();

            return newNums.Count() != nums.Length;

            // nonLinq solution Time limit exeed
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int j = i+1; j < nums.Length; j++)
            //    {
            //        if (nums[i] == nums[j])
            //            return true;
            //    }
            //}

            //return false; 
        }
    }
}
 