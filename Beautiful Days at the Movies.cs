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

            string[] input = Console.ReadLine().Split(' ');
            int i = int.Parse(input[0]);
            int j = int.Parse(input[1]);
            int k = int.Parse(input[2]);

            int ans = 0;
            for (int n = i; n <= j; n++)
            {
                char[] rev = n.ToString().ToCharArray();
                Array.Reverse(rev);

                if (Math.Abs(n - int.Parse(new string(rev))) % k == 0)
                {
                    ans++;
                }
            }

            Console.WriteLine(ans);


            Console.ReadLine();
        }
    }
}

