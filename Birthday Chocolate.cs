using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;

class Solution
{
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] squares_temp = Console.ReadLine().Split(' ');
        int[] squares = Array.ConvertAll(squares_temp, Int32.Parse);
        string[] tokens_d = Console.ReadLine().Split(' ');
        int d = Convert.ToInt32(tokens_d[0]);
        int m = Convert.ToInt32(tokens_d[1]);
        int ans = 0;
        int sum = 0;
        for (int i = 0; i < m; i++)
        {
            sum += squares[i];
        }
        if (sum == d)
        {
            ans++;
        }
        for (int i = 0; i + m < squares.Length; i++)
        {
            sum -= squares[i];
            sum += squares[i + m];
            if (sum == d)
            {
                ans++;
            }
        }
        Console.WriteLine(ans);
    }
}
