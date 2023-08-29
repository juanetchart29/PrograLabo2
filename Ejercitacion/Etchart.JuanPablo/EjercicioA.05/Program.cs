internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "ejercicioA05";
        Console.WriteLine("Centros numericos");

        int acumuladorA = 0;
        int acumuladorB = 0;

        int tryIntentoNumerico = 1;
        Console.WriteLine("Ingrese el numero final:");
        int numeroFinal =  int.Parse(Console.ReadLine());// no olvidarme de paresearlo 

        while (true) 
        {
            for (int j = 1; j < tryIntentoNumerico; j++)
            {
                acumuladorA += j;
            }        

            for (int k = tryIntentoNumerico+1; k <=  numeroFinal; k++) 
            { 
                acumuladorB += k; 
            } 

            //Console.WriteLine($"{acumuladorA}--{acumuladorB}");
            
            if (acumuladorA == acumuladorB )
            {
                Console.WriteLine($"el centro numerico = {tryIntentoNumerico}");
                break;
            }
            tryIntentoNumerico++;
            acumuladorA = 0;
            acumuladorB = 0;
        }





        


    }
}