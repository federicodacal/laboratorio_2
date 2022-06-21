using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Application.Files.Xml
{
    public class Xml<T> : IFile<T>
        where T : class
    {
        //private static string rutaBase;
        //static Xml()
        //{
        //    DirectoryInfo info = Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Xml_serialization"));
        //    Xml<T>.rutaBase = info.FullName;
        //}
        public bool Read(string file, out T data)
        {
            bool rta = false;
            try
            {
                using (StreamReader sr = new StreamReader($"{file}"))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(T));
                    data = xs.Deserialize(sr) as T;
                    rta = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Problema serializando xml: {ex.Message}", ex);
            }
            return rta;
        }

        public bool Save(string file, T data)
        {
            bool rta = false;
            try
            {
                using (StreamWriter sw = new StreamWriter($"{file}"))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(T));
                    xs.Serialize(sw, data);
                    rta = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Problema serializando xml: {ex.Message}", ex);
            }
            return rta;
        }
    }
}
