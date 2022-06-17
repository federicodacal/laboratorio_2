using System;

namespace Entidades
{
    // Los Objetos Newsletter son los emisores del evento.
    public class Newsletter // Button
    {
        //public delegate void NovedadHandler(Newsletter sender, string novedades);
        public delegate void NovedadHandler(Newsletter sender, NewsletterEventArgs novedades);

        public event NovedadHandler NovedadEnviada; // Click

        private string tema;

        public Newsletter(string tema)
        {
            this.tema = tema;
        }

        public string Tema
        {
            get { return this.tema; }
            set { this.tema = value; }
        }

        public void EnviarNovedades() // Acción de hacer el Click, lanzar evento
        {
            if(this.NovedadEnviada is not null)
            {
                NewsletterEventArgs eventArgs = new NewsletterEventArgs();

                eventArgs.Contenido = "Contenido";

                //this.NovedadEnviada.Invoke(this, "Contenido");

                this.NovedadEnviada.Invoke(this, eventArgs);
            }
        }
    }
}
