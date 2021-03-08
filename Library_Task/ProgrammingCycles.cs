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

                for (int i = a; i <= 1000; i += a)
                {
                    arr[i] = a;
                }

                return arr;

            }
            else
            {
                throw new Exception("Число больше 1000");
            }
        }

        public static int GetNumberOfPositiveIntegersWhoseSquareIsLess(int a)
        {
            /// <summary>
            /// Пользователь вводит 1 число (A). Найдите количество положительных целых чисел, 
            /// квадрат которых меньше A.
            /// </summary>

            int i = 0;

            for (i = 1; i * i < a; i++)
            {

            }

            return i - 1;

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
                for (int i = a + 1; i > 0; i++)
                {
                    if (a % i == 0)
                    {
                        return i;
                    }
                }
            }
            else
            {
                throw new Exception("Число не должно быть 0");
            }

            return 0;
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
            /// 6.	Пользователь вводит 1 число (N). Выведите N-ое число ряда фибоначчи. 
            /// В ряду фибоначчи каждое следующее число является суммой двух предыдущих. 
            /// Первое и второе считаются равными 1.
            /// </summary>

            int fibon1 = 1;
            int fibon2 = 1;
            int i = 2;

            while (i < a)
            {
                var sumF = fibon1 + fibon2;
                fibon1 = fibon2;
                fibon2 = sumF;
                i = i + 1;
            }

            return fibon2;
        }

    }
}
