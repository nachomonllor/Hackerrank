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
        string a = Console.ReadLine();
        string b = Console.ReadLine();
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
        Console.WriteLine(sobra_a + sobra_b);
    }
}