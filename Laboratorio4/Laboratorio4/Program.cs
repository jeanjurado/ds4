using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número entero: ");
        int n = int.Parse(Console.ReadLine());

        int i = 1;
        while (i <= n)
        {
            Console.WriteLine(i);
            i++;
        }
    }
}
