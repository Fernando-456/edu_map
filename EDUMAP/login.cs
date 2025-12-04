using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Diagnostics;
using System.Windows.Forms;

namespace EDUMAP
{
    public partial class login : Form
    {

        string conexionBD = "Server=62.72.5.62;Database=EduMap;Uid=fer;Pwd=1234;";

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

                    string consulta = "SELECT Usuario, Contraseña FROM registro WHERE Usuario = @Usuario";

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Usuario", txtusuario.Text);

                        MySqlDataReader reader = comando.ExecuteReader();

                        // Validar campos vacíos
                        if (string.IsNullOrWhiteSpace(txtusuario.Text) ||
                            string.IsNullOrWhiteSpace(txtcontraseña.Text))
                        {
                            MessageBox.Show("Por favor, complete todos los campos.");
                            return;
                        }

                        // Si el usuario NO existe
                        if (!reader.Read())
                        {
                            MessageBox.Show("El usuario no existe. Verifique el nombre de usuario.");
                            return;
                        }

                        string usuarioBD = reader["Usuario"].ToString();
                        string contraseñaBD = reader["Contraseña"].ToString();

                        reader.Close();

                        // Validar nombre EXACTO
                        if (txtusuario.Text != usuarioBD)
                        {
                            MessageBox.Show("El usuario ingresado no coincide con el registrado.");
                            return;
                        }

                        // Validar contraseña EXACTA
                        if (txtcontraseña.Text != contraseñaBD)
                        {
                            MessageBox.Show("La contraseña es incorrecta.");
                            return;
                        }

                        // Si todo coincide → iniciar sesión
                        Global.usuario = txtusuario.Text;
                        Global.contraseña = txtcontraseña.Text;

                        Menu otroForm = new Menu();
                        otroForm.StartPosition = FormStartPosition.CenterScreen;
                        otroForm.Show();
                        this.Hide();
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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            txtcontraseña.PasswordChar = '\0';
            iconButton1.Visible = false;
            iconButton2.Visible = true;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            txtcontraseña.PasswordChar = '•';
            iconButton2.Visible = false;
            iconButton1.Visible = true;
        }
    }
}
