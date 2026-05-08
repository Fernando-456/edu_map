using Npgsql;
using System.Configuration;
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

        public static NpgsqlConnection ConexionDB()
        {
            try
            {
                string cadenaConexion = ConfigurationManager
                                        .ConnectionStrings["EduMapDB"]
                                        .ConnectionString;

                NpgsqlConnection conexion = new NpgsqlConnection(cadenaConexion);
                return conexion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message);
                return null;
            }
        }


    }
}
