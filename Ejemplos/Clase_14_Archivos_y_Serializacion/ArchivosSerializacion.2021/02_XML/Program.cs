using System;
using System.Text;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Xml;
using Entidades;
using System.IO;

namespace _02_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Serializar y Deserializar objeto

            Dato d = new Dato("Pepe", 20);

            try
            {
                //Creo un objeto que 'sabe' como escribir en XML
                //Datos.xml se crea en la carpeta Debug del proyecto -> net 5.0 -> Datos.xml 
                using (XmlTextWriter writer = new XmlTextWriter("Datos.xml", System.Text.Encoding.UTF8))
                {
                    //Creo un objeto que 'sabe' como serializar a XML
                    //Le tengo que indicar que tipo de objeto se va a serializar
                    XmlSerializer ser = new XmlSerializer(typeof(Dato));

                    //Utilizo el método Serialize, pasándole el 'escritor' de XML
                    //y el objeto a serializar
                    ser.Serialize(writer, d);
                }

                //Creo un objeto que 'sabe' como leer de XML
                using (XmlTextReader reader = new XmlTextReader("Datos.xml"))
                {
                    //Creo un objeto que 'sabe' como deserializar de XML
                    //Le tengo que indicar que tipo de objeto se va a deserializar
                    XmlSerializer ser = new XmlSerializer(typeof(Dato));

                    //Utilizo el método Deserialize, pasándole el 'lector' de XML
                    //Debo 'castear' al tipo de dato específico, ya que 
                    //el método Deserialize retorna un Object
                    Dato aux = (Dato)ser.Deserialize(reader);

                    Console.WriteLine(aux.ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Falló la serialización. Razones: " + e.Message);
            }

            #endregion

            #region Serializar y Deserializar 'generics'

            Lista<Dato> listaDato = new Lista<Dato>();
            Lista<Dato> listaDatoXML;

            Dato d1 = new Dato("juan", 22);
            Dato d2 = new Dato("pedro", 33);
            Dato d3 = new Dato("mara", 44);
            Dato d4 = new Dato("carmen", 55);

            listaDato.Items.Add(d1);
            listaDato.Items.Add(d2);
            listaDato.Items.Add(d3);
            listaDato.Items.Add(d4);

            string desktop = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            string ruta = Path.Combine(desktop, "DatosLista.xml");

            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(ruta, Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer((typeof(Lista<Dato>)));
                    ser.Serialize(writer, listaDato);
                }

                using (XmlTextReader reader = new XmlTextReader(ruta))
                {
                    XmlSerializer ser = new XmlSerializer((typeof(Lista<Dato>)));

                    listaDatoXML = (Lista<Dato>)ser.Deserialize(reader);
                }

                foreach (Dato miDato in listaDatoXML.Items)
                {
                    Console.WriteLine(miDato.ToString());
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Error al Serializar/Deserializar los Datos");
            }

            #endregion

            #region Serializar y Deserializar 'herencia'

            List<ClaseAbstracta> lista = new List<ClaseAbstracta>();

            lista.Add(new ClaseHija1(1, "Cadena1", 1.1));
            lista.Add(new ClaseHija2(2, "Cadena2", true));
            lista.Add(new ClaseHija1(3, "Cadena3", 2.2));
            lista.Add(new ClaseHija2(4, "Cadena4", false));

            string rutaHerencia = Path.Combine(desktop, "DatosListaHerencia.xml");

            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(rutaHerencia, Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer((typeof(List<ClaseAbstracta>)));

                    ser.Serialize(writer, lista);
                }

                using (XmlTextReader reader = new XmlTextReader(rutaHerencia))
                {
                    XmlSerializer ser = new XmlSerializer((typeof(List<ClaseAbstracta>)));

                    lista = (List<ClaseAbstracta>)ser.Deserialize(reader);
                }

                foreach (ClaseAbstracta item in lista)
                {
                    Console.WriteLine(item.ToString());
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("Error al Serializar los Datos");
            }

            Console.ReadLine();

            #endregion

        }
    }
}
