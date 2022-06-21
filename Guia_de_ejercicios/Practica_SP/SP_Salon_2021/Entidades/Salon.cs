using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Generar la clase genérica Salón. Contiene el atributo elementos:List del tipo genérico.
// (este sólo se podrá inicializar en el constructor por defécto, que además será privado)
// y el atributo capacidad:int (generar un constructor público que lo reciba como parámetro).
// Sobrecarga en el operador +.
// Al sumar un Salón con un elemento de tipo Persona, se deberá agregar a la lista de elementos
// SÓLO si el idioma de la persona es Español y aún hay lugar en el salon.
//Eventos
//Agregar en la clase Salón que, si se llego al limite de capacidad, se lance un evento SalonLlenoEvent.
//Esto mostrará un mensaje en el manejador Salon_SalonLlenoEvent (realizarlo según convenciones).
//Agregar en la clase Salon que, si el idioma no es español, se lance un evento SalonNoEspañolEvent.
//Esto mostrará un mensaje en el manejador Salon_SalonNoEspañolEvent (realizarlo según convenciones).

namespace Entidades
{

    public class Salon<T>
        where T : Persona
    {
        public delegate void DelegadoSalon(Salon<T> sender);

        private List<T> elementos;
        private int capacidad;

        public event DelegadoSalon SalonLlenoEvent;
        public event DelegadoSalon SalonNoEspañolEvent;

        private Salon()
        {
            this.elementos = new List<T>();
        }

        public Salon(int capacidad):this()
        {
            this.capacidad = capacidad;
        }

        public static Salon<T> operator +(Salon<T> s, Persona p)
        {
            if(s is not null && p is not null)
            {
                if(s.capacidad > s.elementos.Count)
                {
                    if (p.Idioma == EIdioma.Español)
                    {
                        s.elementos.Add((T)p);
                    }
                    else
                    {
                        if(s.SalonNoEspañolEvent is not null)
                        {
                            s.SalonNoEspañolEvent.Invoke(s);
                        }
                    }
                }
                else
                {
                    if(s.SalonLlenoEvent is not null)
                    {
                        s.SalonLlenoEvent.Invoke(s);
                    }
                }
            }
            return s;
        }


    }
}
