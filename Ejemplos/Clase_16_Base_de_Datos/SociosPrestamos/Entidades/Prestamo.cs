using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Prestamo
    {
        private int id;
        private string descripcion;
        private long dniSocio;
        private Socio socio;

        public Prestamo(int id, string descripcion, Socio socio):this(id, descripcion, socio.Dni)
        {
            this.socio = socio;
        }

        public Prestamo(int id, string descripcion, long dniSocio)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.dniSocio = dniSocio;
        }

        public int Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public Socio Socio { get => socio; set => socio = value; }
        public long DniSocio { get => dniSocio; set => dniSocio = value; }

        public override string ToString()
        {
            return $"{this.Id}: {this.Descripcion}";
        }
    }
}
