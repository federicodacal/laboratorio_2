using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Entidades
{
    public class ClaseGenerica<T,U> : ISerializable<T,U>
    {
        protected List<T> items;
        protected U atributo;    

        public ClaseGenerica()
        {
            this.items = new List<T>();
        }

        public ClaseGenerica(U atributo):this()
        {
            this.atributo = atributo;
        }

        public List<T> Items
        {
            get { return this.items; }
        }

        public U Atributo
        {
            get { return this.atributo; }
            set { this.atributo = value; }
        }

        public void Add(T item)
        {
            this.items.Add(item);
        }

        public void Remove(int index)
        {
            if(index <= this.items.Count && index >= 0)
            {
                this.items.RemoveAt(index);
            }
        }

        public bool Serializar(string path)
        {
            bool rta = false;
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                path = Path.Combine(path, $"{DateTime.Now.ToString("HH_mm_ss")}.xml");

                using (StreamWriter sw = new StreamWriter(path))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(ClaseGenerica<T, U>));
                    xs.Serialize(sw, this);
                    rta = true;
                }
            }
            catch (Exception e)
            {
                throw new XmlSerializationException($"Ocurrió un problema Serializando: {e.Message}", e);
            }
            return rta;
        }

        public bool Deserializar(string path, out ClaseGenerica<T, U> objeto)
        {
            bool rta = false;
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(ClaseGenerica<T, U>));
                    objeto = xs.Deserialize(sr) as ClaseGenerica<T, U>;
                    rta = true;
                }
            }
            catch (Exception e)
            {
                throw new XmlSerializationException($"Ocurrió un problema Deserializando: {e.Message}", e);
            }
            return rta;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Atributo: {this.atributo}");
            sb.AppendLine("Lista de items: ");
            foreach (T item in this.items)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }

    }
}
