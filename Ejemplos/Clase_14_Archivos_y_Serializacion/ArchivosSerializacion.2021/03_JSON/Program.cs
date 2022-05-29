using System;
using JSON;

namespace _03_JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Sin propiedades

            Dato obj = new Dato();

            string obj_json = System.Text.Json.JsonSerializer.Serialize(obj);

            Console.WriteLine(obj_json); // {}

            #endregion

            #region Con propiedades

            Dato1 obj1 = new Dato1();

            obj_json = System.Text.Json.JsonSerializer.Serialize(obj1);

            Console.WriteLine(obj_json);

            #endregion

            #region Clase no pública y sin constructor por defecto

            Dato2 obj2 = new Dato2("valor inicial");

            obj_json = System.Text.Json.JsonSerializer.Serialize(obj2);

            Console.WriteLine(obj_json);

            #endregion

            #region Con propiedades sólo lectura

            Dato3 obj3 = new Dato3("mi cadena");

            obj_json = System.Text.Json.JsonSerializer.Serialize(obj3);

            Console.WriteLine(obj_json);

            obj3 = null;
            obj3 = (Dato3)System.Text.Json.JsonSerializer.Deserialize(obj_json, typeof(Dato3));

            Console.WriteLine(obj3);

            #endregion

            #region Con colecciones

            Dato4 obj4 = new Dato4();

            // Genero el objeto de configuración de la serialización.
            System.Text.Json.JsonSerializerOptions opciones = new System.Text.Json.JsonSerializerOptions();
            opciones.WriteIndented = true; // Me permite ver la serialización con formato más legible

            obj_json = System.Text.Json.JsonSerializer.Serialize(obj4, opciones);

            Console.WriteLine(obj_json);

            obj4.Datos.Add(obj1);
            obj4.Datos.Add(new Dato1());

            obj_json = System.Text.Json.JsonSerializer.Serialize(obj4, opciones);

            Console.WriteLine(obj_json);

            Dato4 aux = (Dato4)System.Text.Json.JsonSerializer.Deserialize(obj_json, typeof(Dato4));

            Console.WriteLine(aux);

            Dato4 aux2 = System.Text.Json.JsonSerializer.Deserialize<Dato4>(obj_json);

            Console.WriteLine(aux2);

            #endregion

            #region Desde cadena json

            string jsonString = @"
                                {
                                    ""Cadena"": ""Valor cadena"",
                                    ""Fecha"": ""2018-12-09T09:12:18"",
                                    ""Numerico"": 31
                                }";

            // Obtengo un objeto de tipo Empleado a partir de un string
            // que contiene un empleado serializado en formato json. 
            Dato5 obj5 = System.Text.Json.JsonSerializer.Deserialize<Dato5>(jsonString);

            Console.WriteLine($"Cadena: {obj5.Cadena}");
            Console.WriteLine($"Fecha: {obj5.Fecha}");
            Console.WriteLine($"Numérico: {obj5.Numerico}");

            Console.WriteLine(obj5);

            #endregion

            #region Con archivos

            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(@"C:\archivos\dato.json"))
            {
                sw.WriteLine(obj_json);
            }

            Dato4 obj_archivo;
            using (System.IO.StreamReader sr = new System.IO.StreamReader(@"C:\archivos\dato.json"))
            {
                string json_str = sr.ReadToEnd();

                Console.WriteLine(json_str);

                obj_archivo = (Dato4)System.Text.Json.JsonSerializer.Deserialize(json_str, typeof(Dato4));
            }

            Console.WriteLine(obj_archivo);

            #endregion
        }
    }
}
