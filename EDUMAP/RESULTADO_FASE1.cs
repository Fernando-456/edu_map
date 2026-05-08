using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace EDUMAP
{
    public partial class RESULTADO_FASE1 : Form
    {
        public RESULTADO_FASE1()
        {
            InitializeComponent();
        }

        private Form FormActual = null;

        private void RESULTADO_FASE1_Load(object sender, EventArgs e)
        {
            MostrarResultados();
        }

        private void MostrarResultados()
        {
            int total = Global.TotalFase1();

            if (total == 0)
            {
                MessageBox.Show("No hay resultados de la Fase 1.");
                return;
            }

            var top3 = Global.PuntajesFase1
                .Select((valor, indice) => new { Valor = valor, Indice = indice })
                .OrderByDescending(x => x.Valor)
                .Take(3)
                .ToList();

            picResultado_1.Image = ObtenerImagen(top3[0].Indice);
            picResultado_2.Image = ObtenerImagen(top3[1].Indice);
            picResultado_3.Image = ObtenerImagen(top3[2].Indice);

            lblResultado_1.Text = (top3[0].Valor * 100.0 / total).ToString("0.0") + "%";
            lblResultado_2.Text = (top3[1].Valor * 100.0 / total).ToString("0.0") + "%";
            lblResultado_3.Text = (top3[2].Valor * 100.0 / total).ToString("0.0") + "%";

            CentrarTodosLosLabels();
        }
        public static (string campo1, string campo2) ObtenerTop2CamposFase1()
        {
            return Global.ObtenerTop2CamposFase1();
        }
        public static string ObtenerNombreCampo(int indice)
        {
            switch (indice)
            {
                case 0: return "ARTISTICO";
                case 1: return "CIENTIFICO";
                case 2: return "DESARROLLO";
                case 3: return "EMPRENDIMIENTO";
                case 4: return "FINANZAS";
                case 5: return "LEYES";
                case 6: return "SOCIAL";
                default: return "DESCONOCIDO";
            }
        }
        private Image ObtenerImagen(int indice)
        {
            switch (indice)
            {
                case 0: return Properties.Resources.imgA;
                case 1: return Properties.Resources.imgC;
                case 2: return Properties.Resources.imgD;
                case 3: return Properties.Resources.imgE;
                case 4: return Properties.Resources.imgF;
                case 5: return Properties.Resources.imgL;
                case 6: return Properties.Resources.imgS;
                default: return null;
            }
        }
        private void GuardarResultadosEnBD()
        {
            using (NpgsqlConnection conexion = Conexion.ConexionDB())
            {
                try
                {
                    conexion.Open();

                    string deleteQuery = "DELETE FROM resultados WHERE usuario = @Usuario";
                    using (NpgsqlCommand deleteCmd = new NpgsqlCommand(deleteQuery, conexion))
                    {
                        deleteCmd.Parameters.AddWithValue("@Usuario", Global.usuario);
                        deleteCmd.ExecuteNonQuery();
                    }

                    string query = @"
                    INSERT INTO resultados
                    (usuario, campo_a, campo_c, campo_d, campo_e, campo_f, campo_l, campo_s)
                    VALUES
                    (@Usuario, @A, @C, @D, @E, @F, @L, @S)";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Usuario", Global.usuario);
                        cmd.Parameters.AddWithValue("@A", Global.PuntajesFase1[0]);
                        cmd.Parameters.AddWithValue("@C", Global.PuntajesFase1[1]);
                        cmd.Parameters.AddWithValue("@D", Global.PuntajesFase1[2]);
                        cmd.Parameters.AddWithValue("@E", Global.PuntajesFase1[3]);
                        cmd.Parameters.AddWithValue("@F", Global.PuntajesFase1[4]);
                        cmd.Parameters.AddWithValue("@L", Global.PuntajesFase1[5]);
                        cmd.Parameters.AddWithValue("@S", Global.PuntajesFase1[6]);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar resultados Fase 1: " + ex.Message);
                }
            }
        }

        private void iconButton16_Click(object sender, EventArgs e)
        {
            GuardarResultadosEnBD();
            abrirForm(new TEST_FASE2());
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
            panel2.Hide();
            tableLayoutPanel3.Hide();
            tableLayoutPanel2.Hide();
            tableLayoutPanel1.Hide();
        }

        private void CentrarLabel(Label lbl, PictureBox pb, int offsetY)
        {
            lbl.Left = (pb.Width - lbl.Width) / 2;
            lbl.Top = (pb.Height - lbl.Height) / 2 + offsetY;
        }

        void CentrarTodosLosLabels()
        {
            CentrarLabel(lblResultado_1, picResultado_1, -30);
            CentrarLabel(lblResultado_2, picResultado_2, -30);
            CentrarLabel(lblResultado_3, picResultado_3, -30);
        }

        private void RESULTADO_FASE1_Shown(object sender, EventArgs e)
        {
            CentrarTodosLosLabels();
        }
    }
}
