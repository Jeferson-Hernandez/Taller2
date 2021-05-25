using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.Parte1
{
    class Ejercicio_15
    {
        //15.Realizar un algoritmo que lea un número y si éste es superior o igual a 10,
        //permita imprimir su cubo.
        public void NumeroAlCubo()
        {
            Console.WriteLine("**Imprimir el cubo de un numero si es mayor a 10**\nIngrese el numero");
            double num = double.Parse(Console.ReadLine());

            if (num >= 10)
                Console.WriteLine($"El numero {num} al cubo es: {Math.Pow(num,3)}");            
        }
    }
}
