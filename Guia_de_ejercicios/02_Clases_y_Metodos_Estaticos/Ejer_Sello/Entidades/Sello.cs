using System;

namespace Entidades
{
    public static class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;

        public static string Imprimir()
        {
            string mensaje;
            if(Sello.TryParse(Sello.mensaje, out mensaje))
            {
                return $"{Sello.ArmarFormatoMensaje()}\n{mensaje}\n{Sello.ArmarFormatoMensaje()}";
            }
            else
            {
                return "No se puede armar formato para mensaje vacío\n";
            }
        }

        public static void Borrar()
        {
            Sello.mensaje = "";
        }

        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = Sello.color;
            Console.WriteLine(Sello.Imprimir());
            Console.ResetColor();
        }

        private static string ArmarFormatoMensaje()
        {
            int length = Sello.mensaje.Trim().Length;
            string asteriscos = "";

            for (int i = 0; i < length; i++)
            {
                asteriscos += "*";
            }
            return asteriscos;
        }

        private static bool TryParse(string cadena, out string mensaje)
        {
            bool rta = false;
            cadena = cadena.Trim();
            mensaje = "";

            if(cadena.Length > 0)
            {
                rta = true;
                mensaje = cadena;
            }
            return rta;
        }
    }
}
