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
    public partial class Segunda_opcion : Form
    {
        string conexion = "server=89.116.159.185; database=EduMap; uid=Fernando_BD; pwd=1209;";
        public Segunda_opcion()
        {
            
            InitializeComponent();
        }
        void mayor()
        {
            int[] valores = { Global.SI_A, Global.SI_E, Global.SI_C, Global.SI_S, Global.SI_D, Global.SI_F, Global.SI_L };
            // 2. Ordenamos de mayor a menor
            Array.Sort(valores);
            Array.Reverse(valores);
            // 3. Asignamos los 3 mayores a los textBox
            //lblprimera.Text = valores[0].ToString(); // Mayor
            lblsegunda.Text = valores[1].ToString(); // Segunda mayor
            //textBox3.Text = valores[2].ToString(); // Tercera mayor
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
            mayor();
            if (lblsegunda.Text == Global.SI_A.ToString())
            {
                CargarDatos_A();
                lblsegunda.Visible = true;
                lblsegunda.Text = "Artístico";
            }
            else if (lblsegunda.Text == Global.SI_E.ToString())
            {
                CargarDatos_E();
                lblsegunda.Visible = true;
                lblsegunda.Text = "Emprendimiento";
            }
            else if (lblsegunda.Text == Global.SI_C.ToString())
            {
                CargarDatos_C();
                lblsegunda.Visible = true;
                lblsegunda.Text = "Científico";
            }
            else if (lblsegunda.Text == Global.SI_S.ToString())
            {
                CargarDatos_S();
                lblsegunda.Visible = true;
                lblsegunda.Text = "Social";
            }
            else if (lblsegunda.Text == Global.SI_D.ToString())
            {
                CargarDatos_D();
                lblsegunda.Visible = true;
                lblsegunda.Text = "Desarrollo";
            }
            else if (lblsegunda.Text == Global.SI_F.ToString())
            {
                CargarDatos_F();
                lblsegunda.Visible = true;
                lblsegunda.Text = "Finanzas";
            }
            else if (lblsegunda.Text == Global.SI_L.ToString())
            {
                CargarDatos_L();
                lblsegunda.Visible = true;
                lblsegunda.Text = "Leyes";
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
            abrirForm(new Tercera_opcion());
        }

        private void Segunda_opcion_Load(object sender, EventArgs e)
        {

        }
    }
}
