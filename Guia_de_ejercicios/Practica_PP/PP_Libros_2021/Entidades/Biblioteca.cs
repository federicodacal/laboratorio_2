using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Biblioteca
    {
        private int capacidad;
        private List<Libro> libros;

        private Biblioteca()
        {
            this.libros = new List<Libro>();
        }
        private Biblioteca(int capacidad):this()
        {
            this.capacidad = capacidad;
        }

        public double PrecioDeManuales
        {
            get { return this.ObtenerPrecio(ELibro.PrecioDeManuales); }
        }

        public double PrecioDeNovelas
        {
            get { return this.ObtenerPrecio(ELibro.PrecioDeNovelas); }
        }

        public double PrecioTotal
        {
            get { return this.ObtenerPrecio(ELibro.PrecioTotal); }
        }

        public static implicit operator Biblioteca(int capacidad)
        {
            return new Biblioteca(capacidad);
        }

        public static string Mostrar(Biblioteca b)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(b.GetType().Name);
            sb.AppendLine($"Capacidad: {b.capacidad} ({b.libros.Count})");
            sb.AppendLine($"Total por manuales: {String.Format("{0:0.00}", b.PrecioDeManuales)}");
            sb.AppendLine($"Total por novelas: {String.Format("{0:0.00}", b.PrecioDeNovelas)}");
            sb.AppendLine($"Total: {String.Format("{0:0.00}", b.PrecioTotal)}");
            sb.AppendLine("**********************************************");
            sb.AppendLine("\tListado de Libros");
            sb.AppendLine("**********************************************");
            foreach (Libro item in b.libros)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }

        public double ObtenerPrecio (ELibro tipo)
        {
            double precioTotal = 0;
            foreach (Libro item in this.libros)
            {
                if(tipo == ELibro.PrecioDeManuales && item.GetType() == typeof(Manual))
                {
                    precioTotal += (float)(Manual)item;
                }
                else if(tipo == ELibro.PrecioDeNovelas && item.GetType() == typeof(Novela))
                {
                    precioTotal += (Novela)item;
                }
                else if(tipo == ELibro.PrecioTotal)
                {
                    if(item.GetType() == typeof(Manual))
                    {
                        precioTotal += (float)(Manual)item;
                    }
                    else if(item.GetType() == typeof(Novela))
                    {
                        precioTotal += (Novela)item;
                    }
                }
            }
            return precioTotal;
        }

        public static bool operator ==(Biblioteca b, Libro l)
        {
            bool rta = false;
            if(b is not null && l is not null)
            {
                foreach (Libro item in b.libros)
                {
                    if (item.Equals(l))
                    {
                        rta = true;
                        break;
                    }
                }
            }
            return rta;
        }

        public static bool operator !=(Biblioteca b, Libro l)
        {
            return !(b == l);
        }

        public static Biblioteca operator +(Biblioteca b, Libro l)
        {
            if(b.capacidad > b.libros.Count)
            {
                if (b != l)
                {
                    b.libros.Add(l);
                }
                else
                {
                    Console.WriteLine("No se agregó. Ya se encuentra");
                }
            }
            else
            {
                Console.WriteLine("No hay mas lugar");
            }
            return b;
        }

    }
}
