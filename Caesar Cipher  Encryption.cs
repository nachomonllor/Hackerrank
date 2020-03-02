using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static string Caesar(string text, int shift)
    {
        //string alfab = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz";
        //string mayus = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZ";
        shift = shift % 26;
        string ans = "";
        for (int i = 0; i < text.Length; i++)
        {
            //ans += (alfab.IndexOf(text[i]) + shift).ToString().ToUpper();
            //ans += alfab[ text.IndexOf(i)+shift];
            //if (char.IsLetter(text[i]))
            if(  (text[i] >= 'A' && text[i] <= 'Z') || (text[i] >= 'a' && text[i] <= 'z'))
            {
                //if (char.IsUpper(text[i]))
                if (text[i] >= 'A' && text[i] <= 'Z')
                {
                    //int indmayus = mayus.IndexOf(text[i]);
                    ans += (char)(((text[i] % 'A') + shift) % 26 + 'A');
                }
                else
                {
                    //int indalfab = alfab.IndexOf(text[i]);
                    ans += (char)(((text[i] % 'a') + shift) % 26 + 'a');
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
        int n = Convert.ToInt32(Console.ReadLine());

        string s = Console.ReadLine();

        int k = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine(Caesar(s, k));

        Console.ReadLine();
    }
    //static void Main(string[] args)
    //{
    //    ////int n = 11;
    //    ////string s= "middle-Outz";
    //    ////int k = 2;
    //    //int n = int.Parse(Console.ReadLine());
    //    //string s = Console.ReadLine();
    //    //int k = int.Parse(Console.ReadLine());
    //    //Console.WriteLine(Caesar(s, k));
    //    //// Console.ReadLine();

    //    string s = "middle-Outz";
    //    int shift = 2;

    //    Console.WriteLine(Caesar(s, shift));


    //    Console.ReadLine();

    //}
}