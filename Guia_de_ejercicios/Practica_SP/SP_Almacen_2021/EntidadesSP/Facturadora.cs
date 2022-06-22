using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///Crear el manejador necesario para que, una vez capturado el evento, se imprima en un archivo de texto: 
///la fecha (con hora, minutos y segundos) y el total de la caja (en un nuevo renglón). 
///Se deben acumular los mensajes. 
///El archivo se guardará con el nombre 'facturas.log' en la carpeta 'Mis documentos' del cliente.
///El manejador de eventos (Caja_EventoPrecio) invocará al método (de clase) 
///ImprimirFactura(Caja<T>) (se alojará en la clase Facturadora<T>), que retorna un booleano 
///indicando si se pudo escribir o no.
///la clase Facturadora<T> sólo podrá 'facturar' Zapatos, Fósforos o Remedios.

namespace EntidadesSP
{
    public class Facturadora<T>
        where T : Producto
    {
        public static bool ImprimirFactura(Caja<T> caja)
        {
            bool rta = false;
            try
            {
                using (StreamWriter sw = new StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "facturas.log"), true))
                {
                    sw.WriteLine(DateTime.Now.ToString());
                    sw.WriteLine($"Total Caja: ${String.Format("{0:0.00}", caja.PrecioTotal)}");
                    rta = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return rta;

        }

    }
}
