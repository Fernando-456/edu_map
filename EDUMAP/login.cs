using FontAwesome.Sharp;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Diagnostics;
using System.Windows.Forms;

namespace EDUMAP
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private string Encriptar(string texto)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(texto));
                StringBuilder sb = new StringBuilder();

                foreach (byte b in bytes)
                    sb.Append(b.ToString("x2"));

                return sb.ToString();
            }
        }

        private void login_Load(object sender, EventArgs e)
        {
            txtcontraseña.PasswordChar = '•';
            iconButton2.Visible = false;
            iconButton1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtusuario.Text) ||
                    string.IsNullOrWhiteSpace(txtcontraseña.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return;
                }

                string usuarioIngresado = txtusuario.Text.Trim();
                string hashIngresado = Encriptar(txtcontraseña.Text.Trim());

                using (NpgsqlConnection conexion = Conexion.ConexionDB())
                {
                    conexion.Open();

                    string consulta = @"
                    SELECT id, usuario, email, contrasena, id_estado, id_municipio
                    FROM registro
                    WHERE usuario = @Usuario";

                    using (NpgsqlCommand comando = new NpgsqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Usuario", usuarioIngresado);

                        using (NpgsqlDataReader reader = comando.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show("El usuario no existe. Verifique el nombre de usuario.");
                                return;
                            }

                            string usuarioBD = reader["usuario"].ToString();
                            string correoBD = reader["email"].ToString();
                            string contraseñaBD = reader["contrasena"].ToString();
                            int idBD = Convert.ToInt32(reader["id"]);

                            int idEstadoBD = reader["id_estado"] == DBNull.Value
                                ? 0
                                : Convert.ToInt32(reader["id_estado"]);

                            int idMunicipioBD = reader["id_municipio"] == DBNull.Value
                                ? 0
                                : Convert.ToInt32(reader["id_municipio"]);

                            if (hashIngresado != contraseñaBD)
                            {
                                MessageBox.Show("La contraseña es incorrecta.");
                                return;
                            }

                            Global.usuario = usuarioBD;
                            Global.email = correoBD;
                            Global.id = idBD;
                            Global.id_estado = idEstadoBD;
                            Global.id_municipio = idMunicipioBD;
                            Global.contraseña = txtcontraseña.Text.Trim();
                        }
                    }
                }

                Menu menu = new Menu();
                menu.FormClosed += (s, args) => this.Close();
                menu.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 registro = new Form1();
            registro.FormClosed += (s, args) => this.Show();
            registro.Show();
            this.Hide();

        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            txtcontraseña.PasswordChar = '•';
            iconButton2.Visible = false;
            iconButton1.Visible = true;
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            txtcontraseña.PasswordChar = '\0';
            iconButton1.Visible = false;
            iconButton2.Visible = true;
        }
    }
}
