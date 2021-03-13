using NUnit.Framework;

namespace Library_Task.Tests
{
    public class ArraysTests
    {
        []
        public void FindMinimumNumberInArrayTests(int[] arr, int expected)
        {
            int actual = Arrays.FindMinimumNumberInArray(arr);

            Assert.AreEqual(expected, actual);
        }


    }
}
