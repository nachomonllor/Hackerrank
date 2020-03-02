using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp16
{
    class Program
    {

        static string highestValuePalindrome(string s, int n, int k)
        {

            int cambiar_para_que_sea_palindromo = 0;
            int i = 0, j = n - 1;
            while (i < j)
            {
                if (s[i] != s[j])
                {
                    cambiar_para_que_sea_palindromo++;
                }
                i++;
                j--;
            }

            if (cambiar_para_que_sea_palindromo > k) return "-1";

            i = 0;
            j = n - 1;

            char[] ch = s.ToCharArray();
            //palindromizo con los maximos
            HashSet<int> hash = new HashSet<int>();
            while (i < j)
            {
                if (ch[i] > ch[j])
                {
                    hash.Add(j);
                    ch[j] = ch[i];
                }
                else if (ch[j] > ch[i])
                {
                    hash.Add(i);
                    ch[i] = ch[j];
                }
                i++;
                j--;
            }

            //Console.WriteLine(new string(ch));

            //convierto los que sobran a 9's
            if (k - hash.Count > 0)
            {
                i = 0;
                j = n - 1;

                k -= hash.Count;

                while (i < j)
                {

                    if (ch[i] != '9' && ch[j] != '9')
                    {

                        if (hash.Contains(i) && hash.Contains(j))
                        {
                            if (k >= 0)
                            {
                                ch[i] = '9';
                                ch[j] = '9';
                            }
                        }
                        else if (hash.Contains(i))
                        {
                            if (k >= 1)
                            {
                                ch[i] = '9';
                                k--;
                                ch[j] = '9';
                            }
                        }
                        else if (hash.Contains(j))
                        {
                            if (k >= 1)
                            {
                                ch[j] = '9';
                                k--;
                                ch[i] = '9';
                            }
                        }
                        else
                        {
                            if (k >= 2)
                            {
                                ch[i] = '9';
                                ch[j] = '9';


                                //------------
                                if (i != j)
                                {
                                    k -= 2;
                                }
                                else
                                {
                                    k--;
                                }


                            }
                        }


                    }
                    else if (ch[i] != '9') //i!=9 j = 9
                    {
                        if (hash.Contains(i))
                        {
                            if (k >= 0)
                            {
                                ch[i] = '9';
                            }
                        }
                        else
                        {
                            if (k >= 1)
                            {
                                ch[i] = '9';
                                k--;
                            }
                        }
                    }
                    else if (ch[j] != '9') //i=9 j != 9 
                    {
                        if (hash.Contains(j))
                        {
                            if (k >= 0)
                            {
                                ch[j] = '9';
                            }
                        }
                        else
                        {
                            if (k >= 1)
                            {
                                ch[j] = '9';
                                k--;
                            }
                        }
                    }


                    i++;
                    j--;
                }

            }

            if (n % 2 != 0)
            {
                if (ch[(int)(Math.Ceiling((double)(double)n / 2.0) - 1)] != '9')
                {
                    if (k >= 1)
                    {
                        ch[(int)(Math.Ceiling((double)(double)n / 2.0) - 1)] = '9';
                    }
                }
            }


            return new string(ch);
        }


        static void Main(string[] args)
        {
            //string s = "128392759430124";
            //int n = 15;
            //int k = 8;
            string s = "1";
            int n = 1;
            int k = 5;
            Console.WriteLine(highestValuePalindrome(s, n, k));

            Console.ReadLine();
        }
    }
}


