using NUnit.Framework;

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


        [TestCase(1000, new int[1] { 0 })]
        [TestCase(0, new int[1] { 0 })]
        [TestCase(-22, new int[1] { 0 })]
        [TestCase(250, new int[] { 250, 500, 750, 1000 })]
        [TestCase(40, new int[] { 40, 80, 120, 160, 200, 240, 280, 320, 360, 400, 440, 480, 520, 560, 600, 640, 680, 720, 760, 800, 840, 880, 920, 960, 1000 })]
        public void GetNumberOfDivisionTests(int a, int[] expected)
        {
            int[] actual = ProgrammingCycles.GetNumberOfDivision(a);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(40, 6)]
        [TestCase(90, 9)]
        [TestCase(40, 6)]
        public void GetNumberOfPositiveIntegersWhoseSquareIsLessTests(int a, int expected)
        {
            int actual = ProgrammingCycles.GetNumberOfPositiveIntegersWhoseSquareIsLess(a);

            Assert.AreEqual(expected, actual);
        }



        [TestCase(8, 4)]
        [TestCase(-8, -4)]
        [TestCase(15, 5)]
        [TestCase(17, 1)]
        [TestCase(1, 1)] // "ОШИбКА"
        [TestCase(0, 0)] // "ОШИбКА"
        public void GreatestСommonDivisorTests(int a, int expected)
        {
            int actual = ProgrammingCycles.GreatestСommonDivisor(a);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(49, 0, 196)]
        [TestCase(0, 0, 0)]
        [TestCase(1, 18, 21)]
        [TestCase(-7, 7, 0)]
        [TestCase(1, 1, 0)] // "ОШИбКА"
        public void SumOfDivisionOnSevenTests(int a, int b, int expected)
        {
            int actual = ProgrammingCycles.SumOfDivisionOnSeven(a, b);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(-1, 0)]  // "ОШИбКА"
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(6, 8)]
        public void GetNumberFibonacciTests(int a, int expected)
        {
            int actual = ProgrammingCycles.GetNumberFibonacci(a);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(6, 8, 2)]
        [TestCase(12, 2, 2)]
        [TestCase(100, 6, 2)]
        [TestCase(-100, -25, -25)]
        [TestCase(0, 0, 0)]
        public void FindGreatestCommonDivisorTests(int a, int b, int expected)
        {
            int actual = ProgrammingCycles.FindGreatestCommonDivisor(a, b);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(27, 3)]
        [TestCase(8, 2)]
        [TestCase(-125, -5)] // "Число должно быть положительным."
        public void FindThirdRootTests(int a, int expected)
        {
            int actual = ProgrammingCycles.FindThirdRoot(a);

            Assert.AreEqual(expected, actual);
        }



    }
}
