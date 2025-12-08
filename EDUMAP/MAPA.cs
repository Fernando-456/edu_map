using FontAwesome.Sharp;
using MySql.Data.MySqlClient;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data;
using System.Drawing;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;

namespace EDUMAP
{
    public partial class MAPA : Form
    {
        string conexion = "Server=62.72.5.62;Database=EduMap;Uid=fer;Pwd=1234;";
        string[] tablas = { "campo_artistico", "campo_emprendimiento", "campo_cientifico", "campo_desarrollo", "campo_leyes", "campo_finanzas", "campo_social" };
        public MAPA()
        {
            InitializeComponent();
            comboBoxmunicipio.DisplayMember = "";
            comboBoxmunicipio.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        
        
        private void MAPA_Load(object sender, EventArgs e)
        {
            CargarCarreras();
            CargarMunicipios();
            CargarUniversidades();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void CargarUniversidades()
        {
            using (MySqlConnection con = new MySqlConnection(conexion))
            {
                con.Open();
                string query = "SELECT nombre, ruta_imagen, pagina_web FROM universidades";

                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView2.DataSource = dt;

                // Mostrar columnas bonitas
                dataGridView2.Columns["nombre"].HeaderText = "Universidad";

                // Ocultar la ruta de imagen (si no quieres verla en la tabla)
                dataGridView2.Columns["ruta_imagen"].Visible = false;

                // Mostrar el link
                dataGridView2.Columns["pagina_web"].Visible = false;

                
            }
        }
        private void CargarCarreras()
        {
            using (MySqlConnection con = new MySqlConnection(conexion))
            {
                con.Open();
                string unionQuery = "";
                for (int i = 0; i < tablas.Length; i++)
                {
                    unionQuery += $"SELECT Carrera FROM {tablas[i]} WHERE Carrera IS NOT NULL AND Carrera <> ''";

                    if (i < tablas.Length - 1)
                        unionQuery += " UNION ";
                }
                // Consulta final ordenada
                string query = $@"
                SELECT DISTINCT Carrera
                FROM ({unionQuery}) AS todas
                ORDER BY Carrera ASC;";

                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBoxcarreras.DataSource = dt;
                comboBoxcarreras.DisplayMember = "Carrera";
                comboBoxcarreras.DropDownStyle = ComboBoxStyle.DropDownList;

            }
        }
        private void CargarMunicipios()
        {
            using (MySqlConnection cn = new MySqlConnection(conexion))
            {
                cn.Open();
                // Combinar todas las tablas pero sin duplicados
                string query = string.Join(" UNION ", Array.ConvertAll(tablas, t => $"SELECT DISTINCT Municipio FROM {t}"));
                MySqlCommand cmd = new MySqlCommand(query, cn);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string municipio = dr["Municipio"].ToString();
                    if (!comboBoxmunicipio.Items.Contains(municipio))
                        comboBoxmunicipio.Items.Add(municipio);
                }
                dr.Close();
            }
        }

        private void FormResize()
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                // Ajustar el tamaño y la posición de los controles para pantalla maximizada
            }
            else
            {
                // Ajustar el tamaño y la posición de los controles para pantalla normal
            }
        }

        private void MAPA_ResizeEnd(object sender, EventArgs e)
        {
            FormResize();
        }


        private void MostrarDatos()
        {
            if (comboBoxcarreras.SelectedIndex == -1 || comboBoxmunicipio.SelectedIndex == -1)
                return;

            string carrera = comboBoxcarreras.Text;
            string municipio = comboBoxmunicipio.Text;

            using (MySqlConnection cn = new MySqlConnection(conexion))
            {
                cn.Open();
                string unionQuery = "";

                foreach (string tabla in tablas)
                {
                    // Verificar si la tabla tiene coincidencias antes de incluirla
                    string checkQuery = $"SELECT COUNT(*) FROM {tabla} WHERE Carrera=@carrera AND Municipio=@municipio";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, cn);
                    checkCmd.Parameters.AddWithValue("@carrera", carrera);
                    checkCmd.Parameters.AddWithValue("@municipio", municipio);
                    long count = Convert.ToInt64(checkCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        if (unionQuery != "")
                            unionQuery += " UNION ALL ";

                        unionQuery += $@"
                            SELECT 
                                '{tabla}' AS tabla_origen,
                                Carrera,
                                Universidad,
                                Municipio,
                                Tipo_Universidad
                            FROM {tabla}
                            WHERE Carrera=@carrera AND Municipio=@municipio";
                            
                    }
                }

                if (unionQuery == "")
                {
                    MessageBox.Show("Pruebe con otro municipio y/o otra carrera");
                    dataGridView1.DataSource = null;
                    return;
                }

                // Eliminar filas duplicadas de resultado final (por si hay repeticiones entre tablas)
                string queryFinal = $"SELECT DISTINCT * FROM ({unionQuery}) AS todo";

                MySqlCommand cmd = new MySqlCommand(queryFinal, cn);
                cmd.Parameters.AddWithValue("@carrera", carrera);
                cmd.Parameters.AddWithValue("@municipio", municipio);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.Columns["tabla_origen"].Visible = false;


            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxmunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxmunicipio.DropDownStyle = ComboBoxStyle.DropDownList;
            
            MostrarDatos();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
               
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string ruta = dataGridView2.Rows[e.RowIndex].Cells["ruta_imagen"].Value.ToString();
                string link = dataGridView2.Rows[e.RowIndex].Cells["pagina_web"].Value.ToString();

                if (!string.IsNullOrEmpty(ruta))
                {
                    try
                    {
                        using (WebClient web = new WebClient())
                        {
                            byte[] datos = web.DownloadData(ruta);
                            using (var ms = new System.IO.MemoryStream(datos))
                            {
                                pictureBox1.Image = Image.FromStream(ms);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                    }
                }
                // Verificar si es número de teléfono
                if (EsTelefono(link))
                {
                    MessageBox.Show("Número telefónico: " + link, "NO TIENE PAGINA",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return; // NO intenta abrir navegador ni cargar imagen
                }
                if (EsUrl(link))
                {
                    linkLabel1.Visible = true;
                    // --- MOSTRAR LINK ---
                    linkLabel1.Text = link;
                    linkLabel1.Links.Clear();
                    linkLabel1.Links.Add(0, link.Length, link);
                    return;
                }
                
            }
            

        }
        private bool EsTelefono(string texto)
        {
            // Quita espacios y guiones
            string limpio = texto.Replace(" ", "").Replace("-", "");

            // Si empieza con + y el resto son dígitos
            if (limpio.StartsWith("+"))
                return limpio.Substring(1).All(char.IsDigit);

            // Si no tiene + pero son puros dígitos
            return limpio.All(char.IsDigit);
        }
        private bool EsUrl(string ruta)
        {
            return ruta.StartsWith("http://") ||
                   ruta.StartsWith("https://");
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            linkLabel1.LinkVisited = true;
            string url = e.Link.LinkData.ToString();
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }
    }
}
