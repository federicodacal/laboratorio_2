using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lavadero
    {
        private List<Vehiculo> vehiculos;
        private float precioAuto;
        private float precioCamion;
        private float precioMoto;

        private Lavadero()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        public Lavadero(float precioAuto, float precioCamion, float precioMoto):this()
        {
            this.precioAuto = precioAuto;
            this.precioCamion = precioCamion;
            this.precioMoto = precioMoto;
        }

        public List<Vehiculo> Vehiculos
        {
            get { return this.vehiculos; }
        }

        public string Detalle
        {
            get {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine("Lavadero!!!");
                sb.AppendLine($"Precios -> Auto: {this.precioAuto} | Moto: {this.precioMoto} | Camion: {this.precioCamion}");
                sb.AppendLine($"Cantidad de vehiculos en Lavadero: {this.Vehiculos.Count}");
                this.Vehiculos.Sort(Lavadero.OrdenarVehiculosPorPatente);
                if (this.Vehiculos.Count > 0)
                {
                    foreach (Vehiculo item in this.Vehiculos)
                    {
                        if (item is Auto)
                        {
                            sb.AppendLine(((Auto)item).MostrarAuto());
                        }
                        else if (item is Moto)
                        {
                            sb.AppendLine(((Moto)item).MostrarMoto());
                        }
                        else if (item is Camion)
                        {
                            sb.AppendLine(((Camion)item).MostrarCamion());
                        }
                    sb.AppendLine("*******************************************");
                    }
                    sb.AppendLine($"Facturado por Auto: {this.MostrarTotalFacturado(EVehiculos.Auto)}");
                    sb.AppendLine($"Facturado por Moto: {this.MostrarTotalFacturado(EVehiculos.Moto)}");
                    sb.AppendLine($"Facturado por Camion: {this.MostrarTotalFacturado(EVehiculos.Camion)}");
                    sb.AppendLine($"Total Facturado: {this.MostrarTotalFacturado()}");
                }
                return sb.ToString();
            }
        }

        private double MostrarTotalFacturado()
        {
            return MostrarTotalFacturado(EVehiculos.Auto) + MostrarTotalFacturado(EVehiculos.Camion) + MostrarTotalFacturado(EVehiculos.Moto);
        }

        private double MostrarTotalFacturado(EVehiculos tipo)
        {
            double totalFacturado = 0;
            foreach (Vehiculo item in this.Vehiculos)
            {
                if (tipo == EVehiculos.Auto && item.GetType() == typeof(Auto))
                {
                    totalFacturado += this.precioAuto;
                }
                else if(tipo == EVehiculos.Moto && item.GetType() == typeof(Moto))
                {
                    totalFacturado += this.precioMoto;
                }
                else if(tipo == EVehiculos.Camion && item.GetType() == typeof(Camion))
                {
                    totalFacturado += this.precioCamion;
                }
            }
            return totalFacturado;
        }

        public static bool operator ==(Lavadero l, Vehiculo v)
        {
            bool rta = false;
            if(l is not null && v is not null)
            {
                foreach (Vehiculo item in l.Vehiculos)
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

        public static bool operator !=(Lavadero l, Vehiculo v)
        {
            return !(l == v);
        }

        public static Lavadero operator +(Lavadero l, Vehiculo v)
        {
            if(l != v)
            {
                l.Vehiculos.Add(v);
            }
            return l;
        }

        public static Lavadero operator -(Lavadero l, Vehiculo v)
        {   
            if(l == v)
            {
                for(int i = 0; i < l.Vehiculos.Count; i++)
                {
                    if(l.Vehiculos[i] is not null && v == l.Vehiculos[i])
                    {
                        l.Vehiculos.RemoveAt(i);
                    }
                }
            }
            return l;
        }

        public static int OrdenarVehiculosPorPatente(Vehiculo v1, Vehiculo v2)
        {
            return String.Compare(v1.Patente, v2.Patente);
        }

        public static int OrdenarVehiculosPorMarca(Vehiculo v1, Vehiculo v2)
        {
            return String.Compare(v1.Marca.ToString(), v2.Marca.ToString());
        }

    }
}
