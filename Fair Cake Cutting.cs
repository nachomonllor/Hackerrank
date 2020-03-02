using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static long howManyToInvite(long A, long B, long a)
        {
            // Return the number of people Leha should invite to his party
            double b = ((double)A / (double)B);
            return (long)(a / b);
        }
        static void Main(String[] args)
        {
            string[] tokens_A = Console.ReadLine().Split(' ');
            long A = Convert.ToInt64(tokens_A[0]);
            long B = Convert.ToInt64(tokens_A[1]);
            long a = Convert.ToInt64(tokens_A[2]);
            long b = howManyToInvite(A, B, a);
            Console.WriteLine(b);
        }
    }
}
