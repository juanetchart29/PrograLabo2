

internal class Program
{
    private static void Main(string[] args)
    {
        long partida = DateTime.Now.Second;
        Console.WriteLine("Ingrese su nombre");
        string nombre = Console.ReadLine();
        Console.WriteLine($"Your name is {nombre} and you get {DateTime.Now.Second - partida} to write your name");
    }
    
}