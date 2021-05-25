using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.Parte1
{
    class Ejercicio_7
    {
        //7.Leer un número e imprimir un mensaje en caso que sea negativo.
        public void NumeroNegativo()
        {
            Console.WriteLine("**Mensaje si el numero es negativo**\nIngrese el numero");
            int num = int.Parse(Console.ReadLine());

            if (num < 0)
                Console.WriteLine("El numero ingresado es negativo");
        }
    }
}
