using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.Parte2
{
    class Ejercicio_27
    {
        //12.Elaborar un algoritmo que permita calcular el valor total a pagar en una
        //papelería teniendo en cuenta que, si lleva 5 cuadernos o más, se le cobrarán $2.000
        //por cada uno, mientras que, si lleva menos, se le cobrarán $2.500 por cada uno.
        public void ValorAPagar()
        {
            Console.WriteLine("**Valor a pagar, si lleva 5 cuadernos o mas son 2000c/u, menos son 2500c/u**\nIngrese la cantidad de cuadernos");
            int cantCuadernos = int.Parse(Console.ReadLine());
            int valorCuaderno = 2000;
            if (cantCuadernos >= 5)
                Console.WriteLine($"El valor total a pagar por los {cantCuadernos} cuadernos es de {cantCuadernos * valorCuaderno} pesos");
            else if (cantCuadernos > 0 && cantCuadernos < 5)
            {
                valorCuaderno = 2500;
                Console.WriteLine($"El valor total a pagar por los {cantCuadernos} cuadernos es de {cantCuadernos * valorCuaderno} pesos");
            }
            
            
        }
    }
}
