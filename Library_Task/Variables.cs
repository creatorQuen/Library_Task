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
                throw new Exception("Число А не может быть равно B");
            }
            else
            {
                double result = (5 * firstNumber + Math.Pow(secondNumber, 2)) / (secondNumber - firstNumber);
                return result;
            }
        }

        public static (string firstOut, string secondOut) ChangeVariables(string firstInput, string secondInput)
        {
            var changer = (firtsOut: "", secondOut: "");

            //string changer;
            //changer = firstInput;
            //firstInput = secondInput;
            //secondInput = changer;

            changer.firtsOut = secondInput;
            changer.secondOut = firstInput;
            return changer;
        }

        // Другой вариант второй задачи - решение через передачи значения по ссылки.
        public static void ChangeVariables1(ref string firstInput, ref string secondInput)
        {
            string temp = firstInput;
            firstInput = secondInput;
            secondInput = temp;
        }

        public static int[] SolveDivisionAndShowRemainder(int firstNumber, int secondNumber)
        {

            if (secondNumber == 0)
            {
                throw new Exception("При делении в знаменателе ноль.");
            }

            int[] result = new int[2];
            result[0] = firstNumber / secondNumber;
            result[1] = firstNumber % secondNumber;

            return result;
        }

        public static double GetLinearEquation(double firstNubver, double secondNumber, double thirdNumber)
        {
            if (firstNubver == 0)
            {
                throw new Exception("Первый коэфициент (А) линейного уравнения не должно быть 0.");
            }

            double result = (thirdNumber - secondNumber) / firstNubver;

            return result;
        }

        public static string PlacePoint(double a, double b, double c, double d)
        {
            if (a == c)
            {
                throw new Exception("Число X1 и Y1 не должны быть равны.");
            }

            var k = (b - d) / (a - c);
            var s = d - k * c;

            return $"Y={k}x + {s}";

        }


    }
}
