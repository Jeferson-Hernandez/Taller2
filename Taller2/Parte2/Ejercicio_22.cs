using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.Parte2
{
    class Ejercicio_22
    {
        //7.Leer un número e imprimir un mensaje si es par o impar.
        public void NumeroParOImpar()
        {
            Console.WriteLine("**Mostrar si el numero es par o impar**\nIngrese el numero");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine($"El numero {num} es par");
            else
                Console.WriteLine($"El numero {num} es impar");
        }
    }
}
