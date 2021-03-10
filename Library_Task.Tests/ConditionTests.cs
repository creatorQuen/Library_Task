using NUnit.Framework;

namespace Library_Task.Tests
{
    public class ConditionTests
    {
        [TestCase(1, 1, 1)]
        [TestCase(0, -5, -5)]
        [TestCase(9, 9, 81)]
        [TestCase(0, -5, -5)]
        public void SolveAddMultiplySubtructTests(int a, int b, double expected)
        {
            double actual = Conditions.SolveAddMultiplySubtruct(a, b);

            Assert.AreEqual(expected, actual, 0.1);
        }


        [TestCase(0, 0, 0)]
        [TestCase(0, 1.2, 0)]
        [TestCase(56.8, 0, 0)]
        [TestCase(0, -9, 0)]
        [TestCase(-12.2, 0, 0)]
        [TestCase(1.9, 1.3, 1)]
        [TestCase(-1.2, 23.5, 2)]
        [TestCase(-1, -2, 3)]
        [TestCase(56.9, -22, 4)]
        public void GetQuarterPointAreaTests(double x, double y, int expected)
        {
            int actual = Conditions.GetQuarterPointArea(x, y);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(1, 2, 3, new int[] { 1, 2, 3 })]
        [TestCase(89, 0, 12, new int[] { 0, 12, 89 })]
        [TestCase(-8, -52, -3, new int[] { -52, -8, -3 })]
        [TestCase(0, 0, 0, new int[] { 0, 0, 0 })]
        public void SortAscendingTests(int a, int b, int c, int[] expected)
        {
            int[] actual = Conditions.SortAscending(a, b, c);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(0, 0, 0, new double[] {0})]
        [TestCase(4, -20, 25, new double[] {2.5})]
        [TestCase(-1, -2, 15, new double[] {-5, 3})]
        public void SolveQuadraticEquationTests(double a, double b, double c, double[] expected)
        {
            double[] actual = Conditions.SolveQuadraticEquation(a, b, c);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(20, "двадцать")]
        [TestCase(10, "десять")]
        [TestCase(33, "тридцать три")]
        [TestCase(99, "девяносто девять")]
        [TestCase(100, "Число не двузначное")]
        [TestCase(-1, "Число не двузначное")]
        public void GetUpperCaseTwoDigitNumber(int number, string expected)
        {
            string actual = Conditions.GetUpperCaseTwoDigitNumber(number);

            Assert.AreEqual(expected, actual);
        }

    }
}
