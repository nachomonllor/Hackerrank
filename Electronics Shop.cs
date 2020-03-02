using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_s = Console.ReadLine().Split(' ');
            int s = Convert.ToInt32(tokens_s[0]);
            int n = Convert.ToInt32(tokens_s[1]);
            int m = Convert.ToInt32(tokens_s[2]);
            string[] keyboards_temp = Console.ReadLine().Split(' ');
            int[] keyboards = Array.ConvertAll(keyboards_temp, Int32.Parse);
            string[] pendrives_temp = Console.ReadLine().Split(' ');
            int[] pendrives = Array.ConvertAll(pendrives_temp, Int32.Parse);
            int min_dif = int.MaxValue;
            int max_precio = 0;
            bool hay = false;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (s - (keyboards[i] + pendrives[j]) >= 0 && s - (keyboards[i] + pendrives[j]) <
                     min_dif)
                    {
                        min_dif = s - (keyboards[i] + pendrives[j]);
                        max_precio = keyboards[i] + pendrives[j];
                        hay = true;
                    }
                }
            }

            Console.WriteLine(hay ? max_precio :-1);
        }
    }
}
