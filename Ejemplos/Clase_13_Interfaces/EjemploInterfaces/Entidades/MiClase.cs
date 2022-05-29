using System;

namespace Entidades
{
    public class MiClase : IMiInterfaz
    {
        public int Propiedad 
        { 
            get { return 1; } 
        }

        public string Saludar()
        {
            return "Hola!";
        }
    }
}
