using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Aprendete las tablas";
        Console.WriteLine("Ingrese que tabla desea aprenderse");
        int numero = int .Parse(Console.ReadLine());
        tabla(numero);

    }
    public static void tabla(int tabla)
    {
        Console.WriteLine($"La tabla del {tabla}:");
        StringBuilder awnser = new StringBuilder();
        for (int i = 1; i <= 10; i++)
        {
            awnser.AppendLine($"{tabla}x{i} = {tabla*i}");
        }
        Console.WriteLine(awnser.ToString());
    
    }
}