using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    public delegate void FinDeSalida(int bomberoIndex);

    public class Bombero : IArchivos<Bombero>, IArchivos<string>
    {
        private static string path;

        private string nombre;
        private List<Salidas> salidas;

        public event FinDeSalida MarcarFin;
        static Bombero()
        {
            DirectoryInfo info = Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Bomberos"));
            Bombero.path = info.FullName;
        }

        public Bombero()
        {
            this.salidas = new List<Salidas>();
        }

        public Bombero(string nombre):this()
        {
            this.nombre = nombre;
        }
        public string Nombre { get => nombre; set => nombre = value; }
        public List<Salidas> Salidas { get => salidas; set => salidas = value; }

        public void Guardar(Bombero info)
        {
            using (StreamWriter sw = new StreamWriter(Path.Combine(Bombero.path, "bombero.xml")))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Bombero));
                xs.Serialize(sw, info);
            }
        }

        public Bombero Leer()
        {
            using (StreamReader sr = new StreamReader(Path.Combine(Bombero.path, "bombero.xml")))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Bombero));
                Bombero objeto = xs.Deserialize(sr) as Bombero;
                return objeto;
            }
        }

        void IArchivos<string>.Guardar(string info)
        {
            LogDao log = new LogDao();

            log.Save(info);
        }

        string IArchivos<string>.Leer()
        {
            LogDao log = new LogDao();

            return log.Read();
        }

        public void AtenderSalida(object bomberoIndex)
        {
            if(this.Salidas != null)
            {
                Random random = new Random();

                Salidas nuevaSalida = new Salidas();
                this.Salidas.Add(nuevaSalida);
                
                Thread.Sleep(random.Next(2000, 4000));
     
                nuevaSalida.FinalizarSalida();

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Inicio: " + nuevaSalida.FechaInicio.ToLongDateString());
                sb.AppendLine("Fin: " + nuevaSalida.FechaFin.ToLongDateString());
                sb.AppendLine("Duracion: " + nuevaSalida.TiempoTotal + " minutos");

                ((IArchivos<string>)this).Guardar(sb.ToString());

                this.MarcarFin.Invoke((int)bomberoIndex);
            }

        }
    }
}
