using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perro : Mamifero
    {
        bool esGuardian;
        public Perro(string nombre, float peso, EPelaje pelaje, bool esGuardian) 
            :base(nombre, peso, pelaje)
        {
            this.esGuardian = esGuardian;
        }

        public string Ladrar()
        {
            return $"{this.Nombre}: Woof! Woof! :D";
        }

        public override string Mostrar()
        {
            return base.Mostrar() + $"\n¿Es guardian?: {this.esGuardian}";
        }

        public override string Alimentarse()
        {
            return "Perro come contento... " + base.Alimentarse();
        }

    }
}
