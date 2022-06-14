using System;

namespace Veterinaria
{
    public class Mascota
    {
        private string nombre;
        private DateTime fechaNacimiento;
        private string especie;

        public Mascota(string nombre, DateTime fechaNacimiento, string especie)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            //SetFechaNacimiento(fechaNacimiento);
            this.especie = especie;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public string GetFechaNacmiento()
        {
            return fechaNacimiento.ToString();
        }

        public string GetEspecie()
        {
            return especie;
        }

        public void SetNombre(string nuevoNombre)
        {
            nombre = nuevoNombre;
        }

        public bool SetFechaDeNacimiento(DateTime nuevaFechaNacimiento)
        {
            /*
             if(fechaNacimiento > DateTime.Today)
            {
                return false;
            }
            else
            {
                fechaNacimiento = nuevaFechaNacimiento;
                return true;
            }
            */
            if (ValidarFecha(nuevaFechaNacimiento))
            {
                return false;
            }
            else
            {
                fechaNacimiento = nuevaFechaNacimiento;
                return true;
            }
        }

        private bool ValidarFecha(DateTime fecha)
        {
            return fechaNacimiento <= DateTime.Today;
        }
    }
}
