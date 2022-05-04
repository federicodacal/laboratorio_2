using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Guitarra : Instrumento
    {
        private int cantidadCuerdas;

        public Guitarra(int codigo, string marca, int cantidadCuerdas, EClasificacion clasificacion, ETipoGuitarra tipo) 
            :base(codigo, marca, clasificacion)
        {
            this.TipoGuitarra = tipo;
            this.cantidadCuerdas = cantidadCuerdas;
        }

        public Guitarra(EClasificacion clasificacion, ETipoGuitarra tipo, string marca, int codigo)
            :this(codigo,marca,6,clasificacion,tipo)
        {

        }

        // Propiedad autodefinida
        protected ETipoGuitarra TipoGuitarra
        {
            get;
            set;
        }

        protected override string Mostrar()
        {
            return base.Mostrar() + $"\nTipo: {this.TipoGuitarra} | Cuerdas: {this.cantidadCuerdas}";
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        /*
        public override bool Equals(object obj)
        {
            Guitarra unAGuitarra = obj as Guitarra;
            return unAGuitarra is not null && this == unAGuitarra;
        }
        */

    }
}
