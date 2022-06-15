using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_07
{
    internal class GestorDatos
    {


        //public static string TraerRegistros()
        //{         
        //    return "La cantidad de registros es 2000";
        //}

        public static async Task<string> TraerRegistrosAsync() // t0
        {
            // t0
            string informacion = await Task.Run(() => // t1
            {
                Thread.Sleep(5000); // Simulo que va a la base
                return "La cantidad de registros es 2000";
            });
            // Await me indica que voy a esperar hasta que 'información' se cargue, es decir, t0 espera a t1 

            if(informacion.Length < 0)
            {
                throw new Exception("Info vacia");
            }

            return informacion;
        }

    }
}
