
using System.Runtime.ConstrainedExecution;
/// <summary>
/// [A.07] ¿Cuántos días viviste?
//Hacer un programa que pida por pantalla la fecha de nacimiento de una persona
//(día, mes y año) y calcule el número de días vividos por esa persona hasta la fecha
//actual (tomar la fecha del sistema con DateTime.Now).
//Nota: Utilizar estructuras selectivas.Tener en cuenta los años bisiestos.
/// </summary>
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

}