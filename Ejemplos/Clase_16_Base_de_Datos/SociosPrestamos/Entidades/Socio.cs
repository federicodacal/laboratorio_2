using System;
using System.Collections.Generic;

namespace Entidades
{
    public class Socio
    {
        private string nombre;
        private long dni;
        private List<Prestamo> prestamos;

        public Socio(string nombre, long dni)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.prestamos = new List<Prestamo>();
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public long Dni { get => dni; set => dni = value; }
        public List<Prestamo> Prestamos { get => prestamos; set => prestamos = value; }

        public override string ToString()
        {
            string mensaje = $"{this.nombre} | DNI: {this.Dni} ";
            mensaje += "Lista de prestamos: \n";
            foreach (Prestamo item in this.prestamos)
            {
                mensaje += item.ToString();
                mensaje += "\n";
            }
            return mensaje;
        }
    }
}
