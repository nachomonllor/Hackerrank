using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        int n = int.Parse(input[0]);
        int k = int.Parse(input[1]);
        int i;
        string[] contest = new string[n];
        for (i = 0; i < n; i++)
        {
            contest[i] = Console.ReadLine();
        }
        //int n = 6, k = 3;
        //string[] contest = { "5 1","2 1","1 1","8 1","10 0","5 0"};
        List<int> importantes = new List<int>();
        List<int> no_importantes = new List<int>();
        for (i = 0; i < contest.Length; i++)
        {
            if (contest[i].Split(' ')[1] == "1")
            {
                importantes.Add(int.Parse(contest[i].Split(' ')[0]));
            }
            else
            {
                no_importantes.Add(int.Parse(contest[i].Split(' ')[0]));
            }
        }
        int ans = 0;
        if (importantes.Count > 0)
        {
            importantes.Sort();
            importantes.Reverse();
            for (i = 0; i < importantes.Count && i < k; i++)
            {
                ans += importantes[i];
            }
            int ini = i;
            for (i = ini; i < importantes.Count; i++)
            {
                ans -= importantes[i];
            }
        }
        for (i = 0; i < no_importantes.Count; i++)
        {
            ans += no_importantes[i];
        }
        Console.WriteLine(ans);
        // Console.ReadLine();
    }
}