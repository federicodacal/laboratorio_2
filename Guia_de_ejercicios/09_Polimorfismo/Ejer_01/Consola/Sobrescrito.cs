using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    public abstract class Sobrescrito
    {
        protected string MiAtributo;

        public Sobrescrito()
        {
            MiAtributo = "Probar abstractos";
        }

        public abstract string MiPropiedad { get; }

        public abstract string MiMetodo();

        public override string ToString()
        {
            return "¡Este es mi método ToString sobrescrito! :D";
        }

        public override bool Equals(object obj)
        {
            return obj.GetType() == typeof(Sobrescrito);
            // return obj is Sobrescrito;
        }

        public override int GetHashCode()
        {
            return 111445462;
        }
    }
}
