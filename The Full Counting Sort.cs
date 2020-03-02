using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        public class Dato
        {
            public int indiceOriginal;
            public string str;

            public Dato(int indiceOriginal, string str)
            {
                this.indiceOriginal = indiceOriginal;
                this.str = str;
            }

        }


        static void Main(string[] args)
        {

            //int n = 20;
            //string[] s ={
            // "0 ab",
            // "6 cd",
            // "0 ef",
            // "6 gh",
            // "4 ij",
            // "0 ab",
            // "6 cd",
            // "0 ef",
            // "6 gh",
            // "0 ij",
            // "4 that",
            // "3 be",
            // "0 to",
            // "1 be",
            // "5 question",
            // "1 or",
            // "2 not",
            // "4 is",
            // "2 to",
            // "4 the"};

            int n = int.Parse(Console.ReadLine());
            string[] s = new string[n];
            for (int i = 0; i < n; i++)
            {
                s[i] = Console.ReadLine();
            }

            List<Dato>[] arr = new List<Dato>[100];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new List<Dato>();
            }

            for (int i = 0; i < s.Length; i++)
            {
                string[] input = s[i].Split(' ');
                int pos = int.Parse(input[0]);
                string str = input[1];

                arr[pos].Add(new Dato(i, str));
            }

            StringBuilder sb = new StringBuilder();

            for (int pos = 0; pos < arr.Length; pos++)
            {
                for (int i = 0; i < arr[pos].Count; i++)
                {
                    Dato aux = arr[pos][i];

                    if (aux.indiceOriginal < n / 2)
                    {
                        //Console.Write("-");
                        sb.Append("-");
                    }
                    else
                    {
                        //Console.Write(aux.str);
                        sb.Append(aux.str);
                    }
                    //Console.Write(" ");
                    sb.Append(" ");
                }
            }

            Console.WriteLine(sb.ToString());

            Console.ReadLine();

        }



    }
}
