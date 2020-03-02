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
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);
            int[] ppcap = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));
            //int n = 5, k = 3;
            //int[] ppcap = { 4, 2, 6, 1, 10 };
            List<string> paginas = new List<string>();
            for (int i = 0; i < ppcap.Length; i++)
            {
                int prob_cap = ppcap[i];
                string concat = "";
                for (int j = 1; j <= prob_cap; j++)
                {
                    if (j % k == 0)
                    {
                        concat += j;
                        paginas.Add(concat);
                        concat = "";
                    }
                    else
                    {
                        concat += j + ",";
                    }
                }
                if (concat.Length > 0)
                {
                    paginas.Add(concat);
                }
            }
            //foreach (string s in paginas)
            //{
            // Console.WriteLine(s);
            //}
            int ans = 0;
            for (int indicePagina = 0; indicePagina < paginas.Count; indicePagina++)
            {
                string[] cap = paginas[indicePagina].Split(',');
                if (cap.Contains((indicePagina + 1).ToString()))
                {
                    ans++;
                }
            }
        }
    }
}
