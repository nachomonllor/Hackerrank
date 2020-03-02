using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] unsorted = new string[n];
        for (int unsorted_i = 0; unsorted_i < n; unsorted_i++)
        {
            unsorted[unsorted_i] = Console.ReadLine();
        }


        QuickSort(unsorted, 0, n - 1);

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(unsorted[i]);
        }

        Console.ReadLine();
    }

    static void Swap(string[] arr, int i, int j)
    {
        var temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

    static int Partition(string[] arr, int start, int end)
    {
        var i = start + 1;
        var piv = arr[start];
        for (int j = start + 1; j <= end; j++)
        {
            if (CompareLessthan(arr[j], piv))
            {
                Swap(arr, i, j);
                i += 1;
            }
        }
        Swap(arr, start, i - 1);
        return i - 1;
    }

    static bool CompareLessthan(string a, string b)
    {
        if (a.Length > b.Length)
            return false;

        if (a.Length < b.Length)
            return true;

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] < b[i])
                return true;
            else if (a[i] > b[i])
                return false;
        }


        return false;
    }

    static void QuickSort(string[] arr, int start, int end)
    {
        if (start < end)
        {
            var piv_pos = Partition(arr, start, end);
            QuickSort(arr, start, piv_pos - 1);
            QuickSort(arr, piv_pos + 1, end);
        }
    }
}
