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
    public partial class login : Form
    {

        string conexionBD = "Server=89.116.159.185;Database=EduMap;Uid=Fernando_BD;Pwd=1209;";

        public login()
        {
            InitializeComponent();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(conexionBD))
                {
                    conexion.Open();
                    string consulta = "SELECT COUNT(*) FROM registro WHERE Usuario = @Usuario AND Contraseña = @Contraseña";
                    Global.usuario = "@Usuario";
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Usuario", txtusuario.Text);
                        comando.Parameters.AddWithValue("@Contraseña", txtcontraseña.Text);

                        int resultado = Convert.ToInt32(comando.ExecuteScalar());
                        if (txtcontraseña.Text == "" || txtusuario.Text == "")
                        {
                            MessageBox.Show("Por favor, complete todos los campos.");
                        }
                        else
                        {
                            if (resultado > 0)
                            {
                                Global.usuario = txtusuario.Text;

                                
                                Menu otroForm = new Menu();
                                otroForm.StartPosition = FormStartPosition.CenterScreen; 
                                otroForm.Show(); 
                                this.Hide(); 
                            }
                            else
                            {
                                MessageBox.Show("Usuario o contraseña incorrectos");
                            }
                        }
                        
                    }
                }
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
            }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
