using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.Parte1
{
    class Ejercicio_10
    {
        //10.Leer la edad de una persona e imprimir un mensaje en caso que sea mayor de edad.
        public void MayorDeEdad()
        {
            Console.WriteLine("**Mensaje si es mayor de edad**\nIngrese la edad");
            int edad = int.Parse(Console.ReadLine());
            if (edad >= 18)
                Console.WriteLine("Felicidades! Eres mayor de edad");            
        }
    }
}
