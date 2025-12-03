using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDUMAP
{
    public static class Conexion
    {

        public static MySqlConnection ConexionDB()
        {
            string server = "62.72.5.62";
            string database = "EduMap";
            string user = "fer";
            string password = "1234";
            string cadenaconexion = $"server={server}; database={database}; User={user}; Password={password};";
            try
            {
                MySqlConnection conexion = new MySqlConnection(cadenaconexion);
               
                return conexion;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
                return null;
            }

        }
        

    }
}
