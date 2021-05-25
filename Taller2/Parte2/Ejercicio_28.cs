using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.Parte2
{
    class Ejercicio_28
    {
        //13.Una constructora ofrece vivienda de interés social, bajo las siguientes condiciones:
        //Si los ingresos del comprador son iguales o superiores a $1.200.000, la cuota inicial
        //será del 15% del valor de la vivienda y el resto, se distribuirá en 120 cuotas mensuales
        //con un interés del 2% mensual. Si los ingresos del comprador son inferiores a $1.200.000,
        //la cuota inicial será del 30% del valor de la vivienda y el resto, lo distribuirá en
        //84 cuotas mensuales con un interés del 1% mensual. La constructora desea saber cuánto
        //debe pagar un comprador por concepto de cuota inicial y cuánto por cada cuota mensual.
        public void PagoVivienda()
        {
            Console.WriteLine("**Ingresos iguales o superioes a 1.200.000, cuota inicial 15% valor vivienda, resto 120 cuotas mensuales con 2% interes**");
            Console.WriteLine("**Ingresos menores, cuota inicial 30% valor vivienda, resto 84 cuotas mensuales con 1% interes**\nIngrese el valor de sus ingresos");
            double ingresos = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de la vivienda");
            double valorVivienda = double.Parse(Console.ReadLine());
            int limiteIngresos = 1200000;
            double cuotaInicial = 0;
            double cuotaMensual = 0;
            double cuotaMensualConIntereses = 0;
            double interes = 0;

            if (ingresos >= limiteIngresos)
            {
                cuotaInicial = valorVivienda * 0.15;
                cuotaMensual = (valorVivienda - cuotaInicial) / 120;
                interes = cuotaMensual * 0.02;
                cuotaMensualConIntereses = cuotaMensual + interes;
            }
            else
            {
                cuotaInicial = valorVivienda * 0.30;
                cuotaMensual = (valorVivienda - cuotaInicial) / 84;
                interes = cuotaMensual * 0.01;
                cuotaMensualConIntereses = cuotaMensual + interes;
            }
            Console.WriteLine($"El valor a pagar en la cuota inicial es de {cuotaInicial} pesos");
            Console.WriteLine($"El valor a pagar por la cuota mensual es de {cuotaMensualConIntereses} pesos");
        }
    }
}
