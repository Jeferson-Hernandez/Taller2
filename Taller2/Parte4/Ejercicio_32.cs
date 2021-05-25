using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.Parte4
{
    class Ejercicio_32
    {

        public void Ejercicios()
        {
            bool bucle = true;
            do
            {
                Console.WriteLine("**MENU**\n1-Numeros entre 1 y el numero ingresado que son primos\n2-Numero de sueldos y sueldos, mostrar el sueldo mayor");
                Console.WriteLine("3-Numero entre 0 y 99, mostrarlo escrito\n4-Letra del abecedario y mostrar si es vocal o consonante\nIngrese opcion");
                int opcion = int.Parse(Console.ReadLine());                
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el numero");
                        int numeroUsuario = int.Parse(Console.ReadLine());
                        int num = 2, divisible = 0;
                        while (num <= numeroUsuario)
                        {
                            for (int i = 1; i <= num; i++)
                            {
                                if (num % i == 0)
                                    divisible++;
                                if (divisible > 2)
                                    break;
                            }
                            if (divisible == 2)
                                Console.WriteLine("Primos:" + num);

                            divisible = 0;
                            num++;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el numero de sueldos que quiere ingresar");
                        int numeroSueldos = int.Parse(Console.ReadLine());
                        List<int> listaSueldos = new List<int>();
                        int sueldo = 0, sueldoMayor = 0;
                        for (int i = 0; i < numeroSueldos; i++)
                        {
                            Console.WriteLine("Ingrese el sueldo");
                            sueldo = int.Parse(Console.ReadLine());
                            listaSueldos.Add(sueldo);
                        }
                        foreach (int sueldoM in listaSueldos)
                        {
                            if (sueldoM > sueldoMayor)
                                sueldoMayor = sueldoM;
                        }
                        Console.WriteLine($"El sueldo mayor de los ingresados es {sueldoMayor}");
                        break;
                    case 3:
                        Console.WriteLine("Ingrese un numero entre 0 y 99");
                        int numero = int.Parse(Console.ReadLine());
                        int dec, uni;
                        string decena = "", unidad = "";
                        if (numero >= 0 && numero < 100)
                        {
                            if (numero > 10 && numero < 16)
                            {
                                switch (numero)
                                {
                                    case 11: Console.WriteLine("Once"); break;
                                    case 12: Console.WriteLine("Doce"); break;
                                    case 13: Console.WriteLine("Trece"); break;
                                    case 14: Console.WriteLine("Catorce"); break;
                                    case 15: Console.WriteLine("Quince"); break;
                                }
                            }
                            else
                            {
                                dec = numero / 10;
                                uni = numero - (dec * 10);
                                switch (dec)
                                {
                                    case 1: decena = "Diez"; break;
                                    case 2: decena = "Veinte"; break;
                                    case 3: decena = "Treinta"; break;
                                    case 4: decena = "Cuarenta"; break;
                                    case 5: decena = "Cincuenta"; break;
                                    case 6: decena = "Sesenta"; break;
                                    case 7: decena = "Setenta"; break;
                                    case 8: decena = "Ochenta"; break;
                                    case 9: decena = "Noventa"; break;
                                }
                                if (uni != 0)
                                {
                                    switch (uni)
                                    {
                                        case 1: unidad = "Uno"; break;
                                        case 2: unidad = "Dos"; break;
                                        case 3: unidad = "Tres"; break;
                                        case 4: unidad = "Cuatro"; break;
                                        case 5: unidad = "Cinco"; break;
                                        case 6: unidad = "Seis"; break;
                                        case 7: unidad = "Siete"; break;
                                        case 8: unidad = "Ocho"; break;
                                        case 9: unidad = "Nueve"; break;
                                    }
                                    if (dec == 1)
                                        decena = "Dieci";
                                    if (dec == 2)
                                        decena = "Veinti";
                                    if (dec > 2 && dec < 10)
                                        Console.WriteLine($"{decena} y {unidad}");
                                    else
                                        Console.WriteLine($"{decena}{unidad}");
                                }
                                else
                                    Console.WriteLine(decena);
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("Ingrese una letra");
                        string letra = (Console.ReadLine());
                        List<string> vocales = new List<string>();
                        vocales.Add("a");
                        vocales.Add("e");
                        vocales.Add("i");
                        vocales.Add("o");
                        vocales.Add("u");
                        string tipoLetra = "Su letra es una consonante";
                        foreach (var item in vocales)
                        {
                            if (item.Contains(letra))
                                tipoLetra = "Su letra es una vocal";
                        }
                        Console.WriteLine(tipoLetra);
                        break;
                    default:
                        Console.WriteLine("Ingrese una opcion valida");
                        break;
                }
                Console.WriteLine("Desea seguir haciendo ejercicios?");
                string resp = Console.ReadLine();
                if (resp.Contains("no"))
                    bucle = false;
            } while (bucle);
            
        }
        
    }
}
