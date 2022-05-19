using System;

namespace Entidades
{
    public class Calculadora
    {
        public static int Add_I(string parametro)
        {
            int resultado = 0;
            int num1;
            int num2;
            if (!String.IsNullOrWhiteSpace(parametro))
            {
                string[] numeros = parametro.Trim().Split(',');
                if(int.TryParse(numeros[0], out num1))
                {
                    resultado = num1;

                    if(int.TryParse(numeros[1], out num2))
                    {
                        resultado += num2;
                    }
                }
            }
            return resultado;
        }

        public static int Add_II(string parametro)
        {
            int resultado = 0;
            int num;

            if (!String.IsNullOrWhiteSpace(parametro))
            {
                string[] numeros = parametro.Trim().Split(',');
                for (int i = 0; i < numeros.Length; i++)
                {
                    if(int.TryParse(numeros[i], out num))
                    {
                        resultado += num;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return resultado;
        }

        public static int Add_III(string parametro)
        {
            int resultado = 0;
            int num;

            if (!String.IsNullOrWhiteSpace(parametro))
            {
                string[] numeros = parametro.Trim().Split(',');
                for (int i = 0; i < numeros.Length; i++)
                {
                    if (int.TryParse(numeros[i], out num))
                    {
                        if(num < 0)
                        {
                            throw new NegativoNoPermitidoException($"No se admiten numeros negativos. Se ingresó {num}");
                        }
                        resultado += num;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return resultado;
        }
    }
}
