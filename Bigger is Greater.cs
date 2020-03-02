using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public static bool nextPermutation(char[] array)
        {
            // Find non‐increasing suffix
            int i = array.Length - 1;
            while (i > 0 && array[i - 1] >= array[i])
                i--;
            if (i <= 0)
                return false;
            // Find successor to pivot
            int j = array.Length - 1;
            while (array[j] <= array[i - 1])
                j--;
            char temp = array[i - 1];
            array[i - 1] = array[j];
            array[j] = temp;
            // Reverse suffix
            j = array.Length - 1;
            while (i < j)
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                i++;
                j--;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                string w = Console.ReadLine();
                char[] perm = w.ToCharArray();
                bool res = nextPermutation(perm);
                if (res)
                {
                    Console.WriteLine(new string(perm));
                }
                else
                {
                    Console.WriteLine("no answer");
                }
            }
        }
    }
}
