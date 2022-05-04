using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gato : Mamifero
    {
        float horasQueDuerme;
        public Gato(string nombre, float peso, EPelaje pelaje, float horasQueDuerme) 
            :base(nombre, peso, pelaje)
        {
            this.horasQueDuerme = horasQueDuerme;
        }

        public string Maullar() 
        {
            return $"{this.Nombre}: Meooow! :3";
        }

        public override string Mostrar()
        {
            return base.Mostrar() + $"\nHoras que duerme: {this.horasQueDuerme}";
        }

        public override string Alimentarse()
        {
            return "Gato salio a cazar... " + base.Alimentarse();
        }

    }
}
