using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static int shortestTightArray(int a, int b, int c)
        {
            // Complete this function
            int res = 0;
            if (a <= c)
            {
                if (b >= a && b <= c)
                {
                    res = c - a + 1;
                    return res;
                }
            }
            else if (c <= a)
            {
                if (b >= c && b <= a)
                {
                    res = a - c + 1;
                    return res;
                }
            }
            if (b <= a && b <= c)
            {
                res = (a - b) + (c - b) + 1;
                return res;
            }
            if (b >= a && b >= c){

                res = (b - a) + (b - c) + 1;
            }
            return res;
        }
        static void Main(String[] args)
        {
            string[] tokens_a = Console.ReadLine().Split(' ');
            int a = Convert.ToInt32(tokens_a[0]);
            int b = Convert.ToInt32(tokens_a[1]);
            int c = Convert.ToInt32(tokens_a[2]);
            int result = shortestTightArray(a, b, c);
            Console.WriteLine(result);

        }

    }

}
