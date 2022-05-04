using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Ingresante
    {
        private List<string> cursos;
        private string direccion;
        private int edad;
        private string genero;
        private string nombre;
        private string pais;

        public Ingresante(List<string> cursos, string direccion, int edad, string genero, string nombre, string pais)
        {
            this.cursos = cursos;
            this.direccion = direccion;
            this.edad = edad;
            this.genero = genero;
            this.nombre = nombre;
            this.pais = pais;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Direccion: {this.direccion}");
            sb.AppendLine($"Edad: {this.edad}");
            sb.AppendLine($"Genero: {this.genero}");
            sb.AppendLine($"Pais: {this.pais}");
            sb.AppendLine($"Curso/s:");
            foreach (string item in cursos)
            {
                sb.AppendLine(item);
            }
            return sb.ToString();
        }
    }
}
