using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.Parte2
{
    class Ejercicio_23
    {
        //8.Elaborar un algoritmo que permita calcular el número de pulsaciones que debe tener
        //una persona por cada 10 segundos de ejercicio aeróbico; la fórmula que se aplica
        //cuando el sexo es femenino, es: numpulsaciones = (220-edad)/10 y si el sexo es masculino:
        //numpulsaciones = (210-edad)/10
        public void NumeroPulsaciones()
        {
            Console.WriteLine("**Numero de pulsaciones por cada 10 segundos de ejercicio**\nIngrese su genero");
            string genero = Console.ReadLine();
            Console.WriteLine("Ingrese su edad");
            double edad = double.Parse(Console.ReadLine());
            double numPulsaciones = 0;

            if (genero.Contains("femenino"))
            {
                numPulsaciones = (220 - edad) / 10;
                Console.WriteLine($"El numero de pulsaciones que debe tener por cada 10 segundo es de {numPulsaciones}");
            }
            else if (genero.Contains("masculino"))
            {
                numPulsaciones = (210 - edad) / 10;
                Console.WriteLine($"El numero de pulsaciones que debe tener por cada 10 segundo es de {numPulsaciones}");
            }
            else
                Console.WriteLine("Ingrese un genero valido");
        }
    }
}
