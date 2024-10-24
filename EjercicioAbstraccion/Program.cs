using EjercicioAbstraccion;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Seleccione la fórmula que desea calcular:");
            Console.WriteLine("1. Área de un triángulo");
            Console.WriteLine("2. Conversión de metros a kilómetros");
            Console.WriteLine("3. Volumen de una esfera");
            Console.WriteLine("4. Salir");
            string opcion = Console.ReadLine();

            FormulaMatematica formula = null;

            switch (opcion)
            {
                case "1":
                    Console.Write("Ingrese la base del triángulo: ");
                    double baseTriangulo = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese la altura del triángulo: ");
                    double altura = Convert.ToDouble(Console.ReadLine());
                    formula = new AreaTriangulo(baseTriangulo, altura);
                    break;

                case "2":
                    Console.Write("Ingrese la cantidad de metros: ");
                    double metros = Convert.ToDouble(Console.ReadLine());
                    formula = new ConversionMetrosKilometros(metros);
                    break;

                case "3":
                    Console.Write("Ingrese el radio de la esfera: ");
                    double radio = Convert.ToDouble(Console.ReadLine());
                    formula = new VolumenEsfera(radio);
                    break;

                case "4":
                    Console.WriteLine("Saliendo del programa...");
                    return;

                default:
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                    continue;
            }

            if (formula != null)
            {
                formula.Calcular();
                formula.Imprimir();
            }

            Console.WriteLine();  // Espacio adicional antes de mostrar el menú nuevamente
        }
    }
}