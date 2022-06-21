using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Files.Text;

namespace Application.Helpers
{
    public static class Logger
    {
        private static string rutaBase;
        static Logger()
        {
            Logger.rutaBase = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        public static void LogException(string log)
        {
            // TODO: implementar. Debe registara fecha,hora y mensaje de cada excepcion en un archivo de text, 
            //El archivo se tiene que guardar en el escritorio
            try
            {
                using (StreamWriter sw = new StreamWriter($"{Logger.rutaBase}\\log_exception.txt", true))
                {
                    sw.WriteLine(log);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

    }
  
}
