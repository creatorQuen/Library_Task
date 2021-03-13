using System;

namespace Library_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            //var arr = ProgrammingCycles.GetNumberOfPositiveIntegersWhoseSquareIsLess(-40);

            int[] temp = new int[] { 2123, 2, 17, 445, 5, -65 };
            var arr = Arrays.FindMinimumNumberInArray(temp);

            //int[,] temp = new int[,]   {
            //                            {1, 2, 4, 5 },
            //                            { 7, 0, 9 ,4},
            //                            { 5, 67, 7, -1},
            //                            { 567, 34, 123, 68}
            //                            };
            //var arr = ArrayTwoDimensional.FindMInimumIndexNumberOfArray2D(temp);

            Console.WriteLine(arr);

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"{arr[i]} ");
            //}


            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.Write($"{arr[i, j]} ");
            //    }
            //    Console.WriteLine("");   
            //}



        }
    }
}
