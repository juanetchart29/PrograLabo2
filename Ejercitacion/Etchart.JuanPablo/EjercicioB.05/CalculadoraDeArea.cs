using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioB._05
{
    internal class CalculadoraDeArea
    {
        public double CalculadoraAreaCuadrado(double longitudLado)
        {
            return Math.Pow(longitudLado, 2);
        }
        public double CalcularAreaTriangulo(double baseTriangulo, double alturaTriangulo ) 
        {
            return baseTriangulo * alturaTriangulo;
        }
        public double CalcularAreaCirculo(double radio)
        {
            return Math.PI* Math.Pow(radio,2);
        }

    }
}
