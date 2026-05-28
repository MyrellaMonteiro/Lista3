using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3exc9_Myrella
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 1;
            int c;

            Console.Write(a + " " + b + " ");

            for (int i = 3; i <= 30; i++)
            {
                c = a + b;
                Console.Write(c + " ");

                a = b;
                b = c;
            }
        }
    }
}
