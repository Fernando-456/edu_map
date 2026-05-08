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
using Npgsql;

namespace EDUMAP
{
    public partial class TEST_FASE2 : Form
    {
        int preguntaActual = 1;
        const int totalPreguntas = 38;
        int[] respuestas = new int[38];
        private Form FormActual = null;
        class Pregunta
        {
            public int Numero;
            public int Bloque;
            public int Opciones;
            public TabPage Pagina;
        }
        List<Pregunta> preguntas = new List<Pregunta>();
        public TEST_FASE2()
        {
            InitializeComponent();
        }

        private void TEST_FASE2_Load(object sender, EventArgs e)
        {
            Global.ReiniciarFase2();

            for (int i = 0; i < respuestas.Length; i++)
                respuestas[i] = -1;

            preguntas.Clear();

            // BLOQUE 1
            preguntas.Add(new Pregunta { Numero = 0, Bloque = 1, Opciones = 4, Pagina = tabPage1 });
            preguntas.Add(new Pregunta { Numero = 1, Bloque = 1, Opciones = 4, Pagina = tabPage2 });
            preguntas.Add(new Pregunta { Numero = 2, Bloque = 1, Opciones = 4, Pagina = tabPage3 });
            preguntas.Add(new Pregunta { Numero = 3, Bloque = 1, Opciones = 4, Pagina = tabPage4 });
            preguntas.Add(new Pregunta { Numero = 4, Bloque = 1, Opciones = 4, Pagina = tabPage5 });
            preguntas.Add(new Pregunta { Numero = 5, Bloque = 1, Opciones = 4, Pagina = tabPage6 });
            preguntas.Add(new Pregunta { Numero = 6, Bloque = 1, Opciones = 4, Pagina = tabPage7 });
            preguntas.Add(new Pregunta { Numero = 7, Bloque = 1, Opciones = 4, Pagina = tabPage8 });

            // BLOQUE 2
            preguntas.Add(new Pregunta { Numero = 8, Bloque = 2, Opciones = 7, Pagina = tabPage9 });
            preguntas.Add(new Pregunta { Numero = 9, Bloque = 2, Opciones = 7, Pagina = tabPage10 });
            preguntas.Add(new Pregunta { Numero = 10, Bloque = 2, Opciones = 7, Pagina = tabPage11 });
            preguntas.Add(new Pregunta { Numero = 11, Bloque = 2, Opciones = 7, Pagina = tabPage12 });
            preguntas.Add(new Pregunta { Numero = 12, Bloque = 2, Opciones = 7, Pagina = tabPage13 });
            preguntas.Add(new Pregunta { Numero = 13, Bloque = 2, Opciones = 7, Pagina = tabPage14 });
            preguntas.Add(new Pregunta { Numero = 14, Bloque = 2, Opciones = 7, Pagina = tabPage15 });
            preguntas.Add(new Pregunta { Numero = 15, Bloque = 2, Opciones = 7, Pagina = tabPage16 });
            preguntas.Add(new Pregunta { Numero = 16, Bloque = 2, Opciones = 7, Pagina = tabPage17 });
            preguntas.Add(new Pregunta { Numero = 17, Bloque = 2, Opciones = 7, Pagina = tabPage18 });

            // BLOQUE 3
            preguntas.Add(new Pregunta { Numero = 18, Bloque = 3, Opciones = 7, Pagina = tabPage19 });
            preguntas.Add(new Pregunta { Numero = 19, Bloque = 3, Opciones = 7, Pagina = tabPage20 });
            preguntas.Add(new Pregunta { Numero = 20, Bloque = 3, Opciones = 7, Pagina = tabPage21 });
            preguntas.Add(new Pregunta { Numero = 21, Bloque = 3, Opciones = 7, Pagina = tabPage22 });
            preguntas.Add(new Pregunta { Numero = 22, Bloque = 3, Opciones = 7, Pagina = tabPage23 });
            preguntas.Add(new Pregunta { Numero = 23, Bloque = 3, Opciones = 7, Pagina = tabPage24 });
            preguntas.Add(new Pregunta { Numero = 24, Bloque = 3, Opciones = 7, Pagina = tabPage25 });
            preguntas.Add(new Pregunta { Numero = 25, Bloque = 3, Opciones = 7, Pagina = tabPage26 });
            preguntas.Add(new Pregunta { Numero = 26, Bloque = 3, Opciones = 7, Pagina = tabPage27 });
            preguntas.Add(new Pregunta { Numero = 27, Bloque = 3, Opciones = 7, Pagina = tabPage28 });

            // BLOQUE 4
            preguntas.Add(new Pregunta { Numero = 28, Bloque = 4, Opciones = 7, Pagina = tabPage29 });
            preguntas.Add(new Pregunta { Numero = 29, Bloque = 4, Opciones = 7, Pagina = tabPage30 });
            preguntas.Add(new Pregunta { Numero = 30, Bloque = 4, Opciones = 7, Pagina = tabPage31 });
            preguntas.Add(new Pregunta { Numero = 31, Bloque = 4, Opciones = 7, Pagina = tabPage32 });
            preguntas.Add(new Pregunta { Numero = 32, Bloque = 4, Opciones = 7, Pagina = tabPage33 });

            // BLOQUE 5
            preguntas.Add(new Pregunta { Numero = 33, Bloque = 5, Opciones = 7, Pagina = tabPage34 });
            preguntas.Add(new Pregunta { Numero = 34, Bloque = 5, Opciones = 7, Pagina = tabPage35 });
            preguntas.Add(new Pregunta { Numero = 35, Bloque = 5, Opciones = 7, Pagina = tabPage36 });
            preguntas.Add(new Pregunta { Numero = 36, Bloque = 5, Opciones = 7, Pagina = tabPage37 });
            preguntas.Add(new Pregunta { Numero = 37, Bloque = 5, Opciones = 7, Pagina = tabPage38 });

            MostrarPreguntaActual();
        }
        void ActualizarContadorPregunta()
        {
            lblContador.Text = $"Pregunta {preguntaActual} de {totalPreguntas}";
        }
        private void MostrarPreguntaActual()
        {
            var p = preguntas[preguntaActual - 1];
            tabControl1.SelectedTab = p.Pagina;
            lblContador.Text = $"Pregunta {preguntaActual} de {totalPreguntas}";
        }

