using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;


namespace EDUMAP
{
    public partial class PERFIL : Form
    {
        string conexion = "server=62.72.5.62 ;database=EduMap;user=fer;password=1234;";

        public PERFIL()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void PERFIL_Load(object sender, EventArgs e)
        {
            
            label2.Text = Global.usuario;
            label2.Visible = true;
            txtusuario.Text = Global.usuario;
            txtcontraseña.Text = Global.contraseña;
            if (Global.Primera_opcion == Global.SI_A.ToString())
            {
                
                Global.Primera_opcion = "Artístico";
            }
            else if (Global.Primera_opcion == Global.SI_E.ToString())
            {
                
                Global.Primera_opcion = "Emprendimiento";
            }
            else if (Global.Primera_opcion == Global.SI_C.ToString())
            {
                
                Global.Primera_opcion = "Científico";
            }
            else if (Global.Primera_opcion == Global.SI_S.ToString())
            {
                
                Global.Primera_opcion = "Social";
            }
            else if (Global.Primera_opcion == Global.SI_D.ToString())
            {
                
                Global.Primera_opcion = "Desarrollo";
            }
            else if (Global.Primera_opcion == Global.SI_F.ToString())
            {
               
                Global.Primera_opcion = "Finanzas";
            }
            else if (Global.Primera_opcion == Global.SI_L.ToString())
            {
                
                Global.Primera_opcion = "Leyes";
            }

            if (Global.Segunda_opcion == Global.SI_A.ToString())
            {
                Global.Segunda_opcion = "Artístico";
            }
            else if (Global.Segunda_opcion == Global.SI_E.ToString())
            {
                Global.Segunda_opcion = "Emprendimiento";
            }
            else if (Global.Segunda_opcion == Global.SI_C.ToString())
            {
                Global.Segunda_opcion = "Científico";
            }
            else if (Global.Segunda_opcion == Global.SI_S.ToString())
            {
                Global.Segunda_opcion = "Social";
            }
            else if (Global.Segunda_opcion == Global.SI_D.ToString())
            {
                Global.Segunda_opcion = "Desarrollo";
            }
            else if (Global.Segunda_opcion == Global.SI_F.ToString())
            {
                Global.Segunda_opcion = "Finanzas";
            }
            else if (Global.Segunda_opcion == Global.SI_L.ToString())
            {
                Global.Segunda_opcion = "Leyes";
            }

            if (Global.Tercera_opcion == Global.SI_A.ToString())
            {
                Global.Tercera_opcion = "Artistico";
            }
            else if (Global.Tercera_opcion == Global.SI_E.ToString())
            {
                Global.Tercera_opcion = "Emprendimiento";
            }
            else if (Global.Tercera_opcion == Global.SI_C.ToString())
            {
                Global.Tercera_opcion = "Científico";
            }
            else if (Global.Tercera_opcion == Global.SI_S.ToString())
            {
                Global.Tercera_opcion = "Social";
            }
            else if (Global.Tercera_opcion == Global.SI_D.ToString())
            {
                Global.Tercera_opcion = "Desarrollo";
            }
            else if (Global.Tercera_opcion == Global.SI_F.ToString())
            {
                Global.Tercera_opcion = "Finanzas";
            }
            else if (Global.Tercera_opcion == Global.SI_L.ToString())
            {
                Global.Tercera_opcion = "Leyes";
            }
            txtprimera.Text = Global.Primera_opcion;
            txtsegunda.Text = Global.Segunda_opcion;
            txttercera.Text = Global.Tercera_opcion;
             
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            
            if (txtusuario.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa un nuevo usuario");
                return;
            }

            using (MySqlConnection con = new MySqlConnection(conexion))
            {
                con.Open();

                string query = "UPDATE registro SET Usuario = @Usuario WHERE id = @id";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Usuario", txtusuario.Text);
                cmd.Parameters.AddWithValue("@id", Global.id); // ID del usuario

                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario actualizado correctamente");
            }

            
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        string Encriptar(string texto)
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
        private void iconButton2_Click(object sender, EventArgs e)
        {
            
            if (txtcontraseña.Text.Trim() == "")
            {
                MessageBox.Show("Ingresa una contraseña");
                return;
            }



            string hash = Encriptar(txtcontraseña.Text);

            using (MySqlConnection con = new MySqlConnection(conexion))
            {
                con.Open();

                string query = "UPDATE registro SET Contraseña = @Contraseña WHERE id = @id";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Contraseña", hash);
                cmd.Parameters.AddWithValue("@id", Global.id); // ID del usuario

                cmd.ExecuteNonQuery();
                MessageBox.Show("Contraseña actualizada correctamente");
            }

            
        }

        private void txtprimera_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtprimera_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


