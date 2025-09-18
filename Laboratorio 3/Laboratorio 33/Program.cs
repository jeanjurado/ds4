using System;

namespace Laboratorio33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce el lado mayor del rectángulo: ");
            double ladoMayor = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduce el lado menor del rectángulo: ");
            double ladoMenor = Convert.ToDouble(Console.ReadLine());

            double perimetro = 2 * (ladoMayor + ladoMenor);

            Console.WriteLine("El perímetro del rectángulo es: " + perimetro);

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
