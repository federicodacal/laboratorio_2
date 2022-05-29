using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public abstract class Aplicacion
    {
        protected string nombre;
        protected SistemaOperativo sistemaOperativo;
        protected int tamanioMb;

        protected Aplicacion(string nombre, SistemaOperativo sistemaOperativo, int tamanioMb)
        {
            this.nombre = nombre;
            this.sistemaOperativo = sistemaOperativo;
            this.tamanioMb = tamanioMb;
        }

        public SistemaOperativo SistemaOperativo
        {
            get { return this.sistemaOperativo; }
        }

        protected abstract int Tamanio { get; }

        public virtual string ObtenerInformacionApp()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(this.GetType().Name);
            sb.AppendLine($" {this.nombre}");
            sb.AppendLine($"Sistema Operativo: {this.SistemaOperativo}");
            sb.AppendLine($"Tamaño: {this.Tamanio} mb");

            return sb.ToString();
        }

        public static implicit operator Aplicacion(List<Aplicacion> listaApp)
        {
            Aplicacion a = null;
            if(listaApp is not null)
            {
                foreach (Aplicacion item in listaApp)
                {
                    if(a is null || item.Tamanio > a.Tamanio)
                    {
                        a = item;
                    }
                }
            }
            return a;
        }

        public static bool operator ==(List<Aplicacion> lista, Aplicacion app)
        {
            bool rta = false;
            if(lista is not null && app is not null)
            {
                foreach (Aplicacion item in lista)
                {
                    if(item.nombre == app.nombre)
                    {
                        rta = true;
                        break;
                    }
                }
            }
            return rta;
        }

        public static bool operator !=(List<Aplicacion> lista, Aplicacion app)
        {
            return !(lista == app);
        }

        public static bool operator +(List<Aplicacion> lista, Aplicacion app)
        {
            bool rta = false;
            if(lista != app)
            {
                lista.Add(app);
                rta = true;
            }
            return rta;
        }

        public override string ToString()
        {
            return this.nombre;
        }


    }
}
