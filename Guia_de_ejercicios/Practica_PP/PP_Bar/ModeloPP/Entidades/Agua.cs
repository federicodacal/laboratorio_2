using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    namespace Botellas
    {
        public class Agua : Botella
        {
            public TipoAgua tipo;

            public Agua(string marca, double precio, int capacidad, TipoAgua tipo)
                :base(marca, precio, capacidad)
            {
                this.tipo = tipo;
            }

            public Agua(string marca, double precio, TipoAgua tipo)
                :this(marca, precio, 500, tipo)
            {

            }

            public override double Ganancia
            {
                get { return this.precio + (this.precio * 0.25); }
            }

            protected override void ServirMedida()
            {
                this.contenido = 0;
            }

            public static bool operator ==(Agua a, Agua b)
            {
                bool rta = false;
                if(a is not null && b is not null)
                {
                    rta = (Botella)a == (Botella)b && a.tipo == b.tipo;
                }
                return rta;
            }

            public static bool operator !=(Agua a, Agua b)
            {
                return !(a == b);
            }

            public override bool Equals(object obj)
            {
                Agua otraAgua = obj as Agua;
                return otraAgua is not null && this == otraAgua;
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine(this.GetType().Name);
                sb.Append(base.ToString());
                sb.AppendLine($"TIPO: {this.tipo}");

                return sb.ToString();
            }
        }

    }
}
