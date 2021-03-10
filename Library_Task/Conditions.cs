using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Task
{
    public static class Conditions
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

        public static int GetQuarterPointArea(double x, double y)
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
            int temp = 0;
            
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

            numbers[0] = a;
            numbers[1] = b;
            numbers[2] = c;

            return numbers;
        }

        public static double[] SolveQuadraticEquation(double a, double b, double c)
        {
            if(a == 0)
            {
                throw new Exception("Коэффициент a не может быть равен нулю.");
            }

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

                arrayTwo[0] = x1;
                arrayTwo[1] = x2;

                return arrayTwo;
            }

        }

        public static string GetUpperCaseTwoDigitNumber(int number)
        {
            string wordNumber = "";

            if ((number > 9) && (number < 20))
            {
                switch (number)
                {
                    case 10:
                        wordNumber = "десять";
                        break;
                    case 11:
                        wordNumber = "одинадцать";
                        break;
                    case 12:
                        wordNumber = "двенадцать";
                        break;
                    case 13:
                        wordNumber = "тринадцать";
                        break;
                    case 14:
                        wordNumber = "четырнадцать";
                        break;
                    case 15:
                        wordNumber = "пятнадцать";
                        break;
                    case 16:
                        wordNumber = "шестнадцать";
                        break;
                    case 17:
                        wordNumber = "семнадцать";
                        break;
                    case 18:
                        wordNumber = "восемнадцать";
                        break;
                    case 19:
                        wordNumber = "девятнадцать";
                        break;
                }

                return wordNumber;
            }
            else if (number >= 20 && number < 100)
            {
                int inputNumberDec = number / 10;

                switch (inputNumberDec)
                {
                    case 2:
                        wordNumber = "двадцать";
                        break;
                    case 3:
                        wordNumber = "тридцать";
                        break;
                    case 4:
                        wordNumber = "сорок";
                        break;
                    case 5:
                        wordNumber = "пятьдесят";
                        break;
                    case 6:
                        wordNumber = "шестьдесят";
                        break;
                    case 7:
                        wordNumber = "семьдесят";
                        break;
                    case 8:
                        wordNumber = "восемьдесят";
                        break;
                    case 9:
                        wordNumber = "девяносто";
                        break;
                }


                int inputNumberOne = number % 10;

                switch (inputNumberOne)
                {
                    case 1:
                        wordNumber = wordNumber + " один";
                        break;
                    case 2:
                        wordNumber = wordNumber + " два";
                        break;
                    case 3:
                        wordNumber = wordNumber + " три";
                        break;
                    case 4:
                        wordNumber = wordNumber + " четыре";
                        break;
                    case 5:
                        wordNumber = wordNumber + " пять";
                        break;
                    case 6:
                        wordNumber = wordNumber + " шесть";
                        break;
                    case 7:
                        wordNumber = wordNumber + " семь";
                        break;
                    case 8:
                        wordNumber = wordNumber + " восемь";
                        break;
                    case 9:
                        wordNumber = wordNumber + " девять";
                        break;
                }

                return wordNumber;
            }
            else
            {
                throw new Exception("Число не двузначное");
            }
        }


    }
}
