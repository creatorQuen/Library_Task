using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Task
{
    public static class ArrayTwoDimensional
    {
        public static int CountNumberOfElementsGreaterAllNeighbors(int[,] arr)
        {
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
