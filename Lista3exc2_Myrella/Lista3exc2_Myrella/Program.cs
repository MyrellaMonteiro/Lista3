using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3exc2_Myrella
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            Console.Write("Digite o primeiro valor: ");
            a = int.Parse(Console.ReadLine());

            do
            {
                Console.Write("Digite o segundo valor: ");
                b = int.Parse(Console.ReadLine());

                if (b <= a)
                {
                    Console.WriteLine("O segundo valor deve ser maior!");
                }

            } while (b <= a);

            Console.WriteLine("Valores aceitos.");
        }
    }
}
