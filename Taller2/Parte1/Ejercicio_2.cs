using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.Parte1
{
    class Ejercicio_2
    {
        public void NumeroPorTres()
        {
            Console.WriteLine("Ingrese un numero");
            double numero = double.Parse(Console.ReadLine());
            double numeroPorTres;
            if (numero >= 10)
            {
                numeroPorTres = numero * 3;
                Console.WriteLine($"El numero {numero} multiplicado por 3 es {numeroPorTres}");
            }               
        }
    }
}
