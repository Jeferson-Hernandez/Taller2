using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.Parte2
{
    class Ejercicio_19
    {
        //4.Hacer un algoritmo que lea dos números y los imprima en orden ascendente.
        public void OrdenarNumeros()
        {
            Console.WriteLine("**Ordenar dos numeros de manera ascendente**\nIngrese el primer numero");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            double num2 = double.Parse(Console.ReadLine());

            if (num1 > num2)
                Console.WriteLine($"El orden es: {num2} {num1}");
            else
                Console.WriteLine($"El orden es: {num1} {num2}");
        }
    }
}
