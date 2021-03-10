using System;

namespace Library_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Conditions.SolveQuadraticEquation(-1, -2, 15);

            //Console.WriteLine(Conditions.SolveQuadraticEquation(4, -20, 25));

            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            
        }
    }
}
