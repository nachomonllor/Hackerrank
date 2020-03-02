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
            string[] h_temp = Console.ReadLine().Split(' ');
            int[] h = Array.ConvertAll(h_temp, Int32.Parse);
            string word = Console.ReadLine();
            string al = "abcdefghijklmnopqrstuvwxyz";
            // Console.WriteLine(al.Length);
            int max_h = 0;
            for (int i = 0; i < word.Length; i++)
            {
                int h_actual = h[Array.IndexOf(al.ToCharArray(), word[i])];
                max_h = Math.Max(max_h, h_actual);
            }
            Console.WriteLine(max_h * word.Length);

        }
    }
}
