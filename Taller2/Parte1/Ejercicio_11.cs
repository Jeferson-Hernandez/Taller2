using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.Parte1
{
    class Ejercicio_11
    {
        //11.Leer 4 notas, calcular el promedio e imprimir un mensaje indicando
        //que reprobó en caso que la nota sea menor a 3.5
        public void PromedioNotas()
        {
            Console.WriteLine("**Promedio de 4 notas**\nIngrese la primer nota");
            double nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda nota");
            double nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la tercer nota");
            double nota3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cuarta nota");
            double nota4 = double.Parse(Console.ReadLine());

            double promedio = (nota1 + nota2 + nota3 + nota4) / 4;

            if (promedio < 3.5)
                Console.WriteLine($"Reprobaste la materia, nota final {promedio}");
        }
    }
}
