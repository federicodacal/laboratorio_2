using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Estacionamiento
    {
        private int espacioDisponible;
        private string nombre;
        private List<Vehiculo> vehiculos;

        private Estacionamiento()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        public Estacionamiento(string nombre, int espacioDisponible):this()
        {
            this.nombre = nombre;
            this.espacioDisponible = espacioDisponible;
        }

        public static explicit operator string(Estacionamiento e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{e.GetType().Name}: {e.nombre}");
            sb.AppendLine($"Espacio disponible: {e.espacioDisponible}, {e.vehiculos.Count} lugares ocupados");
            sb.AppendLine("Lista de vehiculos: \n");
            foreach (Vehiculo item in e.vehiculos)
            {
                sb.AppendLine(item.ConsultarDatos());
            }

            return sb.ToString();
        }

        public static bool operator ==(Estacionamiento e, Vehiculo v)
        {
            bool rta = false;
            if(e is not null && v is not null)
            {
                foreach (Vehiculo item in e.vehiculos)
                {
                    if(item == v)
                    {
                        rta = true;
                        break;
                    }
                }
            }
            return rta;
        }

        public static bool operator !=(Estacionamiento e, Vehiculo v)
        {
            return !(e == v);
        }

        public static Estacionamiento operator +(Estacionamiento e, Vehiculo v)
        {
            if(e != v && !String.IsNullOrEmpty(v.Patente) && e.espacioDisponible > e.vehiculos.Count)
            {
                e.vehiculos.Add(v);
            }
            return e;
        }

        public static Estacionamiento operator -(Estacionamiento e, Vehiculo v)
        {
            if(e == v)
            {
                for(int i = 0; i < e.vehiculos.Count; i++)
                {
                    if(v == e.vehiculos[i])
                    {
                        Console.WriteLine(e.vehiculos[i].ImprimirTicket());
                        e.vehiculos.RemoveAt(i);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("El vehículo no es parte del estacionamiento");
            }
            return e;
        }
    }
}
