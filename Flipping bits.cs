using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                long n = long.Parse(Console.ReadLine());
                //long n = 2147483648;
                // long n = 1;
                string sbin = Convert.ToString(n, 2);
                sbin = new string('0', 32 - sbin.Length) + sbin;
                char[] bin = sbin.ToCharArray();
                // Console.WriteLine(bin);
                char[] flip = new char[bin.Length];
                for (int i = 0; i < flip.Length; i++)
                {
                    flip[i] = (bin[i] == '1') ? '0' : '1';
                }
                //Console.WriteLine(new string(flip));
                string sfplip = new string(flip);
                int len = sfplip.Length;
                long res = 0;
                while (len > 0)
                {
                    if (sfplip[sfplip.Length - len] == '1')
                    {
                        res += (long)Math.Pow(2, len - 1);
                    }
                    len--;
                }
                Console.WriteLine(res);

            }
        }
    }
}
