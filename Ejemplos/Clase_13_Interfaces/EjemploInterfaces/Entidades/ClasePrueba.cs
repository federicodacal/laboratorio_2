using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClasePrueba
    {
        public static string Probar(IMensaje mensaje)
        {
            return mensaje.EnviarMensaje();
        }
    }
}
