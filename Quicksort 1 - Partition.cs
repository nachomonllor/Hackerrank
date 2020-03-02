using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void partition(int[] ar)
    {
        int pivote = ar[0];
        List<int> left = new List<int>();
        List<int> equal = new List<int>();
        List<int> rigth = new List<int>();
        equal.Add(pivote);
        for (int i = 1; i < ar.Length; i++)
        {
            if (ar[i] < pivote)
            {
                left.Add(ar[i]);
            }
            else if (ar[i] == pivote)
            {
                equal.Add(ar[i]);
            }
            else if (ar[i] > pivote)
            {
                rigth.Add(ar[i]);
            }
        }
        int index = 0;
        for (int i = 0; i < left.Count; i++)
        {
            ar[index++] = left[i];
        }
        for (int i = 0; i < equal.Count; i++)
        {
            ar[index++] = equal[i];
        }
        for (int i = 0; i < rigth.Count; i++)
        {
            ar[index++] = rigth[i];
        }
    }

    /* Tail starts here */
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
        partition(_ar);
        for (int i = 0; i < _ar.Length; i++)
        {
            Console.Write(_ar[i] + " ");
        }
    }
}