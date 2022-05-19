using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadFinanciera
{
    public class Financiera
    {
        private List<Prestamo> listaDePrestamos;
        private string razonSocial;

        private Financiera()
        {
            this.listaDePrestamos = new List<Prestamo>();
        }
        public Financiera(string razonSocial):this()
        {
            this.razonSocial = razonSocial;
        }

        public string RazonSocial
        {
            get { return this.razonSocial; }
        }

        public List<Prestamo> ListaPrestamos
        {
            get { return this.listaDePrestamos; }
        }

        public float InteresesEnDolares
        {
            get { return this.CalcularInteresGanado(TipoDePrestamo.Dolares); }
        }
        public float InteresesEnPesos
        {
            get { return this.CalcularInteresGanado(TipoDePrestamo.Pesos); }
        }

        public float InteresesTotales
        {
            get { return this.CalcularInteresGanado(TipoDePrestamo.Todos); }
        }

        private float CalcularInteresGanado(TipoDePrestamo tipo)
        {
            float interesGanado = 0;

            if(tipo == TipoDePrestamo.Dolares)
            {
                foreach (Prestamo item in this.ListaPrestamos)
                {
                    if(item is PrestamoDolar)
                    {
                        interesGanado += ((PrestamoDolar)item).Interes;
                    }
                }
            }
            else if (tipo == TipoDePrestamo.Pesos)
            {
                foreach (Prestamo item in this.ListaPrestamos)
                {
                    if (item is PrestamoPesos)
                    {
                        interesGanado += ((PrestamoPesos)item).Interes;
                    }
                }
            }
            else if (tipo == TipoDePrestamo.Todos)
            {
                foreach (Prestamo item in this.ListaPrestamos)
                {
                    if (item is PrestamoPesos)
                    {
                        interesGanado += ((PrestamoPesos)item).Interes;
                    }
                    else if(item is PrestamoDolar)
                    {
                        interesGanado += ((PrestamoDolar)item).Interes;
                    }
                }
            }
            return interesGanado;
        }

        public static string Mostrar(Financiera f)
        {
            return (string)f;
        }

        public static explicit operator string(Financiera f)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{f.GetType().Name}: {f.RazonSocial}");
            sb.AppendLine("Intereses Ganados:");
            sb.AppendLine($"Total: ${f.InteresesTotales}");
            sb.AppendLine($"Dolares: ${f.InteresesEnDolares}");
            sb.AppendLine($"Pesos: ${f.InteresesEnPesos}");
            sb.AppendLine("Lista de Prestamos:");
            sb.AppendLine("<------------------------------------------------->");

            f.OrdenarPrestamos();

            foreach (Prestamo item in f.ListaPrestamos)
            {
                sb.AppendLine(item.Mostrar());
            }

            return sb.ToString();
        }

        public void OrdenarPrestamos()
        {
            this.ListaPrestamos.Sort(Prestamo.OrdenarPorFecha);
        }

        public static bool operator ==(Financiera f, Prestamo p)
        {
            bool rta = false;
            if(f is not null && p is not null)
            {
                foreach (Prestamo item in f.ListaPrestamos)
                {
                    if(item.Equals(p))
                    {
                        rta = true;
                        break;
                    }
                }
            }
            return rta;
        }

        public static bool operator !=(Financiera f, Prestamo p)
        {
            return !(f == p);
        }

        public static Financiera operator +(Financiera f, Prestamo p)
        {
            if(f != p)
            {
                f.ListaPrestamos.Add(p);
            }

            return f;
        }
    }
}
