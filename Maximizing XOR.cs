using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static int maxXor(int l, int r)
        {
            int max_xor = 0;
            for (int a = l; a <= r; a++)
            {
                for (int b = l; b <= r; b++)
                {
                    max_xor = Math.Max(max_xor, a ^ b);
                }
            }
            return max_xor;
        }
        static void Main(String[] args)
        {
            int res;
            int _l;
            _l = Convert.ToInt32(Console.ReadLine());
            int _r;
            _r = Convert.ToInt32(Console.ReadLine());
            res = maxXor(_l, _r);
            Console.WriteLine(res);
        }
    }
}
