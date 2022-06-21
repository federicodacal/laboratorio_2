using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    public class XmlManager : IArchivos<List<Barco>>
    {
        public bool Guardar(List<Barco> entidad, string path)
        {
            bool rta = false;
            using (StreamWriter sw = new StreamWriter(path))
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<Barco>));
                xs.Serialize(sw, entidad);
                rta = true;
            }
            return rta;
        }

        public List<Barco> Leer(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<Barco>));
                List<Barco> objeto = xs.Deserialize(sr) as List<Barco>;
                return objeto;
            }
        }
    }
}
