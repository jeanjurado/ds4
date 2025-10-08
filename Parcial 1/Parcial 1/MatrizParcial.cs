using System;

public class MatrizParcial
{
    private int[,] _matriz;
    private readonly Random _random = new Random();

    public MatrizParcial(int N)
    {
        if (N <= 0 || N % 2 != 0)
        {
            throw new ArgumentException("La dimensión N debe ser un número par y positivo.");
        }

        // N debe ser al menos 4 para tener un centro con ceros, pero el problema pide N>=6
        if (N < 4)
        {
            throw new ArgumentException("La dimensión N debe ser al menos 4 para definir las 4 esquinas.");
        }

        _matriz = new int[N, N];
        LlenarMatriz();
    }

    private void LlenarMatriz()
    {
        int N = _matriz.GetLength(0);

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                // Verifica si la celda pertenece a CUALQUIERA de las cuatro esquinas 2x2.

                bool esEsquinaSuperiorIzquierda = (i < 2 && j < 2);       // i=0,1 y j=0,1
                bool esEsquinaSuperiorDerecha = (i < 2 && j >= N - 2);    // i=0,1 y j=N-2, N-1
                bool esEsquinaInferiorIzquierda = (i >= N - 2 && j < 2);  // i=N-2, N-1 y j=0,1
                bool esEsquinaInferiorDerecha = (i >= N - 2 && j >= N - 2); // i=N-2, N-1 y j=N-2, N-1

                // Si la celda cae en alguna de las 4 esquinas 2x2.
                if (esEsquinaSuperiorIzquierda || esEsquinaSuperiorDerecha ||
                    esEsquinaInferiorIzquierda || esEsquinaInferiorDerecha)
                {
                    // Asignar ALEATORIO para rellenar la esquina.
                    _matriz[i, j] = _random.Next(101, 201);
                }
                else
                {
                    // Asignar 0 a todo el resto de la matriz.
                    _matriz[i, j] = 0;
                }
            }
        }
    }

    // El método CalcularSumaElementosAleatorios() queda IGUAL.
    public long CalcularSumaElementosAleatorios()
    {
        long suma = 0;
        int N = _matriz.GetLength(0);
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (_matriz[i, j] != 0) suma += _matriz[i, j];
            }
        }
        return suma;
    }

    // El método MostrarMatriz() queda IGUAL.
    public void MostrarMatriz()
    {
        int N = _matriz.GetLength(0);
        Console.WriteLine($"\nMatriz de {N} x {N} generada:");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write($"{_matriz[i, j],5}");
            }
            Console.WriteLine();
        }
    }
}

