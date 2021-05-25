using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.Parte2
{
    class Ejercicio_17
    {
        //2.Hacer un algoritmo que calcule el total a pagar por la compra de camisas.
        //Si se compran tres camisas o más se aplica un descuento del 20%
        //sobre el total de la compra y si son menos de tres camisas un descuento del 10%
        public void ValorCompra()
        {
            Console.WriteLine("**Descuento por las camisas 3 o mas 20%, menos 10%**\nIngrese el valor de la camisa");            
            double valorCamisa = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de camisas");
            double cantCamisa = double.Parse(Console.ReadLine());
            double descuento = 0;
            double valorCompra = valorCamisa * cantCamisa;

            if (cantCamisa >= 3)
                descuento = valorCompra * 0.20;
            else
                descuento = valorCompra * 0.10;

            Console.WriteLine($"El total de la compra por las {cantCamisa} camisas es de: {valorCompra - descuento}");
            
        }
    }
}
