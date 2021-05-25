using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.Parte2
{
    class Ejercicio_26
    {
        //11.Una empresa desea hacer una compra de varias piezas de la misma clase a una fábrica.
        //La empresa, dependiendo del valor de la compra, decidirá la forma en que
        //le pagará al fabricante. Si el valor de la compra excede o es igual a $5.000.000,
        //la empresa tendrá la capacidad de pagar con recursos propios el 55% del valor de la compra,
        //pedirá prestado a un banco el 30% y el resto lo pagará solicitando un crédito al fabricante.
        //Si el monto total de la compra no excede de $5.000.000, la empresa tendrá la capacidad de
        //pagar con recursos propios un 70% y el 30% restante, lo pagará solicitando un crédito al
        //fabricante. El fabricante cobra un 15% de interés sobre la cantidad que le pague a crédito.
        public void CompraPiezas()
        {
            Console.WriteLine("**Por compras mayores a igual 5M, 55% recursos propios, 30% banco, resto credito**");
            Console.WriteLine("**Por compras menores a 5M, 70% recursos propios, 30% restante credito**\nIngrese el valor de la compra");
            double valorCompra = double.Parse(Console.ReadLine());
            int limiteCompra = 5000000;
            double pagoRecursosPropios = 0;
            double creditoFabricante = 0;
            double interesFabricante = 0;
            if (valorCompra >= limiteCompra)
            {
                pagoRecursosPropios = valorCompra * 0.55;
                double valorPrestadoBanco = valorCompra * 0.30;
                creditoFabricante = valorCompra * 0.15;
                interesFabricante = creditoFabricante * 0.15;
                Console.WriteLine($"El valor del pago con recursos es de {pagoRecursosPropios} pesos\nEl valor prestado en el banco es de {valorPrestadoBanco} pesos");
                Console.WriteLine($"El credito del fabricante es de {creditoFabricante} pesos,el valor total con intereses {creditoFabricante + interesFabricante} pesos");
            }
            else
            {
                pagoRecursosPropios = valorCompra * 0.70;
                creditoFabricante = valorCompra * 0.30;
                interesFabricante = creditoFabricante * 0.15;
                Console.WriteLine($"El valor del pago con recursos es de {pagoRecursosPropios} pesos");
                Console.WriteLine($"El credito del fabricante es de {creditoFabricante} pesos,el valor total con intereses {creditoFabricante + interesFabricante} pesos");
            }

        }
    }
}
