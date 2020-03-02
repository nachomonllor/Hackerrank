using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


class Solution
{

    static void Main(String[] args)
    {
        //int q = Convert.ToInt32(Console.ReadLine());
        for (long i = 1; i < 200; i++)
        {
            //long x = Convert.ToInt64(Console.ReadLine());
            // your code goes here
            long x = i;
            int ans = 0;
            for (long a = 1; a < x; a++)
            {
                if ((a ^ x) > x)
                {
                    ans++;
                }
            }
            Console.WriteLine(i + " " + ans);
        }

        Console.ReadLine();
    }

    //static void Main(String[] args)
    //{
    //    int q = Convert.ToInt32(Console.ReadLine());
    //    for (int a0 = 0; a0 < q; a0++)
    //    {
    //        long x = Convert.ToInt64(Console.ReadLine());
    //        // your code goes here
    //        int ans = 0;
    //        for (long a = 1; a < x; a++)
    //        {
    //            if ((a ^ x) > x)
    //            {
    //                ans++;
    //            }
    //        }
    //        Console.WriteLine(ans);
    //    }
    //}
}
