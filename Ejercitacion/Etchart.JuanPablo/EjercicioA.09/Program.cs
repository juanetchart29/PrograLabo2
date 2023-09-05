internal class Program
{
    private static void Main(string[] args)
    {
        int altura = int.Parse(Console.ReadLine());
        int largo = 1;


        for (int i = 0; i < altura; i++) 
        {
            for (int j = 0; j < largo; j++) 
            {
                Console.Write("*");
            }
            Console.WriteLine("");
            largo += 1;
        }
    }
}