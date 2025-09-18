using System;

namespace Laboratorio31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce el primer número (a): ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce el segundo número (b): ");
            int b = Convert.ToInt32(Console.ReadLine());

            CalculosMatematicos calc = new CalculosMatematicos();
            int resultado = calc.Calcular(a, b);

            Console.WriteLine("El resultado de (a+b)*(a-b) es: " + resultado);

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }

    public class CalculosMatematicos
    {
        public int Calcular(int a, int b)
        {
            return (a + b) * (a - b);
        }
    }
}
