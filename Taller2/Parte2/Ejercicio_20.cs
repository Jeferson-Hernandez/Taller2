using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.Parte2
{
    class Ejercicio_20
    {
        //5.Determinar el precio de un pasaje de ida y vuelta por avión, conociendo la distancia
        //a recorrer y sabiendo que que esta es superior a 1.000 km, la línea aérea le hace un
        //descuento del 30%. El precio por kilómetro es de $150.
        public void ValorPasajeAvion()
        {
            Console.WriteLine("**Valor pasaje de avion conociendo la distancia, superior a 1000km 30%desc, precio por kilometro 150**\nIngrese la distancia a recorrer");
            double distancia = double.Parse(Console.ReadLine());
            double descuento = 0;
            int precioXKilometro = 150;
            double valorViaje = distancia * precioXKilometro;

            if (distancia > 1000)
            {
                descuento = valorViaje * 0.30;
                Console.WriteLine($"El valor total del pasaje es: {valorViaje - descuento}");
            }
            else
                Console.WriteLine($"El valor total del pasaje es: {valorViaje}");
        }
    }
}
