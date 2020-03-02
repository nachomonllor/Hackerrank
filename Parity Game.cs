using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));
            int sum = arr.Sum();
            if (arr.Length == 1 && sum % 2 != 0)
            {
                Console.WriteLine(-1);
            }
            else if (sum % 2 != 0)
            {
                int i;
                for (i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0 && arr.Length > 1)
                    {
                        Console.WriteLine(1);
                        break;
                    }
                }
                if (i == arr.Length)
                {
                    Console.WriteLine(-1);
                }
            }
            else
            {
                Console.WriteLine(0);
            }
            Console.ReadLine();

        }
    }
}
