using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Task
{
    public static class ArrayTwoDimensional
    {
        public static int FindMinimumElementOfArray2D(int[,] arr)
        {
            /// <summary>
            /// Найти минимальный элемент массива.
            /// </summary>

            if (arr.Length == 0)
            {
                throw new ArgumentException("Пустой массив.");
            }

            int minimum = arr[0, 0];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < minimum)
                    {
                        minimum = arr[i, j];
                    }
                }
            }

            return minimum;
        }

        public static int FindMaximumElementOfArray2D(int[,] arr)
        {
            /// <summary>
            /// Найти максимальный элемент массива.
            /// </summary>

            if (arr.Length == 0)
            {
                throw new ArgumentException("Пустой массив.");
            }

            int maximum = arr[0, 0];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > maximum)
                    {
                        maximum = arr[i, j];
                    }
                }
            }

            return maximum;
        }

        public static int[] FindMinimumIndexNumberOfArray2D(int[,] arr)
        {
            /// <summary>
            /// Найти индекс минимального элемента массива.
            /// </summary>

            if (arr.Length == 0)
            {
                throw new ArgumentException("Пустой массив.");
            }

            int minIndexI = 0;
            int minIndexJ = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < arr[minIndexI, minIndexJ])
                    {
                        minIndexI = i;
                        minIndexJ = j;
                    }
                }
            }

            return new int[] { minIndexI + 1, minIndexJ + 1 };
        }

        public static int[] FindMaximumIndexNumberOfArray2D(int[,] arr)
        {
            /// <summary>
            /// Найти индекс максимального элемента массива.
            /// </summary>

            if (arr.Length == 0)
            {
                throw new ArgumentException("Пустой массив.");
            }

            int maxIndexI = 0;
            int maxIndexJ = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > arr[maxIndexI, maxIndexJ])
                    {
                        maxIndexI = i;
                        maxIndexJ = j;
                    }
                }
            }

            return new int[] { maxIndexI + 1, maxIndexJ + 1 };
        }

        public static int CountNumberOfElementsGreaterAllNeighbors(int[,] arr)
        {
            /// <summary>
            /// Найти количество элементов массива, которые больше всех своих соседей одновременно.
            /// </summary>

            if (arr.Length == 0)
            {
                throw new ArgumentException("Пустой массив.");
            }

            int counter = 0;

            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    if ((i <= 0 || arr[i, j] > arr[i - 1, j])
                        && (i >= arr.GetLength(0) - 1 || arr[i, j] > arr[i + 1, j])
                        && (j <= 0 || arr[i, j] > arr[i , j - 1])
                        && (j >= arr.GetLength(1) - 1 || arr[i, j] > arr[i, j + 1]))
                    {
                        counter++;
                    }
                }
            }

            return counter;
        }

        public static int[,] GetReverseArray2D(int[,] arr)
        {
            /// <summary>
            /// Отразите массив относительно его главной диагонали.
            /// </summary>

            if(arr.Length == 0)
            {
                throw new ArgumentException("Пустой массив.");
            }

            int[,] tempArr = new int[arr.GetLength(1), arr.GetLength(0)];

            for (int i = 0; i < tempArr.GetLength(0); i++)
            {
                for (int j = 0; j < tempArr.GetLength(1); j++)
                {
                    tempArr[i, j] = arr[j, i];
                }
            }

            return tempArr;
        }

    }
}
