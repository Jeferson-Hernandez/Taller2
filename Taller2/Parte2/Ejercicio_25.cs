using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.Parte2
{
    class Ejercicio_25
    {
        //10.Una persona enferma y cuyo peso es 70 kg, se encuentra en reposo y desea saber
        //cuántas calorías consume su cuerpo durante el tiempo que realice una misma actividad.
        //Las actividades que puede realizar son únicamente dormir o estar sentado.
        //Los datos que tiene son que estando dormido consume 1.08 calorías por minuto y
        //estando sentado en reposo consume 1.66 calorías por minuto.
        public void CantidadCalorias()
        {
            Console.WriteLine("**Calorias consumidas al dormir o estar sentado**\nIngrese la actividad");
            string actividad = (Console.ReadLine());
            Console.WriteLine("Ingrese el tiempo que la va a realizar en minutos");
            int actividadTiempo = int.Parse(Console.ReadLine());
            double caloriasPorMinuto = 1.66;

            if (actividad.Contains("dormir"))
            {
                caloriasPorMinuto = 1.08;
                Console.WriteLine($"Las calorias totales por {actividadTiempo} minutos son de {Math.Floor(actividadTiempo * caloriasPorMinuto)} calorias");
            }
            else if (actividad.Contains("estar sentado"))
                Console.WriteLine($"Las calorias totales por {actividadTiempo} minutos son de {Math.Floor(actividadTiempo * caloriasPorMinuto)} calorias");
            else
                Console.WriteLine("Ingrese una actividad valida");
        }
    }
}
