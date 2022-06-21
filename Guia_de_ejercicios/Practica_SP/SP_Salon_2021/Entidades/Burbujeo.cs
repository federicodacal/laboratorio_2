using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Burbujeo
    {
        public void MetodoInstancia()
        {
            throw new MiException("MiException lanzada en MetodoInstancia");
        }

        public static void MetodoClase()
        {
            try
            {
                Burbujeo burbujeo = new Burbujeo();
                burbujeo.MetodoInstancia();
            }
            catch (MiException ex)
            {
                throw new MiException($"MiException lanzada en MetodoClase\nStackTrace:{ex.StackTrace}");
            }
        }
    }
}
