using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(string[] args)
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string str = Console.ReadLine();
            //string str = "bcxz"; // Console.ReadLine();
            //string str = "acxz";
            char[] S = str.ToCharArray();
            char[] R = str.ToCharArray();
            Array.Reverse(R);
            string ans = "Funny";
            for (int i = 1; i < S.Length; i++)
            {
                if (Math.Abs(S[i] - S[i - 1]) != Math.Abs(R[i] - R[i - 1]))
                {
                    ans = "Not Funny";
                    break;
                }
            }
            Console.WriteLine(ans);
        }
        Console.ReadLine();
    }

}
