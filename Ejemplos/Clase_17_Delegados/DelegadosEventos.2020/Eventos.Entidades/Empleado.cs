using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eventos.Entidades
{
    //DECLARO UN DELEGADO
    public delegate void LimiteSueldoDelegado(Double sueldo, Empleado e);


    /// <summary>
    /// Clase que será el 'EMISOR' del evento
    /// </summary>
    public class Empleado
    {
        //DECLARO UN EVENTO
        public event LimiteSueldoDelegado LimiteSueldo;

        #region Atributos

            protected String nombre;
            protected Double sueldo;

        #endregion

        #region Propiedades

        public String Nombre 
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public Double Sueldo 
        {
            get { return this.sueldo; }
            set
            {
                //SI EL VALOR SUPERA AL PERMITIDO...
                if(value > 20000)
                {
                    //LANZO EL EVENTO
                    this.LimiteSueldo(value, this); // el 'this' del parametro es la instancia de Empleado
                }
                else
                {
                    this.sueldo = value;
                }
            }
        }

        #endregion

    }
}
