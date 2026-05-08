using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace EDUMAP
{

    public partial class TEST : Form
    {
        private int preguntaActual = 1;
        private const int totalPreguntas = 30;
        private int[] respuestas = new int[30];
        private Form FormActual = null;
        
        public TEST()
        {
            InitializeComponent();
        }
        int[] respuesta = new int[30];
        private void TEST_Load(object sender, EventArgs e)
        {
            Global.ReiniciarFase1();

            for (int i = 0; i < respuestas.Length; i++)
                respuestas[i] = -1;

            ActualizarContadorPregunta();
        }
        private void ActualizarContadorPregunta()
        {
            lblContador.Text = $"Pregunta {preguntaActual} de {totalPreguntas}";
        }
        private void SiguientePregunta()
        {
            if (preguntaActual < totalPreguntas)
            {
                preguntaActual++;
                ActualizarContadorPregunta();
            }
        }

        private void PreguntaAnterior()
        {
            if (preguntaActual > 1)
            {
                preguntaActual--;
                ActualizarContadorPregunta();
            }
        }

        private void SeleccionarOpcion(int numeroPregunta, int categoria, TabPage siguientePagina = null, bool finalizar = false)
        {
            if (numeroPregunta < 0 || numeroPregunta >= respuestas.Length)
            {
                MessageBox.Show("Número de pregunta inválido.");
                return;
            }

            if (categoria < 0 || categoria > 6)
            {
                MessageBox.Show("Categoría inválida.");
                return;
            }

            if (respuestas[numeroPregunta] != -1)
                Global.PuntajesFase1[respuestas[numeroPregunta]]--;

            respuestas[numeroPregunta] = categoria;
            Global.PuntajesFase1[categoria]++;

            if (finalizar)
            {
                abrirForm(new RESULTADO_FASE1());
                return;
            }

            SiguientePregunta();

            if (siguientePagina != null)
                tabControl1.SelectedTab = siguientePagina;
        }

        private void abrirForm(Form form)
        {
            if (FormActual != null)
                FormActual.Close();

            FormActual = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            panel1.Tag = form;
            form.BringToFront();
            form.Show();

            panelHeader.Hide();
            tableLayoutPanel2.Hide();
            tabControl1.Hide();
        }
        private void button209_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage30;
            SiguientePregunta();
            SeleccionarOpcion(29, 0);

            abrirForm(new RESULTADO_FASE1());
        }

        private void button206_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage30;
            SiguientePregunta();
            SeleccionarOpcion(29, 5);

            abrirForm(new RESULTADO_FASE1());
        }

        private void button207_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage30;
            SiguientePregunta();
            SeleccionarOpcion(29, 1);

            abrirForm(new RESULTADO_FASE1());
        }

        private void button205_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage30;
            SiguientePregunta();
            SeleccionarOpcion(29, 2);

            abrirForm(new RESULTADO_FASE1());
        }

        private void button203_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage30;
            SiguientePregunta();
            SeleccionarOpcion(29, 3);

            abrirForm(new RESULTADO_FASE1());
        }

        private void button208_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage30;
            SiguientePregunta();
            SeleccionarOpcion(29, 4);

            abrirForm(new RESULTADO_FASE1());
        }

        private void button204_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage30;
            SiguientePregunta();
            SeleccionarOpcion(29, 6);

            abrirForm(new RESULTADO_FASE1());
        }
        
        private void iconButton20_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage21;
            PreguntaAnterior();
        }

        private void lblContador_Click(object sender, EventArgs e)
        {

        }

        private void btnCampoA_Click(object sender, EventArgs e)
        {
            
            SeleccionarOpcion(0, 0);
            tabControl1.SelectedTab = tabPage2;
        }

        private void btnCampoC_Click_1(object sender, EventArgs e)
        {
            SeleccionarOpcion(0, 1);
            
            tabControl1.SelectedTab = tabPage2;
        }

        private void btnCampoD_Click_1(object sender, EventArgs e)
        {
            SeleccionarOpcion(0, 2);
            
            tabControl1.SelectedTab = tabPage2;
        }

        private void btnCampoE_Click_1(object sender, EventArgs e)
        {
            SeleccionarOpcion(0, 3);
            
            tabControl1.SelectedTab = tabPage2;
        }

        private void btnCampoF_Click_1(object sender, EventArgs e)
        {
            SeleccionarOpcion(0, 4);
            
            tabControl1.SelectedTab = tabPage2;
        }

        private void btnCampoL_Click_1(object sender, EventArgs e)
        {
            SeleccionarOpcion(0, 5);
            
            tabControl1.SelectedTab = tabPage2;
        }

        private void btnCampoS_Click_1(object sender, EventArgs e)
        {
            SeleccionarOpcion(0, 6);
            
            tabControl1.SelectedTab = tabPage2;
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            SeleccionarOpcion(1, 0);
            
            tabControl1.SelectedTab = tabPage3;
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            SeleccionarOpcion(1, 1);
            
            tabControl1.SelectedTab = tabPage3;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            SeleccionarOpcion(1, 2);
            
            tabControl1.SelectedTab = tabPage3;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SeleccionarOpcion(1, 3);
           
            tabControl1.SelectedTab = tabPage3;
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            SeleccionarOpcion(1, 4);
            
            tabControl1.SelectedTab = tabPage3;
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            SeleccionarOpcion(1, 5);
            
            tabControl1.SelectedTab = tabPage3;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            SeleccionarOpcion(1, 6);
            
            tabControl1.SelectedTab = tabPage3;
        }

        private void regresar_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
            PreguntaAnterior();
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            SeleccionarOpcion(2, 0);
           
            tabControl1.SelectedTab = tabPage4;
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            SeleccionarOpcion(2, 1);
            
            tabControl1.SelectedTab = tabPage4;
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            SeleccionarOpcion(2, 2);
            
            tabControl1.SelectedTab = tabPage4;
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            SeleccionarOpcion(2, 3);
            
            tabControl1.SelectedTab = tabPage4;
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            SeleccionarOpcion(2, 4);
            
            tabControl1.SelectedTab = tabPage4;
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            SeleccionarOpcion(2, 5);
            
            tabControl1.SelectedTab = tabPage4;
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            SeleccionarOpcion(2, 6);
            
            tabControl1.SelectedTab = tabPage4;
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
            PreguntaAnterior();
        }

        private void button27_Click_1(object sender, EventArgs e)
        {
            SeleccionarOpcion(3, 0);
            
            tabControl1.SelectedTab = tabPage5;
        }

        private void button25_Click_1(object sender, EventArgs e)
        {
            SeleccionarOpcion(3, 1);
            
            tabControl1.SelectedTab = tabPage5;
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            SeleccionarOpcion(3, 2);
            
            tabControl1.SelectedTab = tabPage5;
        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            SeleccionarOpcion(3, 3);
            
            tabControl1.SelectedTab = tabPage5;
        }

        private void button26_Click_1(object sender, EventArgs e)
        {
            SeleccionarOpcion(3, 4);
            
            tabControl1.SelectedTab = tabPage5;
        }

        private void button24_Click_1(object sender, EventArgs e)
        {
            SeleccionarOpcion(3, 5);
            
            tabControl1.SelectedTab = tabPage5;
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            SeleccionarOpcion(3, 6);
            
            tabControl1.SelectedTab = tabPage5;
        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
            PreguntaAnterior();
        }

        private void button34_Click_1(object sender, EventArgs e)
        {
            SeleccionarOpcion(4, 0);
            
            tabControl1.SelectedTab = tabPage6;
        }

        private void button32_Click_1(object sender, EventArgs e)
        {
            SeleccionarOpcion(4, 1);
            
            tabControl1.SelectedTab = tabPage6;
        }

        private void button30_Click_1(object sender, EventArgs e)
        {
            SeleccionarOpcion(4, 2);
            
            tabControl1.SelectedTab = tabPage6;
        }

        private void button28_Click_1(object sender, EventArgs e)
        {
            SeleccionarOpcion(4, 3);
            
            tabControl1.SelectedTab = tabPage6;
        }

        private void button33_Click_1(object sender, EventArgs e)
        {
            SeleccionarOpcion(4, 4);
            
            tabControl1.SelectedTab = tabPage6;
        }

        private void button31_Click_1(object sender, EventArgs e)
        {
            SeleccionarOpcion(4, 5);
            
            tabControl1.SelectedTab = tabPage6;
        }

        private void button29_Click_1(object sender, EventArgs e)
        {
            SeleccionarOpcion(4, 6);
            
            tabControl1.SelectedTab = tabPage6;
        }

        private void iconButton3_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
            PreguntaAnterior();
        }

        private void button41_Click_1(object sender, EventArgs e)
        {
            SeleccionarOpcion(5, 0);
            
            tabControl1.SelectedTab = tabPage7;
        }

        private void button39_Click_1(object sender, EventArgs e)
        {
            SeleccionarOpcion(5, 1);
            
            tabControl1.SelectedTab = tabPage7;
        }

        private void button37_Click_1(object sender, EventArgs e)
        {
            SeleccionarOpcion(5, 2);
            
            tabControl1.SelectedTab = tabPage7;
        }

        private void button35_Click_1(object sender, EventArgs e)
        {
            SeleccionarOpcion(5, 3);
            
            tabControl1.SelectedTab = tabPage7;
        }

        private void button40_Click_1(object sender, EventArgs e)
        {
            SeleccionarOpcion(5, 4);
            
            tabControl1.SelectedTab = tabPage7;
        }

        private void button38_Click_1(object sender, EventArgs e)
        {
            SeleccionarOpcion(5, 5);
            
            tabControl1.SelectedTab = tabPage7;
        }

        private void button36_Click_1(object sender, EventArgs e)
        {
            SeleccionarOpcion(5, 6);
            
            tabControl1.SelectedTab = tabPage7;
        }

        private void iconButton4_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage5;
            PreguntaAnterior();
        }

        private void button48_Click_1(object sender, EventArgs e)
        {
            SeleccionarOpcion(6, 0);
            
            tabControl1.SelectedTab = tabPage8;
        }

        private void button46_Click_1(object sender, EventArgs e)
        {
            SeleccionarOpcion(6, 1);
            
            tabControl1.SelectedTab = tabPage8;
        }

        private void button44_Click_1(object sender, EventArgs e)
        {
            SeleccionarOpcion(6, 2);
            
            tabControl1.SelectedTab = tabPage8;
        }

        private void button42_Click_1(object sender, EventArgs e)
        {
            SeleccionarOpcion(6, 3);
            
            tabControl1.SelectedTab = tabPage8;
        }

        private void button47_Click_1(object sender, EventArgs e)
        {
            SeleccionarOpcion(6, 4);
            
            tabControl1.SelectedTab = tabPage8;
        }

        private void button45_Click_1(object sender, EventArgs e)
        {
            SeleccionarOpcion(6, 5);
            
            tabControl1.SelectedTab = tabPage8;
        }

        private void button43_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage8;
           
            SeleccionarOpcion(6, 6);
        }

        private void iconButton5_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage6;
            PreguntaAnterior();
        }

        private void button55_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage9;
            
            SeleccionarOpcion(7, 0);
        }

        private void button53_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage9;
            
            SeleccionarOpcion(7, 1);
        }

        private void button51_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage9;
            
            SeleccionarOpcion(7, 2);
        }

        private void button49_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage9;
            
            SeleccionarOpcion(7, 3);
        }

        private void button54_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage9;
            
            SeleccionarOpcion(7, 4);
        }

        private void button52_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage9;
            
            SeleccionarOpcion(7, 5);
        }

        private void button50_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage9;
            
            SeleccionarOpcion(7, 6);
        }

        private void iconButton6_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage7;
            PreguntaAnterior();
        }

        private void button62_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage10;
            
            SeleccionarOpcion(8, 0);
        }

        private void button60_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage10;
            
            SeleccionarOpcion(8, 1);
        }

        private void button58_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage10;
            
            SeleccionarOpcion(8, 2);
        }

        private void button56_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage10;
            
            SeleccionarOpcion(8, 3);
        }

        private void button61_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage10;
            
            SeleccionarOpcion(8, 4);
        }

        private void button59_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage10;
            
            SeleccionarOpcion(8, 5);
        }

        private void button57_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage10;
            
            SeleccionarOpcion(8, 6);
        }

        private void iconButton7_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage8;
            PreguntaAnterior();
        }

        private void button69_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage11;
            
            SeleccionarOpcion(9, 0);
        }

        private void button67_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage11;
            
            SeleccionarOpcion(9, 1);
        }

        private void button65_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage11;
            
            SeleccionarOpcion(9, 2);
        }

        private void button63_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage11;
            
            SeleccionarOpcion(9, 3);
        }

        private void button68_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage11;
            
            SeleccionarOpcion(9, 4);
        }

        private void button66_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage11;
            
            SeleccionarOpcion(9, 5);
        }

        private void button64_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage11;
            
            SeleccionarOpcion(9, 6);
        }

        private void iconButton8_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage9;
            PreguntaAnterior();
        }

        private void button76_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage12;
            
            SeleccionarOpcion(10, 0);
        }

        private void button74_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage12;
            
            SeleccionarOpcion(10, 1);
        }

        private void button72_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage12;
            
            SeleccionarOpcion(10, 2);
        }

        private void button70_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage12;
            
            SeleccionarOpcion(10, 3);
        }

        private void button75_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage12;
            
            SeleccionarOpcion(10, 4);
        }

        private void button73_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage12;
            
            SeleccionarOpcion(10, 5);
        }

        private void button71_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage12;
           
            SeleccionarOpcion(10, 6);
        }

        private void iconButton9_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage10;
            PreguntaAnterior();
        }

        private void button83_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage13;
            
            SeleccionarOpcion(11, 0);
        }

        private void button81_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage13;
            
            SeleccionarOpcion(11, 1);
        }

        private void button79_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage13;
            
            SeleccionarOpcion(11, 2);
        }

        private void button77_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage13;
            
            SeleccionarOpcion(11, 3);
        }

        private void button82_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage13;
           
            SeleccionarOpcion(11, 4);
        }

        private void button80_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage13;
            SeleccionarOpcion(11, 5);
        }

        private void button78_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage13;
            SeleccionarOpcion(11, 6);
        }

        private void iconButton10_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage11;
            PreguntaAnterior();
        }

        private void button90_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage14;
            SeleccionarOpcion(12, 0);
        }

        private void button88_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage14;
            SeleccionarOpcion(12, 1);
        }

        private void button86_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage14;
            SeleccionarOpcion(12, 2);
        }

        private void button84_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage14;
            SeleccionarOpcion(12, 3);
        }

        private void button89_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage14;
            SeleccionarOpcion(12, 4);
        }

        private void button87_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage14;
            
            SeleccionarOpcion(12, 5);
        }

        private void button85_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage14;
            SeleccionarOpcion(12, 6);
        }

        private void iconButton11_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage12;
            PreguntaAnterior();
        }

        private void button97_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage15;
            SeleccionarOpcion(13, 0);
        }

        private void button95_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage15;
            SeleccionarOpcion(13, 1);
        }

        private void button93_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage15;
            SeleccionarOpcion(13, 2);
        }

        private void button91_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage15;
            SeleccionarOpcion(13, 3);
        }

        private void button96_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage15;
            SeleccionarOpcion(13, 4);
        }

        private void button94_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage15;
            SeleccionarOpcion(13, 5);
        }

        private void button92_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage15;
            SeleccionarOpcion(13, 6);
        }

        private void iconButton12_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage13;
            PreguntaAnterior();
        }

        private void button104_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage16;
            SeleccionarOpcion(14, 0);
        }

        private void button102_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage16;
            SeleccionarOpcion(14, 1);
        }

        private void button100_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage16;
            SeleccionarOpcion(14, 2);
        }

        private void button98_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage16;
            SeleccionarOpcion(14, 3);
        }

        private void button103_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage16;
            SeleccionarOpcion(14, 4);
        }

        private void button101_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage16;
            
            SeleccionarOpcion(14, 5);
        }

        private void button99_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage16;
            SeleccionarOpcion(14, 6);
        }

        private void iconButton13_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage14;
            PreguntaAnterior();
        }

        private void button111_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage17;
            
            SeleccionarOpcion(15, 0);
        }

        private void button109_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage17;
            SeleccionarOpcion(15, 1);
        }

        private void button107_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage17;
            SeleccionarOpcion(15, 2);
        }

        private void button105_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage17;
            
            SeleccionarOpcion(15, 3);
        }

        private void button110_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage17;
            SeleccionarOpcion(15, 4);
        }

        private void button108_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage17;
            SeleccionarOpcion(15, 5);
        }

        private void button106_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage17;
            SeleccionarOpcion(15, 6);
        }

        private void iconButton14_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage15;
            PreguntaAnterior();
        }

        private void button118_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage18;
            SeleccionarOpcion(16, 0);
        }

        private void button116_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage18;
            SeleccionarOpcion(16, 1);
        }

        private void button114_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage18;
            SeleccionarOpcion(16, 2);
        }

        private void button112_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage18;
            SeleccionarOpcion(16, 3);
        }

        private void button117_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage18;
            SeleccionarOpcion(16, 4);
        }

        private void button115_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage18;
            SeleccionarOpcion(16, 5);
        }

        private void button113_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage18;
            SeleccionarOpcion(16, 6);
        }

        private void iconButton15_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage16;
            PreguntaAnterior();
        }

        private void button125_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage19;
            SeleccionarOpcion(17, 0);
        }

        private void button123_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage19;
            SeleccionarOpcion(17, 1);
        }

        private void button121_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage19;
            SeleccionarOpcion(17, 2);
        }

        private void button119_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage19;
            SeleccionarOpcion(17, 3);
        }

        private void button124_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage19;
            SeleccionarOpcion(17, 4);
        }

        private void button122_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage19;
            SeleccionarOpcion(17, 5);
        }

        private void button120_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage19;
            SeleccionarOpcion(17, 6);
        }

        private void iconButton16_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage17;
            PreguntaAnterior();
        }

        private void button132_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage20;
            SeleccionarOpcion(18, 0);
        }

        private void button130_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage20;
            SeleccionarOpcion(18, 1);
        }

        private void button128_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage20;
            SeleccionarOpcion(18, 2);
        }

        private void button126_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage20;
            SeleccionarOpcion(18, 3);
        }

        private void button131_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage20;
            SeleccionarOpcion(18, 4);
        }

        private void button129_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage20;
            SeleccionarOpcion(18, 5);
        }

        private void button127_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage20;
            SeleccionarOpcion(18, 6);
        }

        private void iconButton17_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage18;
            PreguntaAnterior();
        }

        private void button139_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage21;
            SeleccionarOpcion(19, 0);
        }

        private void button137_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage21;
            SeleccionarOpcion(19, 1);
        }

        private void button135_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage21;
            SeleccionarOpcion(19, 2);
        }

        private void button133_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage21;
            SeleccionarOpcion(19, 3);
        }

        private void button138_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage21;
            SeleccionarOpcion(19, 4);
        }

        private void button136_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage21;
            SeleccionarOpcion(19, 5);
        }

        private void button134_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage21;
            SeleccionarOpcion(19, 6);
        }

        private void iconButton18_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage19;
            PreguntaAnterior();
        }

        private void button146_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage22;
            SeleccionarOpcion(20, 0);
        }

        private void button144_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage22;
            SeleccionarOpcion(20, 1);
        }

        private void button142_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage22;
            SeleccionarOpcion(20, 2);
        }

        private void button140_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage22;
            SeleccionarOpcion(20, 3);
        }

        private void button145_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage22;
            SeleccionarOpcion(20, 4);
        }

        private void button143_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage22;
            SeleccionarOpcion(20, 5);
        }

        private void button141_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage22;
            SeleccionarOpcion(20, 6);
        }

        private void iconButton19_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage20;
            PreguntaAnterior();
        }

        private void button153_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage23;
            SeleccionarOpcion(21, 0);
        }

        private void button151_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage23;
            SeleccionarOpcion(21, 1);
        }

        private void button149_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage23;
            SeleccionarOpcion(21, 2);
        }

        private void button147_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage23;
            SeleccionarOpcion(21, 3);
        }

        private void button152_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage23;
            SeleccionarOpcion(21, 4);
        }

        private void button150_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage23;
            SeleccionarOpcion(21, 5);
        }

        private void button148_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage23;
            SeleccionarOpcion(21, 6);
        }

        private void iconButton20_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage21;
            PreguntaAnterior();
        }

        private void button160_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage24;
            SeleccionarOpcion(22, 0);
        }

        private void button158_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage24;
            SeleccionarOpcion(22, 1);
        }

        private void button156_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage24;
            SeleccionarOpcion(22, 2);
        }

        private void button154_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage24;
            SeleccionarOpcion(22, 3);
        }

        private void button159_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage24;
            SeleccionarOpcion(22, 4);
        }

        private void button157_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage24;
            SeleccionarOpcion(22, 5);
        }

        private void button155_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage24;
            SeleccionarOpcion(22, 6);
        }

        private void iconButton21_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage22;
            PreguntaAnterior();
        }

        private void button167_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage25;
            SeleccionarOpcion(23, 0);
        }

        private void button165_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage25;
            SeleccionarOpcion(23, 1);
        }

        private void button163_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage25;
            SeleccionarOpcion(23, 2);
        }

        private void button161_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage25;
            SeleccionarOpcion(23, 3);
        }

        private void button166_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage25;
            SeleccionarOpcion(23, 4);
        }

        private void button164_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage25;
            SeleccionarOpcion(23, 5);
        }

        private void button162_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage25;
            SeleccionarOpcion(23, 6);
        }

        private void iconButton22_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage23;
            PreguntaAnterior();
        }

        private void button174_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage26;
            SeleccionarOpcion(24, 0);
        }

        private void button172_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage26;
            SeleccionarOpcion(24, 1);
        }

        private void button170_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage26;
            SeleccionarOpcion(24, 2);
        }

        private void button168_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage26;
            SeleccionarOpcion(24, 3);
        }

        private void button173_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage26;
            SeleccionarOpcion(24, 4);
        }

        private void button171_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage26;
            SeleccionarOpcion(24, 5);
        }

        private void button169_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage26;
            SeleccionarOpcion(24, 6);
        }

        private void iconButton23_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage24;
            PreguntaAnterior();
        }

        private void button181_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage27;
            SeleccionarOpcion(25, 0);
        }

        private void button179_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage27;
            SeleccionarOpcion(25, 1);
        }

        private void button177_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage27;
            SeleccionarOpcion(25, 2);
        }

        private void button175_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage27;
            SeleccionarOpcion(25, 3);
        }

        private void button180_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage27;
            SeleccionarOpcion(25, 4);
        }

        private void button178_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage27;
            SeleccionarOpcion(25, 5);
        }

        private void button176_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage27;
            SeleccionarOpcion(25, 6);
        }

        private void iconButton24_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage25;
            PreguntaAnterior();
        }

        private void button188_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage28;
            SeleccionarOpcion(26, 0);
        }

        private void button186_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage28;
            SeleccionarOpcion(26, 1);
        }

        private void button184_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage28;
            SeleccionarOpcion(26, 2);
        }

        private void button182_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage28;
            SeleccionarOpcion(26, 3);
        }

        private void button187_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage28;
            SeleccionarOpcion(26, 4);
        }

        private void button185_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage28;
            SeleccionarOpcion(26, 5);
        }

        private void button183_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage28;
            SeleccionarOpcion(26, 6);
        }

        private void iconButton25_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage26;
            PreguntaAnterior();
        }

        private void button195_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage29;
            SeleccionarOpcion(27, 0);
        }

        private void button193_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage29;
            SeleccionarOpcion(27, 1);
        }

        private void button191_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage29;
            SeleccionarOpcion(27, 2);
        }

        private void button189_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage29;
            SeleccionarOpcion(27, 3);
        }

        private void button194_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage29;
            SeleccionarOpcion(27, 4);
        }

        private void button192_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage29;
            SeleccionarOpcion(27, 5);
        }

        private void button190_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage29;
            
            SeleccionarOpcion(27, 6);
        }

        private void iconButton26_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage27;
            PreguntaAnterior();
        }

        private void button202_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage30;
            SeleccionarOpcion(28, 0);
        }

        private void button200_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage30;
            SeleccionarOpcion(28, 1);
        }

        private void button198_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage30;
            SeleccionarOpcion(28, 2);
        }

        private void button196_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage30;
            SeleccionarOpcion(28, 3);
        }

        private void button201_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage30;
            SeleccionarOpcion(28, 4);
        }

        private void button199_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage30;
            SeleccionarOpcion(28, 5);
        }

        private void button197_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage30;
            SeleccionarOpcion(28, 6);
        }

        private void iconButton27_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage28;
            PreguntaAnterior();
        }

        private void button209_Click_1(object sender, EventArgs e)
        {
            SeleccionarOpcion(29, 0);

            abrirForm(new RESULTADO_FASE1());
        }

        private void button207_Click_1(object sender, EventArgs e)
        {
            SeleccionarOpcion(29, 1);

            abrirForm(new RESULTADO_FASE1());
        }

        private void button205_Click_1(object sender, EventArgs e)
        {
            
            SeleccionarOpcion(29, 2);

            abrirForm(new RESULTADO_FASE1());
        }

        private void button203_Click_1(object sender, EventArgs e)
        {
            SeleccionarOpcion(29, 3);

            abrirForm(new RESULTADO_FASE1());
        }

        private void button208_Click_1(object sender, EventArgs e)
        {
            
            SeleccionarOpcion(29, 4);

            abrirForm(new RESULTADO_FASE1());
        }

        private void button206_Click_1(object sender, EventArgs e)
        {
            SeleccionarOpcion(29, 5);

            abrirForm(new RESULTADO_FASE1());
        }

        private void button204_Click_1(object sender, EventArgs e)
        {
            SeleccionarOpcion(29, 6);

            abrirForm(new RESULTADO_FASE1());
        }

        

        private void iconButton28_Click_2(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage29;
            PreguntaAnterior();
        }
    }
}
