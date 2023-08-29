using System.Diagnostics;
internal class Program
{
    private static void Main()
    {
        pedirDato("ingrese su nombre ");
        imprimirString(nombrar());
    }

    public static void imprimirString(string str)
    {
        Console.WriteLine(str);
    }
    public static string nombrar()
    {
        Alumno juan = new Alumno();
        return juan.elMasLindo;
    }
    public static void pedirDato(string mensaje)
    {
        Console.WriteLine(mensaje);
        string nombre = Console.ReadLine();
        Console.WriteLine(nombre);
    }
}
internal class Alumno
{
    public string nombre = "Juancito";
    public string elMasLindo = "LucianoVega10 ;)";
}