using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer4
{
    class Program
    {
        static void Main(string[] args)
        {
            string Horas;
            int Sueldo;
            String Control = "S";

            while (Control != "N")
            {
                Console.WriteLine("¿CuAntas horas trabajO?");
                Horas = Console.ReadLine();
                if (int.Parse(Horas) >= 35)
                {
                    int HorasExt;
                    HorasExt = int.Parse(Horas) - 35;
                    Sueldo = (HorasExt * 22) + (35 * 15);
                }
                else
                {
                    Sueldo = int.Parse(Horas) * 15;
                }
                Console.WriteLine("Su sueldo es: $" + Sueldo.ToString());
                Control = Console.ReadLine();
            }
        }
    }
}
