//[A.08] Recibos de sueldo
//Por teclado se ingresa el valor hora, el nombre, la antigüedad (en años) y la cantidad
//de horas trabajadas en el mes de N empleados de una fábrica.
//Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de
//multiplicar el valor hora por la cantidad de horas trabajadas), hay que sumarle la
//cantidad de años trabajados multiplicados por $15000, y al total de todas esas
//operaciones restarle el 13% en concepto de descuentos.
//Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total
//a cobrar en bruto, el total de descuentos y el valor neto a cobrar de todos los
//empleados ingresados.
//Nota: Utilizar estructuras repetitivas y selectivas.
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        
        int valorAntiguedad = 15000;
        int descuento = 13;
        int sueldoBruto;
        float sueldoFinal;
        string nombre;
        int antiguedad;
        int valorHora;
        while (true) 
        {
            Console.WriteLine("Ingrese el valor por hora:");
            valorHora = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la antiguedad(años):");
            antiguedad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de horas trabajadas en el mes :");
            int horasTabajadas = int.Parse(Console.ReadLine());


            sueldoBruto = horasTabajadas * valorHora + antiguedad *valorAntiguedad;

            sueldoFinal = sueldoBruto - sueldoBruto * descuento / 100;

            Console.WriteLine("------Facturacion-------");
            Console.WriteLine($"Empleado: {nombre}");
            Console.WriteLine($"La antiguedad que tiene en la empresa es: {antiguedad}");
            Console.WriteLine($"Valor * hora: {valorHora}");
            Console.WriteLine($"Sueldo bruto: {sueldoBruto}");
            Console.WriteLine($"Descuento: %{descuento}");
            Console.WriteLine($"Sueldo final: {sueldoFinal}");

            Console.WriteLine("Deseas ingresar otro empleado?:");
            string respuesta = Console.ReadLine();
            if (respuesta != "si")
            {
                break;
            }        

        }





    }

}