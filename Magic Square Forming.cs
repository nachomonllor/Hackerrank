using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp51
{
    class Program
    {
        static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be
            named Solution */
            List<string> entrada = new List<string>();
            for (int i = 0; i < 3; i++)
            {
                entrada.Add(String.Join("", Console.ReadLine().Split(' ')));
            }
            //foreach (string s in entrada)
            //{
            // Console.WriteLine(s);
            //}
            List<List<string>> todos = new List<List<string>>();
            todos.Add(new List<string>(new string[] { "816", "357", "492" }));
            todos.Add(new List<string>(new string[] { "618", "753", "294" }));
            todos.Add(new List<string>(new string[] { "438", "951", "276" }));
            todos.Add(new List<string>(new string[] { "276", "951", "438" }));
            todos.Add(new List<string>(new string[] { "294", "753", "618" }));
            todos.Add(new List<string>(new string[] { "492", "357", "816" }));
            todos.Add(new List<string>(new string[] { "672", "159", "834" }));
            todos.Add(new List<string>(new string[] { "834", "159", "672" }));
            int min_costo = int.MaxValue;
            foreach (List<string> lista in todos)
            {
                int costo = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        costo += Math.Abs(int.Parse(entrada[i][j].ToString()) - int.Parse(lista[i]
                        [j].ToString()));
                    }
                }
                min_costo = Math.Min(min_costo, costo);
            }
            Console.WriteLine(min_costo);
        }
    }
}
