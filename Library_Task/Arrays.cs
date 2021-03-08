using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Task
{
    public static class Arrays
    {
        public static int GetMinimumNumberInArray(int[] array)
        {
            /// <summary>
            /// Найти минимальный элемент массива.
            /// </summary>

            int minimum = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minimum)
                {
                    minimum = array[i];
                }
            }

            return minimum;
        }



    }
}
