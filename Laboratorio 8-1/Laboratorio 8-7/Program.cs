internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Corrio la aplicacion");
    }
}

sealed class ClaseBase
{
    public void test()
    {
        // El cuerpo del método está vacío, pero se mantiene la estructura.
    }

    public void moreTesting()
    {
        // El cuerpo del método está vacío, pero se mantiene la estructura.
    }
}

class ClaseHijo : ClaseBase
{
    // Esta línea generará un error de compilación.
}
