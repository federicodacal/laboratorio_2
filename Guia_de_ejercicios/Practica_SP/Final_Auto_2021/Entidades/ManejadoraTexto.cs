using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ManejadoraTexto
    {
        public static bool EscribirArchivo(List<Auto> lista)
        {
            bool rta = false;
            try
            {
                using (StreamWriter sw = new StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "autos.log"), true))
                {
                    sw.WriteLine(DateTime.Now.ToString());
                    foreach (Auto item in lista)
                    {
                        sw.WriteLine(item.ToString());
                    }
                    rta = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return rta;
        }
    }
}
