using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static void bubbleSort(int[] arr, int n)
        {
            int i, j, temp;
            bool swapped;
            for (i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // swap arr[j] and arr[j+1] 
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }

                // IF no two elements were  
                // swapped by inner loop, then break 
                if (swapped == false)
                    break;
            }
        } 



        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int[] vaccines = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));
            int[] patients = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), e => int.Parse(e));

            Array.Sort(vaccines);
            Array.Sort(patients);

            string ans = "Yes";
            for (int i = 0; i < n; i++)
            {
                if (vaccines[i] > patients[i])
                {
                    ans = "No";
                    break;
                }
            }

            Console.WriteLine(ans);

            Console.ReadLine();
        }


        

    }
}
