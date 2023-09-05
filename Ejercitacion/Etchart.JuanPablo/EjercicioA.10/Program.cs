using System.Reflection;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("ingrese la altura");
        int altura = int.Parse(Console.ReadLine());
        
        int ancho = 1;

        int izquierda = 0;
        for (int i = 0; i < altura; i++) 
        {
            for (int j = 0; j < altura*2; j++) 
            {
                if (altura < j-izquierda || altura > j + izquierda) 
                {
                    Console.Write(" ");
                
                }else
                {
                    Console.Write('*');
                }

            }
            Console.WriteLine("");
            izquierda++;
            ancho += 2;
        }
       
    }
}