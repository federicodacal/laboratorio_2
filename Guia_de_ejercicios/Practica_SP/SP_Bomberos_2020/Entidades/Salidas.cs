using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Salidas
    {
        private DateTime fechaFin;
        private DateTime fechaInicio;

        public Salidas()
        {
            this.fechaInicio = DateTime.Now;
        }

        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }

        public int TiempoTotal
        {
            get { return this.FechaInicio.DiferenciaEnMinutos(this.FechaFin); }
        }

        public void FinalizarSalida()
        {
            this.FechaFin = DateTime.Now;
        }
    }
}
