using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3exc1_Myrella
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;

            do
            {
                Console.Write("Digite um valor: ");
                a = int.Parse(Console.ReadLine());

                if (a <= 0)
                {
                    Console.WriteLine("Valor inválido!");
                }

            } while (a <= 0);

            Console.WriteLine("Valor aceito: " + a );
        }
    }
}
