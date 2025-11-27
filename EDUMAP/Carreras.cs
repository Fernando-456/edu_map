using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDUMAP
{
    public partial class Carreras : Form
    {
        public Carreras()
        {
            InitializeComponent();
        }
        string conexion = "server=89.116.159.185; database=EduMap; uid=Fernando_BD; pwd=1209;";

        private void Carreras_Load(object sender, EventArgs e)
        {
            CargarCarreras();
        }
        public class Carreras_
        {
            public string Nombre { get; set; }
            public string RutaImagen { get; set; }

            public override string ToString()
            {
                return Nombre; // Esto hará que el ComboBox muestre solo el nombre
            }
        }
        private void CargarCarreras()
        {
            using (MySqlConnection con = new MySqlConnection(conexion))
            {
                con.Open();
                string query = "SELECT nombre, ruta_imagen FROM carreras";

                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cbCarreras.Items.Add(new Carreras_
                    {
                        Nombre = dr["nombre"].ToString(),
                        RutaImagen = dr["ruta_imagen"].ToString()
                    });
                }
            }
        }

        private void cbCarreras_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCarreras.SelectedItem is Carreras_ u)
            {
                try
                {
                    using (WebClient web = new WebClient())
                    {
                        byte[] datos = web.DownloadData(u.RutaImagen);
                        using (var ms = new System.IO.MemoryStream(datos))
                        {
                            pictureBox1.Image = Image.FromStream(ms);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar imagen: " + ex.Message);
                }
            }

        }
    }
}
