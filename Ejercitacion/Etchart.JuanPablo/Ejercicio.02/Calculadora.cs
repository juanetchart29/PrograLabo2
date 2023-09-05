using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._02
{
    internal class Calculadora
    {
        public static int Calcular(int operandoA, int operandoB,string operacion) 
        { 
            switch (operacion) 
            {
                case "+":
                    return operandoA + operandoB;
                case "-":
                    return operandoA - operandoB;
                case "*":
                    return operandoA * operandoB;   

                case "/":
                    bool okey = Validar(operandoB);
                    if (okey) { return operandoA / operandoB; }
                    Console.WriteLine("los enteros en reales no pueden dividirse por 0");
                    return 0;
                default:
                    Console.WriteLine("operacion no valida");
                    return 0;
            }
        }
        public static bool Validar(int dividendo)
        {
            if (dividendo == 0) return false;
            return true;
        }
    }
}
