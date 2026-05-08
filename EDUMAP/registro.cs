using FontAwesome.Sharp;
using MySql.Data.MySqlClient;
using Npgsql;
using Org.BouncyCastle.Bcpg;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EDUMAP
{
    public partial class registro : Form
    {
        private readonly Form _formAnterior;
        private readonly NpgsqlConnection mconexion = Conexion.ConexionDB();

        public registro(Form formAnterior)
        {
            InitializeComponent();

            _formAnterior = formAnterior;

            txtestado.DisplayMember = "";
            txtestado.DropDownStyle = ComboBoxStyle.DropDownList;

            txtmunicipio.DisplayMember = "";
            txtmunicipio.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public registro()
        {
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

        private void registro_Load(object sender, EventArgs e)
        {
            try
            {
                txtmunicipio.Enabled = false;
                CargarEstados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el formulario: " + ex.Message);
            }
        }

        private void CargarEstados()
        {
            try
            {
                if (mconexion.State != ConnectionState.Open)
                    mconexion.Open();

                string consulta = "SELECT id_estado, nombre FROM estados ORDER BY nombre";

                using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(consulta, mconexion))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    DataRow filaInicial = dt.NewRow();
                    filaInicial["id_estado"] = 0;
                    filaInicial["nombre"] = "Seleccione un estado";
                    dt.Rows.InsertAt(filaInicial, 0);

                    txtestado.DataSource = dt;
                    txtestado.DisplayMember = "nombre";
                    txtestado.ValueMember = "id_estado";
                    txtestado.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar estados: " + ex.Message);
            }
            finally
            {
                if (mconexion.State == ConnectionState.Open)
                    mconexion.Close();
            }
        }

        private void CargarMunicipios(int idEstado)
        {
            try
            {
                if (mconexion.State != ConnectionState.Open)
                    mconexion.Open();

                string consulta = @"
                SELECT id_municipio, nombre
                FROM municipios
                WHERE id_estado = @id_estado
                ORDER BY nombre";

                using (NpgsqlCommand cmd = new NpgsqlCommand(consulta, mconexion))
                {
                    cmd.Parameters.AddWithValue("@id_estado", idEstado);

                    using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        DataRow filaInicial = dt.NewRow();
                        filaInicial["id_municipio"] = 0;
                        filaInicial["nombre"] = "Seleccione un municipio";
                        dt.Rows.InsertAt(filaInicial, 0);

                        txtmunicipio.DataSource = dt;
                        txtmunicipio.DisplayMember = "nombre";
                        txtmunicipio.ValueMember = "id_municipio";
                        txtmunicipio.SelectedIndex = 0;
                        txtmunicipio.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar municipios: " + ex.Message);
            }
            finally
            {
                if (mconexion.State == ConnectionState.Open)
                    mconexion.Close();
            }
        }

        private void LimpiarMunicipios()
        {
            txtmunicipio.DataSource = null;
            txtmunicipio.Items.Clear();
            txtmunicipio.Text = "";
            txtmunicipio.Enabled = false;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtnombre.Text.Trim();
                string correo = txtcorreo.Text.Trim();
                string contrasena = txtcontraseña.Text.Trim();

                if (usuario == "")
                {
                    MessageBox.Show("Ingrese un nombre de usuario.");
                    txtnombre.Focus();
                    return;
                }

                if (correo == "")
                {
                    MessageBox.Show("Ingrese un correo electrónico.");
                    txtcorreo.Focus();
                    return;
                }

                if (contrasena == "")
                {
                    MessageBox.Show("Ingrese una contraseña.");
                    txtcontraseña.Focus();
                    return;
                }

                if (txtestado.SelectedValue == null || txtestado.SelectedValue.ToString() == "0")
                {
                    MessageBox.Show("Seleccione un estado.");
                    txtestado.Focus();
                    return;
                }

                if (txtmunicipio.SelectedValue == null || txtmunicipio.SelectedValue.ToString() == "0")
                {
                    MessageBox.Show("Seleccione un municipio.");
                    txtmunicipio.Focus();
                    return;
                }

                int idEstado = Convert.ToInt32(txtestado.SelectedValue);
                int idMunicipio = Convert.ToInt32(txtmunicipio.SelectedValue);

                if (mconexion.State != ConnectionState.Open)
                    mconexion.Open();

                string consultaUsuario = "SELECT usuario FROM registro WHERE usuario = @Usuario";
                using (NpgsqlCommand cmdVerificar = new NpgsqlCommand(consultaUsuario, mconexion))
                {
                    cmdVerificar.Parameters.AddWithValue("@Usuario", usuario);
                    object resultado = cmdVerificar.ExecuteScalar();

                    if (resultado != null)
                    {
                        MessageBox.Show("Este usuario ya existe. Elija otro nombre de usuario.");
                        return;
                    }
                }

                string consultaCorreo = "SELECT email FROM registro WHERE email = @Correo";
                using (NpgsqlCommand cmdCorreo = new NpgsqlCommand(consultaCorreo, mconexion))
                {
                    cmdCorreo.Parameters.AddWithValue("@Correo", correo);
                    object resultadoCorreo = cmdCorreo.ExecuteScalar();

                    if (resultadoCorreo != null)
                    {
                        MessageBox.Show("Este correo ya está registrado.");
                        return;
                    }
                }

                string contrasenaHash = Encriptar(contrasena);

                string consultaInsert = @"
                INSERT INTO registro 
                (usuario, email, contrasena, id_estado, id_municipio) 
                VALUES 
                (@usuario, @correo, @contrasena, @id_estado, @id_municipio)";

                using (NpgsqlCommand cmdInsert = new NpgsqlCommand(consultaInsert, mconexion))
                {
                    cmdInsert.Parameters.AddWithValue("@usuario", usuario);
                    cmdInsert.Parameters.AddWithValue("@correo", correo);
                    cmdInsert.Parameters.AddWithValue("@contrasena", contrasenaHash);
                    cmdInsert.Parameters.AddWithValue("@id_estado", idEstado);
                    cmdInsert.Parameters.AddWithValue("@id_municipio", idMunicipio);

                    cmdInsert.ExecuteNonQuery();
                }

                MessageBox.Show("Usuario registrado exitosamente.");

                _formAnterior.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el usuario: " + ex.Message);
            }
            finally
            {
                if (mconexion.State == ConnectionState.Open)
                    mconexion.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }

        private void registro_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_formAnterior != null && !_formAnterior.IsDisposed && !_formAnterior.Visible)
            {
                _formAnterior.Show();
            }
        }

        private void txtmunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtestado_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (txtestado.SelectedValue == null)
                {
                    LimpiarMunicipios();
                    return;
                }

                if (txtestado.SelectedValue is DataRowView)
                    return;

                if (!int.TryParse(txtestado.SelectedValue.ToString(), out int idEstado))
                {
                    LimpiarMunicipios();
                    return;
                }

                if (idEstado == 0)
                {
                    LimpiarMunicipios();
                    return;
                }

                CargarMunicipios(idEstado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar estado: " + ex.Message);
            }
        }
    }
}
