using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int m = Convert.ToInt32(tokens_n[1]);
        string[] topic = new string[n];
        for (int topic_i = 0; topic_i < n; topic_i++)
        {
            topic[topic_i] = Console.ReadLine();
        }
        //int n = 4, m = 5;
        //string[] topic = { "10101",
        // "11100",
        // "11010",
        // "00101"};
        int ans = 0;
        int max_ancho = 0;
        int person_teams2 = 0;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                int k;
                int ancho = 0;
                for (k = 0; k < m; k++)
                {
                    if (topic[i][k] == '1' || topic[j][k] == '1')
                    {
                        ancho++;
                    }
                }
                //max_ancho = Math.Max(max_ancho, ancho);
                if (ancho > max_ancho)
                {
                    max_ancho = ancho;
                    person_teams2 = 1;
                }
                else if (ancho == max_ancho)
                {
                    person_teams2++;
                }
            }
        }
        Console.WriteLine(max_ancho);
        Console.WriteLine(person_teams2);
    }

}

