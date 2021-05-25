using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.Parte1
{
    class Ejercicio_6
    {
        //6.Calcular el salario de un empleado, teniendo en cuenta que si el salario bruto
        //es superior a $2.000.000, debe hacerse una retención del 10%.
        public void SalarioEmpleado()
        {
            Console.WriteLine("**Salario neto**\nIngrese el salario bruto");
            double salarioBruto = double.Parse(Console.ReadLine());
            double retencion = salarioBruto * 0.10;
            if (salarioBruto > 2000000)
                Console.WriteLine($"El salario neto es de: {salarioBruto - retencion}");
        }
    }
}
