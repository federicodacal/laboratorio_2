using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    public static class ClaseEstatica
    {
        public static string MiMetodoEstatico(string value)
        {
            MiClase miClase;
            try
            {
                miClase = new MiClase(value);
            }
            catch(MensajeInvalidoException exception)
            {
                throw new Exception($"Excepción capturada y lanzada en MiMetodoEstatico \n{exception.Message}", exception);
            }

            return miClase.Mensaje;
        }

        public static void MiOtroMetodoEstatico(string value)
        {
            try
            {
                MiMetodoEstatico(value);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
