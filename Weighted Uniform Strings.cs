using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {


        static Dictionary<char, long> maxUniformString(string s)
        {

            Dictionary<char, long> diccio = new Dictionary<char, long>();

            for (char ch = 'a'; ch <= 'z'; ch++)
            {
                diccio[ch] = 0;
            }

            for (int i = 0; i < s.Length; )
            {
                long cont = 0;
                char actual = s[i];
                while (i < s.Length && s[i] == actual)
                {
                    i++;
                    cont++;
                }
                diccio[actual] = Math.Max(cont, diccio[actual]);
            }

            return diccio;
        }

        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            long n = long.Parse(Console.ReadLine());

            Dictionary<char, long> diccio = maxUniformString(s);

            while (n-- > 0)
            {
                long x = long.Parse(Console.ReadLine());

                string ans = "No";
                for (char ch = 'a'; ch <= 'z'; ch++)
                {
                    if (x % (ch - 'a' + 1) == 0 && x <= diccio[ch] * (ch - 'a' + 1))
                    {
                        ans = "Yes";
                        break;
                    }
                }
                Console.WriteLine(ans);
            }

            Console.ReadLine();
        }


    }
}
