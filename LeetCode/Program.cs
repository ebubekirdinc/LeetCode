﻿using System;
using System.Collections.Generic;
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
            int[] nums = { 1, 2, 2, 1 };
            int[] nums2 = { 2, 2 };
            //int[] prices = { 7, 1, 5, 3, 6, 4 };

            ArrayProblems array = new ArrayProblems();
            array.Intersect(nums,nums2);

            //Console.WriteLine(sl.RemoveDuplicates(nums).Count());
            //Console.WriteLine("--------------");
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
             

        }

    }
}
