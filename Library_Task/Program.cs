using System;

namespace Library_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            //var arr = ProgrammingCycles.GetNumberOfPositiveIntegersWhoseSquareIsLess(-40);

            //int[] temp = new int[] { 2123, 2, 17, 445, 5, -65 };
            //var arr = Arrays.FindMinimumNumberInArray(temp);

            int[,] temp = new int[,]   {
                            {0, 17, -65, -65},
                            {1, -65, -65, -65},
                            {8, -1, -1, 0},
                            {65, -4, 11, 11},
                            {11, -4, 11, 11},
                                        };
            var arr = ArrayTwoDimensional.GetReverseArray2D(temp);

            //Console.WriteLine(arr);

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"{arr[i]} ");
            //}


            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine("");
            }



        }
    }
}
