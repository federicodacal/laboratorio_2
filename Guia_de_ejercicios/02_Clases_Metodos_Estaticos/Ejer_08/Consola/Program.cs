using System;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia;
            int mes;
            int anio;
            int diasTranscurridos;

            Console.WriteLine("Ingrese su fecha de nacimiento");

            Console.WriteLine("Año: ");
            while(!int.TryParse(Console.ReadLine(), out anio))
            {
                Console.WriteLine("Error. Reingrese año: ");
            }

            Console.WriteLine("Mes: ");
            while (!int.TryParse(Console.ReadLine(), out mes))
            {
                Console.WriteLine("Error. Reingrese mes: ");
            }

            Console.WriteLine("Dia: ");
            while (!int.TryParse(Console.ReadLine(), out dia))
            {
                Console.WriteLine("Error. Reingrese dia: ");
            }

            if(Program.ValidarFecha(dia,mes,anio))
            {
                diasTranscurridos = Program.CalcularDiasTranscurridos(new DateTime(anio, mes, dia));
                Console.WriteLine($"Los dias transcurridos fueron {diasTranscurridos}");
            }
            else
            {
                Console.WriteLine("La fecha ingresada no es válida");
            }
        }

        public static bool esBisiesto(int anio)
        {
            bool rta = false;
            if(anio % 4 == 0)
            {
                rta = true;
                if(anio % 100 == 0)
                {
                    rta = false;
                    if(anio % 400 == 0)
                    {
                        rta = true;
                    }
                }
            }
            return rta;
        }

        public static bool ValidarFecha(int dia, int mes, int anio)
        {
            /*
            Con 31 días: Enero, Marzo, Mayo, Julio, Agosto, Octubre, Diciembre
            Con 30 días: Abril, Junio, Septiembre, Noviembre
            Con 29 días: Febrero (año bisiesto)
            Con 28 días: Febrero
            */

            bool esValido = false; 

            if(dia >= 1 && mes >= 1 && mes <= 12)
            {
                switch (mes)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        if (dia <= 31)
                        {
                            esValido = true;
                        }
                        break;
                    case 2:
                        if (Program.esBisiesto(anio))
                        {
                            if (dia <= 29)
                            {
                                esValido = true;
                            }
                        }
                        else
                        {
                            if (dia <= 28)
                            {
                                esValido = true;
                            }
                        }
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        if (dia <= 30)
                        {
                            esValido = true;
                        }
                        break;
                }
            }
            return esValido;
        }

        public static int CalcularDiasTranscurridos(DateTime fecha)
        {
            return (int)(DateTime.Now - fecha).TotalDays;
        }
    }
}
