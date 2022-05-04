using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cliente
    {
        private string nombre;
        private string apellido;
        private string domicilio;
        private string telefono;
        private List<Mascota> mascotas;

        public Cliente(string nombre, string apellido, string domicilio, string telefono)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.domicilio = domicilio;
            this.telefono = telefono;
            this.mascotas = new List<Mascota>();
        }

        public bool AgregarMascota(Mascota m)
        {
            bool rta = false;
            if(m is not null && this.mascotas is not null)
            {
                this.mascotas.Add(m);
                rta = true;
            }
            return rta;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"CLIENTE: {this.apellido} {this.nombre}");
            sb.AppendLine($"DOMICILIO: {this.domicilio} CONTACTO: {this.telefono}");
            sb.AppendLine($"Mascotas:\n");
            foreach (Mascota item in this.mascotas)
            {
                sb.AppendLine($"{item.Mostrar()}");
            }
            return sb.ToString();
        }
    }
}
