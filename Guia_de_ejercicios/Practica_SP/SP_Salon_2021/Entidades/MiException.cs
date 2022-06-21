using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MiException : Exception
    {

        public MiException(string message):base(message)
        {
            this.EscribirLog(message);
        }

        public MiException(string message, Exception innerException):base(message, innerException)
        {
            this.EscribirLog(message);
        }

        private void EscribirLog(string message)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "burbujeo.log"), true))
                {
                    sw.WriteLine(DateTime.Now.ToString());
                    sw.WriteLine(message);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
