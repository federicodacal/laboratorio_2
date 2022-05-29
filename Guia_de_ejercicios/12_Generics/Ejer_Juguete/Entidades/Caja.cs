using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Caja<T>
        where T : Juguete
    {
        private static List<T> lista;

        static Caja()
        {
            Caja<T>.lista = new List<T>();
        }

        public static List<T> Lista
        {
            get { return Caja<T>.lista; }
        }

        public static G Agregar<G>(G param)
            where G : T
        {
            if (Caja<T>.Lista is not null && param is not null)
            {
                Caja<T>.Lista.Add(param);
            }
            return param;
        }

        public static string Mostrar<X>()
            where X : T
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Caja de {typeof(X).Name}");

            foreach (X item in Caja<T>.lista)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }

    }
}
