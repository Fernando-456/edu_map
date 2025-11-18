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
    public partial class Resultados : Form
    {
        MySqlConnection mconexion = Conexion.ConexionDB();

        public Resultados()
        {
            InitializeComponent();
            

        }
        



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblA_Click(object sender, EventArgs e)
        {

        }

        private void lblE_Click(object sender, EventArgs e)
        {

        }
        private void CargarDatos_A()
        {
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            lblA.Text = Global.SI_A.ToString();
            lblA.Visible = true;

            lblE.Text = Global.SI_E.ToString();
            lblE.Visible = true;

            lblC.Text = Global.SI_C.ToString();
            lblC.Visible = true;

            lblS.Text = Global.SI_S.ToString();
            lblS.Visible = true;

            lblD.Text = Global.SI_D.ToString();
            lblD.Visible = true;

            lblF.Text = Global.SI_F.ToString();
            lblF.Visible = true;

            lblL.Text = Global.SI_L.ToString();
            lblL.Visible = true;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                mconexion.Open();
                string consulta = "INSERT INTO resultados (Usuario, Campo_A, Campo_E, Campo_C, Campo_S, Campo_D, Campo_F, Campo_L) VALUES ('" + Global.usuario + "', '" + lblA.Text + "', '" + lblE.Text + "', '" + lblC.Text + "', '" + lblS.Text + "', '" + lblD.Text + "', '" + lblF.Text + "', '" + lblL.Text + "')";


                // Si el texto contiene algún número



                MySqlCommand mysqlCommand = new MySqlCommand(consulta);
                mysqlCommand.Connection = mconexion;
                mysqlCommand.ExecuteNonQuery();


                MessageBox.Show("Resultados guardados correctamente..");



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar resultados el usuario: " + ex.Message);
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
        private void button2_Click(object sender, EventArgs e)
            {
            flowLayoutPanel1.Visible = false;
            abrirForm(new Primera_opcion());
        }

            private void Resultados_Load(object sender, EventArgs e)
            {

            }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
