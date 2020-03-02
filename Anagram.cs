using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Solution
{
    static void Main(string[] args)
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            //string s = "aaabbb";
            //string s = "mnop";
            //string s = "xaxbbbxx";
            string s = Console.ReadLine();
            if (s.Length % 2 != 0)
            {
                Console.WriteLine(-1);
                continue;
            }
            string a = s.Substring(0, s.Length / 2);
            string b = s.Substring(s.Length / 2, s.Length / 2);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            Dictionary<char, int> frec_a = a.ToCharArray().GroupBy(x => x)
            .ToDictionary(x => x.Key, x => x.Count());
            Dictionary<char, int> frec_b = b.ToCharArray().GroupBy(x => x)
            .ToDictionary(x => x.Key, x => x.Count());
            int sobra_a = 0, sobra_b = 0;
            foreach (KeyValuePair<char, int> kvp in frec_a)
            {
                if (frec_b.ContainsKey(kvp.Key))
                {
                    if (kvp.Value >= frec_b[kvp.Key])
                    {
                        sobra_a += kvp.Value - frec_b[kvp.Key];
                    }
                    else
                    {
                        sobra_b += frec_b[kvp.Key] - kvp.Value;
                    }
                }
                else
                {
                    sobra_a += kvp.Value;
                }
            }
            foreach (KeyValuePair<char, int> kvp in frec_b)
            {
                if (!frec_a.ContainsKey(kvp.Key))
                {
                    sobra_b += kvp.Value;
                }
            }
            Console.WriteLine(Math.Min(sobra_a, sobra_b));

        }

        // Console.ReadLine();

    }

}
