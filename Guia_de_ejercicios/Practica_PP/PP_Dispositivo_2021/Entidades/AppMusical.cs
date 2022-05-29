using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AppMusical : Aplicacion
    {
        private List<string> listaCanciones;

        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanioMb)
            :this(nombre, sistemaOperativo, tamanioMb, new List<string>())
        {

        }

        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanioMb, List<string> canciones)
            :base(nombre, sistemaOperativo, tamanioMb)
        {
            this.listaCanciones = canciones;
        }

        protected override int Tamanio
        {
            get 
            {
                return this.tamanioMb + this.listaCanciones.Count * 2;
            }
        }

        public override string ObtenerInformacionApp()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ObtenerInformacionApp());
            sb.AppendLine("Lista de canciones: ");
            foreach (string item in this.listaCanciones)
            {
                sb.AppendLine(item);
            }

            return sb.ToString();
        }
    }
}
