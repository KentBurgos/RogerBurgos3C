using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer6
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num;
            Console.WriteLine("Ingrese un número");
            Num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= Num; i++)
            {
                for (int j = 1; j <= Num - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= (2 * i) - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = Num - 1; i >= 1; i--)
            {
                for (int j = Num - i; j >= 1; j--)
                {
                    Console.Write(" ");
                }
                for (int j = (2 * i) - 1; j >= 1; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
