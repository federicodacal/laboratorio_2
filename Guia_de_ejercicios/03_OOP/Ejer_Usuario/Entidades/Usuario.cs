using System;
using System.Text;

namespace Entidades
{
    public class Usuario
    {
        private static int userId;
        private int id;
        private string username;
        private string telefono;
        private string direccion;
        private string password;

        static Usuario()
        {
            Usuario.userId = 100;
        }

        public Usuario(string username, string password)
        {
            this.username = username;
            this.password = password;
            this.id = Usuario.userId++;
        }

        public Usuario(string username, string password, string telefono, string direccion):this(username, password)
        {
            this.telefono = telefono;
            this.direccion = direccion;
        }

        public int GetId()
        {
            return this.id;
        }

        private void SetId(int value)
        {
            if(value > 0)
            {
                this.id = value;
            }
        }

        public string GetUsername()
        {
            return this.username;
        }

        private void SetUsername(string value)
        {
            if (!String.IsNullOrWhiteSpace(value) && value.Length > 4)
            {
                this.username = value;
            }
        }

        public string GetPassword()
        {
            return this.password;
        }

        private void SetPassword(string value)
        {
            if (!String.IsNullOrWhiteSpace(value) && value.Length > 4)
            {
                this.password = value;
            }
        }

        public string Telefono { get => telefono; set => telefono = value; }

        public string Direccion { get => direccion; set => direccion = value; }

        public static bool operator ==(Usuario u1, Usuario u2)
        {
            if(u1 is not null && u2 is not null)
            {
                return u1.username == u2.username && u1.password == u2.password;
            }
            return false;
        }

        public static bool operator !=(Usuario u1, Usuario u2)
        {
            return !(u1 == u2);
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"ID: {this.GetId()} | Nombre: {this.GetUsername()}");
            sb.AppendLine($"Direccion: {this.Direccion}");
            sb.AppendLine($"Telefono: {this.Telefono}");
            return sb.ToString();
        }

    }
}
