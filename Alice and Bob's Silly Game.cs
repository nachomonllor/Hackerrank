using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ConsoleApp35
{
    class Program
    {

        // function generate all prime number less then N in O(n) 
        static  List<int> Sieve(int N)
        {
            // 0 and 1 are not prime 
            // isprime[0] = isprime[1] = false;

            List<bool> isprime = new List<bool>(N + 1);
            List<int> prime = new List<int>(N + 1);
            List<int> SPF = new List<int>(N + 1);

            isprime.Add(false);
            isprime.Add(false);
            SPF.Add(0);
            SPF.Add(0);

            for (int i = 2; i < N + 1; i++)
            {
                isprime.Add(true);
                SPF.Add(0);
            }

            // Fill rest of the entries 
            for (int i = 2; i < N; i++)
            {
                // If isPrime[i] == True then i is 
                // prime number 
                if (isprime[i])
                {
                    // put i into prime[] vector 
                    prime.Add(i);

                    // A prime number is its own smallest 
                    // prime factor 
                    SPF[i] = i;
                }

                // Remove all multiples of  i*prime[j] which are 
                // not prime by making isPrime[i*prime[j]] = false 
                // and put smallest prime factor of i*Prime[j] as prime[j] 
                // [ for exp :let  i = 5 , j = 0 , prime[j] = 2 [ i*prime[j] = 10 ] 
                // so smallest prime factor of '10' is '2' that is prime[j] ] 
                // this loop run only one time for number which are not prime 
                for (int j = 0;
                     j < (int)prime.Count &&
                     i * prime[j] < N && prime[j] <= SPF[i];
                     j++)
                {
                    isprime[i * prime[j]] = false;

                    // put smallest prime factor of i*prime[j] 
                    SPF[i * prime[j]] = prime[j];
                }
            }

            return prime;

        }

        static void Main(string[] args)
        {
            // int N = 13;
            // SieveOfEratosthenes(N);
            int g = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < g; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());
                // your code goes here
                int primos = Sieve(n);
                if (primos % 2 == 1) Console.WriteLine("Alice");
                else Console.WriteLine("Bob");
            }
            Console.ReadLine();
        }
    }
}
