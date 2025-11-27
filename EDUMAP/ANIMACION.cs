using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDUMAP
{
    public partial class ANIMACION : Form
    {
        Timer animLogo;
        Timer animTitulo;
        Timer animFrase;
        Timer finalizador;

        PictureBox logo;
        Label titulo;
        Label frase;

        int pasoLogo = 0;
        float escalaTitulo = 0.1f;
        float opacidadFrase = 0f;
        public ANIMACION()
        {
            InitializeComponent();
            ConfiguracionInicial();
            CrearComponentes();
            IniciarAnimaciones();
        }
        private void ConfiguracionInicial()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;
            this.Width = 600;
            this.Height = 350;
            this.Opacity = 1;
        }
        private void CrearComponentes()
        {
            // LOGO
            logo = new PictureBox();
            logo.Image = Properties.Resources.EDUMAP;
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.Width = 140;
            logo.Height = 140;
            logo.Location = new Point((this.Width - logo.Width) / 2, 200);
            this.Controls.Add(logo);

            // TÍTULO
            titulo = new Label();
            titulo.Text = "EduMap";
            titulo.ForeColor = Color.FromArgb(0, 51, 102);
            titulo.Font = new Font("Segoe UI", 1, FontStyle.Bold); // Comienza pequeño
            titulo.AutoSize = true;
            titulo.Location = new Point(240, 40);
            this.Controls.Add(titulo);

            
        }
        private void IniciarAnimaciones()
        {
            // LOGO SUBE
            animLogo = new Timer();
            animLogo.Interval = 15;
            animLogo.Tick += AnimLogo_Tick;
            animLogo.Start();

            // TÍTULO CRECE
            animTitulo = new Timer();
            animTitulo.Interval = 20;
            animTitulo.Tick += AnimTitulo_Tick;

            

            // FINALIZAR SPLASH
            finalizador = new Timer();
            finalizador.Interval = 3000;
            finalizador.Tick += Finalizador_Tick;
        }
        private void AnimLogo_Tick(object sender, EventArgs e)
        {
            if (pasoLogo < 60)
            {
                logo.Top -= 2;
                pasoLogo++;
            }
            else
            {
                animLogo.Stop();
                animTitulo.Start();
            }
        }
        private void AnimTitulo_Tick(object sender, EventArgs e)
        {
            if (escalaTitulo < 1.0f)
            {
                escalaTitulo += 0.05f;
                titulo.Font = new Font("Segoe UI", 26 * escalaTitulo, FontStyle.Bold);
                titulo.Left = (this.Width - titulo.Width) / 2;
            }
            else
            {
                animTitulo.Stop();
                
               
            }
        }
        private void AnimFrase_Tick(object sender, EventArgs e)
        {
            if (opacidadFrase < 1.0f)
            {
                opacidadFrase += 0.05f;
                frase.ForeColor = Color.FromArgb((int)(255 * opacidadFrase), 0, 0, 0);
            }
            else
            {
                animFrase.Stop();
                finalizador.Start();
            }
        }
        private void Finalizador_Tick(object sender, EventArgs e)
        {
            finalizador.Stop();

            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void ANIMACION_Load(object sender, EventArgs e)
        {
            
        }

    }
}
