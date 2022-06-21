using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Files.Text
{
    public class Text<T> : IFile<string>
    {
        //private static string rutaBase;

        //static Text()
        //{
        //    Text<T>.rutaBase = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        //}

        public bool Read(string file, out string data)
        {
            bool rta = false;
            try
            {
                using (StreamReader sr = new StreamReader($"{file}.txt"))
                {
                    data = sr.ReadToEnd();
                    rta = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return rta;
        }

        public bool Save(string file, string data)
        {
            bool rta = false;
            try
            {
                using (StreamWriter sw = new StreamWriter($"{file}.txt"))
                {
                    sw.WriteLine(data);
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

