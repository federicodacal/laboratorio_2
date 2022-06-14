using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class MiClase
    {
        #region Miembros de una clase

        #region Miembros ESTÁTICOS

        ///* miembros ESTÁTICOS
        ///* lleva la palabra reservada static
        ///* se pueden llamar: miembro estático o miembro de clase
        ///* cómo lo invoco: Clase.Miembro

        #endregion

        #region Miembros NO ESTÁTICOS

        ///* miembros NO ESTÁTICOS
        ///* NO LLEVA la palabra reservada static
        ///* se pueden llamar: miembros de instancia
        ///* cómo lo invoco: objeto.Miembro

        #endregion


        #region atributos (de clase)

        public static int entero;

        public static string cadena;

        #endregion

        #region métodos (de clase)

        public static void Mostrar()
        {
            System.Console.WriteLine(MiClase.entero);
            System.Console.WriteLine(MiClase.cadena);
        }

        public static void Guardar(int entero, string cadena)
        {
            MiClase.entero = entero;
            MiClase.cadena = cadena;
        }

        #endregion

        #endregion
    }
}
