using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioC._02
{
    internal class Persona
    {
        string nombre;
        DateTime fechaDeNacimiento;
        int dni;


        public Persona(string nombre, DateTime fechaDeNacimiento,int dni)
        { 
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }

        public string GetNombre() { return this.nombre; }
        public string GetFecha() { return this.fechaDeNacimiento.ToString(); }
        public int GetDni() { return this.dni; }
        
        private int CalcularEdad() { return (DateTime.Now.Year-this.fechaDeNacimiento.Year); }

        public string EsMayorDeEdad()
        {
            string respuesta;
            if (CalcularEdad()>= 18)
            {
                respuesta = "Es mayor de edad";
            }
            else
            {
                respuesta = "No es mayor de edad";
            }
            return respuesta;
        }
        public void Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"El nombre es: {this.GetNombre()}");
            sb.AppendLine($"La fecha de nacimiento es: {GetFecha()}");
            sb.AppendLine($"El Dni es: {GetDni()}");
            sb.AppendLine($"{GetNombre()} tinene {CalcularEdad()} años");
            sb.AppendLine(EsMayorDeEdad());
            Console.WriteLine( sb.ToString() ); 
        }

    }
}
