using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp45
{
    class Program
    {
        static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be
            named Solution */
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));
            Array.Sort(a);
            int ans = 0;
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (sum + a[i] <= k)
                {
                    sum += a[i];
                    ans++;
                }
                else
                {
                    break;
                }
            }
            //Console.WriteLine(sum);
            Console.WriteLine(ans);
        }
    }
}
