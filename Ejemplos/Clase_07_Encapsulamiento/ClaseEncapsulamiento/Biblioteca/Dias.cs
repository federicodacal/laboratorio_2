using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Dias
    {
        private string[] diasHabiles = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes"};

        public string this[int index]
        {
            get
            {
                if(index >= 0 && index < this.diasHabiles.Length)
                {
                    return this.diasHabiles[index];
                }
                return String.Empty;
            }

            set
            {
                if(index >= 0 && index < this.diasHabiles.Length)
                {
                    this.diasHabiles[index] = value;
                }
            }
        }
    }
}
