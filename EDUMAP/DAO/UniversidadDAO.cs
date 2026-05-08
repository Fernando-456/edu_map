using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;

namespace EDUMAP.DAO
{
    public class FiltroUniversidad
    {
        public string Carrera { get; set; }
        public string Universidad { get; set; }
        public string Estado { get; set; }
        public string Tipo { get; set; } // Pública o Privada
    }
    public class UniversidadDAO
    {
        public static DataTable ObtenerEstados()
        {
            DataTable dt = new DataTable();

            using (var con = Conexion.ConexionDB())
            {
                con.Open();

                string sql = @"
                SELECT id_estado, nombre
                FROM estados
                ORDER BY nombre;";

                using (var cmd = new NpgsqlCommand(sql, con))
                using (var da = new NpgsqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }

        public static DataTable ObtenerUniversidadesCombo()
        {
            DataTable dt = new DataTable();

            using (var con = Conexion.ConexionDB())
            {
                con.Open();

                string sql = @"
                SELECT id_universidad, nombre
                FROM universidades
                ORDER BY nombre;";

                using (var cmd = new NpgsqlCommand(sql, con))
                using (var da = new NpgsqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }

        public static DataTable ObtenerCarrerasCombo()
        {
            DataTable dt = new DataTable();

            using (var con = Conexion.ConexionDB())
            {
                con.Open();

                string sql = @"
                SELECT id_carrera, nombre
                FROM carreras
                ORDER BY nombre;";

                using (var cmd = new NpgsqlCommand(sql, con))
                using (var da = new NpgsqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }

        public static DataTable ObtenerUniversidadesFiltradas(FiltroUniversidad filtro)
        {
            DataTable dt = new DataTable();

            using (var con = Conexion.ConexionDB())
            {
                con.Open();

                StringBuilder sql = new StringBuilder(@"
                SELECT DISTINCT
                    u.id_universidad,
                    u.nombre AS universidad,
                    u.pagina_web AS pagina_web,
                    tu.nombre AS tipo,
                    c.nombre AS carrera,
                    e.nombre AS estado,
                    m.nombre AS municipio,
                    m.latitud AS latitud,
                    m.longitud AS longitud
                FROM universidades u
                INNER JOIN tipos_universidad tu
                    ON tu.id_tipo = u.id_tipo
                INNER JOIN estados e
                    ON e.id_estado = u.id_estado
                INNER JOIN municipios m
                    ON m.id_municipio = u.id_municipio
                INNER JOIN oferta_academica oa
                    ON oa.id_universidad = u.id_universidad
                INNER JOIN carreras c
                    ON c.id_carrera = oa.id_carrera
                WHERE m.latitud IS NOT NULL
                  AND m.longitud IS NOT NULL
            ");

                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = con;

                    if (!string.IsNullOrWhiteSpace(filtro.Tipo))
                    {
                        sql.Append(" AND tu.nombre = @tipo");
                        cmd.Parameters.AddWithValue("@tipo", filtro.Tipo);
                    }

                    if (!string.IsNullOrWhiteSpace(filtro.Estado))
                    {
                        sql.Append(" AND e.nombre = @estado");
                        cmd.Parameters.AddWithValue("@estado", filtro.Estado);
                    }

                    if (!string.IsNullOrWhiteSpace(filtro.Universidad))
                    {
                        sql.Append(" AND u.nombre = @universidad");
                        cmd.Parameters.AddWithValue("@universidad", filtro.Universidad);
                    }

                    if (!string.IsNullOrWhiteSpace(filtro.Carrera))
                    {
                        sql.Append(" AND c.nombre = @carrera");
                        cmd.Parameters.AddWithValue("@carrera", filtro.Carrera);
                    }

                    sql.Append(" ORDER BY u.nombre, c.nombre;");

                    cmd.CommandText = sql.ToString();

                    using (var da = new NpgsqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt;
        }
    }
}
