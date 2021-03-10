using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Task
{
    public static class Arrays
    {
        public static int FindMinimumNumberInArray(int[] arr)
        {
            /// <summary>
            /// Найти минимальный элемент массива.
            /// </summary>

            int minimum = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < minimum)
                {
                    minimum = arr[i];
                }
            }

            return minimum;
        }

        public static int FindMaximumNumberInArray(int[] arr)
        {
            /// <summary>
            /// Найти максимальный элемент массива.
            /// </summary>

            int maximum = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > maximum)
                {
                    maximum = arr[i];
                }
            }

            return maximum;
        }

        public static int FindIndexOfMinimumNumberInArray(int[] arr)
        {
            /// <summary>
            /// Найти индекс минимального элемента массива.
            /// </summary>

            int numberIndex = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[numberIndex])
                {
                    numberIndex = i;
                }
            }

            return numberIndex;
        }

        public static int FindIndexOfMaximumNumberInArray(int[] arr)
        {
            /// <summary>
            /// Найти индекс максимального элемента массива.
            /// </summary>

            int numberIndex = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[numberIndex])
                {
                    numberIndex = i;
                }
            }

            return numberIndex;
        }

        public static int SumArrayElementsWithOddIndex(int[] arr)
        {
            /// <summary>
            /// Посчитать сумму элементов массива с нечетными индексами.
            /// </summary>

            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (!(i % 2 == 0))
                {
                    sum += arr[i];
                }
            }

            return sum;
        }

        public static int[] GetArrayReverse(int[] arr)
        {
            /// <summary>
            /// Сделать реверс массива (массив в обратном направлении).
            /// </summary>

            int[] arrayTmp = new int[arr.Length];

            for (int i = 0; i < arrayTmp.Length; i++)
            {
                arrayTmp[i] = arr[i];
            }

            for (int i = 0; i < (arrayTmp.Length / 2); i++)
            {
                int index = arrayTmp.Length - i - 1;
                int tmp = arrayTmp[i];

                arrayTmp[i] = arrayTmp[index];
                arrayTmp[index] = tmp;
            }

            return arrayTmp;
        }

        public static int SumNumberOddArrayElements(int[] arr)
        {
            /// <summary>
            /// Посчитать количество нечетных элементов массива.
            /// </summary>

            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    count++;
                }
            }

            return count;
        }

        public static int[] GetArrayChangeHalfNumber(int[] arr)
        {
            /// <summary>
            /// Поменять местами первую и вторую половину массива,
            /// например, для массива 1 2 3 4, результат 3 4 1 2,  или для 12345 - 45312.
            /// </summary>

            int[] arrayTmp = new int[arr.Length];

            for (int i = 0; i < arrayTmp.Length; i++)
            {
                arrayTmp[i] = arr[i];
            }

            for (int i = 0; i < (arrayTmp.Length / 2); i++)
            {
                int indexMiddle = 0;

                if (arrayTmp.Length % 2 == 0)
                {
                    indexMiddle = arrayTmp.Length / 2 + i;
                }
                else
                {
                    indexMiddle = arrayTmp.Length / 2 + i + 1;
                }

                int tmp = arrayTmp[i];
                arrayTmp[i] = arrayTmp[indexMiddle];
                arrayTmp[indexMiddle] = tmp;
            }
            return arrayTmp;
        }

        //public static int[] SortArrayBubble(int[] arr)
        //{
        //    /// <summary>
        //    /// Отсортировать массив по возрастанию одним из способов:  
        //    /// пузырьком(Bubble), выбором (Select) или вставками (Insert)
        //    /// </summary>


        //}
    }
}
