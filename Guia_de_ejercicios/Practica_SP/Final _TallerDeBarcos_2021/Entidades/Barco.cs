using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    public enum ETipoBarco { Pirata, Marina }
    public enum EOperacion { Reparar_Mastil, Pintar, Cambiar_Velas, Reparar_Mascaron, Reparar_Casco, Recargar_Caniones }

    [XmlInclude(typeof(Marina))]
    [XmlInclude(typeof(Pirata))]
    public abstract class Barco
    {
        protected float costo;
        protected bool estadoReparado;
        protected string nombre;
        protected EOperacion operacion;
        protected int tripulacion;

        public Barco()
        {

        }

        public Barco(string nombre, EOperacion operacion)
        {
            this.nombre = nombre;
            this.operacion = operacion;
        }

        public float Costo
        {
            get { return this.costo; }
            set { this.costo = value; }
        }

        public bool EstadoReparado
        {
            get { return this.estadoReparado; }
            set { this.estadoReparado = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public EOperacion Operacion
        {
            get { return this.operacion; }
            set { this.operacion = value; }
        }

        public abstract int Tripulacion { get; }

        public abstract void CalcularCosto();

        public static bool operator ==(Barco b1, Barco b2)
        {
            bool rta = false;
            if(!(b1 is null && b2 is null))
            {
                rta = b1.Nombre == b2.Nombre;
            }
            return rta;
        }

        public static bool operator !=(Barco b1, Barco b2)
        {
            return !(b1 == b2);
        }

        public static explicit operator string(Barco b)
        {
            return $"{b.Costo}";
        }
    }
}
