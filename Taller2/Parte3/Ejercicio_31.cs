using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.Parte3
{
    class Ejercicio_31
    {
        //Desarrolle un algoritmo que le permita al usuario escoger entre los siguientes ejercicios (se deben usar métodos):
        //1.Realizar un programa que nos pida un número n, y nos diga cuantos números hay entre 1 y n que son primos.
        //2.Pedir un número N, introducir N sueldos, y mostrar el sueldo máximo.
        //3.Pedir un número de 0 a 99 y mostrarlo escrito. Por ejemplo, para 56 mostrar: cincuenta y seis.
        //Pista: separar las unidades y las decenas. (unidades = num % 10; decenas = num / 10).
        //4.Pedir al usuario que ingrese una letra cualquiera del abecedario y mostrar por consola si se trata de un vocal o una consonante.
        public void Ejercicio()
        {
            bool bucle = true;
            do
            {
                Console.WriteLine("**MENU**\n1-Numeros entre 1 y el numero ingresado que son primos\n2-Numero de sueldos y sueldos, mostrar el sueldo mayor");
                Console.WriteLine("3-Numero entre 0 y 99, mostrarlo escrito\n4-Letra del abecedario y mostrar si es vocal o consonante\nIngrese opcion");
                int opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    Console.WriteLine("Ingrese el numero");
                    int numeroUsuario = int.Parse(Console.ReadLine());
                    NumerosPrimos(numeroUsuario);
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("Ingrese el numero de sueldos que quiere ingresar");
                    int numeroSueldos = int.Parse(Console.ReadLine());
                    Console.WriteLine($"El sueldo mayor de los ingresados es {SueldoMayor(numeroSueldos)}");
                }
                else if (opcion == 3)
                {
                    Console.WriteLine("Ingrese un numero entre 0 y 99");
                    int numero = int.Parse(Console.ReadLine());
                    NumeroATexto(numero);
                }
                else if (opcion == 4)
                {
                    Console.WriteLine("Ingrese una letra");
                    string letra = (Console.ReadLine());
                    Console.WriteLine($"{AdivinarLetra(letra)}");
                }
                else
                {
                    Console.WriteLine("Ingrese una opcion valida");                    
                }
                Console.WriteLine("Desea seguir haciendo ejercicios?");
                string resp = Console.ReadLine();
                if (resp.Contains("no"))
                    bucle = false;
            } while (bucle);
        }
        public void NumerosPrimos(int numeroUsuario)
        {
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
                if(divisible == 2)                    
                    Console.WriteLine("Primos:"+ num);

                divisible = 0;
                num++;
            }            
        }
        public int SueldoMayor(int numeroSueldos)
        {
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
            return sueldoMayor;
        }
        public void NumeroATexto(int numero)
        {
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
        }
        public string AdivinarLetra(string letra)
        {
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
            return tipoLetra;
        }
    }
}
