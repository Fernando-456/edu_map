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

namespace EDUMAP
{
    public partial class Tercera_opcion : Form
    {
        string conexion = "server=62.72.5.62; database=EduMap; uid=fer; pwd=1234;";
        public Tercera_opcion()
        {
            InitializeComponent();
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
        private void button2_Click(object sender, EventArgs e)
        {
            
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
        

        private void Tercera_opcion_Load(object sender, EventArgs e)
        {

            if (Global.Tercera_opcion == Global.SI_A.ToString())
            {
                CargarDatos_A();
                lbltercera.Visible = true;
                lbltercera.Text = "Artistico";
            }
            else if (Global.Tercera_opcion == Global.SI_E.ToString())
            {
                CargarDatos_E();
                lbltercera.Visible = true;
                lbltercera.Text = "Emprendimiento";
            }
            else if (Global.Tercera_opcion == Global.SI_C.ToString())
            {
                CargarDatos_C();
                lbltercera.Visible = true;
                lbltercera.Text = "Científico";
            }
            else if (Global.Tercera_opcion == Global.SI_S.ToString())
            {
                CargarDatos_S();
                lbltercera.Visible = true;
                lbltercera.Text = "Social";
            }
            else if (Global.Tercera_opcion == Global.SI_D.ToString())
            {
                CargarDatos_D();
                lbltercera.Visible = true;
                lbltercera.Text = "Desarrollo";
            }
            else if (Global.Tercera_opcion == Global.SI_F.ToString())
            {
                CargarDatos_F();
                lbltercera.Visible = true;
                lbltercera.Text = "Finanzas";
            }
            else if (Global.Tercera_opcion == Global.SI_L.ToString())
            {
                CargarDatos_L();
                lbltercera.Visible = true;
                lbltercera.Text = "Leyes";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            abrirForm(new Segunda_opcion());
        }
    }
}
