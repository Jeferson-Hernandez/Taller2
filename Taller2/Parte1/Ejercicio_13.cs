using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.Parte1
{
    class Ejercicio_13
    {
        //13.Un proveedor de computadores ofrece descuento del 10%, si cuesta $1.000.000 o más.
        //Determinar cuánto pagará, con IVA incluido (19%),
        //cliente cualquiera por la compra de una computadora.
        public void ValorTotalCompra()
        {
            Console.WriteLine("Ingrese el valor del computador");
            long valor = long.Parse(Console.ReadLine());
            int valorLimite = 1000000;
            double descuento = valor * 0.10;
            double valorConDescuento = valor - descuento;
            double ivaConDescuento = valorConDescuento * 0.19;
            double iva = valor * 0.19;
            if (valor >= valorLimite)
                Console.WriteLine($"El valor total de la compra es: {valorConDescuento + ivaConDescuento}");
            else
                Console.WriteLine($"El valor total de la compra es: {valor + iva}");
        }
    }
}
