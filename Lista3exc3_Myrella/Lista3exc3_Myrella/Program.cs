using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3exc3_Myrella
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char sexo;

            do
            {
                Console.Write("Digite F ou M: ");
                sexo = char.Parse(Console.ReadLine().ToUpper());

                if (sexo != 'F' && sexo != 'M')
                {
                    Console.WriteLine("Entrada inválida!");
                }

            } while (sexo != 'F' && sexo != 'M');

            Console.WriteLine("Sexo válido.");
        }
    }
}
