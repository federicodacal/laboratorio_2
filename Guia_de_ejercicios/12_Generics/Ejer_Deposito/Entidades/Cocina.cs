using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cocina
    {
        private int codigo;
        private bool esIndustrial;
        private double precio;

        public Cocina(int codigo, double precio, bool esIndustrial)
        {
            this.codigo = codigo;
            this.esIndustrial = esIndustrial;
            this.precio = precio;
        }

        public int Codigo
        {
            get { return this.codigo; }
        }

        public bool EsIndustrial
        {
            get { return this.esIndustrial; }
        }

        public double Precio
        {
            get { return this.precio; }
        }

        public static bool operator ==(Cocina c1, Cocina c2)
        {
            bool rta = false;
            if(c1 is not null && c2 is not null)
            {
                rta = c1.Codigo == c2.Codigo;
            }
            return rta;
        }

        public static bool operator !=(Cocina c1, Cocina c2)
        {
            return !(c1 == c2);
        }

        public override bool Equals(object obj)
        {
            Cocina otraCocina = obj as Cocina;
            return otraCocina is not null && this == otraCocina;
        }

        public override string ToString()
        {
            return $"Cocina \nCodigo: {this.Codigo} - Industrial: {this.EsIndustrial} - Precio: {String.Format("{0:00.00}", this.precio)}";
        }

    }
}
