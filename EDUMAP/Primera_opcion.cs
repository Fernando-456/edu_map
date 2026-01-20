using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EDUMAP
{
    public partial class Primera_opcion : Form
    {
        string conexion = "server=62.72.5.62; database=EduMap; uid=fer; pwd=1234;";
        public Primera_opcion()
        {
            InitializeComponent();
        }
        
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void mayor()
        {
            int[] valores = { Global.SI_A, Global.SI_E, Global.SI_C, Global.SI_S, Global.SI_D, Global.SI_F, Global.SI_L };

            // 1. Eliminar repetidos
            int[] valoresUnicos = valores.Distinct().ToArray();

            // 2. Ordenar de mayor a menor
            Array.Sort(valoresUnicos);
            Array.Reverse(valoresUnicos);

            // 3. Asignar los 3 mayores SIN repetidos
            Global.Primera_opcion = valoresUnicos.Length > 0 ? valoresUnicos[0].ToString() : "0";
            Global.Segunda_opcion = valoresUnicos.Length > 1 ? valoresUnicos[1].ToString() : "0";
            Global.Tercera_opcion = valoresUnicos.Length > 2 ? valoresUnicos[2].ToString() : "0";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            

        }
        
        private void CargarDatos_A()
        {
            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM campo_artistico;";
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conn);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dataGridView2.DataSource = tabla;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar: " + ex.Message);
                }
            }
        }
        private void CargarDatos_E()
        {
            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM campo_emprendimiento;";
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conn);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dataGridView2.DataSource = tabla;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar: " + ex.Message);
                }
            }
        }
        private void CargarDatos_C()
        {
            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM campo_cientifico;";
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conn);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dataGridView2.DataSource = tabla;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar: " + ex.Message);
                }
            }
        }
        private void CargarDatos_S()
        {
            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM campo_social;";
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conn);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dataGridView2.DataSource = tabla;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar: " + ex.Message);
                }
            }
        }
        private void CargarDatos_D()
        {
            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM campo_desarrollo;";
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conn);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dataGridView2.DataSource = tabla;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar: " + ex.Message);
                }
            }
        }
        private void CargarDatos_F()
        {
            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM campo_finanzas;";
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conn);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dataGridView2.DataSource = tabla;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar: " + ex.Message);
                }
            }
        }
        private void CargarDatos_L()
        {
            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM campo_leyes;";
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conn);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dataGridView2.DataSource = tabla;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar: " + ex.Message);
                }
            }
        }
        private void Primera_opcion_Load(object sender, EventArgs e)
        {
            mayor();
            if (Global.Primera_opcion == Global.SI_A.ToString())
            {
                CargarDatos_A();
                lblprimera.Visible = true;
                lblprimera.Text = "Artístico";
                Global.Primera_opcion = "Artístico";
            }
            else if (Global.Primera_opcion == Global.SI_E.ToString())
            {
                CargarDatos_E();
                lblprimera.Visible = true;
                lblprimera.Text = "Emprendimiento";
                Global.Primera_opcion = "Emprendimiento";
            }
            else if (Global.Primera_opcion == Global.SI_C.ToString())
            {
                CargarDatos_C();
                lblprimera.Visible = true;
                lblprimera.Text = "Científico";
                Global.Primera_opcion = "Científico";
            }
            else if (Global.Primera_opcion == Global.SI_S.ToString())
            {
                CargarDatos_S();
                lblprimera.Visible = true;
                lblprimera.Text = "Social";
                Global.Primera_opcion = "Social";
            }
            else if (Global.Primera_opcion == Global.SI_D.ToString())
            {
                CargarDatos_D();
                lblprimera.Visible = true;
                lblprimera.Text = "Desarrollo";
                Global.Primera_opcion = "Desarrollo";
            }
            else if (Global.Primera_opcion == Global.SI_F.ToString())
            {
                CargarDatos_F();
                lblprimera.Visible = true;
                lblprimera.Text = "Finanzas";
                Global.Primera_opcion = "Finanzas";
            }
            else if (Global.Primera_opcion == Global.SI_L.ToString())
            {
                CargarDatos_L();
                lblprimera.Visible = true;
                lblprimera.Text = "Leyes";
                Global.Primera_opcion = "Leyes";
            }
        }
        private Form FormActual = null;
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


        }
        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            abrirForm(new Segunda_opcion());
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
