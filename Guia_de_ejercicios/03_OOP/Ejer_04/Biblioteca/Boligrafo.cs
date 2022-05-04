using System;

namespace Biblioteca
{
    public class Boligrafo
    {
        private const short cantidadMaximaTinta = 10;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(ConsoleColor color):this(color,cantidadMaximaTinta)
        {

        }

        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            short tintaBoligrafo = (short)(this.GetTinta() + tinta);
            if(tintaBoligrafo < 0)
            {
                this.tinta = 0;
            }
            else if(tintaBoligrafo >= 0 && tintaBoligrafo <= 100)
            {
                this.tinta = tintaBoligrafo;
            }
            else
            {
                this.tinta = 100;
            }
        }
        public void Recargar()
        {
            this.SetTinta(cantidadMaximaTinta);
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            bool rta = false;
            short tintaBoligrafo = this.GetTinta();
            dibujo = "";
            if(tintaBoligrafo > 0)
            {
                if(tintaBoligrafo < gasto)
                {
                    dibujo = this.DibujarAsteriscos(tintaBoligrafo);
                    this.SetTinta(0);
                }
                else if(tintaBoligrafo > gasto)
                {
                    dibujo = this.DibujarAsteriscos(gasto);
                    this.SetTinta((short)(tintaBoligrafo - gasto));
                }
                rta = true;
            }
            return rta;
        }

        private string DibujarAsteriscos(short tinta)
        {
            string asteriscos = "";
            for (int i = 0; i < tinta; i++)
            {
                asteriscos += "*";
            }
            return asteriscos;
        }

        public void PintarDibujoEnConsola(string dibujo)
        {
            Console.ForegroundColor = this.GetColor();
            Console.WriteLine(dibujo);
            Console.ResetColor(); 
        }

        public string Mostrar()
        {
            return $"Bolígrafo: \nTinta: {this.GetTinta()} Color: {this.GetColor()}";
        }
    }
}
