using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3exc5_Myrella
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;

            do
            {
                Console.Write("Digite um número positivo: ");
                a = int.Parse(Console.ReadLine());

            } while (a <= 0);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(a + " x " + i + " = " + (a * i));
            }
        }
    }
}
