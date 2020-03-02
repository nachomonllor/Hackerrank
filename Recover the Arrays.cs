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
            int n = Convert.ToInt32(Console.ReadLine());
            string[] file_temp = Console.ReadLine().Split(' ');
            int[] file = Array.ConvertAll(file_temp, e => int.Parse(e));
            // Print the number of arrays defined in 'file' to STDOUT.
            int i = 0;
            int ans = 0;
            while (i < file.Length)
            {
                int len = file[i];
                int j;
                //Console.Write(len + " ");
                for (j = i + 1; j < len + i + 1; j++)
                {
                    // Console.Write(file[j] + " ");
                }
                // Console.WriteLine();
                ans++;
                i = j;
            }
            Console.WriteLine(ans);
        }
    }
}
