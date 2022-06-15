using System;

namespace Entidades
{
    public static class Almacen
    {
        private static int productos;

        static Almacen()
        {
            Almacen.productos = 10;
        }

        public static void ValidarStock_1(int cantidadSolicitada, Action metodoBien, Action metodoMal)
        {
            if (Almacen.productos >= cantidadSolicitada)
            {
                metodoBien.Invoke();
            }
            else
            {
                metodoMal.Invoke();
            }
        }

        public static void ValidarStock_2(int cantidadSolicitada, Action<string> metodoBien, Action<int> metodoMal)
        {
            if (Almacen.productos >= cantidadSolicitada)
            {
                metodoBien.Invoke("Todo salió bien. Hay stock!");
            }
            else
            {
                int faltante = cantidadSolicitada - Almacen.productos;
                metodoMal.Invoke(faltante);
            }
        }
    }
}
