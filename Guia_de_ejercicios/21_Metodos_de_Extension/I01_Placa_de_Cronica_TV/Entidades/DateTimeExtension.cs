using System;

namespace Entidades
{
    public static class DateTimeExtension
    {
        public static string ObtenerPlacaCronicaTV(this DateTime fechaActual, Estaciones estacion)
        {
            int dias;
            fechaActual = DateTime.Now;
            DateTime fechaEstacion = default;
            switch (estacion)
            {
                case Estaciones.Verano:
                    fechaEstacion = new DateTime(DateTime.Now.Year, 12, 21); 
                    if (fechaActual > fechaEstacion)
                    {
                        fechaEstacion = new DateTime(DateTime.Now.Year+1, 12, 21);
                    }
                    break;
                case Estaciones.Primavera:
                    fechaEstacion = new DateTime(DateTime.Now.Year, 9, 23);
                    if (fechaActual > fechaEstacion)
                    {
                        fechaEstacion = new DateTime(DateTime.Now.Year + 1, 9, 23);
                    }
                    break;
                case Estaciones.Invierno:
                    fechaEstacion = new DateTime(DateTime.Now.Year, 6, 21);
                    if (fechaActual > fechaEstacion)
                    {
                        fechaEstacion = new DateTime(DateTime.Now.Year + 1, 6, 21);
                    }
                    break;
                case Estaciones.Otonio:
                    fechaEstacion = new DateTime(DateTime.Now.Year, 3, 20);
                    if (fechaActual > fechaEstacion)
                    {
                        fechaEstacion = new DateTime(DateTime.Now.Year + 1, 3, 20);
                    }
                    break;                    
            }

            dias = Convert.ToInt32((fechaEstacion - fechaActual).Days);

            return $"Faltan {dias} días para {estacion}";
        }
    }
}
