using System;
using System.Security.Cryptography.X509Certificates;

namespace CalculadoraDeDivisas
{
    internal class Program
    {

        static void Main(string[] args)
        {

            while (true)
            {
                menu();

                static void menu()
                {
                    // Tasa de cambio dólar a colón
                    double tasaCambio = 548.20; // 1 dólar = 548.20 colones, ademas de que el double es para poder ingresar numeros con decimales

                    Console.WriteLine("Calculadora basica de Divisas (Dólares a Colones)");
                    Console.Write("Ingrese la cantidad en dólares que desea convertir: ");
                    double cantidadDolares = double.Parse(Console.ReadLine()); // el double.Parse convierte esa cadena en un valor numérico de tipo double.

                    double cantidadColones = cantidadDolares * tasaCambio; // realiza la convercion de dolares a colones multiplicandolos y almacenandolos en la variable cantidadColones

                    Console.WriteLine($"Equivalente en colones a: {cantidadColones}"); // usamos una interpolacion $

                    Console.WriteLine("Presione Y para realizar una nueva conversion o E para finalizar.");
                }



                while (true)
                {

                    ConsoleKeyInfo key = Console.ReadKey(); // lee la respuesta ingresada por consola

                    if (key.Key == ConsoleKey.E)
                    {
                        // si es E finaliza el codigo 

                        Environment.Exit(0);

                        break;

                    }
                    else if (key.Key == ConsoleKey.Y)
                    {
                        // si es Y se repite de nuevo todo

                        Console.Clear(); // se limpia la pantalla
                        menu(); // se llama al metodo que alberga todo

                    }
                    else
                    {
                        //Si la opcion ingresada no es igual ni a E ni a Y entonces se da un mensaje de que es invalida


                        Console.WriteLine("\nOpción inválida. Presione 'E' o 'Y'.");
                    }
                }

            }

            

            

        }
    }
}
