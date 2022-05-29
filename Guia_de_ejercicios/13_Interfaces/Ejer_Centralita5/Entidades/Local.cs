using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Local : Llamada, IGuardar<string>
    {
        protected float costo;

        public Local(Llamada llamada, float costo)
            :this(llamada.NroOrigen,llamada.Duracion,llamada.NroDestino, costo)
        {
        }

        public Local(string origen, float duracion, string destino, float costo)
            :base(duracion,destino,origen)
        {
            this.costo = costo;
        }

        public override float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }

        public string RutaDeArchivo { get { return "ruta_archivo"; } set => throw new NotImplementedException(); }

        private float CalcularCosto()
        {
            return this.Duracion * this.costo;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Costo: {this.CostoLlamada}");

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj.GetType() == typeof(Local);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public bool Guardar()
        {
            throw new NotImplementedException();
        }

        public string Leer()
        {
            throw new NotImplementedException();
        }
    }
}
