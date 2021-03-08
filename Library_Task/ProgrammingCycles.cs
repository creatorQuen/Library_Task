using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Task
{
    public static class ProgrammingCycles
    {
        public static double RaisePower(int a, int b)
        {
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

        

    }
}
