using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 1;
            String x;
            Console.WriteLine("Ingrese un nUmero para crear tabla");
            x = Console.ReadLine();
            while (a <= 15)
            {
                b = a * int.Parse(x);
                Console.WriteLine(x.ToString() + "X" + a.ToString() + "=" + b.ToString());
                a++;
            }
            Console.ReadKey();
        }
    }
}
