using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class OtraClase
    {
        public void InstanciarMiClase()
        {
            try
            {
                MiClase c = new MiClase(1);
            }
            catch (Exception e)
            {
                throw new MiExcepcion(e.Message, e);
            }
        }
    }
}
