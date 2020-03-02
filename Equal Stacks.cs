using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {

        string[] tokens_n1 = Console.ReadLine().Split(' ');
        int n1 = Convert.ToInt32(tokens_n1[0]);
        int n2 = Convert.ToInt32(tokens_n1[1]);
        int n3 = Convert.ToInt32(tokens_n1[2]);
        string[] h1_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(h1_temp, Int32.Parse);
        string[] h2_temp = Console.ReadLine().Split(' ');
        int[] b = Array.ConvertAll(h2_temp, Int32.Parse);
        string[] h3_temp = Console.ReadLine().Split(' ');
        int[] c = Array.ConvertAll(h3_temp, Int32.Parse);

        //int[] a = { 3, 2, 1, 1, 1 };
        //int[] b = { 4, 3, 2 };
        //int[] c = { 1, 1, 4, 1 };

        List<int> x = new List<int>();
        //List<int> y = new List<int>();
        //List<int> z = new List<int>();
        bool[] y = new bool[10000000]; //10^5*100
        bool[] z = new bool[10000000];

        int sum_x = 0;
        for (int i = a.Length - 1; i >= 0; i--)
        {
            sum_x += a[i];
            x.Add(sum_x);
        }

        int sum_y = 0;

        for (int i = b.Length - 1; i >= 0; i--)
        {
            sum_y += b[i];
            y[sum_y] = true;
        }

        int sum_z = 0;
        for (int i = c.Length - 1; i >= 0; i--)
        {
            sum_z += c[i];
            z[sum_z] = true;

        }

        int max_altura = 0;

        // x.Sort();
        // y.Sort();
        // z.Sort();

        for (int i = x.Count - 1; i >= 0; i--)
        {

            //if (y.BinarySearch(x[i]) > -1 && z.BinarySearch(x[i]) > -1)
            //{
            //    max_altura = x[i];
            //    break;
            //}
            if (y[x[i]] && z[x[i]])
            {
                max_altura = x[i];
                break;
            }
        }



        Console.WriteLine(max_altura);


        Console.ReadLine();

    }
}

