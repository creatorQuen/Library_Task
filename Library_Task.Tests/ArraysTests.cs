using NUnit.Framework;

namespace Library_Task.Tests
{
    public class ArraysTests
    {
        [TestCase(new int[] { -7, -28 , 100, 1, 0 , 25, 2}, -28)]
        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { 1, 0, 1, 0, -1, 2}, -1)]
        [TestCase(new int[] { -11, -11, -11, -11, -11, -11}, -11)]
        public void FindMinimumNumberInArrayTests(int[] arr, int expected)
        {
            int actual = Arrays.FindMinimumNumberInArray(arr);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { -7, -28, 100, 1, 0, 25, 2 }, 100)]
        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { 1, 0, 1, 0, -1, 2 }, 2)]
        [TestCase(new int[] { -11, -11, -11, -11, -11, -11 }, -11)]
        public void FindMaximumNumberInArrayTests(int[] arr, int expected)
        {
            int actual = Arrays.FindMaximumNumberInArray(arr);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { -7, -28, 100, 1, 0, 25, 2 }, 1)]
        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { 1, 0, 1, 0, -1, 2 }, 4)]
        [TestCase(new int[] { -11, -11, -11, -11, -11, -11 }, 0)]
        public void FindIndexOfMinimumNumberInArrayTests(int[] arr, int expected)
        {
            int actual = Arrays.FindIndexOfMinimumNumberInArray(arr);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { -7, -28, 100, 1, 0, 25, 2 }, 2)]
        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { 1, 0, 1, 0, -1, 2 }, 5)]
        [TestCase(new int[] { -11, -11, -11, -11, -11, -11 }, 0)]
        public void FindIndexOfMaximumNumberInArrayTests(int[] arr, int expected)
        {
            int actual = Arrays.FindIndexOfMaximumNumberInArray(arr);

            Assert.AreEqual(expected, actual);
        }



    }
}
