using System;
using System.IO;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmIdentificacionComputadora : Form
    {
        public FrmIdentificacionComputadora()
        {
            InitializeComponent();
        }

        private void FrmIdentificacionComputadora_Load(object sender, System.EventArgs e)
        {
            this.Text += $"Compu de {Environment.UserName}";

            this.ConfigurarLogoSistemaOperativo();

            this.lblSistemaOperativo.Text += $" {Environment.OSVersion.VersionString}";

            this.lblNombreMaquina.Text += $"{Environment.MachineName}";

            this.ConfigurarArquitectura();

            this.lblCantProcesadores.Text += $" {Environment.ProcessorCount} procesadores lógicos";

            this.lblDirectorioActual.Text += $"{Environment.NewLine}{Environment.CurrentDirectory}";

            this.ConfigurarEspacioTotalYDisponible();
        }

        private double ConvertirBytesAGigabytes(double bytes)
        {
            return bytes / 1073741824;
        }

        private void ConfigurarEspacioTotalYDisponible()
        {
            double espacioTotal = 0;
            double espacioDisponible = 0;
            foreach (DriveInfo item in DriveInfo.GetDrives())
            {
                espacioTotal += item.TotalSize;
                espacioDisponible += item.AvailableFreeSpace;
            }
            this.lblEspacioTotal.Text += $" {Math.Round(this.ConvertirBytesAGigabytes(espacioTotal))} gigabytes";
            this.lblEspacioDisponible.Text += $" {Math.Round(this.ConvertirBytesAGigabytes(espacioDisponible))} gigabytes";
        }

        private void ConfigurarArquitectura()
        {
            if (Environment.Is64BitOperatingSystem)
            {
                this.lblArquitectura.Text += " 64 bits";
            }
            else
            {
                this.lblArquitectura.Text += " 32 bits";
            }
        }

        private void ConfigurarLogoSistemaOperativo()
        {
            if (OperatingSystem.IsWindows())
            {
                this.picboxSistemaOperativo.Image = Properties.Resources.windows;
            }
            else if (OperatingSystem.IsMacOS())
            {
                this.picboxSistemaOperativo.Image = Properties.Resources.mac;
            }
            else if (OperatingSystem.IsLinux())
            {
                this.picboxSistemaOperativo.Image = Properties.Resources.linux;
            }
        }
    }
}
