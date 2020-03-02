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
            int n = Convert.ToInt32(Console.ReadLine());

            int max_sum = 0, menor_divisor = int.MaxValue;
            int sum = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    sum = i.ToString().Sum(e => e - '0');
                    if (sum > max_sum)
                    {
                        max_sum = sum;
                        menor_divisor = i;
                    }
                    else if (sum == max_sum)
                    {
                        if (i < menor_divisor)
                        {
                            menor_divisor = i;
                        }
                    }
                }
            }
            sum = n.ToString().Sum(e => e - '0');
            if (sum > max_sum)
            {
                max_sum = sum;
                menor_divisor = n;
            }
            else if (sum == max_sum)
            {
                if (n < menor_divisor)
                {
                    menor_divisor = n;
                }
            }
            Console.WriteLine(menor_divisor);

        }
    }
}
