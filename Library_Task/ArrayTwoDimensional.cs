using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Task
{
    public static class ArrayTwoDimensional
    {
        // Найти количество элементов массива, которые больше всех своих соседей одновременно

        int[,]arr={ {1, 2, 3, 4, 5, 5 },
                        {3, 2, 7, 4, 5, 5 },
                        {1, 5, 3, 4, 5, 10 },
                        {1, 2, 3, 4, 5, 5 },
                        {6, 2, 3, 4, 9, 5 },
            };

            int k = 0;

            int str = arr.GetLength(0);
            int row = arr.GetLength(1);

            for (int i=0; i < arr.GetLength(0); i++)
            {
                for(int j=0; j < arr.GetLength(1); j++)
                {

                    int element = arr[i, j];


                    if(InRange(i - 1, str))
                    {
                        if(arr[i - 1, j] >= element)
                        {
                            continue;
                        }
                    }
                    
                    if(InRange(i + 1, str))
                    {
                        if (arr[i + 1, j] >= element)
                        {
                            continue;
                        }
                    }

                    if (InRange(j + 1, row))
                    {
                        if (arr[i, j + 1] >= element)
                        {
                            continue;
                        }
                    }

                    if (InRange(j - 1, row))
                    {
                        if (arr[i, j - 1] >= element)
                        {
                            continue;
                        }
                    }

                    k++;


                }
            }
            Console.WriteLine("");
            Console.WriteLine(k);

        }
        public static bool InRange(int index, int lenght)
        {

            return index >= 0 && index < lenght;

        }
    }
}
