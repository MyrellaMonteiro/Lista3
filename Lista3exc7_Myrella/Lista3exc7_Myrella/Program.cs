using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3exc7_Myrella
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Precione ENTER para a proxima tabuada");
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("\nTabuada do " + i);

                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(i + " x " + j + " = " + (i * j));
                }

                Console.ReadKey();
            }
        }
    }
}
