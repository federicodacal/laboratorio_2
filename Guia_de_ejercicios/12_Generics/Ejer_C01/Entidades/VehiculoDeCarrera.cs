using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class VehiculoDeCarrera
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            this.enCompetencia = false;
            this.cantidadCombustible = 0;
            this.vueltasRestantes = 0;
        }

        public short CantidadCombustible
        {
            get { return this.cantidadCombustible; }
            set
            {
                if (value > 0)
                {
                    this.cantidadCombustible = value;
                }
            }
        }

        public string Escuderia
        {
            get { return this.escuderia; }
            set { this.escuderia = value; }
        }

        public short Numero
        {
            get { return this.numero; }
            set { this.numero = value; }
        }

        public bool EnCompetencia
        {
            get { return this.enCompetencia; }
            set { this.enCompetencia = value; }
        }

        public short VueltasRestantes
        {
            get { return this.vueltasRestantes; }
            set
            {
                if (value > 0)
                {
                    this.vueltasRestantes = value;
                }
            }
        }


        public static bool operator ==(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            bool rta = false;
            if (v1 is not null && v2 is not null)
            {
                rta = v1.escuderia == v2.escuderia && v1.numero == v2.numero;
            }
            return rta;
        }

        public static bool operator !=(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return !(v1 == v2);
        }

        public string MostrarDatos()
        {
            return $"Numero: {this.Numero} | Escuderia: {this.Escuderia} | Competencia: {this.enCompetencia} | Vueltas Restantes: {this.VueltasRestantes} | Combustible {this.CantidadCombustible}";
        }
    }
}
