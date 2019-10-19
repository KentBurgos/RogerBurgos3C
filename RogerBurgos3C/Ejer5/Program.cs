using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer5
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num;
            Console.WriteLine("Ingresar dato");
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
            Console.ReadKey();
        }
    }
}
