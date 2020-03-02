//https://www.hackerrank.com/contests/openbracket-2017/challenges/finding-subsequence/problem

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static string solve(string s, int k)
        {
            // Complete this function
            Dictionary<char, int> frec = new Dictionary<char, int>();
            foreach (char ch in s)
            {
                if (frec.ContainsKey(ch))
                {
                    frec[ch]++;
                }
                else
                {
                    frec[ch] = 1;
                }
            }

         
            Dictionary<char, List<int>> indices = new Dictionary<char, List<int>>();
            for (int i = 0; i < s.Length; i++)
            {
                if (indices.ContainsKey(s[i]))
                {
                    indices[s[i]].Add(i);
                }
                else
                {
                    indices[s[i]] = new List<int>();
                    indices[s[i]].Add(i);
                }
            }


            char[] arr = s.ToCharArray();
            Array.Sort(arr);
            string concat = "";

            int indice = -1;

            int busca = arr.Length - 1;
            while (frec[arr[busca]] < k)
            {
                busca--;
            }
            indice = indices[arr[arr.Length - 1]][0];
            concat += arr[arr.Length - 1];

            //Console.WriteLine(indice);

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                
                    List<int> listaIndices = indices[arr[i]];
                    for (int j = 0; j < listaIndices.Count; j++)
                    {
                        if (listaIndices[j] > indice)
                        {
                            concat += arr[i];
                            indice = listaIndices[j];
                        }
                    }
               
            }

            Dictionary<char, int> frecconcat = new Dictionary<char, int>();
            foreach (char ch in concat)
            {
                if (frecconcat.ContainsKey(ch))
                {
                    frecconcat[ch]++;
                }
                else
                {
                    frecconcat[ch] = 1;
                }
            }

            string ans = "";
            foreach (char ch in concat)
            {
                if (frecconcat[ch] >= k)
                {
                    ans += ch;
                }
            }


            return ans;
        }

        static void Main(string[] args)
        {
            //string[] arr = { "rrnk", "rr", "rrank" };
            //string s = "hackerrank";

            //string s = "hackerrank";
            //int k = 1;

            //char[] ch = s.ToCharArray();
            //Array.Sort(ch);
            //Console.WriteLine(new string(ch));
            //Console.WriteLine();

            string s = "banana";
            int k = 2;

            Console.WriteLine(solve(s, k));

            Console.ReadLine();
        }


        //static void Main(string[] args)
        //{
        //    string[] arr = { "rrnk", "rr", "rrank" };
        //    //string[] arr = { "nnaa", "nn" };
        //  //string[] arr ={  "ackernk",
        //  //  "ckr",
        //  //  "ckrr",
        //  //  "erak",
        //  //  "rra",
        //  //  "rrank",
        //  //  "rrn",
        //  //  "rrnk"};
        //    //string[] arr = { "nnc", "nnb" };

        //    Array.Sort(arr);

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        Console.Write(arr[i] + " ");
        //    }
        //    Console.ReadLine();
        //}
    }
}



