using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDUMAP
{
    public partial class cardUniversidades : UserControl
    {
        public double Latitud { get; set; }
        public double Longitud { get; set; }

        public string PaginaWeb { get; set; }
        public bool EsTelefono { get; set; }

        public event EventHandler CardClick;

        public cardUniversidades()
        {
            InitializeComponent();

            this.Click += Card_Click;

            foreach (Control c in Controls)
                c.Click += Card_Click;

            btnDetalles.Click += btnDetalles_Click;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
        }

        private void Card_Click(object sender, EventArgs e)
        {
            CardClick?.Invoke(this, EventArgs.Empty);
        }

        public void CargarDatos(string universidad, string tipo, string carrera, string paginaWeb)
        {
            lblNombre.Text = universidad;
            lblTipo.Text = tipo;
            lblCarrera.Text = carrera;

            PaginaWeb = paginaWeb?.Trim() ?? "";
            EsTelefono = EsNumeroTelefono(PaginaWeb);

            if (string.IsNullOrWhiteSpace(PaginaWeb))
            {
                linkLabel1.Text = "Sin página disponible";
                linkLabel1.Enabled = false;
            }
            else if (EsTelefono)
            {
                linkLabel1.Text = "Tel: " + PaginaWeb;
                linkLabel1.Enabled = false; // No redirige
            }
            else
            {
                linkLabel1.Text = "Página oficial";
                linkLabel1.Enabled = true;
            }
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            // Solo zoom al mapa
            CardClick?.Invoke(this, EventArgs.Empty);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PaginaWeb))
                return;

            if (EsTelefono)
                return;

            AbrirPagina(PaginaWeb);
        }

        private bool EsNumeroTelefono(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
                return false;

            valor = valor.Trim();

            // Detecta teléfonos tipo:
            // +524499675049
            // 4499675049
            // 449 967 5049
            // (449) 967 5049
            return Regex.IsMatch(valor, @"^\+?\d[\d\s\-\(\)]{7,}$");
        }

        private void AbrirPagina(string url)
        {
            try
            {
                if (!url.StartsWith("http://") && !url.StartsWith("https://"))
                    url = "https://" + url;

                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir la página: " + ex.Message);
            }
        }
    }
}
