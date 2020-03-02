using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Solution
{
    static int swapInsertion = 0;
    static int swapQuick = 0;
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
                swapQuick++;
            }
        }
        // swap arr[i+1] and arr[high] (or pivot)
        temp = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = temp;
        swapQuick++;
        return i + 1;
    }
    static void quickSort(int[] array, int start, int end)
    {
        if (start < end)
        {
            int pivotIndex = partition(array, start, end);
            //printArray(array);
            quickSort(array, start, pivotIndex - 1);
            quickSort(array, pivotIndex + 1, end);
        }
    }
    static void insertionSort(int[] ar)
    {
        for (int i = 1; i < ar.Length; i++)
        {
            int indice = i;
            while (indice > 0 && ar[indice - 1] > ar[indice])
            {
                int temp = ar[indice - 1];
                ar[indice - 1] = ar[indice];
                ar[indice] = temp;
                swapInsertion++;
                indice--;
            }
        }
    }
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] arrQuick = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));
        int[] arrInsertion = new int[n];
        Array.Copy(arrQuick, arrInsertion, n);
        quickSort(arrQuick, 0, arrQuick.Length - 1);
        insertionSort(arrInsertion);
        Console.WriteLine(swapInsertion - swapQuick);
        Console.ReadLine();
    }
}

