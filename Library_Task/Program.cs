using System;

namespace Library_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = ProgrammingCycles.GetNumberOfPositiveIntegersWhoseSquareIsLess(-40);

            Console.WriteLine(arr);

            //for(int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($", {arr[i]}");
            //}

        }
    }
}
