using EjercicioClase._01;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Clase Creadora";

        Creadora juan = new Creadora();
        Creadora luciano = new Creadora(); 
        Creadora mariano = new Creadora(); 
        Creadora luis = new Creadora();

        Console.WriteLine($"la diferencia es {juan.ObtenerDiferencia()}");
        Console.WriteLine($"la diferencia es {luciano.ObtenerDiferencia()}");
        Console.WriteLine($"la diferencia es {mariano.ObtenerDiferencia()}");
        Console.WriteLine($"la diferencia es {luis.ObtenerDiferencia()}");

        Console.WriteLine(Creadora.obtenerCantidadObjetosCreados());
    }
}