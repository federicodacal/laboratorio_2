using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class StringExtension
    {
        public static int ContarVocales(string texto)
        {
            int acumVocales = 0;
            char[] vocales = { 'a', 'e', 'i', 'o', 'u' };
            if (!string.IsNullOrWhiteSpace(texto))
            {
                texto = texto.Trim().ToLower();
                for (int i = 0; i < texto.Length; i++)
                {
                    if(vocales.Contains(texto[i]))
                    {
                        acumVocales++;
                    }
                }
            }
            return acumVocales;
        }
    }
}
