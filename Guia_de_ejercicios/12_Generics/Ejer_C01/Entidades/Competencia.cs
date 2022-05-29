using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Competencia<T>
        where T : VehiculoDeCarrera
    {
        private string tipoCompetencia;
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<T> competidores;

        private Competencia()
        {
            this.competidores = new List<T>();
        }
        public Competencia(short cantidadCompetidores, short cantidadVueltas):this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
            this.tipoCompetencia = typeof(T).Name;
        }

        public string TipoCompetencia
        {
            get { return this.tipoCompetencia; }
        }

        public List<T> ListaCompetidores
        {
            get { return this.competidores; }
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

        public T this[int index]
        {
            get 
            {
                T aux = null;
                if(index >= 0 && index < this.competidores.Count)
                {
                    aux = this.competidores[index];
                }
                return aux;
            }
        }

        public static bool operator ==(Competencia<T> c, T v)
        {
            bool rta = false;
            if(c is not null && v is not null)
            {
                foreach (T item in c.competidores)
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

        public static bool operator !=(Competencia<T> c, T v)
        {
            return !(c == v);
        }

        public static bool operator +(Competencia<T> c, T v)
        {
            Random r = new Random();
            bool rta = false;

            try
            {
                if(c != v && c.competidores.Count < c.cantidadCompetidores)
                {
                    c.competidores.Add(v);
                    v.EnCompetencia = true;
                    v.CantidadCombustible = (short)r.Next(15, 100);
                    v.VueltasRestantes = c.cantidadVueltas;
                    rta = true;
                }
            }
            catch (CompetenciaNoDisponibleException e)
            {
                throw new CompetenciaNoDisponibleException("Competencia Incorrecta", "Competencia", "+", e);
            }
            catch (Exception)
            {

            }
            return rta;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Competencia!!! Carrera de {this.TipoCompetencia} \nCantidad máxima competidores: {this.cantidadCompetidores} \nCompetidores en carrera: {this.competidores.Count} \n");

            foreach (T item in this.competidores)
            {
                sb.AppendLine(item.MostrarDatos());
                sb.AppendLine("**************************");
            }
           
            return sb.ToString();
        }


    }
}
