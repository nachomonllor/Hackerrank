using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be
        named Solution */
        int p = int.Parse(Console.ReadLine());
        while (p-- > 0)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string ans = "NO";
            for (char i = 'a'; i <= 'z'; i++)
            {
                //Console.WriteLine(i);
                if (a.Contains(i.ToString()) && b.Contains(i.ToString()))
                {
                    ans = "YES";
                    break;
                }
            }
            Console.WriteLine(ans);
        }
    }
}