using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Biblioteca
    {
        private int codigoJuego;
        private string genero;
        private string juego;
        private string usuario;

        public Biblioteca(string genero, string juego, string usuario, int codigoJuego)
        {
            this.genero = genero;
            this.juego = juego;
            this.usuario = usuario;
            this.codigoJuego = codigoJuego;
        }

        public int CodigoJuego { get => codigoJuego; }
        public string Genero { get => genero;  }
        public string Juego { get => juego;  }
        public string Usuario { get => usuario;  }
    }
}
