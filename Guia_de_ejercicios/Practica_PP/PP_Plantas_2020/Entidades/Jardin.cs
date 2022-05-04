using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jardin
    {
        public enum Tipo { Terrozo, Arenozo }

        private static Tipo suelo;
        private List<Planta> plantas;
        private int espacioTotal;

        static Jardin()
        {
            Jardin.suelo = Tipo.Terrozo;
        }

        private Jardin()
        {
            this.plantas = new List<Planta>();
        }

        public Jardin(int espacio):this()
        {
            this.espacioTotal = espacio;
        }

        public static Tipo Suelo
        {
            set { Jardin.suelo = value; }
        }

        private int EspacioOcupado(Planta planta)
        {
            return this.EspacioOcupado() + planta.Tamanio;
        }

        private int EspacioOcupado()
        {
            int espacioOcupado = 0;
            foreach (Planta item in this.plantas)
            {
                espacioOcupado += item.Tamanio;
            }
            return espacioOcupado;
        }

        public static bool operator +(Jardin j, Planta p)
        {
            bool rta = false;
            if(j.EspacioOcupado(p) <= j.espacioTotal)
            {
                j.plantas.Add(p);
                rta = true;
            }
            return rta;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.GetType().Name} {Jardin.suelo}");
            sb.AppendLine($"Espacio ocupado {this.EspacioOcupado()} de {this.espacioTotal}");
            sb.AppendLine("LISTA DE PLANTAS:");
            foreach (Planta item in this.plantas)
            {
                sb.Append(item.ResumenDeDatos());
                sb.AppendLine("---------------------------------------");
            }
            return sb.ToString();
        }

    }
}
