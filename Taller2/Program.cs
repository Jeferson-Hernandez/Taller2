using System;
using Taller2.Parte1;
using Taller2.Parte2;
using Taller2.Parte3;
using Taller2.Parte4;

namespace Taller2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero de la parte del ejercicio");
            int parte = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero del ejercicio");
            int ejercicio = int.Parse(Console.ReadLine());
            switch (parte)
            {
                case 1:                    
                    if (ejercicio == 1)
                    {
                        Ejercicio_1 ejercicio1 = new Ejercicio_1();                        
                        ejercicio1.ImprimirNumeroPar();
                    }
                    else if (ejercicio == 2)
                    {
                        Ejercicio_2 ejercicio2 = new Ejercicio_2();
                        ejercicio2.NumeroPorTres();
                    }
                    else if (ejercicio == 3)
                    {
                        Ejercicio_3 ejercicio3 = new Ejercicio_3();
                        ejercicio3.ValorTotalCompra();
                    }
                    else if (ejercicio == 4)
                    {
                        Ejercicio_4 ejercicio4 = new Ejercicio_4();
                        ejercicio4.SumaNumeros();
                    }
                    else if (ejercicio == 5)
                    {
                        Ejercicio_5 ejercicio5 = new Ejercicio_5();
                        ejercicio5.DescuentoCompra();
                    }
                    else if (ejercicio == 6)
                    {
                        Ejercicio_6 ejercicio6 = new Ejercicio_6();
                        ejercicio6.SalarioEmpleado();
                    }
                    else if (ejercicio == 7)
                    {
                        Ejercicio_7 ejercicio7 = new Ejercicio_7();
                        ejercicio7.NumeroNegativo();
                    }
                    else if (ejercicio == 8)
                    {
                        Ejercicio_8 ejercicio8 = new Ejercicio_8();
                        ejercicio8.CantidadInvertida();
                    }
                    else if (ejercicio == 9)
                    {
                        Ejercicio_9 ejercicio9 = new Ejercicio_9();
                        ejercicio9.MultiploDeCinco();
                    }
                    else if (ejercicio == 10)
                    {
                        Ejercicio_10 ejercicio10 = new Ejercicio_10();
                        ejercicio10.MayorDeEdad();
                    }
                    else if (ejercicio == 11)
                    {
                        Ejercicio_11 ejercicio11 = new Ejercicio_11();
                        ejercicio11.PromedioNotas();
                    }
                    else if (ejercicio == 12)
                    {
                        Ejercicio_12 ejercicio12 = new Ejercicio_12();
                        ejercicio12.Estatura();
                    }
                    else if (ejercicio == 13)
                    {
                        Ejercicio_13 ejercicio13 = new Ejercicio_13();
                        ejercicio13.ValorTotalCompra();
                    }
                    else if (ejercicio == 15)
                    {
                        Ejercicio_15 ejercicio15 = new Ejercicio_15();
                        ejercicio15.NumeroAlCubo();
                    }
                    break;
                case 2:
                    if (ejercicio == 1)
                    {
                        Ejercicio_16 ejercicio16 = new Ejercicio_16();
                        ejercicio16.InformacionArticulo();
                    }
                    else if (ejercicio == 2)
                    {
                        Ejercicio_17 ejercicio17 = new Ejercicio_17();
                        ejercicio17.ValorCompra();
                    }
                    else if (ejercicio == 3)
                    {
                        Ejercicio_18 ejercicio18 = new Ejercicio_18();
                        ejercicio18.OperacionNumero();
                    }
                    else if (ejercicio == 4)
                    {
                        Ejercicio_19 ejercicio19 = new Ejercicio_19();
                        ejercicio19.OrdenarNumeros();
                    }
                    else if (ejercicio == 5)
                    {
                        Ejercicio_20 ejercicio20 = new Ejercicio_20();
                        ejercicio20.ValorPasajeAvion();
                    }
                    else if (ejercicio == 6)
                    {
                        Ejercicio_21 ejercicio21 = new Ejercicio_21();
                        ejercicio21.SalarioEmpleado();
                    }
                    else if (ejercicio == 7)
                    {
                        Ejercicio_22 ejercicio22 = new Ejercicio_22();
                        ejercicio22.NumeroParOImpar();
                    }
                    else if (ejercicio == 8)
                    {
                        Ejercicio_23 ejercicio23 = new Ejercicio_23();
                        ejercicio23.NumeroPulsaciones();
                    }
                    else if (ejercicio == 9)
                    {
                        Ejercicio_24 ejercicio24 = new Ejercicio_24();
                        ejercicio24.SalarioMensualObrero();
                    }
                    else if (ejercicio == 10)
                    {
                        Ejercicio_25 ejercicio25 = new Ejercicio_25();
                        ejercicio25.CantidadCalorias();
                    }
                    else if (ejercicio == 11)
                    {
                        Ejercicio_26 ejercicio26 = new Ejercicio_26();
                        ejercicio26.CompraPiezas();
                    }
                    else if (ejercicio == 12)
                    {
                        Ejercicio_27 ejercicio27 = new Ejercicio_27();
                        ejercicio27.ValorAPagar();
                    }
                    else if (ejercicio == 13)
                    {
                        Ejercicio_28 ejercicio28 = new Ejercicio_28();
                        ejercicio28.PagoVivienda();
                    }
                    else if (ejercicio == 14)
                    {
                        Ejercicio_29 ejercicio29 = new Ejercicio_29();
                        ejercicio29.NumeroOperacion();
                    }
                    else if (ejercicio == 15)
                    {
                        Ejercicio_30 ejercicio30 = new Ejercicio_30();
                        ejercicio30.PagoTotal();
                    }
                    break;
                case 3:
                    if (ejercicio == 1)
                    {
                        Ejercicio_31 ejercicio31 = new Ejercicio_31();
                        ejercicio31.Ejercicio();
                    }
                    break;
                case 4:
                    if (ejercicio == 1)
                    {
                        Ejercicio_32 ejercicio32 = new Ejercicio_32();
                        ejercicio32.Ejercicios();
                    }
                    break;
                default:
                    Console.WriteLine("Ingrese una opcion valida");
                    break;
            }
        }
    }
}
