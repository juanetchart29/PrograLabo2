internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "EjercicioA.04";

        int cont_encontrados = 0;

        int numero = 1;
        int acumulador = 0;

        while (cont_encontrados<5) 
        {
            for (int i = 1; i < numero; i++) 
            {
                if (numero % i  == 0)
                {
                    acumulador += i;

                }
                if (acumulador == numero)
                {
                    Console.WriteLine($"se ha encontrado el numero perfecto {numero},vuelta {cont_encontrados}");
                    cont_encontrados++;
                    numero++;
                }
                
            }

            numero++;
            acumulador = 0;
        }
    }
}