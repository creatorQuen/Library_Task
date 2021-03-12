using System;

namespace Library_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            //var arr = ProgrammingCycles.GetNumberOfPositiveIntegersWhoseSquareIsLess(-40);

            //var arr = ProgrammingCycles.FindThirdRoot(27);

            //Console.WriteLine(arr);

            //for(int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($", {arr[i]}");
            //}


            //Console.Write("Введите число N: ");
            //var N = Convert.ToInt32(Console.ReadLine());
            //string currentNum;
            //int sum;
            //for (int i = 1; i <= N; i++)
            //{
            //    currentNum = Convert.ToString(i);
            //    sum = 0;
            //    for (int j = 0; j < currentNum.Length; j++)
            //    {
            //        if ((int)(Char.GetNumericValue(currentNum[j])) % 2 == 0)
            //        {
            //            sum += (int)(Char.GetNumericValue(currentNum[j]));
            //        }
            //        else
            //        {
            //            sum -= (int)(Char.GetNumericValue(currentNum[j]));
            //        }
            //    }
            //    if (sum > 0)
            //    {
            //        Console.Write(i + " ");
            //    }
            //}


            var n = ProgrammingCycles.IsSameDigit(20, 21);

            Console.WriteLine(n);
        }
    }
}
