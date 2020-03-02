using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static string isValid(string email)
        {
            // Complete this function

            string[] sp = email.Split('@');

            if (sp.Length != 2) return "No";

            if (sp[0].Length != 5)
            {
                return "No";
            }

            for (int i = 0; i < sp[0].Length; i++)
            {
                if (char.IsUpper(sp[0][i]))
                {
                    return "No";
                }
            }

            if (sp[1] != "hogwarts.com")
            {
                return "No";
            }
            return "Yes";
        }
        static void Main(string[] args)
        {
            //string s = "dumbledore@hogwarts.com";
            //string s = "harry@hogwarts.com@hogwarts.com";
            //string s = "harry@hogwarts.com";
            string s = "HARRY@hogwarts.com";
            Console.WriteLine(isValid(s));



            Console.ReadLine();

        }
    }
}

