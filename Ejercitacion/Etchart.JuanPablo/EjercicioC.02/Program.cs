using EjercicioC._02;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Vos cuantas primaveras tenes";

        Persona juan = new Persona("Juancito", DateTime.Parse("29/03/2007"),1234234);
        Persona carlos = new Persona("Carlitos", DateTime.Parse("19/07/2005"),1234234);
        Persona damian = new Persona("Damiancito", DateTime.Parse("09/12/2000"),1234234);

        juan.Mostrar();
        carlos.Mostrar();
        damian.Mostrar();
    }
}