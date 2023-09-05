using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase._01
{

    internal class Creadora
    {
        public static DateTime fechaCreacionPrimerObjeto;
        public static int contadorObjetosCreados = 0;

        public DateTime fechaCreacion;


        static Creadora() 
        {
            fechaCreacionPrimerObjeto = DateTime.Now;
            Console.WriteLine("first time");
        }
        public Creadora()
        {
            this.fechaCreacion = DateTime.Now;
            //Console.WriteLine(fechaCreacion);
            Creadora.contadorObjetosCreados++;
        }



        public static int obtenerCantidadObjetosCreados()
        {
            return Creadora.contadorObjetosCreados;
        }

        public string ObtenerDiferencia()
        {
            Console.WriteLine($"la diferencia entre {fechaCreacionPrimerObjeto.Millisecond} y {fechaCreacion.Millisecond} es: ");
            return (this.fechaCreacion - Creadora.fechaCreacionPrimerObjeto).Milliseconds.ToString();

        }



    }
}
