using System;

namespace Entidades
{
    public class Calculadora 
    {
        public double Dividir(double dividendo, double divisor)
        {
            double resultado = double.MinValue;
            if(divisor != 0)
            {
                resultado = dividendo / divisor;
            }
            return resultado;
        }
    }
}
