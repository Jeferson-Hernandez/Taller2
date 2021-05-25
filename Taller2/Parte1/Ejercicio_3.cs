using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.Parte1
{
    class Ejercicio_3
    {
        public void ValorTotalCompra()
        {
            Console.WriteLine("Ingrese el valor del computador");
            long valor = long.Parse(Console.ReadLine());
            int valorLimite = 1000000;
            double descuento = valor * 0.10;
            double valorConDescuento = valor - descuento;
            double iva = valorConDescuento * 0.19;
            if (valor >= valorLimite)
            {
                double valorTotal = valorConDescuento + iva;
                Console.WriteLine($"El valor total de la compra es: {valorTotal}");
            }               
        }
    }
}
