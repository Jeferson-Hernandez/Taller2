using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.Parte1
{
    class Ejercicio_1
    {
        public void ImprimirNumeroPar()
        {
            Console.WriteLine("Ingrese un numero");
            int numero = int.Parse(Console.ReadLine());
            if (numero % 2 == 0)
                Console.WriteLine("Su numero es par");            
        }
    }
}
