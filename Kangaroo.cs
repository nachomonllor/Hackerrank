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

            string[] tokens_x1 = Console.ReadLine().Split(' '); // "28 8 96 2".Split(' ');
            int x1 = Convert.ToInt32(tokens_x1[0]);
            int v1 = Convert.ToInt32(tokens_x1[1]);
            int x2 = Convert.ToInt32(tokens_x1[2]);
            int v2 = Convert.ToInt32(tokens_x1[3]);

            int i = x1, j = x2; /*les asigno a i y a j 
                                 * las posiciones iniciales  x1 y x2
                                 * donde empiezan los canguros*/

            int cont = 0;
            int prev_dif = 0, actual_dif = 0;
            /*prev_dif y actual_dif son para saber si las diferencias 
             * entre i y j aumentan, en el caso de que aumenten,
             * si con cada iteracion es mayor, entonces i y j no se 
             * encuentran nunca*/

            string ans = "YES";
            while (i != j)
            {
                if (i == j)
                {
                    break;
                }

                /* diferencia previa entre i y j antes de 
                 * aumentarles la velocidad v*/
                if (j > i)
                {
                    prev_dif = j - i;
                }
                else if (j < i)
                {
                    prev_dif = i - j;
                }


                //Console.WriteLine(i + " " + j);
                i += v1;
                j += v2;

                /* diferencia posterior entre i y j luego de asignarles la
                 * velocidad v */
                if (j > i)
                {
                    actual_dif = j - i;
                }
                else if (j < i)
                {
                    actual_dif = i - j;
                }

                /* si la diferencia es cada vez mayor, es porque i y j
                 * nunca van a ser iguales, nunca se van a encontrar, 
                 * si es menor se van a encontrar: en ese caso entran
                 * al if i == j y sale del bucle, por lo tanto queda YES */
                if (actual_dif > prev_dif)
                {
                    ans = "NO";
                    break;
                }

                cont++;
            }

            Console.WriteLine(ans);

            Console.ReadLine();
        }
    }
}


