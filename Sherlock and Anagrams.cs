using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {

                Dictionary<string, int> diccio = new Dictionary<string, int>();
                //string s = "ifailuhkqq";
                string s = Console.ReadLine();

                int len = 1;
                while (len <= s.Length)
                {
                    for (int i = 0; i < s.Length - len + 1; i++)
                    {
                        string subs = s.Substring(i, len);
                        char[] sorted = subs.ToCharArray();
                        Array.Sort(sorted);
                        string sortedString = new string(sorted);

                        if (diccio.ContainsKey(sortedString))
                        {
                            diccio[sortedString]++;
                        }
                        else
                        {
                            diccio[sortedString] = 1;
                        }
                    }

                    len++;
                }

                int contPares = 0;
                foreach (KeyValuePair<string, int> kvp in diccio)
                {
                    //Console.WriteLine(kvp.Key + " " + kvp.Value);
                    contPares += (kvp.Value * (kvp.Value - 1)) / 2;
                }

                Console.WriteLine(contPares);

            }

            Console.ReadLine();

        }
    }
}

