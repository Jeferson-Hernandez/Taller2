using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.Parte1
{
    class Ejercicio_12
    {
        //12.Hacer un algoritmo que lea la estatura de una persona y si es mayor de 1.70,
        //imprima que es alta
        public void Estatura()
        {
            Console.WriteLine("**Imprimir si la estatura es mayor a 1.70**\nIngrese la estatura");
            double estatura = double.Parse(Console.ReadLine());

            if (estatura > 1.70)
                Console.WriteLine($"Eres una persona alta");
        }
    }
}
