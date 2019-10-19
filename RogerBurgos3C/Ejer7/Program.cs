using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer7
{
    class Program
    {
        static void Main(string[] args)
        {
            int FilaIzquierda = 1, FilaDerecha = 100, i = 1;
            while (i <= 100)
            {
                Console.WriteLine(FilaIzquierda.ToString() + " " + FilaDerecha.ToString());
                FilaIzquierda++;
                FilaDerecha--;
                i++;
            }
            Console.ReadKey();
        }
    }
}
