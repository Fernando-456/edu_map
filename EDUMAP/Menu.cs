using MySql.Data.MySqlClient;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace EDUMAP
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        
        private Form FormActual = null;

        private void Menu_Load(object sender, EventArgs e)
        {
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

            panel1.Controls.Clear();
            panel1.Controls.Add(form);
            panel1.Tag = form;
            form.BringToFront();
            form.Show();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.panel1.Controls)
            {
                if (ctrl is Valoranos valoranosForm)
                {
                    valoranosForm.Close();
                    break;
                }
            }

            flowTITULO.Visible = false;
            panelControl.Visible = false;
            abrirFormMenu(new Menu());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            flowTITULO.Visible = false;
            abrirForm(new Valoranos());
        }

        private void Menu_Resize(object sender, EventArgs e)
        {
        }

        
        private void abrirFormMenu(Form form)
        {
            if (FormActual != null)
            {
                FormActual.Close();
            }

            FormActual = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panelFONDO.Controls.Clear();
            panelFONDO.Controls.Add(form);
            panelFONDO.Tag = form;
            form.BringToFront();
            form.Show();

        }
        

        /// <summary>
        /// Carga los resultados de Fase 1 desde BD a Global.PuntajesFase1
        /// </summary>
        private bool CargarResultadosFase1(string usuario)
        {
            using (NpgsqlConnection conexion = Conexion.ConexionDB())
            {
                conexion.Open();

                string query = @"
                SELECT campo_a, campo_c, campo_d, campo_e, campo_f, campo_l, campo_s
                FROM resultados
                WHERE usuario = @usuario";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                            return false;

                        Global.PuntajesFase1[0] = reader.IsDBNull(0) ? 0 : Convert.ToInt32(reader[0]); // A
                        Global.PuntajesFase1[1] = reader.IsDBNull(1) ? 0 : Convert.ToInt32(reader[1]); // C
                        Global.PuntajesFase1[2] = reader.IsDBNull(2) ? 0 : Convert.ToInt32(reader[2]); // D
                        Global.PuntajesFase1[3] = reader.IsDBNull(3) ? 0 : Convert.ToInt32(reader[3]); // E
                        Global.PuntajesFase1[4] = reader.IsDBNull(4) ? 0 : Convert.ToInt32(reader[4]); // F
                        Global.PuntajesFase1[5] = reader.IsDBNull(5) ? 0 : Convert.ToInt32(reader[5]); // L
                        Global.PuntajesFase1[6] = reader.IsDBNull(6) ? 0 : Convert.ToInt32(reader[6]); // S

                        return true;
                    }
                }
            }
        }
        private bool CargarResultadosFase2(string usuario)
        {
            using (NpgsqlConnection conexion = Conexion.ConexionDB())
            {
                conexion.Open();

                string query = @"
            SELECT 
                r1,r2,r3,r4,r5,r6,r7,r8,
                r9,r10,r11,r12,r13,r14,r15,r16,
                r17,r18,r19,r20,r21,r22,r23,r24,
                r25,r26,r27,r28,r29,r30,r31,r32
            FROM resultados_fase2
            WHERE usuario = @usuario";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                            return false;

                        Global.RespuestasUsuario = new int[32];

                        for (int i = 0; i < 32; i++)
                        {
                            Global.RespuestasUsuario[i] = reader.IsDBNull(i)
                                ? 0
                                : Convert.ToInt32(reader.GetValue(i));
                        }

                        return true;
                    }
                }
            }
        }
        /// <summary>
        /// Valida si el usuario tiene registro de resultados en la tabla resultados
        /// </summary>
        private bool TieneResultadosFase1(string usuario)
        {
            using (NpgsqlConnection conexion = Conexion.ConexionDB())
            {
                conexion.Open();

                string query = "SELECT COUNT(*) FROM resultados WHERE usuario = @usuario";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    int cantidad = Convert.ToInt32(cmd.ExecuteScalar());
                    return cantidad > 0;
                }
            }
        }

        /// <summary>
        /// Valida si todos los puntajes de Fase 1 están en cero
        /// </summary>
        private bool ResultadosFase1Vacios()
        {
            for (int i = 0; i < Global.PuntajesFase1.Length; i++)
            {
                if (Global.PuntajesFase1[i] != 0)
                    return false;
            }

            return true;
        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            flowTITULO.Visible = false;
            abrirForm(new PERFIL());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            flowTITULO.Visible = false;
            abrirForm(new MENU_TEST());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Global.usuario))
                {
                    MessageBox.Show("No hay un usuario activo.");
                    return;
                }

                Global.ReiniciarFase1();

                if (!TieneResultadosFase1(Global.usuario))
                {
                    MessageBox.Show("Primero debes realizar el test.");
                    return;
                }

                if (!CargarResultadosFase1(Global.usuario))
                {
                    MessageBox.Show("No se pudieron cargar los resultados de Fase 1.");
                    return;
                }

                if (ResultadosFase1Vacios())
                {
                    MessageBox.Show("Necesitas hacer el test.");
                    return;
                }

                // ESTA PARTE ES LA QUE FALTABA
                if (!CargarResultadosFase2(Global.usuario))
                {
                    MessageBox.Show("Falta completar la Fase 2 para poder calcular carreras.");
                    return;
                }

                flowTITULO.Visible = false;
                
                abrirForm(new FASE3());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar resultados: " + ex.Message);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            flowTITULO.Visible = false;
            panelControl.Visible = false;
            abrirForm(new MAPA());
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            flowTITULO.Visible = false;
            abrirForm(new Carreras());
        }
    }
}
