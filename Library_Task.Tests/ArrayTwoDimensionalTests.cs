﻿using NUnit.Framework;
using System;

namespace Library_Task.Tests
{
    public class ArrayTwoDimensionalTests
    {
        [TestCase(1, -65)]
        [TestCase(2, -1)]
        [TestCase(3, -5)]
        public void FindMinimumElementOfArray2DTests(int mockNumber, int expected)
        {
            int[,] arr = DoubleArraysMock.GetMock(mockNumber);

            int actual = ArrayTwoDimensional.FindMinimumElementOfArray2D(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(4)]
        public void FindMinimumElementOfArray2D_EmptyArray__ShouldArgumentException(int mockNumber)
        {
            int[,] arr = DoubleArraysMock.GetMock(mockNumber);

            Assert.Throws<ArgumentException>(() => ArrayTwoDimensional.FindMinimumElementOfArray2D(arr));
        }


        [TestCase(1, 65)]
        [TestCase(2, 2)]
        [TestCase(3, 17)]
        public void FindMaximumElementOfArray2DTests(int mockNumber, int expected)
        {
            int[,] arr = DoubleArraysMock.GetMock(mockNumber);

            int actual = ArrayTwoDimensional.FindMaximumElementOfArray2D(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(4)]
        public void FindMaximumElementOfArray2D_EmptyArray__ShouldArgumentException(int mockNumber)
        {
            int[,] arr = DoubleArraysMock.GetMock(mockNumber);

            Assert.Throws<ArgumentException>(() => ArrayTwoDimensional.FindMaximumElementOfArray2D(arr));
        }


        [TestCase(1, new int[] { 1, 3 })]
        [TestCase(2, new int[] { 1, 4 })]
        [TestCase(3, new int[] { 4, 1 })]
        public void FindMinimumIndexNumberOfArray2DTests(int mockNumber, int[] expected)
        {
            int[,] arr = DoubleArraysMock.GetMock(mockNumber);

            int[] actual = ArrayTwoDimensional.FindMinimumIndexNumberOfArray2D(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(4)]
        public void FindMinimumIndexNumberOfArray2D_EmptyArray__ShouldArgumentException(int mockNumber)
        {
            int[,] arr = DoubleArraysMock.GetMock(mockNumber);

            Assert.Throws<ArgumentException>(() => ArrayTwoDimensional.FindMinimumIndexNumberOfArray2D(arr));
        }


        [TestCase(1, new int[] { 4, 1 })]
        [TestCase(2, new int[] { 3, 1 })]
        [TestCase(3, new int[] { 1, 1 })]
        public void FindMaximumIndexNumberOfArray2DTests(int mockNumber, int[] expected)
        {
            int[,] arr = DoubleArraysMock.GetMock(mockNumber);

            int[] actual = ArrayTwoDimensional.FindMaximumIndexNumberOfArray2D(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(4)]
        public void FindMaximumIndexNumberOfArray2D_EmptyArray__ShouldArgumentException(int mockNumber)
        {
            int[,] arr = DoubleArraysMock.GetMock(mockNumber);

            Assert.Throws<ArgumentException>(() => ArrayTwoDimensional.FindMaximumIndexNumberOfArray2D(arr));
        }




        public static class DoubleArraysMock
        {
            public static int[,] GetMock(int number)
            {
                int[,] result = new int[0, 0];
                switch (number)
                {
                    case 1:
                        result = new int[,]
                        {
                            {0, 17, -65, -65},
                            {1, -65, -65, -65},
                            {8, -1, -1, 0},
                            {65, -4, 11, 11},
                            {11, -4, 11, 11},
                        };
                        break;
                    case 2:
                        result = new int[,]
                        {
                            {0, 0, 1, -1},
                            {0, 1, -1, 1},
                            {2, -1, -1, 2},
                        };
                        break;
                    case 3:
                        result = new int[,]
                        {
                            {17, 1, 11, 0},
                            {1, 2, 3, 0},
                            {8, 0, -1, 0},
                            {-5, -4, 11,0},
                            {0, 0, 0, 0},
                        };
                        break;
                    case 4:
                        result = new int[,] { { },{ }};
                        break;
                }

                return result;
            }
        }
    }
}
