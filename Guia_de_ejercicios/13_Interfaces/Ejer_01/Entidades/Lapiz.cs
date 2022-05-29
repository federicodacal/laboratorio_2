using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;

        public Lapiz(int unidades)
        {
            this.tamanioMina = unidades;
        }

        ConsoleColor IAcciones.Color 
        {
            get { return ConsoleColor.Gray; }
            set { throw new NotImplementedException(); } 
        }
        float IAcciones.UnidadesDeEscritura 
        {
            get { return this.tamanioMina; }
            set { this.tamanioMina = value; } 
        }

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            ((IAcciones)this).UnidadesDeEscritura -= texto.Length * 0.1F;
            return new EscrituraWrapper(((IAcciones)this).Color, texto);
        }

        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Lapiz \nTinta: {((IAcciones)this).UnidadesDeEscritura} Color: {((IAcciones)this).Color}";
        }
    }
}
