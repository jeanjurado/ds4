using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número: ");
        int num = int.Parse(Console.ReadLine());

        if (num % 2 == 0)
            Console.WriteLine("El número es PAR");
        else
            Console.WriteLine("El número es IMPAR");
    }
}
