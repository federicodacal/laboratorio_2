using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    namespace Botellas
    {
        public class Cerveza : Botella
        {
            public int medida;
            public TipoCerveza tipo;

            public Cerveza(string marca, double precio, int capacidad, TipoCerveza tipo)
                :this(marca, precio, capacidad, tipo, capacidad/3)
            {

            }

            public Cerveza(string marca, double precio, int capacidad, TipoCerveza tipo, int medida)
                :base(marca, precio, capacidad)
            {
                this.tipo = tipo;
                this.medida = medida;
            }

            public override double Ganancia
            {
                get { return this.precio + (this.precio * 0.5); }
            }

            protected override void ServirMedida()
            {
                this.contenido -= this.medida;
                if(this.contenido < this.medida)
                {
                    this.contenido = 0;
                }
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine(this.GetType().Name);
                sb.Append(base.ToString());
                sb.AppendLine($"TIPO: {this.tipo}");

                return sb.ToString();
            }

            public static bool operator ==(Cerveza a, Cerveza b)
            {
                bool rta = false;
                if (a is not null && b is not null)
                {
                    rta = (Botella)a == (Botella)b && a.tipo == b.tipo;
                }
                return rta;
            }

            public static bool operator !=(Cerveza a, Cerveza b)
            {
                return !(a == b);
            }

            public override bool Equals(object obj)
            {
                Cerveza otraCerveza = obj as Cerveza;
                return otraCerveza is not null && this == otraCerveza;
            }
        }

    }
}
