using System;
using System.Drawing;

namespace CoreLibraries
{
    public class Senador : IParlamentario
    {
        private object controlVisual;
        private string banca;
        private bool presentismo;
        private EVoto voto;

        public Senador(string banca, object controlVisual)
        {
            this.controlVisual = controlVisual;
            this.banca = banca;
            this.voto = EVoto.Indefinido;
        }

        [System.Text.Json.Serialization.JsonIgnore]
        public object ControlVisual { get => controlVisual; set => controlVisual = value; }

        public Color ColorDeBanca
        {
            get
            {
                if (this.Presentismo)
                {
                    switch (this.Voto)
                    {
                        case EVoto.Abstencion:
                            return Color.FromArgb(0,200,255);
                        case EVoto.Negativo:
                            return Color.DarkRed;
                        case EVoto.Afirmativo:
                            return Color.DarkGreen;
                        default:
                            return Color.DarkBlue;
                    }
                }
                else
                    return Color.Black;
            }
        }

        public bool AperturaSesion
        {
            set
            {
                if (value) // true
                {
                    if (new Random().Next(0,2) == 1)
                    {
                        this.Presentismo = value;
                    }
                    else
                    {
                        this.Presentismo = false;
                    }
                }
                else
                {
                    this.Presentismo = false;
                }
            }
        }

        public bool Presentismo 
        { 
            get => this.presentismo;
            set => this.presentismo = value; 
        }
        public EVoto Voto 
        {
            get => this.voto;
            set => this.voto = value;
        }
        public string Banca { get => banca; set => banca = value; }

        public void EmitirVoto()
        {
            this.voto = (EVoto)new Random().Next(1, 4);
        }

    }
}
