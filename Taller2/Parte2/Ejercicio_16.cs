using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.Parte2
{
    class Ejercicio_16
    {
        //1.Hacer un algoritmo que imprima el nombre de un artículo, clave, precio original
        //y su precio con descuento. El descuento lo hace en base a la clave, si la clave es 01
        //el descuento es del 10% y si la clave es 02 el descuento es del 20% (solo existen dos claves).
        public void InformacionArticulo()
        {
            Console.WriteLine("**Imprimir nombre articulo, clave, precio original y con descuento**\nIngrese el nombre del articulo");
            string nomArticulo = (Console.ReadLine());
            Console.WriteLine("Ingrese la clave");
            string clave = (Console.ReadLine());
            Console.WriteLine("Ingrese el precio");
            double precio = double.Parse(Console.ReadLine());
            double descuento = 0;

            if (clave.Contains("01"))
                descuento = precio * 0.10;
            else if (clave.Contains("02"))
                descuento = precio * 0.20;
            else
                Console.WriteLine("Ingrese una clave valida");

            Console.WriteLine($"**Informacion**\nNombre articulo: {nomArticulo}\nClave: {clave}");
            Console.WriteLine($"Precio original: {precio}\nPrecio con descuento: {precio - descuento}");            
        }
    }
}
