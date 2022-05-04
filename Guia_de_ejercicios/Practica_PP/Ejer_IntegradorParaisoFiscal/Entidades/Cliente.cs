using System;
using System.Text;

namespace Entidades
{
    public class Cliente
    {
        private string aliasParaIncognito;
        private string nombre;
        private ETipoCliente tipo;

        private Cliente()
        {
            this.nombre = "NN";
            this.aliasParaIncognito = "Sin alias";
            this.tipo = ETipoCliente.SinTipo;
        }

        public Cliente(ETipoCliente tipo):this()
        {
            this.tipo = tipo;
        }

        public Cliente(ETipoCliente tipo, string nombre):this(tipo)
        {
            this.nombre = nombre;
        }

        private void CrearAlias()
        {
            Random random = new Random();
            int numero = random.Next(1000, 9999);

            this.aliasParaIncognito = numero + this.tipo.ToString();
        }

        public string GetAlias()
        {
            if(this.aliasParaIncognito == "Sin alias")
            {
                this.CrearAlias();
            }
            return this.aliasParaIncognito;
        }

        private string RetornarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Tipo: {this.tipo}");
            sb.AppendLine($"Alias: {this.GetAlias()}");

            return sb.ToString();
        }

        public static string RetornarDatos(Cliente c)
        {
            return c.RetornarDatos();
        }

    }
}
