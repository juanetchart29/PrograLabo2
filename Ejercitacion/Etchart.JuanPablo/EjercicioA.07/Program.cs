internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "EjercicioA.07";
        Console.WriteLine("ingrese su fecha de nacimiento en dd/mm/year");
        EasyWay();
    }
    public static void EasyWay()
    {
        Console.WriteLine("ingrese su fecha de nacimiento en dd/mm/year");
        string fechaNacimiento =Console.ReadLine();
        Console.WriteLine($"{(DateTime.Now.Date - DateTime.Parse(fechaNacimiento)).Days}");
    }
    public static void HardWay()
    {

    }
}