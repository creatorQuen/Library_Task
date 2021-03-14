using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Task
{
    public static class ProgrammingCycles
    {
        public static double RaisePower(int a, int b)
        {
            /// <summary>
            /// Пользователь вводит 2 числа (A и B). Возвести число A в степень B.
            /// </summary>

            double res = 1;

            if (a == 0 && b == 0)
            {
                return 1;
            }
            else if (b < 0)
            {
                for (int i = 0; i > b; i--)
                {
                    res /= a;
                }
                return res;
            }
            else
            {
                for (int i = 0; i < b; i++)
                {
                    res *= a;
                }
                return res;
            }
        }

        public static int[] GetNumberOfDivision(int a)
        {
            /// <summary>
            /// Пользователь вводит 1 число (A). Вывести все числа от 1 до 1000, которые делятся на A.
            /// </summary>

            if (a > 0 && a <= 1000)
            {
                int size = 1000 / a;
                int[] arr = new int[size];
                int j = 0;

                for (int i = 1; i <= 1000; i++)
                {
                    if (i % a == 0)
                    {
                        arr[j] = i;
                        j++;
                    }
                }

                return arr;

            }
            else
            {
                throw new Exception("Число больше 1000 либо меньше 1.");
            }
        }

        public static int GetNumberOfPositiveIntegersWhoseSquareIsLess(int a)
        {
            /// <summary>
            /// Пользователь вводит 1 число (A). Найдите количество положительных целых чисел, квадрат которых меньше A.
            /// </summary>


            int i = 0;

            if (a == 0)
            {
                throw new Exception("Число не должно быть равно нулю.");
            }
            else if (a > 0)
            {
                for (i = 1; i * i < a; i++)
                {

                }

                return i - 1;
            }
            else
            {
                throw new Exception("Число не должно быть отрицательным.");
            }



            //int a = 1;

            //while (a * a < A3)
            //{
            //  a++;
            //}
        }

        public static int GreatestСommonDivisor(int a)
        {

            /// <summary>
            /// Пользователь вводит 1 число (A). Вывести наибольший делитель (кроме самого A) числа A.
            /// </summary>

            if (a > 0)
            {
                for (int i = a - 1; i > 0; i--)
                {
                    if (a % i == 0)
                    {
                        return i;
                    }
                }
            }
            else if (a < 0)
            {
                for (int i = a + 1; i < 0; i++)
                {
                    if (a % i == 0)
                    {
                        return i;
                    }
                }
            }
            else if (a == 1)
            {
                throw new Exception("Число не должно быть 1");
            }
            else
            {
                throw new Exception("Число не должно быть 0");
            }

            return 1;
        }

        public static int SumOfDivisionOnSeven(int a, int b)
        {
            /// <summary>
            /// Пользователь вводит 2 числа (A и B). Вывести сумму всех чисел из диапазона от A до B, 
            /// которые делятся без остатка на 7 (Учтите, что при вводе B может оказаться меньше A).
            /// </summary>

            int sum = 0;

            if (a < b)
            {
                for (int i = a; i <= b; i++)
                {
                    if (i % 7 == 0)
                    {
                        sum += i;
                    }

                }
                return sum;

            }
            else if (b < a)
            {
                for (int i = b; i <= a; i++)
                {
                    if (i % 7 == 0)
                    {
                        sum += i;
                    }
                }
                return sum;

            }
            else
            {
                if (a % 7 == 0)
                {
                    return a;
                }
                else
                {
                    throw new Exception("Числа одинаковые и не делятся на 7");
                }
            }
        }

        public static int GetNumberFibonacci(int a)
        {
            /// <summary>
            /// Пользователь вводит 1 число (N). Выведите N-ое число ряда фибоначчи. 
            /// В ряду фибоначчи каждое следующее число является суммой двух предыдущих. 
            /// Первое и второе считаются равными 1.
            /// </summary>

            int fibon1 = 1;
            int fibon2 = 1;
            int i = 2;

            if (a < 1)
            {
                throw new Exception("Число не может быть меньше единицы.");
            }

            while (i < a)
            {
                var sumF = fibon1 + fibon2;
                fibon1 = fibon2;
                fibon2 = sumF;
                i = i + 1;
            }

            return fibon2;
        }

        public static int FindGreatestCommonDivisor(int a, int b)
        {
            /// <summary>
            /// Пользователь вводит 2 числа. Найти их наибольший общий делитель используя алгоритм Евклида.
            /// </summary>

            if ((a == 0)|| (b == 0))
            {
                throw new Exception("Числа не должны быть равны нулю.");
            }


            if (a > b)
            {
                int temp = a;

                a = b;
                b = temp;
            }


            if ( a % b != 0)
            {
                while ((a != 0) && (b != 0))
                {
                    if (a > b)
                    {
                        a = a % b;
                    }
                    else
                    {
                        b = b % a;
                    }
                }

                return a + b;
            }
            else
            {
                return b;
            }

        }

        public static int FindThirdRoot(int a)
        {
            /// <summary>
            /// Пользователь вводит целое положительное число, которое является кубом целого числа N. 
            /// Найдите число N методом половинного деления.
            /// </summary>
            
            if (a < 1)
            {
                throw new Exception("Число должно быть положительным.");
            }


            int left = 0;
            int right = a;
            int middle = (right + left) / 2;
            int y = middle * middle * middle;

            while (y != a)
            {
                if (middle * middle * middle > a)
                {
                    right = middle;
                }
                else
                {
                    left = middle;
                }
                middle = (right + left) / 2;
                y = middle * middle * middle;
            }

            return middle;
        }

        public static int FindOddDigitsOfNumber(int a)
        {
            /// <summary>
            /// Пользователь вводит 1 число. Найти количество нечетных цифр этого числа.
            /// </summary>

            int count = 0;

            if (a < 0)
            {
                a = Math.Abs(a);

                for (int i = 0; i < a.ToString().Length; i++)
                {
                    char number = a.ToString()[i];
                    if ((int)Char.GetNumericValue(number) % 2 != 0)
                    {
                        count++;
                    }
                }

                return count;
            }
            else
            {
                for (int i = 0; i < a.ToString().Length; i++)
                {
                    char number = a.ToString()[i];
                    if ((int)Char.GetNumericValue(number) % 2 != 0)
                    {
                        count++;
                    }
                }

                return count;
            }


        }

        public static string GetReverseNumber(int a)
        {
            /// <summary>
            /// Пользователь вводит 1 число. Найти число, которое является зеркальным отображением 
            /// последовательности цифр заданного числа, например, задано число 123, вывести 321.
            /// </summary>

            string newAns = "";

            for (int i = a.ToString().Length - 1; i >= 0; i--)
            {
                newAns += a.ToString()[i];
            }
            
            return newAns;
        }

        public static string SumOfEvenDigitsIsGreaterThanSumOfOdd(int a)
        {
            /// <summary>
            /// Пользователь вводит целое положительное  число (N).
            /// Выведите числа в диапазоне от 1 до N, сумма четных цифр которых больше суммы нечетных. 
            /// </summary>

            if(a <= 0)
            {
                throw new Exception("Число должно быть целым, положительным и больше нуля");
            }

            string currentNum;
            int sum;
            string d = "";

            for (int i = 1; i <= a; i++)
            {
                currentNum = Convert.ToString(i);
                sum = 0;

                for (int j = 0; j < currentNum.Length; j++)
                {
                    if ((int)(Char.GetNumericValue(currentNum[j])) % 2 == 0)
                    {
                        sum += (int)(Char.GetNumericValue(currentNum[j]));
                    }
                    else
                    {
                        sum -= (int)(Char.GetNumericValue(currentNum[j]));
                    }
                }

                if (sum > 0)
                {
                    d = i + "";

                }
            }

            return d;

        }

        public static string IsSameDigit(int a, int b)
        {
            /// <summary>
            /// Пользователь вводит 2 числа. Сообщите, есть ли в написании двух чисел одинаковые цифры.
            /// Например, для пары 123 и 3456789, ответом будет являться “ДА”, а, для пары 500 и 99 - “НЕТ”.
            /// </summary>

            string FLAG = "НЕТ";

            do
            {
                int digitA = a % 10;
                int tempB = b;
                
                do
                {
                    if (tempB % 10 == digitA)
                    {
                        FLAG = "ДА";
                    }

                    tempB = tempB / 10;

                } 
                while (tempB != 0);

                a = a / 10;

            } 
            while (a != 0);

            return FLAG;
        }




    }
}

