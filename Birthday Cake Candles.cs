using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;

class Solution
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] height_temp = Console.ReadLine().Split(' ');
        int[] height = Array.ConvertAll(height_temp, e => int.Parse(e));
        int max = 0;
        int cont_max = 0;
        for (int i = 0; i < height.Length; i++)
        {
            if (height[i] > max)
            {
                max = height[i];
                cont_max = 1;
            }
            else if (height[i] == max)
            {
                cont_max++;
            }
        }
        Console.WriteLine(cont_max);


    }

}
