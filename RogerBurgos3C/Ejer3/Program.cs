using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num;
            double precio, total = 0, final = 0;
            do
            {
                do
                {
                    Console.WriteLine("\nIntroduzca la cantidad vendida: ");
                    Num = int.Parse(Console.ReadLine());
                    if (Num < 0) Console.WriteLine("Cantidad no valida");
                } while (Num < 0);
                if (Num > 0)
                {
                    Console.WriteLine("Introduzca el precio: ");
                    do
                    {
                        precio = double.Parse(Console.ReadLine());
                        if (precio < 0) Console.WriteLine("Precio no valido");
                        else
                        {
                            total = Num * precio;

                        }

                    } while (precio < 0);
                    final = final + total;
                }

            } while (Num != 0);
            Console.Write("Total vendido =");
            Console.Write(final);
            Console.ReadKey();
        }
    }
}
