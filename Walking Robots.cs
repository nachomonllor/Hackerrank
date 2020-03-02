using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static int howManyCollisions(string s)
        {
            // Complete this function
            int sum = 0;
            string nueva = s.Replace("rl", "d");
            sum += ((s.Length - nueva.Length) * 2);
            string estado = "";
            while (estado != nueva)
            {
                estado = nueva;
                string anterior = nueva;
                nueva = anterior.Replace("rl", "d");
                sum += ((anterior.Length - nueva.Length) * 2);
                anterior = nueva;
                nueva = nueva.Replace("rd", "d");
                sum += anterior.Length - nueva.Length;
                anterior = nueva;
                nueva = nueva.Replace("dl", "d");
                sum += anterior.Length - nueva.Length;
            }
            //Console.WriteLine(sum);
            return sum;
        }
        static void Main(String[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < q; a0++)
            {
                string s = Console.ReadLine();
                // Returns the number of times moving robots collide.
                int result = howManyCollisions(s);
                Console.WriteLine(result);
            }
        }
    }
}
