using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            string[] tokens_R = Console.ReadLine().Split(' ');
            int R = Convert.ToInt32(tokens_R[0]);
            int C = Convert.ToInt32(tokens_R[1]);
            string[] G = new string[R];
            for (int G_i = 0; G_i < R; G_i++)
            {
                G[G_i] = Console.ReadLine();
            }
            string[] tokens_r = Console.ReadLine().Split(' ');
            int r = Convert.ToInt32(tokens_r[0]);
            int c = Convert.ToInt32(tokens_r[1]);
            string[] P = new string[r];
            for (int P_i = 0; P_i < r; P_i++)
            {
                P[P_i] = Console.ReadLine();
            }

            bool encontro = false;

            for (int i = 0; i < G.Length && !encontro; i++)
            {
                int indice_col = G[i].IndexOf(P[0]);
                if (indice_col > -1)
                {
                    while (indice_col > -1 && !encontro)
                    {
                        int j = 0;
                        for (j = 0; j < P.Length; j++)
                        {
                            // Console.WriteLine(G[i + j].Substring(indice_col, P[j].Length) + " " + P[j]);
                            if (G[i + j].Substring(indice_col, P[j].Length) != P[j])
                            {
                                break;
                            }
                        }
                        if (j == P.Length)
                        {
                            encontro = true;
                            Console.WriteLine("YES");
                            break;
                        }
                        indice_col = G[i].IndexOf(P[0], indice_col + 1);

                        // Console.WriteLine();
                    }
                }
                if (!encontro && i + P.Length >= G.Length)
                {
                    Console.WriteLine("NO");
                    break;
                }
            }


        }
    }
}
