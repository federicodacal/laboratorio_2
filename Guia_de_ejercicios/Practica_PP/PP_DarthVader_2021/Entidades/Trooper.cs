using System;
using System.Text;

namespace Entidades
{
    public abstract class Trooper
    {
        protected Blaster armamento;
        protected bool esClon;

        public Trooper(Blaster armamento)
            :this(armamento, false)
        {

        }

        public Trooper(Blaster armamento, bool esClon)
        {
            this.armamento = armamento;
            this.esClon = esClon;
        }

        public Blaster Armamento
        {
            get { return this.armamento; }
        }

        public bool EsClon
        {
            get { return this.esClon; }
            set { this.esClon = value; }
        }

        public abstract string Tipo { get; }

        public virtual string InfoTrooper()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{this.Tipo} armado con {this.Armamento}, ");
            if (esClon)
            {
                sb.Append("SI ");
            }
            else
            {
                sb.Append("NO ");
            }
            sb.AppendLine("es clone");

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return this.GetType() == obj.GetType();
        }
    }
}
