using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.Parte2
{
    class Ejercicio_18
    {
        //3.Elabore un algoritmo que lea un número y si este es mayor o igual a 10
        //devuelva el triple de este de lo contrario la cuarta parte de este.
        public void OperacionNumero()
        {
            Console.WriteLine("**Numero mayor a o igual a 10 triple, menor la cuarta parte**\nIngrese el numero");
            double num = double.Parse(Console.ReadLine());

            if (num >= 10)
            {
                num = num * 3;
                Console.WriteLine($"El tripe de su numero es: {num}");
            }
            else
            {
                num = num / 4;
                Console.WriteLine($"La cuarta parte del numero es: {num}");
            } 
        }
    }
}
