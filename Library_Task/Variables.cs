using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Task
{
    public static class Variables
    {
        public static double SolveEquation(int firstNumber, int secondNumber)
        {
            if (firstNumber == secondNumber)
            {
                throw new ArgumentException("Число А не может быть равно B");
            }
            else
            {
                double result = (5 * firstNumber + Math.Pow(secondNumber, 2)) / (secondNumber - firstNumber);
                return result;
            }
        }

        //// Другой вариант второй задачи - решение через передачи значения по ссылки.
        //public static (string firstOut, string secondOut) ChangeVariables(string firstInput, string secondInput)
        //{
        //    var changer = (firtsOut: "", secondOut: "");

        //    changer.firtsOut = secondInput;
        //    changer.secondOut = firstInput;
        //    return changer;
        //}


        public static void ChangeVariables(ref string firstInput, ref string secondInput)
        {
            string temp = firstInput;
            firstInput = secondInput;
            secondInput = temp;
        }

        public static int[] SolveDivisionAndShowRemainder(int firstNumber, int secondNumber)
        {

            if (secondNumber == 0)
            {
                throw new ArgumentException("Второе число не может быть нулем.");
            }

            int[] result = new int[2];
            result[0] = firstNumber / secondNumber;
            result[1] = firstNumber % secondNumber;

            return result;
        }

        public static double GetLinearEquation(double firstNumber, double secondNumber, double thirdNumber)
        {
            if (firstNumber == 0)
            {
                throw new ArgumentException("Первый коэфициент (А) линейного уравнения не должно быть 0.");
            }

            double result = (thirdNumber - secondNumber) / firstNumber;

            return result;
        }

        public static string ShowLinearEquation(double a, double b, double c, double d)
        {
            if (a == c)
            {
                throw new ArgumentException("Числа a и c не должны быть равны.");
            }

            var k = (b - d) / (a - c);
            var s = d - k * c;

            return $"Y={k}x + ({s})";

        }


    }
}
