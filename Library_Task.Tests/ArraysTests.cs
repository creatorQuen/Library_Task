using NUnit.Framework;
using System;

namespace Library_Task.Tests
{
    public class ArraysTests
    {
        [TestCase(new int[] { -7, -28, 100, 1, 0, 25, 2 }, -28)]
        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { 1, 0, 1, 0, -1, 2 }, -1)]
        [TestCase(new int[] { -11, -11, -11, -11, -11, -11 }, -11)]
        public void FindMinimumNumberInArrayTests(int[] arr, int expected)
        {
            int actual = Arrays.FindMinimumNumberInArray(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[0])]
        public void FindMinimumNumberInArray_EmptyArray__ShouldArgumentException(int[] arr)
        {
            Assert.Throws<ArgumentException>(() => Arrays.FindMinimumNumberInArray(arr));
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

        [TestCase(new int[0])]
        public void FindMaximumNumberInArray_EmptyArray__ShouldArgumentException(int[] arr)
        {
            Assert.Throws<ArgumentException>(() => Arrays.FindMaximumNumberInArray(arr));
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

        [TestCase(new int[0])]
        public void FindIndexOfMinimumNumberInArray_EmptyArray__ShouldArgumentException(int[] arr)
        {
            Assert.Throws<ArgumentException>(() => Arrays.FindIndexOfMinimumNumberInArray(arr));
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

        [TestCase(new int[0])]
        public void FindIndexOfMaximumNumberInArray_EmptyArray__ShouldArgumentException(int[] arr)
        {
            Assert.Throws<ArgumentException>(() => Arrays.FindIndexOfMaximumNumberInArray(arr));
        }


        [TestCase(new int[] { -7, -28, 100, 1, 0, 25, 2 }, -2)]
        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { 1, 0, 1, 0, -1, 2 }, 2)]
        [TestCase(new int[] { -11, -11, -11, -11, -11, -11 }, -33)]
        public void SumArrayElementsWithOddIndex(int[] arr, int expected)
        {
            int actual = Arrays.SumArrayElementsWithOddIndex(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[0])]
        public void SumArrayElementsWithOddIndex_EmptyArray__ShouldArgumentException(int[] arr)
        {
            Assert.Throws<ArgumentException>(() => Arrays.SumArrayElementsWithOddIndex(arr));
        }


        [TestCase(new int[] { -7, -28, 100, 1, 0, 25, 2 }, new int[] { 2, 25, 0, 1, 100, -28, -7 })]
        [TestCase(new int[] { 0 }, new int[] { 0 })]
        [TestCase(new int[] { 1, 0, 1, 0, -1, 2 }, new int[] { 2, -1, 0, 1, 0, 1 })]
        [TestCase(new int[] { -11, -11, -11, -11, -11, -11 }, new int[] { -11, -11, -11, -11, -11, -11 })]
        public void GetArrayReverseTests(int[] arr, int[] expected)
        {
            int[] actual = Arrays.GetArrayReverse(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[0])]
        public void GetArrayReverse_EmptyArray__ShouldArgumentException(int[] arr)
        {
            Assert.Throws<ArgumentException>(() => Arrays.GetArrayReverse(arr));
        }


        [TestCase(new int[] { -7, -28, 100, 1, 0, 25, 2 }, 3)]
        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { 1, 0, 1, 0, -1, 2 }, 3)]
        [TestCase(new int[] { -11, -11, -11, -11, -11, -11 }, 6)]
        public void SumNumberOddArrayElementsTests(int[] arr, int expected)
        {
            int actual = Arrays.SumNumberOddArrayElements(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[0])]
        public void SumNumberOddArrayElements_EmptyArray__ShouldArgumentException(int[] arr)
        {
            Assert.Throws<ArgumentException>(() => Arrays.SumNumberOddArrayElements(arr));
        }


        [TestCase(new int[] { -7, -28, 100, 1, 0, 25, 2 }, new int[] { 0, 25, 2, 1, -7, -28, 100 })]
        [TestCase(new int[] { 0 }, new int[] { 0 })]
        [TestCase(new int[] { 1, 0, 1, 0, -1, 2 }, new int[] { 0, -1, 2, 1, 0, 1 })]
        [TestCase(new int[] { -11, -11, -11, -11, -11, -11 }, new int[] { -11, -11, -11, -11, -11, -11 })]
        public void GetArrayChangeHalfNumberTests(int[] arr, int[] expected)
        {
            int[] actual = Arrays.GetArrayChangeHalfNumber(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[0])]
        public void GetArrayChangeHalfNumber_EmptyArray__ShouldArgumentException(int[] arr)
        {
            Assert.Throws<ArgumentException>(() => Arrays.GetArrayChangeHalfNumber(arr));
        }


        [TestCase(new int[] { -7, -28, 100, 1, 0, 25, 2 }, new int[] { -28, -7, 0, 1, 2, 25, 100 })]
        [TestCase(new int[] { 0 }, new int[] { 0 })]
        [TestCase(new int[] { 1, 0, 1, 0, -1, 2 }, new int[] { -1, 0, 0, 1, 1, 2 })]
        [TestCase(new int[] { -11, -11, -11, -11, -11, -11 }, new int[] { -11, -11, -11, -11, -11, -11 })]
        public void SortArrayBubbleUpTests(int[] arr, int[] expected)
        {
            int[] actual = Arrays.SortArrayBubbleUp(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[0])]
        public void SortArrayBubbleUp_EmptyArray__ShouldArgumentException(int[] arr)
        {
            Assert.Throws<ArgumentException>(() => Arrays.SortArrayBubbleUp(arr));
        }



        [TestCase(new int[] { -7, -28, 100, 1, 0, 25, 2 }, new int[] { 100, 25, 2, 1, 0, -7, -28 })]
        [TestCase(new int[] { 0 }, new int[] { 0 })]
        [TestCase(new int[] { 1, 0, 1, 0, -1, 2 }, new int[] { 2, 1, 1, 0, 0, -1 })]
        [TestCase(new int[] { -11, -11, -11, -11, -11, -11 }, new int[] { -11, -11, -11, -11, -11, -11 })]
        public void SortArraySelectDownTests(int[] arr, int[] expected)
        {
            int[] actual = Arrays.SortArraySelectDown(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[0])]
        public void SortArraySelectDown_EmptyArray__ShouldArgumentException(int[] arr)
        {
            Assert.Throws<ArgumentException>(() => Arrays.SortArraySelectDown(arr));
        }


    }
}
