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
            string s = Console.ReadLine();
            /*almaceno la frecuencia con la que está presente cada numero en arr */
            Dictionary<char, int> frec = s.ToCharArray().GroupBy(x => x)
            .ToDictionary(x => x.Key, x => x.Count());
            int impares = 0;
            foreach (KeyValuePair<char, int> kvp in frec)
            {
                if (kvp.Value % 2 != 0)
                {
                    impares++;
                }
            }
            if (impares > 1)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}
