using NUnit.Framework;
using System;

namespace Library_Task.Tests
{
    public class VariablesTests
    {
        [TestCase(1, 2, 9)]
        [TestCase(0, 1, 1)]
        [TestCase(-1, -7, -7.33d)]
        public void SolveEquationTests(int firstNumber, int secondNumber, double expected)
        {
            double actual = Variables.SolveEquation(firstNumber, secondNumber);

            Assert.AreEqual(expected, actual, 0.01);
        }

        [TestCase(1, 1)]
        [TestCase(0, 0)]
        public void SolveEquationTests_FirstNumberIsEqualSecondNumber_ShouldArgumentException(int firstNumber, int secondNumber)
        {
            Assert.Throws<ArgumentException>(() => Variables.SolveEquation(firstNumber, secondNumber));
        }


        [TestCase("0", "0", "0", "0")]
        [TestCase("32", "11", "11", "32")]
        [TestCase("-1", "8", "8", "-1")]
        public void ChangeVariablesTests(string firstInput, string secondInput, string expected1, string expected2)
        {
            Variables.ChangeVariables(ref firstInput, ref secondInput);

            string actual1 = firstInput;
            string actual2 = secondInput;

            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }


        [TestCase(10, 4, new int[] { 2, 2 })]
        [TestCase(10, 3, new int[] { 3, 1 })]
        [TestCase(3, 10, new int[] { 0, 3 })]
        public void SolveDivisionAndShowRemainderTests(int firstNumber, int secondNumber, int[] expected)
        {
            int[] actual = Variables.SolveDivisionAndShowRemainder(firstNumber, secondNumber);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 0)]
        [TestCase(-8, 0)]
        public void SolveDivisionAndShowRemainder_SecondNumberEqualZero_ShouldArgumentException(int firstNumber, int secondNumber)
        {
            Assert.Throws<ArgumentException>(() => Variables.SolveDivisionAndShowRemainder(firstNumber, secondNumber));
        }


        [TestCase(1, 5, 17, 12)]
        [TestCase(2, 2, 24, 11)]
        [TestCase(-2, -15, 35, -25)]
        [TestCase(3, 2, 24, 7.3d)]
        public void GetLinearEquationTests(double firstNubver, double secondNumber, double thirdNumber, double expected)
        {
            double actual = Variables.GetLinearEquation(firstNubver, secondNumber, thirdNumber);

            Assert.AreEqual(expected, actual, 0.1);
        }

        [TestCase(0, 7, -8)]
        [TestCase(0, -89, 5)]
        public void GetLinearEquation_FirstNumberEqualZero_ShouldArgumentException(double firstNumber, double secondNumber, double thirdNumber)
        {
            Assert.Throws<ArgumentException>(() => Variables.GetLinearEquation(firstNumber, secondNumber, thirdNumber));
        }


        [TestCase(6, 5, 1, 4, "Y=0,2x + (3,8)")]
        [TestCase(-1, 2, 1,  0, "Y=-1x + (1)")]
        [TestCase(-1, 2, 1, -4, "Y=-3x + (-1)")]
        public void ShowLinearEquationTests(double a, double b, double c, double d, string expected)
        {
            string actual = Variables.ShowLinearEquation(a, b, c, d);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 7, 1, 8)]
        [TestCase(-8, 2, -8, -152)]
        public void ShowLinearEquation_AEqualB_ShouldArgumentException(double a, double b, double c, double d)
        {
            Assert.Throws<ArgumentException>(() => Variables.ShowLinearEquation(a, b, c, d));
        }

    }
}