using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Contabilidad<T,U>
        where T : Documento
        where U : Documento, new()
    {
        private List<T> egresos;
        private List<U> ingresos;

        public Contabilidad()
        {
            this.egresos = new List<T>();
            this.ingresos = new List<U>();
        }

        public static Contabilidad<T, U> operator +(Contabilidad<T,U> c, T egreso)
        {
            if(c is not null && c.egresos is not null && egreso is not null)
                c.egresos.Add(egreso);
            return c;
        }

        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, U ingreso)
        {
            if (c is not null && c.ingresos is not null && ingreso is not null)
                c.ingresos.Add(ingreso);
            return c;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Lista de egresos: ");
            foreach (T item in this.egresos)
            {
                sb.AppendLine(item.Numero.ToString());
            }
            sb.AppendLine("Lista de ingresos: ");
            foreach (U item in this.ingresos)
            {
                sb.AppendLine(item.Numero.ToString());
            }

            return sb.ToString();
        }
    }
}
