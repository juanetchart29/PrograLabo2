//Ingresar un número y mostrar: el cuadrado y el cubo del mismo.
//Se debe validar que el número sea mayor que cero, caso contrario, mostrar el
//mensaje: "ERROR.
//¡Reingresar número!".

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "EjercicioA.02";
        Console.WriteLine("ingrese un numero mayor que 0");
        int numero = int.Parse(Console.ReadLine());
        while (numero <= 0) 
        {
            Console.WriteLine("Error, el numero no es mayor que 0 vuelva  a intentarlo");
            numero = int.Parse(Console.ReadLine());
        }
        Console.WriteLine($"el numero era {numero}, su cuadrado es {(Math.Pow(numero, 2))} y su cubo {Math.Pow(numero,3)}");
    }
}