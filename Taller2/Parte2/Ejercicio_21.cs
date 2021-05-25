using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.Parte2
{
    class Ejercicio_21
    {
        //6.Calcular e imprimir el salario de un empleado, teniendo en cuenta que si el salario bruto
        //es igual o superior a $2.000.000, debe hacerse una retención del 10%, si el
        //salario es inferior, la retención será del 3%.
        public void SalarioEmpleado()
        {
            Console.WriteLine("**Salario neto superior a 2.000.000 retencion 10%, inferior 3%**\nIngrese el salario bruto");
            double salarioBruto = double.Parse(Console.ReadLine());
            double retencion = 0;
            if (salarioBruto > 2000000)
            {
                retencion = salarioBruto * 0.10;
                Console.WriteLine($"El salario neto es de: {salarioBruto - retencion}");
            }
            else
            {
                retencion = salarioBruto * 0.03;
                Console.WriteLine($"El salario neto es de: {salarioBruto - retencion}");
            }
        }
    }
}
