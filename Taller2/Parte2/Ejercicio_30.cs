using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.Parte2
{
    class Ejercicio_30
    {
        //15.En un almacén se hace un 17% de descuento a los clientes cuya compra sea
        //superior a $200.000, para las compras inferiores, el descuento será del 5%.
        //¿Cuánto deberá pagar cada cliente?
        public void PagoTotal()
        {
            Console.WriteLine("**Por compras mayores a 200.000 desc 17%, menores 5%**\nIngrese el valor de la compra");
            double valorCompra = double.Parse(Console.ReadLine());
            double descuento = valorCompra * 0.17;
            if (valorCompra > 200000)
                Console.WriteLine($"El valor total a pagar es de {valorCompra - descuento}");
            else
            {
                descuento = valorCompra * 0.05;
                Console.WriteLine($"El valor total a pagar es de {valorCompra - descuento}");
            }
        }
    }
}
