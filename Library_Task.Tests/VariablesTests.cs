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

            Assert.AreEqual(expected, actual, 0.1);
        }


        //[TestCase(1, 2, 9)]
        //[TestCase(0, 0, 0)]
        //[TestCase(1, 1, 1)]
        //[TestCase(-1, -2, 1)]
        //public void ChangeVariablesTests(string firstInput, string secondInput, string expected)
        //{
        //    string actual = Variables.ChangeVariables(firstInput, secondInput);

        //    Assert.AreEqual(expected, actual);
        //}


        //[TestCase(1, 2, 9)]
        //[TestCase(0, 0, 0)]
        //[TestCase(1, 1, 1)]
        //[TestCase(-1, -2, 1)]
        //public void ChangeVariables1Tests(int firstNumber, int secondNumber, double expected)
        //{
        //    double actual = Variables.ChangeVariables1(firstNumber, secondNumber);

        //    Assert.AreEqual(expected, actual);
        //}


    }
}