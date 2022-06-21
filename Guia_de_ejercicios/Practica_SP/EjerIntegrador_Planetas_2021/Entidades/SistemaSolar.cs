using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    public class SistemaSolar<T> : ISerializable
        where T : Planeta
    {
        protected List<T> lista;
        protected int capacidad;

        public SistemaSolar()
        {
            this.lista = new List<T>();
        }

        public SistemaSolar(int capacidad):this()
        {
            this.capacidad = capacidad;
        }

        public string Path 
        {
            get { return System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "integradorSistemaSolar"); } 
        }

        public List<T> Lista { get => lista; }
        public int Capacidad { get => capacidad; set => capacidad = value; }

        public bool Agregar(Planeta planeta)
        {
            bool rta = false;

            if(this.capacidad > this.lista.Count)
            {
                if (planeta != null)
                {
                    this.lista.Add((T)planeta);
                    rta = true;
                }
            }
            else
            {
                throw new NoHayLugarException();
            }
            return rta;
        }

        public string DeserializarXml()
        {
            try
            {
                using (StreamReader sr = new StreamReader(System.IO.Path.Combine(this.Path, "sistemaSolar.xml")))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(SistemaSolar<T>));
                    SistemaSolar<T> objeto = xs.Deserialize(sr) as SistemaSolar<T>;
                    return objeto.ToString();
                }
            }
            catch
            {
                throw;
            }
        }

        public bool SerializarXml()
        {
            bool rta = false;
            try
            {
                if (!Directory.Exists(this.Path))
                {
                    Directory.CreateDirectory(this.Path);
                }

                using (StreamWriter sw = new StreamWriter(System.IO.Path.Combine(this.Path, "sistemaSolar.xml")))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(SistemaSolar<T>));
                    xs.Serialize(sw, this);
                    rta = true;
                }
            }
            catch
            {
                throw;
            }
            return rta;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Sistema Solar:");
            foreach (Planeta item in this.Lista)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
    }
}
