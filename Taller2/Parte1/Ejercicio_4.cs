using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.Parte1
{
    class Ejercicio_4
    {
        //4.Realizar un algoritmo que lea dos números
        //e imprima la suma de los 2, en caso que el primero sea mayor al segundo
        public void SumaNumeros()
        {
            Console.WriteLine("**Suma de dos numeros**\nIngrese el primer numero ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            double num2 = double.Parse(Console.ReadLine());

            if (num1 > num2)
                Console.WriteLine($"La suma de los numeros es {num1 + num2}");
        }
    }
}
