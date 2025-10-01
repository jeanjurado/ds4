class ClaseBase
{
    public void test()
    {
        // El cuerpo del método está vacío.
    }

    public sealed override void masTests()
    {
        // El cuerpo del método está vacío.
    }
}

class ClaseHijo : ClaseBase
{
    public override void masTests()
    {
        // Este método generará un error de compilación.
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Corrio la aplicacion");
    }
}