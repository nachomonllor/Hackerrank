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
        string[] input = Console.ReadLine().Split(' ');
        int n = int.Parse(input[0]);
        int d = int.Parse(input[1]);
        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));
        int ans = 0;
        for (int i = 0; i < n; i++)
        {
            int j = i + 1;
            while (j < n && a[j] - a[i] <= d)
            {
                if (a[j] - a[i] == d)
                {
                    int k = j + 1;
                    while (k < n && a[k] - a[j] <= d)
                    {
                        if (a[k] - a[j] == d)
                        {
                            ans++;
                            break;
                        }
                        k++;
                    }
                }
                j++;
            }
        }
        Console.WriteLine(ans);
    }
}
