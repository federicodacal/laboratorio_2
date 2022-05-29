using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Dispositivo
    {
        private static List<Aplicacion> appsInstaladas;
        private static SistemaOperativo sistemaOperativo;

        static Dispositivo()
        {
            Dispositivo.appsInstaladas = new List<Aplicacion>();
            Dispositivo.sistemaOperativo = SistemaOperativo.ANDROID;
        }

        public static List<Aplicacion> AppsInstaladas
        {
            get { return Dispositivo.appsInstaladas; }
        }

        public static bool InstalarApp(Aplicacion app)
        {
            bool rta = false;
            if(app.SistemaOperativo == Dispositivo.sistemaOperativo)
            {
                rta = Dispositivo.appsInstaladas + app;
            }
            return rta;
        }

        public static string ObtenerInformacionDispositivo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Dispositivo con {Dispositivo.sistemaOperativo}\n");
            sb.AppendLine($"Apps Instaladas: {Dispositivo.appsInstaladas.Count}\n");
            foreach (Aplicacion item in Dispositivo.appsInstaladas)
            {
                sb.AppendLine(item.ObtenerInformacionApp());
                sb.AppendLine("************************************");
            }

            return sb.ToString();
        }
    }
}
