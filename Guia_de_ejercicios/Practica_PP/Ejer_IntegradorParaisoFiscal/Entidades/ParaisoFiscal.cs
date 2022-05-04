using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ParaisoFiscal
    {
        private List<CuentaOffShore> listadoCuentas;
        private EParaisosFiscales lugar;
        public static int cantidadCuentas;
        public static DateTime fechaInicioActividades;

        static ParaisoFiscal()
        {
            ParaisoFiscal.cantidadCuentas = 0;
            ParaisoFiscal.fechaInicioActividades = DateTime.Now;
        }
        private ParaisoFiscal()
        {
            this.listadoCuentas = new List<CuentaOffShore>();
        }

        private ParaisoFiscal(EParaisosFiscales lugar):this()
        {
            this.lugar = lugar;
        }

        public string MostrarParaiso()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Fecha de Inicio: {ParaisoFiscal.fechaInicioActividades.ToShortDateString()}");
            sb.AppendLine($"Locacion: {this.lugar}");
            sb.AppendLine($"Cantidad de 'cuentitas': {ParaisoFiscal.cantidadCuentas}");
            sb.AppendLine("******Listado de cuentas offshore******");
            foreach (CuentaOffShore item in this.listadoCuentas)
            {
                sb.Append(Cliente.RetornarDatos(item.Duenio));
                sb.AppendLine($"Nro. de cuenta: {(int)item}");
                sb.AppendLine($"Saldo: {item.Saldo}");
                sb.AppendLine("");
            }

            return sb.ToString();
        }

        public static implicit operator ParaisoFiscal(EParaisosFiscales epf)
        {
            return new ParaisoFiscal(epf);
        }

        public static bool operator ==(ParaisoFiscal p, CuentaOffShore c)
        {
            bool rta = false;
            if(p is not null && c is not null)
            {
                foreach (CuentaOffShore item in p.listadoCuentas)
                {
                    if(item == c)
                    {
                        rta = true;
                        break;
                    }
                }
            }
            return rta;
        }

        public static bool operator!=(ParaisoFiscal p, CuentaOffShore c)
        {
            return !(p == c);
        }

        public static ParaisoFiscal operator +(ParaisoFiscal p, CuentaOffShore c)
        {
            if(p != c)
            {
                p.listadoCuentas.Add(c);
                ParaisoFiscal.cantidadCuentas++;
                Console.WriteLine("Se agregó la cuenta");
            }
            else
            {
                Console.WriteLine("No se agregó la cuenta");
            }
            return p;
        }

        public static ParaisoFiscal operator -(ParaisoFiscal p, CuentaOffShore c)
        {
            bool seQuito = false;
            if(p == c)
            {
                for(int i = 0; i < p.listadoCuentas.Count; i++)
                {
                    if(p.listadoCuentas[i] == c)
                    {
                        p.listadoCuentas.RemoveAt(i);
                        ParaisoFiscal.cantidadCuentas--;
                        seQuito = true;
                        break;
                    }
                }
            }

            if(seQuito)
            {
                Console.WriteLine("Se quitó la cuenta");
            }
            else
            {
                Console.WriteLine("No se quitó la cuenta");
            }
            return p;
        }

    }
}
