using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///Crear, en EntidadesSP, la clase Caja<T>, dónde T sea de tipo Zapato, Fósforo o Remedio.
///atributos: capacidad:int y elementos:List<T> (TODOS protegidos)        
///Propiedades:
///Elementos:(sólo lectura) expone al atributo de tipo List<T>.
///PrecioTotal:(sólo lectura) retorna el precio total de la caja (la suma de los precios de sus elementos).
///Constructor
///Caja(), Caja(int); 
///El constructor por default es el único que se encargará de inicializar la lista.
///Métodos:
///ToString: Mostrará en formato de tipo string: 
///.-el tipo de caja, la capacidad, la cantidad actual de elementos, el precio total y el listado completo 
///de todos los elementos contenidos en la misma. Reutilizar código.
///Sobrecarga de operadores:
///(+) Será el encargado de agregar elementos a la caja, 
///siempre y cuando no supere la capacidad máxima de la misma.

namespace EntidadesSP
{
    public delegate void DelegadoCaja(object sender, EventArgs e);

    public class Caja<T>
        where T : Producto
    {

        protected int capacidad;
        protected List<T> elementos;

        public event DelegadoCaja EventoPrecio;

        private Caja()
        {
            this.elementos = new List<T>();
        }

        public Caja(int capacidad):this()
        {
            this.capacidad = capacidad;
        }

        public List<T> Elementos { get { return this.elementos; } }

        public double PrecioTotal
        {
            get
            {
                double total = 0;
                foreach (T item in this.Elementos)
                {
                    total += item.Precio;
                }
                return total;
            }
        }

        public static Caja<T> operator +(Caja<T> c, T item)
        {
            if(c is not null && item is not null)
            {
                if(c.Elementos.Count < c.capacidad)
                {
                    c.Elementos.Add(item);
                    if(c.PrecioTotal > 999)
                    {
                        if(c.EventoPrecio is not null)
                        {
                            c.EventoPrecio.Invoke(c, EventArgs.Empty);
                        }
                    }
                }
                else
                {
                    throw new CajaLlenaException("Caja Llena: no queda lugar disponible en la caja");
                }
            }
            return c;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Caja de {typeof(T).Name} - Capacidad: {this.capacidad} - Elementos: {this.Elementos.Count} - Precio Total {this.PrecioTotal}");
            foreach (T item in this.Elementos)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
    }
}
