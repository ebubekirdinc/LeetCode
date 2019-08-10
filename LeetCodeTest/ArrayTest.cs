using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTest
{
    [TestClass]
    public class ArrayTest
    {
        ArrayProblems _array = new ArrayProblems();

        /// <summary>
        /// Remove Duplicates from Sorted Array
        /// </summary>
        #region RemoveDuplicatesfromSortedArray

        [TestMethod]
        public void RemoveDuplicates1()
        {
            int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int[] res = { 0, 1, 2, 3, 4, 2, 2, 3, 3, 4 };

            CollectionAssert.AreEqual(res, _array.RemoveDuplicates(nums));
        }

        [TestMethod]
        public void RemoveDuplicates2()
        {
            int[] nums = { 1, 1, 2 };
            int[] res = { 1, 2, 2 };

            CollectionAssert.AreEqual(res, _array.RemoveDuplicates(nums));
        }

        [TestMethod]
        public void RemoveDuplicates3()
        {
            int[] nums = { -1, 0, 0, 0, 0, 3, 3 };
            int[] res = { -1, 0, 3, 0, 0, 3, 3 };

            CollectionAssert.AreEqual(res, _array.RemoveDuplicates(nums));
        }

        #endregion

        /// <summary>
        /// Best Time to Buy and Sell Stock II
        /// </summary>
        #region BestTimetoBuyandSellStockII

        [TestMethod]
        public void MaxProfitTest1()
        {
            int[] prices = { 7, 1, 5, 3, 6, 4 };

            Assert.AreEqual(7, _array.MaxProfit(prices));
        }

        [TestMethod]
        public void MaxProfitTest2()
        {
            int[] prices = { 1, 2, 3, 4, 5 };

            Assert.AreEqual(4, _array.MaxProfit(prices));
        }

        [TestMethod]
        public void MaxProfitTest3()
        {
            int[] prices = { 7, 6, 4, 3, 1 };

            Assert.AreEqual(0, _array.MaxProfit(prices));
        }

        #endregion
    }
}
