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

            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine().Trim());

                int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));

                int[] countNeg = new int[1000001];
                int[] countPos = new int[1000001];

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < 0) countNeg[-arr[i]]++;
                    else countPos[arr[i]]++;
                }

                int ans = 0;
                for (int i = 0; i < countNeg.Length; i++)
                {
                    ans += (countNeg[i] * (countNeg[i] + 1)) / 2;
                }

                for (int i = 0; i < countPos.Length; i++)
                {
                    ans += (countPos[i] * (countPos[i] + 1)) / 2;
                }

                Console.WriteLine(ans);
            }


            Console.ReadLine();
        }


        

    }
}
