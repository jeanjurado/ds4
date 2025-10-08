using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Aplicación de Consola para Matriz N x N con Patrón (POO) ---");

        int N;
        // Bucle para n
        while (true)
        {
            Console.Write("Ingrese la dimensión de la matriz N (N debe ser par, por ejemplo 6 u 8): ");
            // Validación de par y positivo
            if (int.TryParse(Console.ReadLine(), out N) && N > 0 && N % 2 == 0)
            {
                break;
            }
            Console.WriteLine("Error: Ingrese un número par y positivo. Intente de nuevo.");
        }

        try
        {
            // uso de la clase
            MatrizParcial miMatriz = new MatrizParcial(N);

            miMatriz.MostrarMatriz();

            long resultadoSuma = miMatriz.CalcularSumaElementosAleatorios();
            Console.WriteLine($"\nSuma total de los elementos aleatorios (excluyendo el patrón 0): {resultadoSuma}");
        }
        // para errores
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error de Matriz: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocurrió un error inesperado: {ex.Message}");
        }

        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}
