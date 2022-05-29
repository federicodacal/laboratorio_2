using System;
using Entidades;

namespace ConsolaSerializacion
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("<---------------------SERIALIZACION------------------------------>");
                Console.WriteLine("<---------------------XML------------------------------>");
                Console.WriteLine();

                Alumno alumno1 = new Alumno("Pepe", new DateTime(1990, 10, 05));
                alumno1.Materias.Add("Programacion");
                alumno1.Materias.Add("Laboratorio");
                alumno1.Materias.Add("Ingles");

                Alumno alumno2 = new Alumno("Juana", new DateTime(1995, 10, 15));
                alumno2.Materias.Add("Base de Datos");
                alumno2.Materias.Add("Programacion");
                alumno2.Materias.Add("Matematica");

                Profesor profesor = new Profesor("Ramon", new DateTime(1955, 09, 03), 19500);
                profesor.Divisiones.Add("2C");
                profesor.Divisiones.Add("2D");

                SerializadoraPersona<Persona>.SerializarPersona_StreamWriter("alumnoSerializado1.xml", alumno1);
                SerializadoraPersona<Persona>.SerializarPersona_XmlTextWriter("alumnoSerializado2.xml", alumno2);
                SerializadoraPersona<Persona>.SerializarPersona_StreamWriter("profesorSerializado.xml", profesor);

                Console.WriteLine("Deserializo con StreamReader");
                Console.WriteLine();
                Persona a1 = SerializadoraPersona<Persona>.DeserializarPersona_StreamReader("alumnoSerializado1.xml");
                Persona a2 = SerializadoraPersona<Persona>.DeserializarPersona_StreamReader("alumnoSerializado2.xml");
                Persona p1 = SerializadoraPersona<Persona>.DeserializarPersona_StreamReader("profesorSerializado.xml");

                Console.WriteLine(a1.ToString());
                Console.WriteLine(a2.ToString());
                Console.WriteLine(p1.ToString());

                Console.WriteLine("Deserializo con TextReader");
                Console.WriteLine();
                Persona a4 = SerializadoraPersona<Persona>.DeserializarPersona_TextReader("alumnoSerializado1.xml");
                Persona a5 = SerializadoraPersona<Persona>.DeserializarPersona_TextReader("alumnoSerializado2.xml");
                Persona p2 = SerializadoraPersona<Persona>.DeserializarPersona_TextReader("profesorSerializado.xml");

                Console.WriteLine(a4.ToString());
                Console.WriteLine(a5.ToString());
                Console.WriteLine(p2.ToString());

                Console.WriteLine();
                Console.WriteLine("<---------------------JSON------------------------------>");
                Console.WriteLine();

                Alumno nuevoAlumno = new Alumno("Alumno Sobresaliente", new DateTime(1999, 09, 09));
                nuevoAlumno.Materias.Add("Programacion");
                nuevoAlumno.Materias.Add("Sistemas Operativos");

                Profesor nuevoProfesor = new Profesor("Laura", new DateTime(1985, 12, 04), 16000);
                nuevoProfesor.Divisiones.Add("3C");
                nuevoProfesor.Divisiones.Add("4A");

                SerializadoraPersona<Alumno>.Serializar_JSON("alumno.json", nuevoAlumno);
                SerializadoraPersona<Profesor>.Serializar_JSON("profesor.json", nuevoProfesor);

                Alumno alumnoJson = SerializadoraPersona<Alumno>.Deserializar_JSON("alumno.json");
                Profesor profesorJson = SerializadoraPersona<Profesor>.Deserializar_JSON("profesor.json");

                Console.WriteLine(alumnoJson.ToString());
                Console.WriteLine(profesorJson.ToString());

                Console.WriteLine("Listo");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
