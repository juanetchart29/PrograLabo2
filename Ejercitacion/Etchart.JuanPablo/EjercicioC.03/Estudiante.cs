using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioC._03
{
    internal class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private Random random = new Random();

        public Estudiante() 
        {

        }

        public double CalcularNotaFinal()
        {
            if(notaPrimerParcial>3 && notaSegundoParcial > 3)
            {
                double notaFinal = random.NextDouble()*(4)+6;// hago el numero random * 4 ya que varia entre 6 y 10
                return notaFinal;
            }
            else
            {
                return -1;
            }
        }


        private float CalcularPromedio()
        {
            return (this.notaPrimerParcial + this.notaSegundoParcial) / 2;
        }
        //private static Estudiante()
        //{

        //}
        public Estudiante(string nombre,string apellido,string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;   
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder(); 
            sb.AppendLine($"Alumno: {this.nombre} {this.apellido}. {this.legajo}");
            sb.AppendLine($"Primer parcial: {this.notaPrimerParcial}");
            sb.AppendLine($"Segundo parcial: {this.notaSegundoParcial}");
            sb.AppendLine($"Promedio:{CalcularPromedio()}");
            if (CalcularNotaFinal()>0)
            {
                sb.AppendLine($"Nota final {CalcularNotaFinal()}");
            }
            else
            {
                sb.AppendLine("Alumno desaprobado");
            }
            return sb.ToString();
        }
        public void SetNotaPrimerParcial(int nota)
        {
            this.notaPrimerParcial = nota;
        }
        public void SetNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial = nota;
        }







    }
}
