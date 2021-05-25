using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.Parte1
{
    class Ejercicio_5
    {
        //5.En un almacén se hace un 20% de descuento a los clientes
        //cuya compra sea superior a $100.000. ¿Cuánto deberá pagar cada cliente?
        public void DescuentoCompra()
        {
            Console.WriteLine("**Valor total de la compra**\nIngrese valor de la compra");
            double valorCompra = double.Parse(Console.ReadLine());
            double descuentoCompra = valorCompra * 0.20;
            if (valorCompra > 100000)
                Console.WriteLine($"El valor total a apagar es de: {valorCompra - descuentoCompra}");
        }
    }
}
