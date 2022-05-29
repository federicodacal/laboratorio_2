using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DepositoDeAutos
    {
        private int capacidadMaxima;
        private List<Auto> lista;

        public DepositoDeAutos(int capacidad)
        {
            this.capacidadMaxima = capacidad;
            this.lista = new List<Auto>();
        }

        public bool Agregar(Auto a)
        {
            return this + a;
        }

        public bool Remover(Auto a)
        {
            return this - a;
        }

        private int GetIndice(Auto a)
        {
            int indice = -1;
            if(a is not null && this.lista is not null)
            {
                for(int i=0; i < this.lista.Count; i++)
                {
                    if(this.lista[i] == a)
                    {
                        indice = i;
                        break;
                    }
                }
            }
            return indice;
        }

        public static bool operator +(DepositoDeAutos d, Auto a)
        {
            bool rta = false;
            if (a is not null && d.lista is not null && d.lista.Count < d.capacidadMaxima)
            {
                d.lista.Add(a);
                rta = true;
            }
            return rta;
        }

        public static bool operator -(DepositoDeAutos d, Auto a)
        {
            bool rta = false;
            int indice = d.GetIndice(a);

            if (indice != -1)
            {
                d.lista.RemoveAt(indice);
                rta = true;
            }
            return rta;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Deposito de Autos: {this.capacidadMaxima} ({this.lista.Count})");
            foreach (Auto item in this.lista)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }
    }
}
