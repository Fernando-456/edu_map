using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDUMAP.DAO
{
    public class MunicipioPendiente
    {
        public int IdMunicipio { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }
    }

    public class MunicipioDAO
    {
        public List<MunicipioPendiente> ObtenerMunicipiosSinCoordenadas()
        {
            List<MunicipioPendiente> lista = new List<MunicipioPendiente>();

            using (var con = Conexion.ConexionDB())
            {
                con.Open();

                string sql = @"
                SELECT 
                    m.id_municipio,
                    m.nombre AS municipio,
                    e.nombre AS estado
                FROM municipios m
                INNER JOIN estados e ON e.id_estado = m.id_estado
                WHERE m.latitud IS NULL OR m.longitud IS NULL
                ORDER BY e.nombre, m.nombre;";

                using (var cmd = new NpgsqlCommand(sql, con))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new MunicipioPendiente
                        {
                            IdMunicipio = Convert.ToInt32(reader["id_municipio"]),
                            Municipio = reader["municipio"].ToString(),
                            Estado = reader["estado"].ToString()
                        });
                    }
                }
            }

            return lista;
        }

        public int ActualizarCoordenadasMunicipio(int idMunicipio, double latitud, double longitud)
        {
            using (var con = Conexion.ConexionDB())
            {
                con.Open();

                string sql = @"
                UPDATE municipios
                SET latitud = @latitud,
                    longitud = @longitud
                WHERE id_municipio = @idMunicipio;";

                using (var cmd = new NpgsqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@latitud", latitud);
                    cmd.Parameters.AddWithValue("@longitud", longitud);
                    cmd.Parameters.AddWithValue("@idMunicipio", idMunicipio);

                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
