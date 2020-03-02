using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static int partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int temp;
            int i = (low - 1); // index of smaller element
            for (int j = low; j <= high - 1; j++)
            {
                // If current element is smaller than or
                // equal to pivot
                if (arr[j] <= pivot)
                {
                    i++;

                    // swap arr[i] and arr[j]
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot)
            temp = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp;

            return i + 1;
        }


        private static void quickSort(int[] array, int start, int end)
        {
            if (start < end)
            {
                int pivotIndex = partition(array, start, end);

                quickSort(array, start, pivotIndex - 1);
                quickSort(array, pivotIndex + 1, end);
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));

            quickSort(arr, 0, arr.Length - 1);

            Console.ReadLine();
        }
    }
}

