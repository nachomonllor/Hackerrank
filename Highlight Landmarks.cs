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
            string D = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(' ');
            string[] split = D.Split(' ');
            for (int i = 0; i < names.Length; i++)
            {
                for (int j = 0; j < split.Length; j++)
                {
                    if (names[i] == split[j])
                    {
                        split[j] = "<b>" + names[i] + "</b>";
                    }
                }
            }
            Console.WriteLine(String.Join(" ", split).Trim());
        }
    }
}
