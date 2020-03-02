using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void printArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
    static void insertionSort(int[] ar)
    {
        for (int i = 1; i < ar.Length; i++)
        {
            int indice = i;
            while (indice > 0 && ar[indice - 1] > ar[indice])
            {
                int temp = ar[indice];
                ar[indice] = ar[indice - 1];
                ar[indice - 1] = temp;
                indice--;
            }
            printArray(ar);
        }
    }
    static void Main(String[] args)
    {
        int _ar_size;
        _ar_size = Convert.ToInt32(Console.ReadLine());
        int[] _ar = new int[_ar_size];
        String elements = Console.ReadLine();
        String[] split_elements = elements.Split(' ');
        for (int _ar_i = 0; _ar_i < _ar_size; _ar_i++)
        {
            _ar[_ar_i] = Convert.ToInt32(split_elements[_ar_i]);
        }
        insertionSort(_ar);
    }
}
