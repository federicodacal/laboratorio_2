using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {
        private float altura;
        private float peso;
        private Posicion posicion;

        public Jugador(string nombre, string apellido, int edad, int dni, float peso, float altura, Posicion posicion) 
            :base(nombre, apellido, edad, dni)
        {
            this.peso = peso;
            this.altura = altura;
            this.posicion = posicion;
        }

        public float Alutra
        {
            get { return this.altura; }
        }

        public float Peso
        {
            get { return this.peso; }
        }

        public Posicion Posicion
        {
            get { return this.posicion; }
        }

        public override bool ValidarAptitud()
        {
            return this.Edad < 40 && this.ValidarEstadoFisico();
        }

        public bool ValidarEstadoFisico()
        {
            float imc = this.Peso / (float)Math.Pow(this.Alutra, 2);
            return imc >= 18.5F && imc <= 25;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.AppendLine($"Posicion: {this.Posicion}");
            sb.AppendLine($"Peso: {this.Peso}kgs. Altura: {this.Alutra}mts.");

            return sb.ToString();
        }
    }
}
