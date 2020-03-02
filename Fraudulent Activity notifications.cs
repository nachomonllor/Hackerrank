using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

      

        private static double getMedian(int[] data, int d)
        {
            double median = 0;
            if (d % 2 == 0)
            {
                int m1 = 0;
                int m2 = 0;
                int count = 0;
                for (int j = 0; j < data.Length; j++)
                {
                    count += data[j];
                    if (m1 == 0 && count >= d / 2)
                    {
                        m1 = j;
                    }
                    if (m2 == 0 && count >= d / 2 + 1)
                    {
                        m2 = j;
                        break;
                    }
                }
                median = (m1 + m2) / 2.0;
            }
            else
            {
                int count = 0;
                for (int j = 0; j < data.Length; j++)
                {
                    count += data[j];
                    if (count > d / 2)
                    {
                        median = j;
                        break;
                    }
                }
            }
            return median;
        }

        static int activityNotifications(int[] expenditure, int d)
        {
            int cont = 0;

            int[] count = new int[201];
            for (int i = 0; i < d; i++)
            {
                count[expenditure[i]]++;
            }

            for (int i = 0; i + d < expenditure.Length; i++)
            {

                if (expenditure[i + d] >= 2 * getMedian (count,d))
                {
                    cont++;
                }
                count[expenditure[i]]--;
                count[expenditure[i + d]]++;
            }

            return cont;

        }


        static void Main(string[] args)
        {

            //int[] arr = { 6, 1, 9, 2, 0, 0, 6, 3, 5, 3, 2, 5 };
            //CountSort(arr);

            //int[] arr = { 10, 20, 30, 40, 50, 60, 70 };
                         //0   1   2   3   4   5   6

            //int[] arr = { 7, 3, 90, 76, 44, 32, 12 };

            ////activityNotifications(arr, 3);
            //int[] r = countsort(arr);

            //foreach (int item in r)
            //{
            //    Console.Write(item + " ");
            //}

            int[] arr = { 2, 3, 4, 2, 3, 6, 8, 4, 5 };
           // int[] arr = { 10, 20, 30, 40, 50 };

            Console.WriteLine( activityNotifications(arr, 5));


            Console.ReadLine();


        }

    }
}
