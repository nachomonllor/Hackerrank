﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static string Caesar(string text, int shift)
    {
        string alfab = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz";
        string mayus = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZ";
        shift = shift % 26;
        string ans = "";
        for (int i = 0; i < text.Length; i++)
        {
            // ans += (alfab.IndexOf(text[i]) + shift).ToString().ToUpper();
            //ans += alfab[ text.IndexOf(i)+shift];
            if (char.IsLetter(text[i]))
            {
                if (char.IsUpper(text[i]))
                {
                    int indmayus = mayus.IndexOf(text[i]);
                    ans += mayus[indmayus + shift].ToString();
                }
                else
                {
                    int indalfab = alfab.IndexOf(text[i]);
                    ans += alfab[indalfab + shift].ToString();
                }
            }
            else
            {
                ans += text[i];
            }
        }
        return ans;
    }
    static void Main(string[] args)
    {
        //int n = 11;
        //string s= "middle-Outz";
        //int k = 2;
        int n = int.Parse(Console.ReadLine());
        string s = Console.ReadLine();
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine(Caesar(s, k));
        // Console.ReadLine();
    }
}
