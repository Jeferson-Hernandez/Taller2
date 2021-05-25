using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.Parte2
{
    class Ejercicio_24
    {
        //9.Un obrero necesita calcular su salario semanal, el cual se obtiene de la siguiente manera:
        //Si trabaja 40 horas o menos, se le paga a $10.000 la hora
        //Si trabaja más de 40 horas, se le paga $10.000 por cada una de las
        //primeras 40 horas y $15.000 por cada una de las horas extras.

        public void SalarioMensualObrero()
        {
            Console.WriteLine("**Salario semanal de un obrero**\nIngrese las horas de trabajo");
            int horasTrabajo = int.Parse(Console.ReadLine());
            int pagoPorHora = 10000;
            int pagoHorasExtra = 15000;

            if (horasTrabajo <= 40)
                Console.WriteLine($"Su salario por las {horasTrabajo} de trabajo semanal es de {pagoPorHora * horasTrabajo} pesos");
            else
            {
                int horasExtras = horasTrabajo - 40;
                Console.WriteLine($"Su salario por las 40 horas de trabajo y las {horasExtras} horas extras es de {(pagoPorHora * 40) + (horasExtras * pagoHorasExtra)}");
            }
        }
    }
}
