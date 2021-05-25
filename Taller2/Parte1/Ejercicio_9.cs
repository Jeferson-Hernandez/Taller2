using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.Parte1
{
    class Ejercicio_9
    {
        //9.Leer un número e imprimir un mensaje en caso que sea múltiplo de 5.
        public void MultiploDeCinco()
        {
            Console.WriteLine("**Mensaje si el numero es multiplo de 5**\nIngrese el numero");
            int num = int.Parse(Console.ReadLine());
            if (num % 5 == 0)
                Console.WriteLine("El numero es multiplo de 5");
        }
    }
}
