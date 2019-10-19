using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer8
{
    class Program
    {
        static void Main(string[] args)
        {
            String x;
            int a = 1;
            int b = 2;
            int c = 3;
            int i = 1;
            Console.WriteLine("Ingrese número a mostrar: "); x = Console.ReadLine();
            while (i <= int.Parse(x))
            {
                if (b < int.Parse(x) && c < int.Parse(x))
                {
                    Console.WriteLine(a.ToString() + "    " + b.ToString() + "" +
                        "    " + c.ToString());
                }
                else if (b < int.Parse(x))
                {
                    Console.WriteLine(a.ToString() + "    " + b.ToString());
                }
                else
                {
                    Console.WriteLine(a.ToString());
                }
                a++;
                b = b + 2;
                c = c + 3;
                i++;
            }
            Console.ReadKey();
        }
    }
}
