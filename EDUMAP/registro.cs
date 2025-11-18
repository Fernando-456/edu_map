using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EDUMAP
{
    public partial class registro : Form
    {
        public registro()
        {
            InitializeComponent();
            
        }
        MySqlConnection mconexion = Conexion.ConexionDB();
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                mconexion.Open();
                string consulta = "INSERT INTO registro (Usuario, Email, Contraseña, Municipio) VALUES ('" + txtnombre.Text + "', '" + txtcorreo.Text + "', '" + txtcontraseña.Text + "', '" + txtmunicipio.Text + "')";
                Global.usuario = txtnombre.Text;
                string textoCorreo = txtcorreo.Text;
                string textoMunicipio = txtmunicipio.Text;
                string numContraseña = txtcontraseña.Text;

                // Si el texto contiene algún número
                
                
                
                MySqlCommand mysqlCommand = new MySqlCommand(consulta);
                mysqlCommand.Connection = mconexion;
                mysqlCommand.ExecuteNonQuery();
                
                
                MessageBox.Show("Usuario registrado exitosamente.");
                
                    login login = new login();
                    login.Show();
                    this.Hide();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el usuario: " + ex.Message);
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void registro_Load(object sender, EventArgs e)
        {
            
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
