using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static string isBalanced(string s)
        {

            string abiertos = "[{(";
            string cerrados = "]})";

            Dictionary<char, char> dic =
                new Dictionary<char, char>();
            for (int i = 0; i < abiertos.Length; i++)
            {
                dic[abiertos[i]] = cerrados[i];
            }

            Stack<char> ab =
                new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {

                if (abiertos.Contains(s[i]))
                {
                    ab.Push(s[i]);
                }
                else
                {
                    if (ab.Count == 0)
                    {
                        return "NO";
                    }

                    if (dic[ab.Peek()] != s[i])
                    {
                        return "NO";
                    }
                    ab.Pop();
                }
            }

            return ab.Count == 0 ? "YES" : "NO";
        }

        static void Main(string[] args)
        {

            //  string s = "{[(])}";
            string s = ")))))))";

            Console.WriteLine(isBalanced(s));

            Console.ReadLine();
        }
    }
}

