using NUnit.Framework;
using System;

namespace Library_Task.Tests
{
    public class ProgrammingCyclesTests
    {
        [TestCase(1, 1, 1)]
        [TestCase(0, 0, 1)]
        [TestCase(2, 3, 8)]
        [TestCase(-1, 3, -1)]
        [TestCase(-3, 3, -27)]
        [TestCase(3, -3, 0.037)]
        public void RaisePowerTests(int a, int b, double expected)
        {
            double actual = ProgrammingCycles.RaisePower(a, b);

            Assert.AreEqual(expected, actual, 0.001);
        }


        [TestCase(250, new int[] { 250, 500, 750, 1000 })]
        [TestCase(40, new int[] { 40, 80, 120, 160, 200, 240, 280, 320, 360, 400, 440, 480, 520, 560, 600, 640, 680, 720, 760, 800, 840, 880, 920, 960, 1000 })]
        public void GetNumberOfDivisionTests(int a, int[] expected)
        {
            int[] actual = ProgrammingCycles.GetNumberOfDivision(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1001)]
        [TestCase(-1)]
        public void GetNumberOfDivision_ALarge1000orLess1_ShouldException(int a)
        {
            Assert.Throws<Exception>(() => ProgrammingCycles.GetNumberOfDivision(a));
        }


        [TestCase(40, 6)]
        [TestCase(90, 9)]
        [TestCase(40, 6)]
        public void GetNumberOfPositiveIntegersWhoseSquareIsLessTests(int a, int expected)
        {
            int actual = ProgrammingCycles.GetNumberOfPositiveIntegersWhoseSquareIsLess(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(-25)]
        public void GetNumberOfPositiveIntegersWhoseSquareIsLess_ALess0OrNegativeNumber_ShouldException(int a)
        {
            Assert.Throws<Exception>(() => ProgrammingCycles.GetNumberOfPositiveIntegersWhoseSquareIsLess(a));
        }


        [TestCase(8, 4)]
        [TestCase(-8, -4)]
        [TestCase(15, 5)]
        [TestCase(17, 1)]
        public void GreatestСommonDivisorTests(int a, int expected)
        {
            int actual = ProgrammingCycles.GreatestСommonDivisor(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        public void GreatestСommonDivisor_AEqualOneOrZero_ShouldException(int a)
        {
            Assert.Throws<Exception>(() => ProgrammingCycles.GreatestСommonDivisor(a));
        }


        [TestCase(49, 0, 196)]
        [TestCase(0, 0, 0)]
        [TestCase(1, 18, 21)]
        [TestCase(-7, 7, 0)]
        public void SumOfDivisionOnSevenTests(int a, int b, int expected)
        {
            int actual = ProgrammingCycles.SumOfDivisionOnSeven(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(27,27)]
        public void SumOfDivisionOnSeven_AandBSomeAndNotDivide7_ShouldException(int a, int b)
        {
            Assert.Throws<Exception>(() => ProgrammingCycles.SumOfDivisionOnSeven(a, b));
        }


        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(6, 8)]
        public void GetNumberFibonacciTests(int a, int expected)
        {
            int actual = ProgrammingCycles.GetNumberFibonacci(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        public void GetNumberFibonacci_ALessOne_ShouldException(int a)
        {
            Assert.Throws<Exception>(() => ProgrammingCycles.GetNumberFibonacci(a));
        }


        [TestCase(6, 8, 2)]
        [TestCase(12, 2, 2)]
        [TestCase(100, 6, 2)]
        [TestCase(-100, -25, -25)]
        public void FindGreatestCommonDivisorTests(int a, int b, int expected)
        {
            int actual = ProgrammingCycles.FindGreatestCommonDivisor(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 7)]
        public void FindGreatestCommonDivisor_AorBEqualZero_ShouldException(int a, int b)
        {
            Assert.Throws<Exception>(() => ProgrammingCycles.FindGreatestCommonDivisor(a, b));
        }


        [TestCase(27, 3)]
        [TestCase(8, 2)]
        public void FindThirdRootTests(int a, int expected)
        {
            int actual = ProgrammingCycles.FindThirdRoot(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-125)]
        public void FindThirdRoot_AorBEqualZero_ShouldException(int a)
        {
            Assert.Throws<Exception>(() => ProgrammingCycles.FindThirdRoot(a));
        }


        [TestCase(-54, 1)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(11, 2)]
        [TestCase(11003489, 4)]
        public void FindOddDigitsOfNumberTests(int a, int expected)
        {
            int actual = ProgrammingCycles.FindOddDigitsOfNumber(a);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(123, "321")]
        [TestCase(568210, "012865")]
        [TestCase(0, "0")]
        [TestCase(151, "151")]
        [TestCase(88, "88")]
        public void GetReverseNumberTests(int a, string expected)
        {
            string actual = ProgrammingCycles.GetReverseNumber(a);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(12, "12")]
        public void SumOfEvenDigitsIsGreaterThanSumOfOddTests(int a, string expected)
        {
            string actual = ProgrammingCycles.SumOfEvenDigitsIsGreaterThanSumOfOdd(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        public void SumOfEvenDigitsIsGreaterThanSumOfOdd_AEqualZero_ShouldException(int a)
        {
            Assert.Throws<Exception>(() => ProgrammingCycles.SumOfEvenDigitsIsGreaterThanSumOfOdd(a));
        } 


        [TestCase(123, 3456789, "ДА")]
        [TestCase(500, 99, "НЕТ")]
        [TestCase(0, 0, "ДА")]
        public void IsSameDigitTests(int a, int b, string expected)
        {
            string actual = ProgrammingCycles.IsSameDigit(a, b);

            Assert.AreEqual(expected, actual);
        }
    }
}
