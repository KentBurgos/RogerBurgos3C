using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogerBurgos3C
{
    class Program
    {
        static void Main(string[] args)
        {
            int Ma = 0, Num = 0;
            Console.WriteLine("ingrese cuantos numeros va a ingresar");
            int numeros = int.Parse(Console.ReadLine());
            for (int i = 0; i < Ma; i++)
            {
                Console.WriteLine("Ingresar nUmero");
                Num = int.Parse(Console.ReadLine());

                if (Num > Ma)
                {
                    Ma = Num;
                }
            }
            Console.WriteLine("El nUmero mayor es..." + Ma); 
            Console.ReadKey();
        }
    }
}
