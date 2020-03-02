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

            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));
            /*almaceno la frecuencia con la que está presente cada numero en arr */
            Dictionary<int, int> frec = arr.GroupBy(x => x)
            .ToDictionary(x => x.Key, x => x.Count());
            /* luego al tamaño del array le resto la frecuencia maxima
            * del elemento que mas se repite */
            Console.WriteLine(arr.Length - frec.Max(x => x.Value));

        }
    }
}
