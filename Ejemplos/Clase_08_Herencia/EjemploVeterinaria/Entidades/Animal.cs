using System;
using System.Text;

namespace Entidades
{
    public abstract class Animal
    {
        private string nombre;
        private float peso;

        public Animal(string nombre, float peso)
        {
            this.nombre = nombre;
            this.peso = peso;
        }

        public string Nombre
        {
            get { return this.nombre; }
        }

        public float Peso
        {
            get { return this.peso; }
            set 
            {
                if(value > 0 && value < 300)
                {
                    this.peso = value;
                }
            }
        }

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Nombre} es {this.GetType().Name}");
            sb.AppendLine($"Peso: {this.Peso}kg");

            return sb.ToString();
        }

        public abstract string Alimentarse();

        public override string ToString()
        {
            return "Con ToString()\n" + this.Mostrar();
        }

    }
}