        private void SiguientePregunta()
        {
            if (preguntaActual < totalPreguntas)
            {
                preguntaActual++;
                MostrarPreguntaActual();
            }
        }

        private void PreguntaAnterior()
        {
            if (preguntaActual > 1)
            {
                preguntaActual--;
                MostrarPreguntaActual();
            }
        }
        /*
         *  •	A → Visual (0)
            •	B → Auditivo (1)
            •	C → Lectura/Escritura (2)
            •	D → Kinestésico (3)

         */
        private void Seleccionar(int categoria)
        {
            var p = preguntas[preguntaActual - 1];

            if (categoria < 0 || categoria >= p.Opciones)
            {
                MessageBox.Show("Categoría inválida para esta pregunta.");
                return;
            }

            if (respuestas[p.Numero] != -1)
                RestarPuntaje(p.Bloque, respuestas[p.Numero]);

            respuestas[p.Numero] = categoria;
            SumarPuntaje(p.Bloque, categoria);

            if (preguntaActual == totalPreguntas)
            {
                FinalizarFase2(categoria);
                return;
            }

            SiguientePregunta();
        }

        private void SumarPuntaje(int bloque, int categoria)
        {
            switch (bloque)
            {
                case 1: Global.Puntajes_Bloque1[categoria]++; break;
                case 2: Global.Puntajes_Bloque2[categoria]++; break;
                case 3: Global.Puntajes_Bloque3[categoria]++; break;
                case 4: Global.Puntajes_Bloque4[categoria]++; break;
                case 5: Global.Puntajes_Bloque5[categoria]++; break;
            }
        }
        // =============================
        // PUNTAJES
        // =============================


