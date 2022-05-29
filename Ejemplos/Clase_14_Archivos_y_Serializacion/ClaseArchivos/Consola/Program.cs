using System;
using System.IO;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.VerificarSistemaOperativo();
            Program.ObtenerInformacionOS();
            Program.ObtenerInformacionAlmacenamiento();

            Program.CrearDirectorio();
            Program.CambiarNombreDirectorio();
            Program.TrabajarConRutasRelativasYAbsolutas();
            Program.TrabajarConRutasArchivos();
        }

        static void VerificarSistemaOperativo()
        {
            Console.WriteLine("¿Es Linux? {0}", OperatingSystem.IsLinux());
            Console.WriteLine("¿Es Android? {0}", OperatingSystem.IsAndroid());
            Console.WriteLine("¿Es IOS? {0}", OperatingSystem.IsIOS());
            Console.WriteLine("¿Es MacOS? {0}", OperatingSystem.IsMacOS());
            Console.WriteLine("¿Es Windows? {0}", OperatingSystem.IsWindows());
            Console.WriteLine(Environment.NewLine);
        }

        static void ObtenerInformacionOS()
        {
            Console.WriteLine("Sistema Operativo: {0}", Environment.OSVersion);
            Console.WriteLine("Usuario: {0}", Environment.UserName);
            Console.WriteLine("Plataforma: {0}", Environment.OSVersion.Platform);
            Console.WriteLine("Procesadores lógicos: {0}", Environment.ProcessorCount);
            Console.WriteLine("¿Arquitectura de 64bits? {0}", Environment.Is64BitProcess);
            Console.WriteLine(Environment.NewLine);
        }

        static void ObtenerInformacionAlmacenamiento()
        {
            DriveInfo[] volumenes = DriveInfo.GetDrives();

            foreach (DriveInfo item in volumenes)
            {
                Console.WriteLine("Name: {0} | Tipo: {1} | Formato: {2} | Tamaño: {3} | Espacio Libre: {4}", item.Name, item.DriveType, item.DriveFormat, item.TotalSize, item.AvailableFreeSpace);
            }
            Console.WriteLine(Environment.NewLine);
        }

        static void CrearDirectorio()
        {
            string pathDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            Console.WriteLine("Desktop: {0}", pathDesktop);
            string rutaNuevoDirectorio = Path.Combine(pathDesktop, "Prueba");

            bool rta = Directory.Exists(rutaNuevoDirectorio);
            Console.WriteLine("¿Existe directorio? {0}", rta);

            Directory.CreateDirectory(rutaNuevoDirectorio);

            rta = Directory.Exists(rutaNuevoDirectorio);
            Console.WriteLine("¿Existe directorio? {0}", rta);

            Console.WriteLine(Environment.NewLine);
        }

        static void CambiarNombreDirectorio()
        {
            string pathDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string rutaDirectorio = Path.Combine(pathDesktop, "Prueba");

            string rutaRenombrar = Path.Combine(pathDesktop, "PruebaRenombrar");

            if (!Directory.Exists(rutaRenombrar))
            {
                Directory.Move(rutaDirectorio, rutaRenombrar);
            }

            if (Directory.Exists(rutaRenombrar))
            {
                Console.WriteLine(rutaRenombrar);
            }

            Console.WriteLine(Environment.NewLine);
        }

        static void TrabajarConRutasRelativasYAbsolutas()
        {
            string rutaAbsoluta = Path.GetFullPath(".");
            Console.WriteLine("Ruta absoluta: {0} {1}", rutaAbsoluta, Environment.NewLine);

            string pathDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            
            string rutaRelativa = Path.GetRelativePath(pathDesktop, ".");
            Console.WriteLine("Ruta relativa escritorio a app: {0} {1}", rutaRelativa, Environment.NewLine);

            string rutaRelativa2 = Path.GetRelativePath(".", pathDesktop);
            Console.WriteLine("Ruta relativa app a escritorio: {0} {1}", rutaRelativa2, Environment.NewLine);
        }

        static void TrabajarConRutasArchivos()
        {
            string ruta = ".";
            string[] archivos = Directory.GetFiles(ruta);
            foreach (string item in archivos)
            {
                Console.WriteLine(item);
                Console.WriteLine(Path.GetFileName(item));
                Console.WriteLine(Path.GetExtension(item));
                Console.WriteLine();
            }
        }
    }
}
