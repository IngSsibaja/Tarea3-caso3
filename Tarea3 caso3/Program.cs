using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3_caso1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("--- Conversor de Celsius a Fahrenheit ---\n");
            double celsius = 0;
            bool entradaValida = false;

            while (!entradaValida)
            {
                Console.Write("Ingrese la temperatura en grados Celsius (°C): ");
                string input = Console.ReadLine();

                if (double.TryParse(input, out celsius))
                {
                    entradaValida = true;
                }
                else
                {
                    Console.WriteLine("Error: Debe ingresar un valor numérico válido. Intente otra vez.");
                }
            }

            double fahrenheit = (celsius * 9.0 / 5.0) + 32;

            Console.WriteLine($"\n{celsius:F2} °C equivalen a {fahrenheit:F2} °F.");

        }
    }
}
