using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto
    {
        protected string color;
        protected int kms;
        protected string marca;
        protected string modelo;
        protected string patente;

        public Auto(string marca, string modelo, int kms, string color, string patente)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.kms = kms;
            this.color = color;
            this.patente = patente;
        }

        public string Color { get => color;  }
        public int Kms { get => kms; }
        public string Marca { get => marca;  }
        public string Modelo { get => modelo; }
        public string Patente { get => patente; }

        public override string ToString()
        {
            return $"Marca: {this.Marca} – Modelo: {this.Modelo} – Kms: {this.Kms} – Color: {this.Color} – Patente: {this.Patente}";
        }
    }
}
