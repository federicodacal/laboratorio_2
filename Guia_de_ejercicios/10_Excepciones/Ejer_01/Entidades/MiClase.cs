using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MiClase
    {
        private int param;
        public MiClase()
        {
            try
            {
                MiClase.LanzarExcepcion();
            }
            catch (Exception e )
            {
                throw new UnaExcepcion(e.Message, e);
            }
        }

        public MiClase(int param)
        {
            this.param = param;
            try
            {
                MiClase c = new MiClase();

            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void LanzarExcepcion()
        {
            throw new DivideByZeroException();
        }
    }
}
