using System;
using System.Linq;

namespace Arrays_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Count= " + OptionsManager.CountLess100(arr));
            Console.WriteLine("Max= " + OptionsManager.MaxNum(arr));
            OptionsManager.EvenNums(arr);
            arr = OptionsManager.ReverseArr(arr);
            Console.WriteLine("sumEvens= " + OptionsManager.SumEvenNums(arr));
            Console.WriteLine("countEvens= " + OptionsManager.CountEvenNums(arr));
            OptionsManager.PrintArr(arr);
        }
    }
}
