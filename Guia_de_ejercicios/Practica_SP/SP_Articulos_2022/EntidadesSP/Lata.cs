using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///Crear, en EntidadesSP, la clase genérica Lata<T>, dónde T pueda ser de tipo Tomate, Pintura o Cerveza.
///atributos: capacidad : int y elementos : List<T> (TODOS protegidos)        
///Propiedades:
///Elementos:(sólo lectura) expone al atributo de tipo List<T>.
///PrecioTotal:(sólo lectura) retorna el precio total de la lata (la suma de los precios de sus elementos).
///Constructor
///Lata(), Lata(int); 
///El constructor por default es el único que se encargará de inicializar la lista.
///Métodos:
///ToString: Mostrará en formato de tipo string: 
///el tipo de lata, la capacidad, la cantidad actual de elementos, el precio total y el listado completo 
///de todos los elementos contenidos en la misma. Reutilizar código.
///Sobrecarga de operadores:
///(+) Será el encargado de agregar elementos a la lata, 
///siempre y cuando no supere la capacidad máxima de la misma.
///
///Si el precio total de la caja supera los 2000 pesos, se disparará el evento EventoPrecio. 
///Diseñarlo (de acuerdo a las convenciones vistas) en la clase Lata. 
///Adaptar la sobrecarga del operador +, para que lance el evento, según lo solicitado.


namespace EntidadesSP
{
    public delegate void DelegadoPrecioLata(object sender, PrecioLataEventArgs e);

    public class Lata<T>
        where T : Articulo
    {
        protected int capacidad;
        protected List<T> elementos;

        public event DelegadoPrecioLata EventoPrecio;

        private Lata()
        {
            this.elementos = new List<T>();
        }

        public Lata(int capacidad) : this()
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

        public static Lata<T> operator +(Lata<T> c, T item)
        {
            if (c is not null && item is not null)
            {
                if (c.Elementos.Count < c.capacidad)
                {
                    c.Elementos.Add(item);
                    if (c.PrecioTotal > 2000)
                    {
                        if (c.EventoPrecio is not null)
                        {
                            PrecioLataEventArgs e = new PrecioLataEventArgs();
                            e.Precio = c.PrecioTotal;
                            c.EventoPrecio.Invoke(c, e);
                        }
                    }
                }
                else
                {
                    throw new LataLlenaException("Lata Llena: no queda lugar disponible en la lata");
                }
            }
            return c;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Lata de {typeof(T).Name} - Capacidad: {this.capacidad} - Elementos: {this.Elementos.Count} - Precio Total {this.PrecioTotal}");
            foreach (T item in this.Elementos)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
    }
}
