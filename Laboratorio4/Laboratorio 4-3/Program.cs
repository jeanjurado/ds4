using System;

class Program
{
    static void Main()
    {
        int numero;
        do
        {
            Console.Write("Ingrese un número (0 o negativo para salir): ");
            numero = int.Parse(Console.ReadLine());

            if (numero > 0)
                Console.WriteLine($"Ingresó: {numero}");

        } while (numero > 0);
    }
}
