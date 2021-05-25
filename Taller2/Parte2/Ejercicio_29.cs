using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.Parte2
{
    class Ejercicio_29
    {
        //14.Elaborar un algoritmo que lea un número, si es par, que imprima el cubo
        //y si es impar, que imprima el triple.
        public void NumeroOperacion()
        {
            Console.WriteLine("**Pedir un numero, si es par imprimir el cubo, impar el triple**\nIngrese el numero");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine($"El cubo de {num} es {Math.Pow(num,3)}");
            else
                Console.WriteLine($"El triple de {num} es {num * 3}");
        }
    }
}
