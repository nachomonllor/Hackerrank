using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution
            */
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            //string s = "UDDDUDUU";
            int nivel = 0;
            bool valle = false;
            int total_valles = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'U')
                {
                    nivel++;
                }
                else if (s[i] == 'D')
                {
                    nivel--;
                }
                if (nivel < 0 && !valle)
                {
                    valle = true;
                }
                else if (valle && nivel >= 0)
                {
                    total_valles++;
                    valle = false;
                }
            }
            Console.WriteLine(total_valles);


        }

    }
}
