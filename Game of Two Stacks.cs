//https://www.hackerrank.com/contests/university-codesprint-2/challenges/game-of-two-stacks

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {



            //int n = 5, m = 4, x = 4;
            //int[] a = { 1, 2, 4, 6, 1 };
            //int[] b = { 2, 1, 8, 5 };

            //int n = 5, m = 4, x = 4;
            //int[] a = {   };
            //int[] b = {   };

            //1
            int n = 10, m = 10, x = 100;
            int[] a = { 3, 5, 20, 12, 2, 32, 21, 52, 14, 20 };
            int[] b = { 4, 20, 5, 14, 3, 12, 19, 20, 21, 25 };

            //int n = 5, m = 4, x = 10;
            //int[] a = { 4, 2, 4, 6, 1 };
            //int[] b = { 2, 1, 8, 5 };
            ////4

            int i = 0, j = 0;

            int ans = 0;
            BigInteger sum = 0;
            while (i < a.Length && j < b.Length)
            {
                if (a[i] < b[j])
                {
                    if (sum + a[i] <= x)
                    {
                         Console.Write(a[i] + " ");
                        sum += a[i];
                        i++;
                        ans++;

                    }
                    else
                    {
                        break;
                    }

                }
                else if (a[i] == b[j])
                {

                    int iguales = a[i];
                    int k = i;
                    int l = j;

                    //busco el prox mas grande a iguales

                    int sum_a = 0;
                    for (k = i+1; k < a.Length; k++)
                    {
                        //if (a[k] < iguales)
                        if (a[k] > iguales)
                        {
                            break;
                        }

                        sum_a += a[k];
                       
                    }

                    int sum_b = 0;
                    for (l = j+1; l < b.Length; l++)
                    {
                        if (b[l] > iguales)
                        {
                            break;
                        }
                        sum_b += b[l];
                    }

                    if (sum_a > sum_b) //tomo el camino de b porque es menor
                    {
                          Console.Write(b[j] + " ");
                        sum += b[j];
                        ans++;
                        j++;
                    }
                    else
                    {
                          Console.Write(a[i] + " ");
                        sum += a[i];
                        ans++;
                        i++;
                    }


                }
                else
                {
                    if (sum + b[j] <= x)
                    {
                         Console.Write(b[j] + " ");
                        sum += b[j];
                        j++;
                        ans++;

                    }

                    else
                    {
                        break;
                    }
                }
            }

            while (i < a.Length)
            {
                if (a[i] + sum <= x)
                {
                     Console.Write(a[i] + " ");
                    sum += a[i];
                    i++;
                    ans++;

                }
                else
                {
                    break;
                }

            }
            while (j < b.Length)
            {
                if (b[j] + sum <= x)
                {
                     Console.Write(b[j] + " ");
                    sum += b[j];
                    j++;
                    ans++;

                }
                else
                {
                    break;
                }

            }

            Console.WriteLine(ans);

            //Console.WriteLine(sum);


            Console.ReadLine();
        }
    }
}
