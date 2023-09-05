using Ejercicio._02;

internal class Program
{
    private static void Main(string[] args)
    {
        
        Console.Title = "La calculadora";
        Console.WriteLine("-----Calculcadora-----");

        Console.WriteLine("Ingrese el primer numero");
        int numero1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero");
        int numero2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el operador");
        string operacion = Console.ReadLine();

        int respuesta = Calculadora.Calcular(numero1, numero2, operacion);
        Console.WriteLine(respuesta);


    }
    
}