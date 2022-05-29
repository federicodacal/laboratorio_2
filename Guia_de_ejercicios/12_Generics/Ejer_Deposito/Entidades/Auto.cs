using System;

namespace Entidades
{
    public class Auto
    {
        private string marca;
        private string color;

        public Auto(string color, string marca)
        {
            this.marca = marca;
            this.color = color;
        }

        public string Marca
        {
            get { return this.marca; }
        }

        public string Color
        {
            get { return this.color; }
        }

        public static bool operator ==(Auto a1, Auto a2)
        {
            bool rta = false;
            if(a1 is not null && a2 is not null)
            {
                rta = a1.Color == a2.Color && a1.Marca == a2.Marca;
            }
            return rta;
        }

        public static bool operator !=(Auto a1, Auto a2)
        {
            return !(a1 == a2);
        }

        public override bool Equals(object obj)
        {
            Auto otroAuto = obj as Auto;
            return otroAuto is not null && this == otroAuto;
        }

        public override string ToString()
        {
            return $"Auto \nMarca: {this.Marca} - Color: {this.Color}";
        }
    }
}
