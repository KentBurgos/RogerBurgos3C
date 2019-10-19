using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            int Num = int.Parse(Console.ReadLine());
            int num;
            num = Num;

            for (int i = 0; i < num; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            for (int i = 0; i < num - 2; i++)
            {
                Console.Write("*");
                for (int j = 0; j < num - 2; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }

            for (int i = 0; i < num; i++)
            {
                Console.Write("*");
            }

            Console.ReadKey();
        }
    }
}
