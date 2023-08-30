
using EjercicioI._01;

internal class Program
{
    private static void Main(string[] args)
    {
        bool bandera = true;
        int valorMaximo=0;
        int valorMinimo=0;
        int promedio;

        int acumulador = 0;
        int numeroIngresado;
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"{i + 1}- ingrese un numero entre -100 y 100:");
            numeroIngresado = int.Parse(Console.ReadLine());
            bool correcto = Validador.Validar(numeroIngresado, -100, 100);

            while (!correcto)
            {
                Console.WriteLine($"{i + 1}- error, ingrese un numero entre -100 y 100:");
                numeroIngresado = int.Parse(Console.ReadLine());
                correcto = Validador.Validar(numeroIngresado, -100, 100);
            }

            if (bandera)
            {
                valorMaximo = numeroIngresado;
                valorMinimo = numeroIngresado;
                bandera = false;
            }

            if (valorMaximo < numeroIngresado)
            {
                valorMaximo = numeroIngresado;
            }
            if (valorMinimo > numeroIngresado)
            {
                valorMinimo = numeroIngresado;
            }


            acumulador += numeroIngresado;
        }
        promedio = acumulador / 10;
        Console.WriteLine($"El numero mas alto fue el {valorMaximo}");
        Console.WriteLine($"El numero mas alto fue el {valorMinimo}");
        Console.WriteLine($"El numero mas alto fue el {promedio}");
    }
}