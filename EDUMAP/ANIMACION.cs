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
        Timer finalizador;

        PictureBox logo;
        Label titulo1;  // "Edu"
        Label titulo2;  // "Map"

        int pasoLogo = 0;
        int velocidadTitulo1 = 15;
        int velocidadTitulo2 = 15;

        int objetivoCentro1;
        int objetivoCentro2;
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
            this.Width = 800;
            this.Height = 550;
        }
        private void CrearComponentes()
        {
            // LOGO
            logo = new PictureBox();
            logo.Image = Properties.Resources.EDUMAP;
            
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.Width = 300;
            logo.Height = 200;
            logo.Location = new Point((this.Width - logo.Width) / 2, 200);
            this.Controls.Add(logo);

            // TÍTULO PARTE 1 ("Edu")
            titulo1 = new Label();
            titulo1.Text = "Edu";
            titulo1.Font = new Font("Segoe UI", 36, FontStyle.Bold);
            titulo1.ForeColor = Color.FromArgb(0, 51, 102);
            titulo1.AutoSize = true;

            // Empieza FUERA de la pantalla a la izquierda
            titulo1.Left = -300;
            titulo1.Top = 400;

            this.Controls.Add(titulo1);

            // TÍTULO PARTE 2 ("Map")
            titulo2 = new Label();
            titulo2.Text = "Map";
            titulo2.Font = new Font("Segoe UI", 36, FontStyle.Bold);
            titulo2.ForeColor = Color.FromArgb(0, 51, 102);
            titulo2.AutoSize = true;

            // Empieza FUERA de la pantalla a la derecha
            titulo2.Left = this.Width + 300;
            titulo2.Top = 400;

            this.Controls.Add(titulo2);

            // Calcular posiciones finales para que se unan en el centro
            int anchoTotal = titulo1.Width + titulo2.Width - 15; // 5 px de separación
            int inicioX = (this.Width - anchoTotal) / 2;

            objetivoCentro1 = inicioX;
            objetivoCentro2 = inicioX + titulo1.Width - 15;
        }
        private void IniciarAnimaciones()
        {
            // LOGO SUBE
            animLogo = new Timer();
            animLogo.Interval = 10;
            animLogo.Tick += AnimLogo_Tick;
            animLogo.Start();

            // TÍTULO ENTRA DESDE LOS LADOS
            animTitulo = new Timer();
            animTitulo.Interval = 15;
            animTitulo.Tick += AnimTitulo_Tick;

            // FINALIZADOR
            finalizador = new Timer();
            finalizador.Interval = 1500;
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
            bool titulo1Listo = false;
            bool titulo2Listo = false;

            // Mover "Edu" hacia el centro
            if (titulo1.Left < objetivoCentro1)
            {
                titulo1.Left += velocidadTitulo1;
            }
            else
            {
                titulo1.Left = objetivoCentro1;
                titulo1Listo = true;
            }

            // Mover "Map" hacia el centro
            if (titulo2.Left > objetivoCentro2)
            {
                titulo2.Left -= velocidadTitulo2;
            }
            else
            {
                titulo2.Left = objetivoCentro2;
                titulo2Listo = true;
            }

            // Cuando ambos lleguen al centro → detener animación
            if (titulo1Listo && titulo2Listo)
            {
                animTitulo.Stop();
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
