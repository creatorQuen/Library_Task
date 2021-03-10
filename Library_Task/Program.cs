using System;

namespace Library_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = ProgrammingCycles.GetNumberOfDivision(40);

            //Console.WriteLine(Conditions.SolveQuadraticEquation(4, -20, 25));

            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write($", {arr[i]}");
            }
            
        }
    }
}
