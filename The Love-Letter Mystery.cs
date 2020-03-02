using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {

                // string str = "abcd";
                string str = Console.ReadLine(); // "cdyz";

                char[] s = str.ToCharArray();

                int i = 0, j = s.Length - 1;

                int ans = 0;

                while (i < j)
                {
                    while (s[j] >= 'a' && s[i] < s[j])
                    {
                        s[j]--;
                        ans++;
                    }
                    while (s[i] >= 'a' && s[j] < s[i])
                    {
                        s[i]--;
                        ans++;
                    }

                    i++;
                    j--;
                }


                Console.WriteLine(ans);

            }

            Console.ReadLine();
        }

    }
}
