
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {

        static List<string> intercalarIntervalos(string a, string b)
        {
            string[] a_split = a.Split(' ');
            string[] b_split = b.Split(' ');

            int a_ini = int.Parse(a_split[0]);
            int a_fin = int.Parse(a_split[1]);
            int b_ini = int.Parse(b_split[0]);
            int b_fin = int.Parse(b_split[1]);

            List<string> intervalos = new List<string>();
            if (a_ini < b_fin && b_ini <= a_fin)
            {
                //intervalos.Add(a_ini + " " + b_fin);
                intervalos.Add(Math.Min(a_ini, b_ini) + " " + Math.Max(a_fin, b_fin));
            }
            else if (b_ini < a_fin && b_fin >= a_ini)
            {
                //intervalos.Add(b_ini + " " + a_fin);
                intervalos.Add(Math.Min(b_ini, a_ini) + " " + Math.Max(b_fin, a_fin));
            }

            return intervalos;
        }


        static void Main(string[] args)
        {

            //-------------------------
            //List<string> lista = new List<string>();

            //using (StreamReader esc = new StreamReader("C:\\test.txt"))
            //{
            //    string line;
            //    while ((line = esc.ReadLine()) != null)
            //    {
            //        //System.Console.WriteLine(line);
            //        lista.Add(line);
            //    }
            //}
            //int indice_lista = 0;

            //-------------------------

            //string[] input1 = "402159386 855281517 951".Split(' '); 
            string[] input1 = Console.ReadLine().Split(' ');
            long n = long.Parse(input1[0]);
            long m = long.Parse(input1[1]);
            long k = long.Parse(input1[2]);

            //HashSet<string> filas = new HashSet<string>();
            Dictionary<long, List<string>> filas = new Dictionary<long, List<string>>();
            for (int i = 0; i < k; i++)
            {
                string[] input2 = Console.ReadLine().Split(' ');
                long r = long.Parse(input2[0]);
                long c1 = long.Parse(input2[1]);
                long c2 = long.Parse(input2[2]);

                string intervalo_actual = c1.ToString() + " " + c2.ToString();

                if (filas.ContainsKey(r))
                {
                    List<string> value = filas[r];
                    foreach (string inter in value)
                    {
                        List<string> mezclados =
                            intercalarIntervalos(intervalo_actual, inter);
                        if (mezclados.Count == 1)
                        {
                            value.Remove(intervalo_actual);
                            value.Remove(inter);

                            List<string> nueva_lista = new List<string>();
                            nueva_lista.AddRange(value);
                            nueva_lista.Add(mezclados[0]);
                            filas[r] = nueva_lista;
                            break;
                        }
                        else if (mezclados.Count == 0)
                        {
                            filas[r].Add(intervalo_actual);
                            break;
                        }
                    }
                }
                else
                {
                    List<string> aux = new List<string>();
                    aux.Add(intervalo_actual);
                    filas[r] = aux;
                }
            }

            long train_track = 0;

            foreach (KeyValuePair<long, List<string>> kvp in filas)
            {
                foreach (string elem in kvp.Value)
                {
                    string[] inter = elem.Split(' ');
                    train_track += long.Parse(inter[1]) - long.Parse(inter[0]) + 1;
                }
            }

            Console.WriteLine((n * m) - train_track);

            Console.ReadLine();
        }

    }
}

