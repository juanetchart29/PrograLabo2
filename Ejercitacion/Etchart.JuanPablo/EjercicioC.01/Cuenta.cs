using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioC._01
{
    public class Cuenta
    {
        private static float cantidad;
        private string titular;



         public Cuenta(string nombre,float cantidad)
         {
            this.titular = nombre;
            Cuenta.cantidad = cantidad; 

         }


        public string getTitular() { return this.titular; }
        public float getCantidad() {  return Cuenta.cantidad; }

        public void mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.titular);
            sb.AppendLine(Cuenta.cantidad.ToString());
            Console.WriteLine(sb.ToString());
        }
        public void ingresar(float monto)
        {

            if (monto < 0)
            {
                Console.WriteLine("el monto es menor que 0 no se le agregara nada a la cuenta");
            }
            else
            {
                Cuenta.cantidad += monto;
                Console.WriteLine($"Se ha ingresado el monto: {monto}");
            }
        }

        public void recibir(float monto)
        {
            Cuenta.cantidad -= monto;
            Console.WriteLine($"Se ha retirado el monto: {monto}");
        }

    }
}
