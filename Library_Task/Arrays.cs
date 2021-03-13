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

            if (arr.Length == 0)
            {
                throw new Exception("Пустой массив.");
            }

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

        public static int[] SortArrayBubbleUp(int[] arr)
        {
            /// <summary>
            /// Отсортировать массив по возрастанию сортировкой пузырьком(Bubble).
            /// </summary>

            for (int j = arr.Length - 1; j > 0; j--)
            {
                for (int i = 0; i < j; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int tmp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = tmp;
                    }
                }
            }

            return arr;


            //// Пузырьком по убыванию.
            //for (int j = 0; j < arr.Length; j++)
            //{
            //    for (int i = 0; i < arr.Length - 1; i++)
            //    {
            //        if (arr[i] < arr[i + 1])
            //        {
            //            int tmp = arr[i];
            //            arr[i] = arr[i + 1];
            //            arr[i + 1] = tmp;
            //        }
            //    }
            //} 

            //return arr;
        }

        public static int[] SortArraySelectDown(int[] arr)
        {
            /// <summary>
            /// Отсортировать массив по убыванию сортировкой выбором (Select).
            /// </summary>

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int indexOfMax = i;

                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[indexOfMax] < arr[j])
                    {
                        indexOfMax = j;
                    }
                }

                int tmp = arr[i];
                arr[i] = arr[indexOfMax];
                arr[indexOfMax] = tmp;
            }

            return arr;


            // Выбором по возрастанию
            //for (int i = 0; i < arr.Length - 1; i++)
            //{
            //    int indexOfMin = i;

            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[j] < arr[indexOfMin])
            //        {
            //            indexOfMin = j;
            //        }
            //    }

            //    int tmp = arr[i];
            //    arr[i] = arr[indexOfMin];
            //    arr[indexOfMin] = tmp;
            //}
            //return arr;
        }


    }
}
