using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void insertionSort(int[] ar)
    {
        int shifts = 0;
        for (int i = 1; i < ar.Length; i++)
        {
            int indice = i;
            while (indice > 0 && ar[indice - 1] > ar[indice])
            {
                shifts++;
                int temp = ar[indice];
                ar[indice] = ar[indice - 1];
                ar[indice - 1] = temp;
                indice--;
            }
        }
        Console.WriteLine(shifts);
    }
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));
        insertionSort(arr);
        //Console.ReadLine();
    }
}
