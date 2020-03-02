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
        int q = int.Parse(Console.ReadLine());
        while (q-- > 0)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));
            int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));
            Array.Sort(a);
            Array.Sort(b);
            Array.Reverse(b);
            string ans = "YES";
            for (int i = 0; i < n; i++)
            {
                if (a[i] + b[i] < k)
                {
                    ans = "NO";
                    break;
                }
            }
            Console.WriteLine(ans);
        }
    }
}
