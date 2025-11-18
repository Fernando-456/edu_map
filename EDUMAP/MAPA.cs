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
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace EDUMAP
{
    public partial class MAPA : Form
    {
        string conexion = "Server=89.116.159.185;Database=EduMap;Uid=Fernando_BD;Pwd=1209;";
        string[] tablas = { "campo_artistico", "campo_emprendimiento", "campo_cientifico", "campo_desarrollo", "campo_leyes", "campo_finanzas", "campo_social" };
        public MAPA()
        {
            InitializeComponent();
            
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
                string query = "SELECT nombre, ruta_imagen FROM universidades";
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView2.DataSource = dt;

                // Opcional: ocultar la columna de la URL
                dataGridView2.Columns["ruta_imagen"].Visible = false;
                
                dataGridView2.Columns["nombre"].HeaderText = "Universidad";
            }
        }
        private void CargarCarreras()
        {
            using (MySqlConnection cn = new MySqlConnection(conexion))
            {
                cn.Open();
                // Combinar todas las tablas pero sin duplicados
                string query = string.Join(" UNION ", Array.ConvertAll(tablas, t => $"SELECT DISTINCT Carrera FROM {t}"));
                MySqlCommand cmd = new MySqlCommand(query, cn);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string carrera = dr["Carrera"].ToString();
                    if (!comboBoxcarreras.Items.Contains(carrera))
                        comboBoxcarreras.Items.Add(carrera);
                }
                dr.Close();
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
                    MessageBox.Show("No se encontraron resultados");
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
            MostrarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBoxcarreras.Text)
            {
                case null:
                    MessageBox.Show("Por favor, seleccione una carrera.");
                    return;
               
            }
            
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
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
