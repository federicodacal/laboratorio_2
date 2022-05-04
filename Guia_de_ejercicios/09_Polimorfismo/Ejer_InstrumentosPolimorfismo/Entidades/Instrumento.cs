using System;

namespace Entidades
{
    public enum EClasificacion { Cuerdas, Vientos, Percusion }
    public enum ETipoGuitarra { Criolla, Electroacustica, Electrica }
    public class Instrumento
    {
        protected int codigo;
        protected string marca;

        public Instrumento(int codigo, string marca)
        {
            this.codigo = codigo;
            this.marca = marca;
        }

        public Instrumento(int codigo, string marca, EClasificacion clasificacion):this(codigo,marca)
        {
            this.Clasificacion = clasificacion;
        }

        // Propiedad autodefinida
        protected EClasificacion Clasificacion
        {
            get;
            set;
        }

        protected virtual string Mostrar()
        {
            return $"{this.GetType().Name} | {this.Clasificacion} | Marca: {this.marca} | Codigo: {this.codigo}";
        }

        public static bool operator ==(Instrumento i1, Instrumento i2)
        {
            bool rta = false;
            if(i1 is not null && i2 is not null)
            {
                rta = i1.codigo == i2.codigo && i1.GetType() == i2.GetType();
            }
            return rta;
        }

        public static bool operator !=(Instrumento i1, Instrumento i2)
        {
            return !(i1 == i2);
        }

        public override bool Equals(object obj)
        {
            Instrumento unInstrumento = obj as Instrumento;
            return unInstrumento is not null && this == unInstrumento;
        }

        public override int GetHashCode()
        {
            return codigo.GetHashCode();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

    }
}
