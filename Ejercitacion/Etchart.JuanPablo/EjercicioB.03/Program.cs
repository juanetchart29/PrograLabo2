internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Calcular un factorial";
        Console.WriteLine("Ingrese un numero para saber su factorial");
        int nuemro = int.Parse(Console.ReadLine());
        int factorial=1;

        for (int i = 1; i <= nuemro; i++)
        {
            factorial *= i;
        }
        Console.WriteLine($"el factorial es: {factorial}");
    }
}