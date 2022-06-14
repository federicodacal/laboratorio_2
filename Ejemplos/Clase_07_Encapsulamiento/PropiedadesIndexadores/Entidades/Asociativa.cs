using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Asociativa
    {
        #region Atributos

        private Dictionary<string, Capitulo> capitulos;

        #endregion

        #region Indexador

        public Capitulo this[string indice]
        {
            get 
            {
                if ( ! this.capitulos.ContainsKey(indice))
                {
                    return null;
                }
                else 
                {
                    return this.capitulos[indice];
                }                   
            }

            set 
            {
                if( ! this.capitulos.ContainsKey(indice))
                {
                    this.capitulos.Add(indice, value);
                }
                else
                {
                    this.capitulos[indice] = value;//reemplazo el elemento
                }                
            }
        }

        #endregion

        #region Constructor

        public Asociativa()
        {
            this.capitulos = new Dictionary<string, Capitulo>();
        }

        #endregion

        #region Métodos

        public string VerCapitulos()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Capitulo item in this.capitulos.Values)
            {
                sb.Append("Número: ");
                sb.AppendLine(item.Numero.ToString());

                sb.Append("Título: ");
                sb.AppendLine(item.Titulo);
            }

            return sb.ToString();
        }

        #endregion
    }
}
