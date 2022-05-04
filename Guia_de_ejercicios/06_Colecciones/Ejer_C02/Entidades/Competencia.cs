using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Competencia
    {

        public enum TipoCompetencia { F1, MotoCross}

        private short cantidadCompetidores;
        private TipoCompetencia tipo;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;

        private Competencia()
        {
            this.competidores = new List<VehiculoDeCarrera>();
        }
        public Competencia(short cantidadCompetidores, short cantidadVueltas, TipoCompetencia tipo):this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
            this.tipo = tipo;
        }

        public short CantidadCompetidores
        {
            get { return this.cantidadCompetidores; }
            set { this.cantidadCompetidores = value; }
        }

        public short CantidadVueltas
        {
            get { return this.cantidadVueltas; }
            set { this.cantidadVueltas = value; }
        }

        public TipoCompetencia Tipo
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }

        public VehiculoDeCarrera this[int index]
        {
            get 
            {
                VehiculoDeCarrera aux = null;
                if(index >= 0 && index < this.competidores.Count)
                {
                    aux = this.competidores[index];
                }
                return aux;
            }
        }

        public static bool operator ==(Competencia c, VehiculoDeCarrera v)
        {
            bool rta = false;
            if(c is not null && v is not null)
            {
                if(c.Tipo == TipoCompetencia.F1 && v is AutoF1)
                {
                    foreach (VehiculoDeCarrera item in c.competidores)
                    {
                        if(item as AutoF1 == (AutoF1)v)
                        {
                            rta = true;
                            break;
                        }
                    }
                }
                else if(c.Tipo == TipoCompetencia.MotoCross && v is MotoCross)
                {
                    foreach (VehiculoDeCarrera item in c.competidores)
                    {
                        if (item as MotoCross == (MotoCross)v)
                        {
                            rta = true;
                            break;
                        }
                    }
                }
                else
                {
                    rta = true;
                }
            }
            return rta;
        }

        public static bool operator !=(Competencia c, VehiculoDeCarrera v)
        {
            return !(c == v);
        }

        public static bool operator +(Competencia c, VehiculoDeCarrera v)
        {
            Random r = new Random();
            bool rta = false;
            if(c != v && c.competidores.Count < c.cantidadCompetidores)
            {
                c.competidores.Add(v);
                v.EnCompetencia = true;
                v.CantidadCombustible = (short)r.Next(15, 100);
                v.VueltasRestantes = c.cantidadVueltas;
                rta = true;
            }
            return rta;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Competencia!!! \nCantidad máxima competidores: {this.cantidadCompetidores} \nCompetidores en carrera: {this.competidores.Count} \n");

            if (this.Tipo == TipoCompetencia.F1)
            {
                foreach (AutoF1 item in this.competidores)
                {
                    sb.AppendLine(((AutoF1)item).MostrarDatos());
                    sb.AppendLine("**************************");
                }
            }
            else if (this.Tipo == TipoCompetencia.MotoCross)
            {
                foreach (MotoCross item in this.competidores)
                {
                    sb.AppendLine(((MotoCross)item).MostrarDatos());
                    sb.AppendLine("**************************");
                }
            }
            return sb.ToString();
        }


    }
}
