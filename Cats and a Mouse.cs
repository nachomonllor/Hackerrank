using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;

class Solution
{
    static void Main(String[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < q; a0++)
        {
            string[] tokens_x = Console.ReadLine().Split(' ');
            int x = Convert.ToInt32(tokens_x[0]);
            int y = Convert.ToInt32(tokens_x[1]);
            int z = Convert.ToInt32(tokens_x[2]);
            int cat_a = Math.Abs(x - z);
            int cat_b = Math.Abs(y - z);
            if (cat_a < cat_b)
            {
                Console.WriteLine("Cat A");
            }
            else if (cat_b < cat_a)
            {
                Console.WriteLine("Cat B");
            }
            else if (cat_a == cat_b)
            {
                Console.WriteLine("Mouse C");
            }
        }
    }


}
