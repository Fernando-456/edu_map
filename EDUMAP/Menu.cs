using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDUMAP
{
    public partial class Menu : Form
    {
        private Size originalFormSize;
        private Size originalLabelSize;
        private float originalLabelFontSize;
        public Menu()
        {
            InitializeComponent();
        }
        private Form FormActual = null;
        // Agregar este campo a la clase MAPA
        private Size formSize;
        private void FormResize()
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                // Ajustar el tamaño y la posición de los controles para pantalla maximizada
            }
            else
            {
                // Ajustar el tamaño y la posición de los controles para pantalla normal
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            originalFormSize = this.Size;
            originalLabelSize = label1.Size;
            originalLabelFontSize = label1.Font.Size;

            originalLabelSize = label2.Size;
            originalLabelFontSize = label2.Font.Size;
        }
        private void abrirForm (Form form)
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


        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            flowTITULO.Visible = false;
            abrirForm(new INTERESES());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string conexionString = "Server=89.116.159.185;Database=EduMap;Uid=Fernando_BD;Pwd=1209;";

            using (MySqlConnection conexion = new MySqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    // Trae todos los campos de la tabla
                    string query = @"SELECT Usuario, campo_A, campo_E, campo_C, campo_S, campo_D, campo_F, campo_L FROM resultados WHERE Usuario = @Usuario";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@Usuario", Global.usuario);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Verificar si todos están vacíos
                            bool todosVacios = true;
                            for (int i = 0; i < 7; i++)
                            {
                                if (!reader.IsDBNull(i) && !string.IsNullOrWhiteSpace(reader.GetString(i)))
                                {
                                    todosVacios = false;
                                    break;
                                }
                            }

                            if (todosVacios)
                            {
                                MessageBox.Show("Necesitas hacer el test.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }

                            // Obtener los valores de cada campo



                            string campoA = reader.IsDBNull(1) ? "" : reader.GetValue(1).ToString();
                            string campoE = reader.IsDBNull(2) ? "" : reader.GetValue(2).ToString();
                            string campoC = reader.IsDBNull(3) ? "" : reader.GetValue(3).ToString();
                            string campoS = reader.IsDBNull(4) ? "" : reader.GetValue(4).ToString();
                            string campoD = reader.IsDBNull(5) ? "" : reader.GetValue(5).ToString();
                            string campoF = reader.IsDBNull(6) ? "" : reader.GetValue(6).ToString();
                            string campoL = reader.IsDBNull(7) ? "" : reader.GetValue(7).ToString();

                            Global.SI_A = int.TryParse(campoA, out int valA) ? valA : 0;
                            Global.SI_E = int.TryParse(campoE, out int valE) ? valE : 0;
                            Global.SI_C = int.TryParse(campoC, out int valC) ? valC : 0;
                            Global.SI_S = int.TryParse(campoS, out int valS) ? valS : 0;
                            Global.SI_D = int.TryParse(campoD, out int valD) ? valD : 0;
                            Global.SI_F = int.TryParse(campoF, out int valF) ? valF : 0;
                            Global.SI_L = int.TryParse(campoL, out int valL) ? valL : 0;

                            // Enviar los valores al Form2
                            flowTITULO.Visible = false;
                            abrirForm(new Resultados());
                            
                        }
                        else
                        {
                            MessageBox.Show("Necesitas realizar el TEST", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            // Solución: Necesitas una instancia de Valoranos para llamar a Close()
            // Si tienes una instancia abierta, ciérrala. Por ejemplo, si la abriste con abrirForm(new Valoranos()),
            // puedes buscarla en los controles del panel.
            foreach (Control ctrl in this.panel1.Controls)
            {
                if (ctrl is Valoranos valoranosForm)
                {
                    valoranosForm.Close();
                    break;
                }
            }
            flowTITULO.Visible = false;
            abrirForm(new Inicio());
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            
            flowTITULO.Visible = false;
            abrirForm(new Valoranos());
        }

        private void Menu_Resize(object sender, EventArgs e)
        {
            float xRatio = (float)this.Width / originalFormSize.Width;
            float yRatio = (float)this.Height / originalFormSize.Height;

            // Escalar tamaño del Label
            int newWidth = (int)(originalLabelSize.Width * xRatio);
            int newHeight = (int)(originalLabelSize.Height * yRatio);
            label1.Size = new Size(newWidth, newHeight);
            label2.Size = new Size(newWidth, newHeight);

            // Escalar fuente (opcional)
            FormResize();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            flowTITULO.Visible = false;
            abrirForm(new MAPA());
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
