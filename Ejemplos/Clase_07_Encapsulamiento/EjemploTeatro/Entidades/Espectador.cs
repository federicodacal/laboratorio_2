using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Espectador
    {
        private string nombre;
        private int dni;
        private long telefono;
        private List<Entrada> entradas;

        private Espectador()
        {
            this.entradas = new List<Entrada>();
        }

        public Espectador(string nombre, int dni, long telefono):this()
        {
            this.nombre = nombre;
            this.dni = dni;
            this.telefono = telefono;
        }

        public string Nombre
        {
            get { return this.nombre; }
            set
            {
                if(ValidarNombre(value))
                {
                    this.nombre = value;
                }
            }
        }

        private bool ValidarNombre(string nombre)
        {
            bool rta = false;
            bool tieneNumero = false;
            if(!String.IsNullOrWhiteSpace(nombre) && nombre.Length > 1)
            {
                foreach (char item in nombre)
                {
                    if(Char.IsDigit(item))
                    {
                        tieneNumero = true;
                        break;
                    }
                }
                if(!tieneNumero)
                {
                    rta = true;
                }
            }
            return rta;
        }

        public int Dni
        {
            get { return this.dni; }
            set
            {
                if (value > 0 && value.ToString().Length > 5 && value.ToString().Length < 12)
                {
                    this.dni = value;
                }
            }
        }

        public long Telefono
        {
            get { return this.telefono; }
            set 
            { 
                if(value > 0 && value.ToString().Length > 4 && value.ToString().Length < 15)
                {
                    this.telefono = value; 
                }
            }
        }

        public int CantidadEntradas
        {
            get { return this.entradas.Count; }
        }

        public static explicit operator string(Espectador e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Espectador: {e.Nombre}");
            sb.AppendLine($"DNI: {e.Dni}");
            sb.AppendLine($"Telefono: {e.Telefono}");
            sb.AppendLine($"Entradas: {e.CantidadEntradas}");
            if(e.CantidadEntradas > 0)
            {
                sb.AppendLine("Compró entradas para: ");
                foreach (Entrada item in e.entradas)
                {
                    sb.AppendLine(item.Mostrar());
                }
            }
            return sb.ToString();
        }

        public static bool operator ==(Espectador e1, Espectador e2)
        {
            bool rta = false;
            if(e1 is not null && e2 is not null)
            {
                rta = e1.Dni == e2.Dni;
            }
            return rta;
        }

        public static bool operator !=(Espectador e1, Espectador e2)
        {
            return !(e1 == e2);
        }

        public void ComprarEntrada(string obra, DateTime funcion, int cantidad)
        {
            if(!String.IsNullOrEmpty(obra) && cantidad > 0)
            {
                for (int i = 0; i < cantidad; i++)
                {
                    this.entradas.Add(new Entrada(obra, funcion));
                }
            }
        }

    }
}
