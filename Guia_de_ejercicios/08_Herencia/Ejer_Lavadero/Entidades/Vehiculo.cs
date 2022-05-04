using System;
using System.Text;

namespace Entidades
{
    public class Vehiculo
    {
        protected string patente;
        protected Byte cantRuedas;
        protected EMarcas marca;

        public Vehiculo(string patente, byte cantRuedas, EMarcas marca)
        {
            this.patente = patente;
            this.cantRuedas = cantRuedas;
            this.marca = marca;
        }

        protected string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Patente: {this.Patente}");
            sb.AppendLine($"Cantidad Ruedas: {this.cantRuedas}");
            sb.AppendLine($"Marca: {this.marca}");

            return sb.ToString();
        }

        public EMarcas Marca
        {
            get { return this.marca; }
        }

        public string Patente
        {
            get { return this.patente; }
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            bool rta = false;
            if(v1 is not null && v2 is not null)
            {
                rta = v1.patente == v2.patente && v1.marca == v2.marca;
            }
            return rta;
        }
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }


    }
}
