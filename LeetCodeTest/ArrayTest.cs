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
    }
}