        private void RestarPuntaje(int bloque, int categoria)
        {
            switch (bloque)
            {
                case 1: Global.Puntajes_Bloque1[categoria]--; break;
                case 2: Global.Puntajes_Bloque2[categoria]--; break;
                case 3: Global.Puntajes_Bloque3[categoria]--; break;
                case 4: Global.Puntajes_Bloque4[categoria]--; break;
                case 5: Global.Puntajes_Bloque5[categoria]--; break;
            }
        }
        private void btnCampoA_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
            Seleccionar(0);
        }

        private void btnCampoC_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
            Seleccionar(1);
        }

        private void btnCampoF_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
            Seleccionar(2);
        }

        private void btnCampoL_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
            Seleccionar(3);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
            Seleccionar(0);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
            Seleccionar(1);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
            Seleccionar(2);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
            Seleccionar(3);
        }

        private void regresar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
            PreguntaAnterior();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
            Seleccionar(0);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
            Seleccionar(1);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
            Seleccionar(2);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
            Seleccionar(3);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
            PreguntaAnterior();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage5;
            Seleccionar(0);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage5;
            Seleccionar(1);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage5;
            Seleccionar(2);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage5;
            Seleccionar(3);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
            PreguntaAnterior();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage6;
            Seleccionar(0);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage6;
            Seleccionar(1);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage6;
            Seleccionar(2);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage6;
            Seleccionar(3);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
            PreguntaAnterior();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage7;
            Seleccionar(0);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage7;
            Seleccionar(1);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage7;
            Seleccionar(2);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage7;
            Seleccionar(3);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage5;
            PreguntaAnterior();
        }

        private void button48_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage8;
            Seleccionar(0);
        }

        private void button46_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage8;
            Seleccionar(1);
        }

        private void button47_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage8;
            Seleccionar(2);
        }

        private void button45_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage8;
            Seleccionar(3);
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage6;
            PreguntaAnterior();
        }

        private void button55_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage9;
            Seleccionar(0);
        }

        private void button53_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage9;
            Seleccionar(1);
        }

        private void button54_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage9;
            Seleccionar(2);
        }

        private void button52_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage9;
            Seleccionar(3);
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage7;
            PreguntaAnterior();
        }


        private void button62_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage10;
            Seleccionar(0);
        }

        private void button60_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage10;
            Seleccionar(1);
        }

        private void button58_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage10;
            Seleccionar(2);
        }

        private void button56_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage10;
            Seleccionar(3);
        }

        private void button61_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage10;
            Seleccionar(4);
        }

        private void button59_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage10;
            Seleccionar(5);
        }

        private void button57_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage10;
            Seleccionar(6);
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage8;
            PreguntaAnterior();
        }

        private void button69_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage11;
            Seleccionar(0);
        }

        private void button67_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage11;
            Seleccionar(1);
        }

        private void button65_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage11;
            Seleccionar(2);
        }

        private void button63_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage11;
            Seleccionar(3);
        }

        private void button68_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage11;
            Seleccionar(4);
        }

        private void button66_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage11;
            Seleccionar(5);
        }

        private void button64_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage11;
            Seleccionar(6);
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage9;
            PreguntaAnterior();
        }

        private void button76_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage12;
            Seleccionar(0);
        }

        private void button74_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage12;
            Seleccionar(1);
        }

        private void button72_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage12;
            Seleccionar(2);
        }

        private void button70_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage12;
            Seleccionar(3);
        }

        private void button75_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage12;
            Seleccionar(4);
        }

        private void button73_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage12;
            Seleccionar(5);
        }

        private void button71_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage12;
            Seleccionar(6);
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage10;
            PreguntaAnterior();
        }

        private void button83_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage13;
            Seleccionar(0);
        }

        private void button81_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage13;
            Seleccionar(1);
        }

        private void button79_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage13;
            Seleccionar(2);
        }

        private void button77_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage13;
            Seleccionar(3);
        }

        private void button82_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage13;
            Seleccionar(4);
        }

        private void button80_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage13;
            Seleccionar(5);
        }

        private void button78_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage13;
            Seleccionar(6);
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage11;
            PreguntaAnterior();
        }

        private void button90_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage14;
            Seleccionar(0);
        }

        private void button88_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage14;
            Seleccionar(1);
        }

        private void button86_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage14;
            Seleccionar(2);
        }

        private void button84_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage14;
            Seleccionar(3);
        }

        private void button89_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage14;
            Seleccionar(4);
        }

        private void button87_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage14;
            Seleccionar(5);
        }

        private void button85_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage14;
            Seleccionar(6);
        }

        private void iconButton11_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage12;
            PreguntaAnterior();
        }

        private void button97_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage15;
            Seleccionar(0);
        }

        private void button95_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage15;
            Seleccionar(1);
        }

        private void button93_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage15;
            Seleccionar(2);
        }

        private void button91_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage15;
            Seleccionar(3);
        }

        private void button96_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage15;
            Seleccionar(4);
        }

        private void button94_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage15;
            Seleccionar(5);
        }

        private void button92_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage15;
            Seleccionar(6);
        }

        private void iconButton12_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage13;
            PreguntaAnterior();
        }

        private void button104_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage16;
            Seleccionar(0);
        }

        private void button102_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage16;
            Seleccionar(1);
        }

        private void button100_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage16;
            Seleccionar(2);
        }

        private void button98_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage16;
            Seleccionar(3);
        }

        private void button103_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage16;
            Seleccionar(4);
        }

        private void button101_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage16;
            Seleccionar(5);
        }

        private void button99_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage16;
            Seleccionar(6);
        }

        private void iconButton13_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage14;
            PreguntaAnterior();
        }

        private void button111_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage17;
            Seleccionar(0);
        }

        private void button109_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage17;
            Seleccionar(1);
        }

        private void button107_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage17;
            Seleccionar(2);
        }

        private void button105_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage17;
            Seleccionar(3);
        }

        private void button110_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage17;
            Seleccionar(4);
        }

        private void button108_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage17;
            Seleccionar(5);
        }

        private void button106_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage17;
            Seleccionar(6);
        }

        private void iconButton14_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage15;
            PreguntaAnterior();
        }

        private void button118_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage18;
            Seleccionar(0);
        }

        private void button116_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage18;
            Seleccionar(1);
        }

        private void button114_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage18;
            Seleccionar(2);
        }

        private void button112_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage18;
            Seleccionar(3);
        }

        private void button117_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage18;
            Seleccionar(4);
        }

        private void button115_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage18;
            Seleccionar(5);
        }

        private void button113_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage18;
            Seleccionar(6);
        }

        private void iconButton15_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage16;
            PreguntaAnterior();
        }

        private void button125_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage19;
            Seleccionar(0);
        }

        private void button123_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage19;
            Seleccionar(1);
        }

        private void button121_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage19;
            Seleccionar(2);
        }

        private void button119_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage19;
            Seleccionar(3);
        }

        private void button124_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage19;
            Seleccionar(4);
        }

        private void button122_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage19;
            Seleccionar(5);
        }

        private void button120_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage19;
            Seleccionar(6);
        }

        private void iconButton16_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage17;
            PreguntaAnterior();
        }

        private void button132_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage20;
            Seleccionar(0);
        }

        private void button130_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage20;
            Seleccionar(1);
        }

        private void button128_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage20;
            Seleccionar(2);
        }

        private void button126_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage20;
            Seleccionar(3);
        }

        private void button131_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage20;
            Seleccionar(4);
        }

        private void button129_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage20;
            Seleccionar(5);
        }

        private void button127_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage20;
            Seleccionar(6);
        }

        private void iconButton17_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage18;
            PreguntaAnterior();
        }

        private void button146_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage22;
            Seleccionar(0);
        }

        private void button144_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage22;
            Seleccionar(1);
        }

        private void button142_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage22;
            Seleccionar(2);
        }

        private void button140_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage22;
            Seleccionar(3);
        }

        private void button145_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage22;
            Seleccionar(4);
        }

        private void button143_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage22;
            Seleccionar(5);
        }

        private void button141_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage22;
            Seleccionar(6);
        }

        private void iconButton19_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage20;
            PreguntaAnterior();
        }

        private void button153_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage23;
            Seleccionar(0);
        }

        private void button151_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage23;
            Seleccionar(1);
        }

        private void button149_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage23;
            Seleccionar(2);
        }

        private void button147_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage23;
            Seleccionar(3);
        }

        private void button152_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage23;
            Seleccionar(4);
        }

        private void button150_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage23;
            Seleccionar(5);
        }

        private void button148_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage23;
            Seleccionar(6);
        }

        private void iconButton20_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage21;
            PreguntaAnterior();
        }

        private void button160_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage24;
            Seleccionar(0);
        }

        private void button158_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage24;
            Seleccionar(1);
        }

        private void button156_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage24;
            Seleccionar(2);
        }

        private void button154_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage24;
            Seleccionar(3);
        }

        private void button159_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage24;
            Seleccionar(4);
        }

        private void button157_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage24;
            Seleccionar(5);
        }

        private void button155_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage24;
            Seleccionar(6);
        }

        private void iconButton21_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage22;
            PreguntaAnterior();
        }

        private void button167_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage25;
            Seleccionar(0);
        }

        private void button165_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage25;
            Seleccionar(1);
        }

        private void button163_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage25;
            Seleccionar(2);
        }

        private void button161_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage25;
            Seleccionar(3);
        }

        private void button166_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage25;
            Seleccionar(4);
        }

        private void button164_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage25;
            Seleccionar(5);
        }

        private void button162_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage25;
            Seleccionar(6);
        }

        private void iconButton22_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage23;
            PreguntaAnterior();
        }

        private void button174_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage26;
            Seleccionar(0);
        }

        private void button172_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage26;
            Seleccionar(1);
        }

        private void button170_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage26;
            Seleccionar(2);
        }

        private void button168_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage26;
            Seleccionar(3);
        }

        private void button173_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage26;
            Seleccionar(4);
        }

        private void button171_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage26;
            Seleccionar(5);
        }

        private void button169_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage26;
            Seleccionar(6);
        }

        private void iconButton23_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage24;
            PreguntaAnterior();
        }

        private void button181_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage27;
            Seleccionar(0);
        }

        private void button179_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage27;
            Seleccionar(1);
        }

        private void button177_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage27;
            Seleccionar(2);
        }

        private void button175_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage27;
            Seleccionar(3);
        }

        private void button180_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage27;
            Seleccionar(4);
        }

        private void button178_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage27;
            Seleccionar(5);
        }

        private void button176_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage27;
            Seleccionar(6);
        }

        private void iconButton24_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage25;
            PreguntaAnterior();
        }

        private void button188_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage28;
            Seleccionar(0);
        }

        private void button186_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage28;
            Seleccionar(1);
        }

        private void button184_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage28;
            Seleccionar(2);
        }

        private void button182_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage28;
            Seleccionar(3);
        }

        private void button187_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage28;
            Seleccionar(4);
        }

        private void button185_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage28;
            Seleccionar(5);
        }

        private void button183_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage28;
            Seleccionar(6);
        }
        private void iconButton25_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage26;
            PreguntaAnterior();
        }
        private void button195_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage29;
            Seleccionar(0);
        }

        private void button193_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage29;
            Seleccionar(1);
        }

        private void button191_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage29;
            Seleccionar(2);
        }

        private void button189_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage29;
            Seleccionar(3);
        }

        private void button194_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage29;
            Seleccionar(4);
        }

        private void button192_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage29;
            Seleccionar(5);
        }

        private void button190_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage29;
            Seleccionar(6);
        }

        private void iconButton26_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage27;
            PreguntaAnterior();
        }

        private void button209_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage31;
            Seleccionar(0);
        }

        private void button207_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage31;
            Seleccionar(1);
        }

        private void button205_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage31;
            Seleccionar(2);
        }

        private void button203_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage31;
            Seleccionar(3);
        }

        private void button208_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage31;
            Seleccionar(4);
        }

        private void button206_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage31;
            Seleccionar(5);
        }

        private void button204_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage31;
            Seleccionar(6);
        }

        private void iconButton28_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage29;
            PreguntaAnterior();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage32;
            Seleccionar(0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage32;
            Seleccionar(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage32;
            Seleccionar(2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage32;
            Seleccionar(3);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage32;
            Seleccionar(4);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage32;
            Seleccionar(5);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage32;
            Seleccionar(6);
        }

        private void iconButton29_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage30;
            PreguntaAnterior();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage33;
            Seleccionar(0);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage33;
            Seleccionar(1);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage33;
            Seleccionar(2);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage33;
            Seleccionar(3);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage33;
            Seleccionar(4);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage33;
            Seleccionar(5);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage33;
            Seleccionar(6);
        }

        private void iconButton30_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage31;
            PreguntaAnterior();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage34;
            Seleccionar(0);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage34;
            Seleccionar(1);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage34;
            Seleccionar(2);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage34;
            Seleccionar(3);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage34;
            Seleccionar(4);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage34;
            Seleccionar(5);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage34;
            Seleccionar(6);
        }

        private void iconButton31_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage32;
            PreguntaAnterior();
        }

        private void button210_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage35;
            Seleccionar(0);
        }

        private void button50_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage35;
            Seleccionar(1);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage35;
            Seleccionar(2);
        }

        private void button42_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage35;
            Seleccionar(3);
        }

        private void button51_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage35;
            Seleccionar(4);
        }

        private void button49_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage35;
            Seleccionar(5);
        }

        private void button43_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage35;
            Seleccionar(6);
        }

        private void iconButton32_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage33;
            PreguntaAnterior();
        }

        private void button217_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage36;
            Seleccionar(0);
        }

        private void button215_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage36;
            Seleccionar(1);
        }

        private void button213_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage36;
            Seleccionar(2);
        }

        private void button211_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage36;
            Seleccionar(3);
        }

        private void button216_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage36;
            Seleccionar(4);
        }

        private void button214_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage36;
            Seleccionar(5);
        }

        private void button212_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage36;
            Seleccionar(6);
        }

        private void iconButton33_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage34;
            PreguntaAnterior();
        }

        private void button224_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage37;
            Seleccionar(0);
        }

        private void button222_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage37;
            Seleccionar(1);
        }

        private void button220_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage37;
            Seleccionar(2);
        }

        private void button218_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage37;
            Seleccionar(3);
        }

        private void button223_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage37;
            Seleccionar(4);
        }

        private void button221_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage37;
            Seleccionar(5);
        }

        private void button219_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage37;
            Seleccionar(6);
        }

        private void iconButton34_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage35;
            PreguntaAnterior();
        }

        private void button231_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage38;
            Seleccionar(0);
        }

        private void button229_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage38;
            Seleccionar(1);
        }

        private void button227_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage38;
            Seleccionar(2);
        }

        private void button225_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage38;
            Seleccionar(3);
        }

        private void button230_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage38;
            Seleccionar(4);
        }

        private void button228_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage38;
            Seleccionar(5);
        }

        private void button226_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage38;
            Seleccionar(6);
        }

        private void iconButton35_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage36;
            PreguntaAnterior();
        }
        
        private void abrirForm(Form form)
        {
            if (FormActual != null)
            {
                FormActual.Close();
            }
            FormActual = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            panel1.Tag = form;
            form.BringToFront();
            form.Show();
            panelHeader.Hide();
            panelContenido.Hide();
            tableLayoutPanel2.Hide();
            panelFases.Hide();
            this.WindowState = FormWindowState.Maximized;
        }
        private void button238_Click(object sender, EventArgs e)
        {
            FinalizarFase2(0);
            abrirForm(new FASE3());

        }

        private void button236_Click(object sender, EventArgs e)
        {

            FinalizarFase2(1);
            abrirForm(new FASE3());

        }

        private void button234_Click(object sender, EventArgs e)
        {

            FinalizarFase2(2);
            abrirForm(new FASE3());

        }

        private void button232_Click(object sender, EventArgs e)
        {

            FinalizarFase2(3);
            abrirForm(new FASE3());

        }

        private void button237_Click(object sender, EventArgs e)
        {
            FinalizarFase2(4);
            abrirForm(new FASE3());

        }

        private void button235_Click(object sender, EventArgs e)
        {
            FinalizarFase2(5);
            abrirForm(new FASE3());
        }

        private void button233_Click(object sender, EventArgs e)
        {
            FinalizarFase2(6);
            abrirForm(new FASE3());
        }

        private void iconButton36_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage37;
            PreguntaAnterior();
        }
        private void GenerarRespuestasUsuario()
        {
            List<int> lista = new List<int>();
            lista.AddRange(Global.Puntajes_Bloque1);
            lista.AddRange(Global.Puntajes_Bloque2);
            lista.AddRange(Global.Puntajes_Bloque3);
            lista.AddRange(Global.Puntajes_Bloque4);
            lista.AddRange(Global.Puntajes_Bloque5);
            Global.RespuestasUsuario = lista.ToArray();

            if (Global.RespuestasUsuario.Length != 32)
                throw new Exception("Error interno: Fase 3 espera 32 valores.");
        }
        private void GuardarResultadosFase2(string usuario)
        {
            using (var conn = Conexion.ConexionDB())
            {
                conn.Open();

                string deleteQuery = "DELETE FROM resultados_fase2 WHERE usuario = @usuario";
                using (var deleteCmd = new NpgsqlCommand(deleteQuery, conn))
                {
                    deleteCmd.Parameters.AddWithValue("@usuario", usuario);
                    deleteCmd.ExecuteNonQuery();
                }

                string query = @"
                INSERT INTO resultados_fase2
                (usuario,
                 r1,r2,r3,r4,r5,r6,r7,r8,r9,r10,
                 r11,r12,r13,r14,r15,r16,r17,r18,r19,r20,
                 r21,r22,r23,r24,r25,r26,r27,r28,r29,r30,
                 r31,r32)
                VALUES
                (@usuario,
                 @r1,@r2,@r3,@r4,@r5,@r6,@r7,@r8,@r9,@r10,
                 @r11,@r12,@r13,@r14,@r15,@r16,@r17,@r18,@r19,@r20,
                 @r21,@r22,@r23,@r24,@r25,@r26,@r27,@r28,@r29,@r30,
                 @r31,@r32)";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);

                    for (int i = 0; i < 32; i++)
                        cmd.Parameters.AddWithValue($"@r{i + 1}", Global.RespuestasUsuario[i]);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void FinalizarFase2(int categoriaFinal)
        {
            var preguntaFinal = preguntas[preguntaActual - 1];

            if (preguntaFinal.Numero != 37)
            {
                MessageBox.Show("Error: no estás en la última pregunta.");
                return;
            }

            if (respuestas[preguntaFinal.Numero] != -1)
                RestarPuntaje(preguntaFinal.Bloque, respuestas[preguntaFinal.Numero]);

            respuestas[preguntaFinal.Numero] = categoriaFinal;
            SumarPuntaje(preguntaFinal.Bloque, categoriaFinal);

            GenerarRespuestasUsuario();
            GuardarResultadosFase2(Global.usuario);
            abrirForm(new FASE3());
        }
        public class PreguntaFase2
        {
            public int Numero { get; set; }
            public int Bloque { get; set; }
            public int Opciones { get; set; }
            public TabPage Pagina { get; set; }

            public PreguntaFase2(int numero, int bloque, int opciones, TabPage pagina)
            {
                Numero = numero;
                Bloque = bloque;
                Opciones = opciones;
                Pagina = pagina;
            }
        }

        private void button139_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage21;
            Seleccionar(0);
        }

        private void button137_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage21;
            Seleccionar(1);
        }

        private void button135_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage21;
            Seleccionar(2);
        }

        private void button133_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage21;
            Seleccionar(3);
        }

        private void button138_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage21;
            Seleccionar(4);
        }

        private void button136_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage21;
            Seleccionar(5);
        }

        private void button134_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage21;
            Seleccionar(6);
        }

        private void button202_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage30;
            Seleccionar(0);
        }

        private void button200_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage30;
            Seleccionar(1);
        }

        private void button198_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage30;
            Seleccionar(2);
        }

        private void button196_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage30;
            Seleccionar(3);
        }

        private void button201_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage30;
            Seleccionar(4);
        }

        private void button199_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage30;
            Seleccionar(5);
        }

        private void button197_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage30;
            Seleccionar(6);
        }
    }
}
