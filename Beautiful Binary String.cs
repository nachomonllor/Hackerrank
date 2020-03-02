using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string b = Console.ReadLine(); //"0100101010";
        // string b = "0101010";
        // string b = "000000000000000000000000";
        //string b = "01100";
        //string b = "0100101010";
        char[] bc = b.ToCharArray();
        int indiceAnt = 0;
        int indicePost = 0;
        int cont = 0;
        while (indiceAnt > -1 && indicePost != -1)
        {
            indiceAnt = new string(bc).IndexOf("010", indiceAnt);
            if (indiceAnt > -1)
            {
                indicePost = new string(bc).IndexOf("010", indiceAnt + 2);
            }
            if (indiceAnt + 2 == indicePost)
            {
                bc[indiceAnt + 2] = '1';
                cont++;
            }
            else if (indiceAnt > -1)
            {
                bc[indiceAnt + 2] = '1';
                cont++;
            }
        }

        //Console.WriteLine(new string(bc));
        Console.WriteLine(cont);

    }

}
