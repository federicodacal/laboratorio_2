using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mago : Personaje
    {
        private int puntosDeMana;

        public Mago()
        {

        }

        public Mago(int puntosDeVida, string nombre, int puntosDeMana) 
            :base(puntosDeVida, nombre)
        {
            this.puntosDeMana = puntosDeMana;
        }

        public int PuntosDeMana { get => puntosDeMana; set => puntosDeMana = value; }

        public override string ToString()
        {
            return $"{base.ToString()} | Puntos de Mana: {this.PuntosDeMana}";
        }
    }
}
