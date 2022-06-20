using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("********* PUNTO 1 *********");
            //Console.WriteLine();
            //ClaseGenerica<string, DateTime> objClaseGenerica = new ClaseGenerica<string, DateTime>(DateTime.Now);

            //objClaseGenerica.Add("Primer elemento");
            //objClaseGenerica.Add("Segundo elemento");
            //objClaseGenerica.Add("Tercer elemento");

            //Console.WriteLine(objClaseGenerica.ToString());

            //Console.WriteLine();

            //objClaseGenerica.Remove(5);
            //objClaseGenerica.Remove(2);

            //Console.WriteLine(objClaseGenerica.ToString());

            //Console.WriteLine("********* PUNTO 2 *********");
            //try
            //{
            //    string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "serializacion_modelo");

            //    if (objClaseGenerica.Serializar(path))
            //    {
            //        Console.WriteLine("Serialización XML OK!");
            //    }

            //    ClaseGenerica<string, DateTime> objClaseGenericaDeserializada;

            //    string path2 = Path.Combine(path, $"21_28_45.xml");

            //    if (objClaseGenerica.Deserializar(path2, out objClaseGenericaDeserializada))
            //    {
            //        Console.WriteLine("Deserializacion XML OK!\n");
            //        Console.WriteLine(objClaseGenericaDeserializada.ToString());
            //    }
            //}
            //catch (XmlSerializationException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //Console.WriteLine();
            //Console.WriteLine("********* PUNTO 6 *********");

            //try
            //{
            //    ClaseEvento objClaseEvento = new ClaseEvento(30, "Hola");

            //    objClaseEvento.EventoToString += new DelegadoToString(MensajeParaEventoToString);

            //    Console.WriteLine(objClaseEvento.ToString());

            //    Console.WriteLine();
            //    string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //    string pathLog = Path.Combine(desktop, "evento_modelo.log");

            //    Console.WriteLine("Leer archivo .log:");
            //    string logFile = Program.LeerArchivo(pathLog);
            //    Console.WriteLine(logFile);

            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //try
            //{
            //    string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "serializacion_modelo");

            //   string path2 = Path.Combine(path, $"21_53_22.json");

            //    Usuario usuario = new Usuario("Jorge", 85);

            //    if (usuario.Serializar(path))
            //    {
            //        Console.WriteLine("Serialización JSON OK!");
            //    }

            //    Usuario otroUsuario;
            //    if (usuario.Deserializar(path2, out otroUsuario))
            //    {
            //        Console.WriteLine("Deserialización JSON OK!");
            //        Console.WriteLine(otroUsuario.ToString());
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //try
            //{
            //    UsuarioDAO dao = new UsuarioDAO();

            //    Usuario u1 = new Usuario("Juan", 20);

            //    if (dao.Save(u1))
            //    {
            //        Console.WriteLine("Se guardó!!!");
            //        Usuario desdeBase = dao.ReadById(1);
            //        Console.WriteLine(desdeBase.ToString());
            //    }

            //    if (dao.Delete(1))
            //    {
            //        Console.WriteLine("Se eliminó!!!");
            //    }

            //    Usuario u2 = new Usuario(2, "Gaspar", 33);

            //    if (dao.Update(u2))
            //    {
            //        Console.WriteLine("Se actualizó!!!");
            //    }

            //    List<Usuario> usuarios = dao.ReadAll();

            //    foreach (Usuario item in usuarios)
            //    {
            //        Console.WriteLine(item.ToString());
            //    }

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = Path.Combine(desktop, "evento_modelo.log");

            Task t = Task.Run(() => Console.WriteLine(Program.LeerArchivo(path)));

            t.Wait();
            Console.WriteLine("Listo");
            
        }

        // MANEJADOR EVENTO
        public static void MensajeParaEventoToString(ClaseEvento sender, ClaseEventoEventArgs e)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = Path.Combine(desktop, "evento_modelo.log");

            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine($"{e.numero} {e.cadena}");
                    sw.WriteLine($"{e.fecha}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        
        public static string LeerArchivo(string filePath)
        {
            Thread.Sleep(2000);
            using (StreamReader sr = new StreamReader(filePath))
            {
                string texto = sr.ReadToEnd();
                return texto;
            }
        }

    }
}
