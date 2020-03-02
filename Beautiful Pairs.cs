using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp37
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] a = { 1, 2, 2 };
            //int[] b = { 1, 2, 3 };




            int n = int.Parse(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));
            int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));


            //int[] a = { 1};
            //int[] b = { 1 };
            ////0

            //int[] a = { 1, 2, 3,6,6,6 };
            //int[] b = { 1, 2, 3,5,5,5 };

            //int[] a = {6,6,6 };
            //int[] b = { 5,5,5 };

            Dictionary<int, int> frec_a = a.GroupBy(x => x)
                .ToDictionary(x => x.Key, x => x.Count());


            Dictionary<int, int> frec_b = b.GroupBy(x => x)
                .ToDictionary(x => x.Key, x => x.Count());

            int ans = 0;
            bool sobra_a = false, sobra_b = false;
            foreach (KeyValuePair<int, int> kvp in frec_a)
            {
                // Console.WriteLine(kvp.Key + " " + kvp.Value);

                if (frec_b.ContainsKey(kvp.Key))
                {
                    if (kvp.Value > frec_b[kvp.Key]) //sobra en a
                    {
                        ans += frec_b[kvp.Key]; //el minimo
                        sobra_a = true;
                    }
                    else if (frec_b[kvp.Key] > kvp.Value)
                    {
                        ans += kvp.Value; //el minimo
                        sobra_b = true;
                    }
                    else
                    {
                        ans += kvp.Value;
                    }
                }
                else
                {
                    sobra_a = true;
                }
            }

            foreach (KeyValuePair<int, int> kvp in frec_b)
            {
                if (!frec_a.ContainsKey(kvp.Key))
                {
                    sobra_b = true;
                }
            }

            //  Console.WriteLine();
            if (sobra_a && sobra_b)
            {
                ans++;
            }
            else
            {
                ans--;
            }

            Console.WriteLine(ans);

            Console.ReadLine();
        }


    }
}
