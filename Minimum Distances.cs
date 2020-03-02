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
            int[] A = Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));
            int min_dif = int.MaxValue;
            Dictionary<int, int> diccio = new Dictionary<int, int>();
            bool hay = false;
            for (int i = 0; i < n; i++)
            {
                int elem = A[i];
                if (diccio.ContainsKey(elem))
                {
                    int dif = i - diccio[elem];
                    min_dif = Math.Min(min_dif, dif);
                    hay = true;
                }
                diccio[elem] = i;
            }
            Console.WriteLine(hay ? min_dif : -1);
        }
    }
}
