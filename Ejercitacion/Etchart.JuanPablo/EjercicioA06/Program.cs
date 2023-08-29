internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "EjercicioA06";

        Console.WriteLine("Ingrese dos años para sabaer cuales fueron todos los años viciestos en el medio de ambos");
        
        Console.WriteLine("ingrese el año mas chico");
        int añoUno = int.Parse(Console.ReadLine()); 
        Console.WriteLine("ingrese el año mas grande");
        int añoDos = int.Parse(Console.ReadLine());

        string mensaje = $"Los años biciestos entre {añoUno} y {añoDos} son";
        Console.WriteLine(mensaje);

        for (int i = añoUno; i < añoDos; i++)
        {
            if (i % 4 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}