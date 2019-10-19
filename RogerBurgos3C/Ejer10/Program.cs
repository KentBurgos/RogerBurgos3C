using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer10
{
    class Program
    {
        static void Main(string[] args)
        {
            metodos obj = new metodos();

            Console.WriteLine("Ingrese un nUmero");
            Console.WriteLine(" ");
            int op;

            do
            {


                Console.WriteLine("1) Salir)");
                Console.WriteLine("2) Sumatoria");
                Console.WriteLine("3) FactorizaciOn");
                Console.WriteLine("");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        break;
                    case 2:
                        obj.sumatoria();
                        break;
                    case 3:
                        obj.factorizacion();
                        break;
                    default:
                        Console.WriteLine("Ingrese una opciOn vAlida");
                        break;
                        Console.ReadKey();

                }
            } while (op != 1);
        }
    }
}
