using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    public static class Calculadora
    {
        public static float Calcular(int x, int y, char operacion)
        {
            float resultado = 0;
            switch (operacion)
            {
                case '+':
                    resultado = x + y;
                    break;
                case '-':
                    resultado = x - y;
                    break;
                case '/':
                    if(Calculadora.ValidarOperando(y))
                    {
                        resultado = (float) x / y;
                    }
                    break;
                case '*':
                    resultado = x * y;
                    break;
            }
            return resultado;
        }

        public static bool ValidarOperando(int y)
        {
            return y != 0;
        }

        public static bool ValidarOperador(char operador)
        {
            return operador == '+' || operador == '-' || operador == '/' || operador == '0';
        }
    }
}
