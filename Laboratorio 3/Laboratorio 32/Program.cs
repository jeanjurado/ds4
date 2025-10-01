using System;

namespace Laboratorio32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce el radio del círculo: ");
            double radio = Convert.ToDouble(Console.ReadLine());

            CalculosMatematicos calc = new CalculosMatematicos();
            double area = calc.CalculoArea(radio);

            Console.WriteLine("El área del círculo con radio {0} es: {1}", radio, area);

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }

    public class CalculosMatematicos
    {
        public double CalculoArea(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }
    }
}
