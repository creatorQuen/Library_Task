using NUnit.Framework;

namespace Library_Task.Tests
{
    public class VariablesTests
    {
        [TestCase(1, 2, 9)]
        [TestCase(0, 0, 0)]
        [TestCase(1, 1, 0)]
        [TestCase(-1, -7, -7.3d)]
        public void SolveEquationTests(int firstNumber, int secondNumber, double expected)
        {
            double actual = Variables.SolveEquation(firstNumber, secondNumber);

            Assert.AreEqual(expected, actual, 0.01);
        }


        //[TestCase(1, 2, (firstOut)]
        //[TestCase(0, 0, 0, 0)]
        //[TestCase("LOL", "WTF", "WTF", "LOL")]
        //[TestCase("-1", -2, -2, "-1")]
        //public void ChangeVariablesTests(string firstInput, string secondInput, (string firstOut, string secondOut) expected)
        //{
        //    (string firstOut, string secondOut) actual = Variables.ChangeVariables(firstInput, secondInput);

        //    Assert.AreEqual(expected, actual);
        //}


        //[TestCase(1, 2, 9)]
        //[TestCase(0, 0, 0)]
        //[TestCase(1, 1, 1)]
        //[TestCase(-1, -2, 1)]
        //public void ChangeVariables1Tests( firstInput, int secondInput, string expected)
        //{
        //    double actual = Variables.ChangeVariables1(firstInput, secondInput);

        //    Assert.AreEqual(expected, actual);
        //}


        [TestCase(9, 3, new int[] { 3, 0 })]
        [TestCase(0, 0, new int[] { 0, 0 })]
        [TestCase(10, 4, new int[] { 2, 2 })]
        [TestCase(10, 3, new int[] { 3, 1 })]
        [TestCase(3, 10, new int[] { 0, 3 })]
        public void SolveDivisionAndShowRemainderTests(int firstNumber, int secondNumber, int[] expected)
        {
            int[] actual = Variables.SolveDivisionAndShowRemainder(firstNumber, secondNumber);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(0, 0, 0, 0)]
        [TestCase(0, 1d, 1d, 0)]
        [TestCase(1, 5, 17, 12)]
        [TestCase(2, 2, 24, 11)]
        [TestCase(-2, -15, 35, -25)]
        [TestCase(3, 2, 24, 7.3d)]
        public void GetLinearEquationTests(double firstNubver, double secondNumber, double thirdNumber, double expected)
        {
            double actual = Variables.GetLinearEquation(firstNubver, secondNumber, thirdNumber);

            Assert.AreEqual(expected, actual, 0.1);
        }


        [TestCase(0, 0, 0, 0, "„исло X1 и Y1 не должны быть равны.")]
        [TestCase(1, 2, 1, 0, "„исло X1 и Y1 не должны быть равны.")]
        [TestCase(6, 5, 1, 4, "Y=0,2x + (3,8)")]
        [TestCase(-1, 2, 1,  0, "Y=-1x + (1)")]
        [TestCase(-1, 2, 1, -4, "Y=-3x + (-1)")]
        public void ShowLinearEquationTests(double a, double b, double c, double d, string expected)
        {
            string actual = Variables.ShowLinearEquation(a, b, c, d);

            Assert.AreEqual(expected, actual);
        }



    }
}