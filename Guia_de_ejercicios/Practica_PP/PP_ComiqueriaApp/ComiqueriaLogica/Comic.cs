using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comic : Producto
    {

        public enum TipoComic { Occidental, Oriental }

        private string autor;
        private TipoComic tipo;

        public Comic(string descripcion, int stock, double precio, string autor, TipoComic tipo)
            :base(descripcion, stock, precio)
        {
            this.autor = autor;
            this.tipo = tipo;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ToString());
            sb.AppendLine($"Autor: {this.autor}");
            sb.AppendLine($"Tipo: {this.tipo}");

            return sb.ToString();
        }

    }
}
