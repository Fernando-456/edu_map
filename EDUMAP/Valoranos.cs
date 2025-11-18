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
    public partial class Valoranos : Form
    {
        
        public Valoranos()
        {
            InitializeComponent();
        }
        private string ObtenerSeleccion(params RadioButton[] botones)
        {
            foreach (var rb in botones)
            {
                if (rb.Checked)
                    return rb.Text;   // Puedes poner rb.Tag si quieres guardar números
            }
            return null;
        }
        private void Valoranos_Load(object sender, EventArgs e)
        {
            
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Valoranos_Resize(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener valores de cada grupo
            string r1 = ObtenerSeleccion(rdb1, rdb1_2, rdb1_3, rdb1_4);
            string r2 = ObtenerSeleccion(rdb2, rdb2_2, rdb2_3, rdb2_4);
            string r3 = ObtenerSeleccion(rdb3, rdb3_2, rdb3_3, rdb3_4);
            string r4 = ObtenerSeleccion(rdb4, rdb4_2, rdb4_3, rdb4_4);

            // Validar que todas tienen selección
            if (r1 == null || r2 == null || r3 == null || r4 == null)
            {
                MessageBox.Show("Debes contestar todas las preguntas.");
                return;
            }

            string conexion = "server=89.116.159.185; database=EduMap; uid=Fernando_BD; pwd=1209;";
            
            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                conn.Open();
                
                string sql = @"INSERT INTO valoracion (Pregunta_1, Pregunta_2, Pregunta_3, Pregunta_4, Usuario)
                       VALUES (@p1, @p2, @p3, @p4, @Usuario);";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Usuario", Global.usuario);
                cmd.Parameters.AddWithValue("@p1", r1);
                cmd.Parameters.AddWithValue("@p2", r2);
                cmd.Parameters.AddWithValue("@p3", r3);
                cmd.Parameters.AddWithValue("@p4", r4);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Gracias por tu opinion");
            }
        }
    }
}
