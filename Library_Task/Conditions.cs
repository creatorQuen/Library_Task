using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Task
{
    class Conditions
    {
        public static double SolveAddMultiplySubtruct(int a, int b)
        {
            if (a > b)
            {
                return a + b;
            }
            else if (a == b)
            {
                return a * b;
            }
            else
            {
                return a - b;
            }
        }

        public static int QuarterPoint(double x, double y)
        {
            int ans = 0;

            if (x > 0)
            {
                if (y != 0)
                {
                    if (y > 0)
                    {
                        return ans = 1;
                    }
                    else
                    {
                        return ans = 4;
                    }
                }
                else
                {
                    throw new Exception("Точка на положительной части оси Х");
                }
            }
            else if (x < 0)
            {
                if (y > 0)
                {
                    return ans = 2;
                }
                else if (y < 0)
                {
                    return ans = 3;
                }
                else
                {
                    throw new Exception("Точка на отрицательной части оси Х");
                }
            }
            else
            {
                if (y > 0)
                {
                    throw new Exception("Точка на положительной части оси Y");
                }
                else if (y < 0)
                {
                    throw new Exception("Точка на отрицательной части оси Y");
                }
                else
                {
                    throw new Exception("Начало координат");
                }
            }

        }

        public static int[] SortAscending(int a, int b, int c)
        {
            //double a, b, c, temp;
            //Console.Write("Введите число a: ");
            int[] numbers = new int[3];

            if (a > b)
            {
                temp = a;
                a = b;
                b = temp;
            }

            if (b > c)
            {
                temp = b;
                b = c;
                c = temp;
            }

            if (a > b)
            {
                temp = a;
                a = b;
                b = temp;
            }

            Console.WriteLine("Ответ: " + a + " " + b + " " + c);
        }

        public static double[] SolveQuadraticEquation(int a, int b, int c)
        {
            double D = Math.Pow(b, 2) - 4 * a * c;
            double[] arrayOne = new double[1];
            double[] arrayTwo = new double[2];

            if (D < 0)
            {
                throw new Exception("Нет корней D < 0");

            }
            else if (D == 0)
            {
                double x = -b / (2 * a);
                arrayOne[0] = x;

                return arrayOne;
            }
            else
            {
                double x1 = (-b + Math.Pow(D, 0.5d)) / (2 * a);
                double x2 = (-b - Math.Pow(D, 0.5d)) / (2 * a);

                arrayOne[0] = x1;
                arrayOne[1] = x2;

                return arrayTwo;
            }

        }

        public static string GetUpperCaseTwoDigitNumber(int number)
        {
            if ((number > 9) && (number < 20))
            {
                switch (number)
                {
                    case 10:
                        Console.WriteLine("десять");
                        break;
                    case 11:
                        Console.WriteLine("одинадцать");
                        break;
                    case 12:
                        Console.WriteLine("двенадцать");
                        break;
                    case 13:
                        Console.WriteLine("тринадцать");
                        break;
                    case 14:
                        Console.WriteLine("четырнадцать");
                        break;
                    case 15:
                        Console.WriteLine("пятнадцать");
                        break;
                    case 16:
                        Console.WriteLine("шестнадцать");
                        break;
                    case 17:
                        Console.WriteLine("семнадцать");
                        break;
                    case 18:
                        Console.WriteLine("восемнадцать");
                        break;
                    case 19:
                        Console.WriteLine("девятнадцать");
                        break;
                }
            }
            else if (number >= 20)
            {
                int inputNumberDec = number / 10;

                switch (inputNumberDec)
                {
                    case 2:
                        Console.Write("двадцать");
                        break;
                    case 3:
                        Console.Write("тридцать");
                        break;
                    case 4:
                        Console.Write("сорок");
                        break;
                    case 5:
                        Console.Write("пятьдесят");
                        break;
                    case 6:
                        Console.Write("шестьдесят");
                        break;
                    case 7:
                        Console.Write("семьдесят");
                        break;
                    case 8:
                        Console.Write("восемьдесят");
                        break;
                    case 9:
                        Console.Write("девяносто");
                        break;
                }


                int inputNumberOne = number % 10;

                switch (inputNumberOne)
                {
                    case 1:
                        Console.Write(" один");
                        break;
                    case 2:
                        Console.Write(" два");
                        break;
                    case 3:
                        Console.Write(" три");
                        break;
                    case 4:
                        Console.Write(" четыре");
                        break;
                    case 5:
                        Console.Write(" пять");
                        break;
                    case 6:
                        Console.Write(" шесть");
                        break;
                    case 7:
                        Console.Write(" семь");
                        break;
                    case 8:
                        Console.Write(" восемь");
                        break;
                    case 9:
                        Console.Write(" девять");
                        break;
                }
            }
            else
            {
                throw new Exception("Число не двузначное");
            }
        }


    }
}
