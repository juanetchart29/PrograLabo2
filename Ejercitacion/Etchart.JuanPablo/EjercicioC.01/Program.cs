using EjercicioC._01;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Creo que necesito un prestamo";

        Console.WriteLine("------Programa-------");

        Cuenta miCuenta = new Cuenta("Juancito", 4234);



        StringBuilder sb = new StringBuilder();
        Console.WriteLine($"Bienvenido {miCuenta.getTitular()}");

        sb.AppendLine("Que accion desea realizar?");
        sb.AppendLine("1- consultar");
        sb.AppendLine("2- ingresar");
        sb.AppendLine("3- extraer");

        while (true)
        {
            Console.WriteLine(sb.ToString());
            int respuesta = int.Parse(Console.ReadLine());
            switch (respuesta)
            {
                case 1:
                    Console.WriteLine($"Su saldo acutal es de {miCuenta.getCantidad()}");
                    break;
                case 2:
                    bool esBobo = float.TryParse(Console.ReadLine(), out float valor);
                    while (esBobo)
                    {
                        Console.WriteLine("Usted es un bobo, VUELVA intentarlo");
                        esBobo = float.TryParse(Console.ReadLine(), out valor);
                    }
                    miCuenta.ingresar(valor);
                    Console.WriteLine($"Se Ha ingresado{valor}");
                    break;
                case 3:

                default:
                    Console.WriteLine("le has pifiado tioo");
                    break;
            }






            Console.WriteLine("Si desea Salir precione 's' ");
            string salir = Console.ReadLine();
            if (salir == "s" || salir == "S")
            {
                break;
            }

        }
    }
}