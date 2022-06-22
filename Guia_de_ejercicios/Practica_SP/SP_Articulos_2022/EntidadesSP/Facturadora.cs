using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///Crear el manejador necesario para que, una vez capturado el evento, se imprima en un archivo de texto: 
///la fecha (con hora, minutos y segundos) y el total de la lata (en un nuevo renglón). 
///Se deben acumular los mensajes. 
///El archivo se guardará con el nombre 'facturas.log' en la carpeta 'Mis documentos' del cliente.
///El manejador de eventos (Lata_EventoPrecio) invocará al método (de clase) 
///ImprimirFactura(Lata<T>) (se alojará en la clase Facturadora<T>), que retorna un booleano 
///indicando si se pudo escribir o no.
///la clase Facturadora<T> sólo podrá 'facturar' tomates, pinturas o cervezas.

namespace EntidadesSP
{
    public class Facturadora<T>
        where T : Articulo
    {
        public static bool ImprimirFactura(Lata<T> lata)
        {
            bool rta = false;
            try
            {
                using (StreamWriter sw = new StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "facturas.log"), true))
                {
                    sw.WriteLine(DateTime.Now.ToString());
                    sw.WriteLine($"Total Caja: ${String.Format("{0:0.00}", lata.PrecioTotal)}");
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
