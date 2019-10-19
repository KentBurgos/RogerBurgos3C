using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer10
{
    class metodos
    {
        public void sumatoria()
        {

            int Num1 = 0, Num2 = 0;
            Console.WriteLine("Ingrese un nUmero");
            Num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro nUmero");
            Num2 = int.Parse(Console.ReadLine());
            int Suma;
            Suma = Num1 + Num2;
            Console.WriteLine("La Suma es: " + Suma);

        }
        public void factorizacion()
        {
            Console.WriteLine("Introduzca nUmero: ");
            int Num, Factorial = 1, Contador = 0;
            Num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= Num; i++)
            {
                Contador = Contador + 1;
                Factorial = Factorial * Contador;
            }
            Console.WriteLine("El factorial es: " + Factorial);

        }
    }
}
