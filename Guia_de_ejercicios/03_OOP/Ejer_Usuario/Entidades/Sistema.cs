using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Sistema
    {
        private static List<Usuario> usuarios;

        static Sistema()
        {
            Sistema.usuarios = new List<Usuario>();
        }

        public static void CargarUsuarios()
        {
            usuarios.Add(new Usuario("Pepe","asd1234"));
            usuarios.Add(new Usuario("Carola","clave1234"));
            usuarios.Add(new Usuario("Romeo","password"));
            usuarios.Add(new Usuario("Julieta","12341234"));
            usuarios.Add(new Usuario("Juana","juana123"));
            usuarios.Add(new Usuario("Jazmin","jaz_min"));
        }

        public static bool VerificarUsuario(Usuario user)
        {
            if(!String.IsNullOrEmpty(user.GetUsername()) && !String.IsNullOrEmpty(user.GetPassword()))
            {
                foreach (Usuario item in usuarios)
                {
                    if(item == user)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static void AgregarNuevoUsuario(Usuario user)
        {
            if (!String.IsNullOrEmpty(user.GetUsername()) && !String.IsNullOrEmpty(user.GetPassword()))
            {
                if(String.IsNullOrEmpty(user.Telefono) || String.IsNullOrEmpty(user.Direccion))
                {
                    if(!VerificarUsuario(user))
                    {
                        Sistema.usuarios.Add(new Usuario(user.GetUsername(), user.GetPassword()));
                    }
                }
                else
                {
                    if (!VerificarUsuario(user))
                    {
                        Sistema.usuarios.Add(new Usuario(user.GetUsername(), user.GetPassword(), user.Telefono, user.Direccion));
                    }
                }
            }
        }

        public static string ListarUsuarios()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("*** LISTA DE USUARIOS ***");
            foreach (Usuario item in Sistema.usuarios)
            {
                sb.AppendLine(item.Mostrar());
            }
            return sb.ToString();
        }

    }
}
