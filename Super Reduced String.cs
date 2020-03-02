using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be
        named Solution */
        string s = Console.ReadLine();
        Stack<char> pila = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (pila.Count > 0 && pila.Peek() == s[i])
                pila.Pop();
            else
                pila.Push(s[i]);
        }
        char[] rev = pila.ToArray();
        Array.Reverse(rev);
        string a = new string(rev);
        Console.WriteLine(a.Length == 0 ? "Empty String" : a);
    }
}
