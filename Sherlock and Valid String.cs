using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be
        named Solution */
        string s = Console.ReadLine();
        Dictionary<char, int> frec = s.ToCharArray().GroupBy(x => x)
        .ToDictionary(x => x.Key, x => x.Count());
        Dictionary<int, int> values = new Dictionary<int, int>();
        foreach (KeyValuePair<char, int> kvp in frec)
        {
            //Console.WriteLine(kvp.Key + " " + kvp.Value);
            if (values.ContainsKey(kvp.Value))
            {
                values[kvp.Value]++;
            }
            else
            {
                values[kvp.Value] = 1;
            }
        }
        if (values.Count == 1)
        {
            Console.WriteLine("YES");
        }
        else if (values.Count > 2)
        {
            Console.WriteLine("NO");
        }
        else if (values.Count == 2)
        {
            //foreach (KeyValuePair<int, int> kvp in values)
            //{
            // Console.WriteLine(kvp.Key + " " + kvp.Value);
            //}
            List<int> lista = values.Values.ToList();
            //foreach (int v in lista)
            //{
            // Console.Write(v + " ");
            //}
            if (lista[0] != 1 && lista[1] != 1)
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