using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using static EDUMAP.Carreras;
using MessageBox = System.Windows.MessageBox;

namespace EDUMAP
{
    public partial class FASE3 : Form
    {
        private Form FormActual = null;
        private string _primerCampo = "";
        private string _segundoCampo = "";
        private string _tercerCampo = "";

        private List<ResultadoCarrera> _todosResultados = new List<ResultadoCarrera>();
        private List<ResultadoCarrera> _carrerasMostradas = new List<ResultadoCarrera>();
        
        private List<ResultadoCarrera> ObtenerMasCarrerasPorCampo(string codigoCampo, int cantidad = 3)
        {
            return _todosResultados
                .Where(x => x.CodigoCampo == codigoCampo)
                .Where(x => !_carrerasMostradas.Any(y => y.IdCarrera == x.IdCarrera))
                .OrderByDescending(x => x.PuntajeFinal)
                .ThenByDescending(x => x.AfinidadFase2)
                .Take(cantidad)
                .ToList();
        }
        private void MostrarMasCarrerasPorCampo(string codigoCampo)
        {
            if (string.IsNullOrWhiteSpace(codigoCampo))
            {
                MessageBox.Show("No hay un campo válido para explorar.");
                return;
            }

            var nuevasCarreras = _todosResultados
                .Where(x => x.CodigoCampo == codigoCampo)
                .Where(x => !_carrerasMostradas.Any(y => y.IdCarrera == x.IdCarrera))
                .OrderByDescending(x => x.PuntajeFinal)
                .ThenByDescending(x => x.AfinidadFase2)
                .Take(3)
                .ToList();

            if (nuevasCarreras.Count == 0)
            {
                MessageBox.Show("No hay más carreras disponibles para " + ObtenerCampoTexto(codigoCampo));
                return;
            }

            _carrerasMostradas.AddRange(nuevasCarreras);

            MostrarResultados(nuevasCarreras, _primerCampo, _segundoCampo);
        }
        private List<string> ObtenerTop3CamposFase1()
        {
            string[] codigos = { "A", "C", "D", "E", "F", "L", "S" };

            return Global.PuntajesFase1
                .Select((valor, indice) => new
                {
                    Valor = valor,
                    Codigo = codigos[indice]
                })
                .Where(x => x.Valor > 0)
                .OrderByDescending(x => x.Valor)
                .Take(3)
                .Select(x => x.Codigo)
                .ToList();
        }
        public FASE3()
        {
            InitializeComponent();
        }

        private void FASE3_Load(object sender, EventArgs e)
        {
            try
            {
                CalcularYMostrarResultados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar resultados: " + ex.Message);
            }
        }

        private void CalcularYMostrarResultados()
        {
            string[] columnas =
            {
            "c1_a_visual",
            "c1_b_auditivo",
            "c1_c_lectura_escritura",
            "c1_d_kinestesico",

            "c2_a_creatividad",
            "c2_b_analisis",
            "c2_c_resolucion_practica",
            "c2_d_liderazgo",
            "c2_e_gestion",
            "c2_f_argumentacion",
            "c2_g_empatia",

            "c3_a_inteligencia_creativa",
            "c3_b_inteligencia_analitica",
            "c3_c_inteligencia_tecnica",
            "c3_d_inteligencia_estrategica",
            "c3_e_inteligencia_financiera",
            "c3_f_inteligencia_etica",
            "c3_g_inteligencia_interpersonal",

            "c4_a_creatividad",
            "c4_b_analisis",
            "c4_c_tecnica",
            "c4_d_liderazgo",
            "c4_e_gestion_financiera",
            "c4_f_argumentacion_legal",
            "c4_g_interpersonal",

            "c5_a_expresion",
            "c5_b_conocimiento",
            "c5_c_eficiencia",
            "c5_d_logro",
            "c5_e_exito_economico",
            "c5_f_justicia",
            "c5_g_impacto_social"
        };

            if (Global.RespuestasUsuario == null || Global.RespuestasUsuario.Length != 32)
            {
                MessageBox.Show("Los resultados de Fase 2 no son válidos.");
                return;
            }

            Dictionary<string, int> mapaCampos = Global.ObtenerMapaCamposFase1();
            int maxCampo = mapaCampos.Values.Max();

            List<ResultadoCarrera> resultados = new List<ResultadoCarrera>();

            using (var conn = Conexion.ConexionDB())
            {
                conn.Open();

                string query = @"
                SELECT DISTINCT
                    c.id_carrera,
                    c.nombre,
                    c.descripcion,
                    c.ruta_imagen,
                    cp.codigo AS codigo_campo,
                    c.c1_a_visual,
                    c.c1_b_auditivo,
                    c.c1_c_lectura_escritura,
                    c.c1_d_kinestesico,
                    c.c2_a_creatividad,
                    c.c2_b_analisis,
                    c.c2_c_resolucion_practica,
                    c.c2_d_liderazgo,
                    c.c2_e_gestion,
                    c.c2_f_argumentacion,
                    c.c2_g_empatia,
                    c.c3_a_inteligencia_creativa,
                    c.c3_b_inteligencia_analitica,
                    c.c3_c_inteligencia_tecnica,
                    c.c3_d_inteligencia_estrategica,
                    c.c3_e_inteligencia_financiera,
                    c.c3_f_inteligencia_etica,
                    c.c3_g_inteligencia_interpersonal,
                    c.c4_a_creatividad,
                    c.c4_b_analisis,
                    c.c4_c_tecnica,
                    c.c4_d_liderazgo,
                    c.c4_e_gestion_financiera,
                    c.c4_f_argumentacion_legal,
                    c.c4_g_interpersonal,
                    c.c5_a_expresion,
                    c.c5_b_conocimiento,
                    c.c5_c_eficiencia,
                    c.c5_d_logro,
                    c.c5_e_exito_economico,
                    c.c5_f_justicia,
                    c.c5_g_impacto_social
                FROM carreras c
                INNER JOIN oferta_academica oa ON oa.id_carrera = c.id_carrera
                INNER JOIN campos cp ON cp.id_campo = oa.id_campo;";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    int[] respuestasNormalizadas = NormalizarRespuestasUsuario(Global.RespuestasUsuario);
                    while (reader.Read())
                    {
                        int diferenciaTotal = 0;

                        for (int i = 0; i < columnas.Length; i++)
                        {
                            int valorCarrera = Convert.ToInt32(reader[columnas[i]]);
                            int valorUsuario = Global.RespuestasUsuario[i];
                            diferenciaTotal += Math.Abs(valorCarrera - valorUsuario);
                        }

                        double maxDiferencia = columnas.Length * 4.0;
                        double afinidadFase2 = 100.0 - ((diferenciaTotal / maxDiferencia) * 100.0);

                        string codigoCampo = reader["codigo_campo"].ToString();
                        int valorCampo = mapaCampos.ContainsKey(codigoCampo) ? mapaCampos[codigoCampo] : 0;

                        double afinidadCampo = maxCampo == 0
                            ? 0
                            : (valorCampo * 100.0 / maxCampo);

                        double puntajeFinal = (afinidadFase2 * 0.65) + (afinidadCampo * 0.35);

                        resultados.Add(new ResultadoCarrera
                        {
                            IdCarrera = Convert.ToInt32(reader["id_carrera"]),
                            Nombre = reader["nombre"].ToString(),
                            Descripcion = reader["descripcion"].ToString(),
                            RutaImagen = reader["ruta_imagen"].ToString(),
                            CodigoCampo = codigoCampo,
                            AfinidadFase2 = afinidadFase2,
                            AfinidadCampo = afinidadCampo,
                            PuntajeFinal = puntajeFinal
                        });
                    }
                }
            }
            _todosResultados = resultados;

            
            var top3Campos = ObtenerTop3CamposFase1();

            _primerCampo = top3Campos.Count > 0 ? top3Campos[0] : "";
            _segundoCampo = top3Campos.Count > 1 ? top3Campos[1] : "";
            _tercerCampo = top3Campos.Count > 2 ? top3Campos[2] : "";

            var top3 = _todosResultados
                .Where(x => x.CodigoCampo == _primerCampo)
                .OrderByDescending(x => x.PuntajeFinal)
                .ThenByDescending(x => x.AfinidadFase2)
                .Take(3)
                .ToList();

            _carrerasMostradas = top3;

            MostrarResultados(top3, _primerCampo, _segundoCampo);

            /*var top3 = resultados
                .OrderByDescending(x => x.PuntajeFinal)
                .ThenByDescending(x => x.AfinidadFase2)
                .Take(3)
                .ToList();

            if (top3.Count < 3)
            {
                MessageBox.Show("No hay suficientes carreras para mostrar.");
                return;
            }

            var top2Campos = Global.ObtenerTop2CamposFase1();

            var resultadosFiltrados = resultados
                .Where(x => x.CodigoCampo == top2Campos.campo1 || x.CodigoCampo == top2Campos.campo2)
                .OrderByDescending(x => x.PuntajeFinal)
                .ThenByDescending(x => x.AfinidadFase2)
                .Take(3)
                .ToList();

            if (resultadosFiltrados.Count < 3)
            {
                var faltantes = resultados
                    .Where(x => !resultadosFiltrados.Any(y => y.IdCarrera == x.IdCarrera))
                    .OrderByDescending(x => x.PuntajeFinal)
                    .Take(3 - resultadosFiltrados.Count)
                    .ToList();

                resultadosFiltrados.AddRange(faltantes);
            }

            MostrarResultados(resultadosFiltrados, top2Campos.campo1, top2Campos.campo2);*/
        }

        private void MostrarResultados(List<ResultadoCarrera> carreras, string primerCampo, string segundoCampo)
        {
            if (carreras == null || carreras.Count == 0)
            {
                MessageBox.Show("No hay carreras para mostrar.");
                return;
            }

            // Limpia primero
            lblCampo1.Text = "";
            lblCarrera1.Text = "";
            lblDescripcion1.Text = "";

            lblCampo2.Text = "";
            lblCarrera2.Text = "";
            lblDescripcion2.Text = "";

            lblCampo3.Text = "";
            lblCarrera3.Text = "";
            lblDescripcion3.Text = "";

            // Carrera 1
            if (carreras.Count >= 1)
            {
                lblCampo1.Text = ObtenerCampoTexto(carreras[0].CodigoCampo);
                lblCarrera1.Text = carreras[0].Nombre;
                lblDescripcion1.Text = carreras[0].Descripcion;
            }

            // Carrera 2
            if (carreras.Count >= 2)
            {
                lblCampo2.Text = ObtenerCampoTexto(carreras[1].CodigoCampo);
                lblCarrera2.Text = carreras[1].Nombre;
                lblDescripcion2.Text = carreras[1].Descripcion;
            }

            // Carrera 3
            if (carreras.Count >= 3)
            {
                lblCampo3.Text = ObtenerCampoTexto(carreras[2].CodigoCampo);
                lblCarrera3.Text = carreras[2].Nombre;
                lblDescripcion3.Text = carreras[2].Descripcion;
            }

            var perfil = GenerarPerfilMejorado(primerCampo, segundoCampo);

            lblPerfil.Text = perfil.titulo;
            lblDESCRIPCION.Text = perfil.descripcion;
            lblFortalezas.Text = perfil.habilidades;
            lblAreas.Text = perfil.areas;
        }

        private string ObtenerCampoTexto(string codigo)
        {
            switch (codigo)
            {
                case "A": return "ARTÍSTICO";
                case "C": return "CIENTÍFICO";
                case "D": return "DESARROLLO";
                case "E": return "EMPRENDIMIENTO";
                case "F": return "FINANZAS";
                case "L": return "LEYES";
                case "S": return "SOCIAL";
                default: return "GENERAL";
            }
        }

        public (string titulo, string descripcion, string habilidades, string areas) GenerarPerfilMejorado(string c1, string c2)
        {
            c1 = (c1 ?? "").Trim().ToUpper();
            c2 = (c2 ?? "").Trim().ToUpper();

            List<string> combinacion = new List<string> { c1, c2 };
            combinacion.Sort();
            string clave = string.Join("+", combinacion);

            switch (clave)
            {
                case "A+C":
                case "A+D":
                case "A+E":
                    return (
                        "Perfil Creativo-Innovador",
                        "Tienes una inclinación fuerte hacia la creación, la expresión y la transformación de ideas en proyectos concretos.",
                        "• Creatividad aplicada\n" +
                        "• Capacidad de innovación\n" +
                        "• Pensamiento flexible\n" +
                        "• Iniciativa para emprender proyectos\n" +
                        "• Expresión de ideas con originalidad",
                        "• Diseño\n" +
                        "• Producción audiovisual\n" +
                        "• Emprendimiento creativo\n" +
                        "• Innovación de productos\n" +
                        "• Proyectos artísticos y tecnológicos"
                    );

                case "A+L":
                    return (
                        "Perfil Creativo-Argumentativo",
                        "Combinas sensibilidad artística y expresiva con pensamiento crítico, estructura y capacidad de argumentación.",
                        "• Expresión creativa\n" +
                        "• Capacidad crítica\n" +
                        "• Comunicación persuasiva\n" +
                        "• Sensibilidad estética con análisis\n" +
                        "• Interés por el significado, la interpretación y la estructura",
                        "• Comunicación\n" +
                        "• Diseño con enfoque estratégico\n" +
                        "• Derecho con perfil humanista\n" +
                        "• Producción de contenidos\n" +
                        "• Gestión cultural, medios y análisis social"
                    );

                case "A+S":
                    return (
                        "Perfil Creativo-Humanista",
                        "Tienes una orientación expresiva y humana, con facilidad para conectar con otros mediante ideas, emociones y mensajes.",
                        "• Empatía\n" +
                        "• Sensibilidad social\n" +
                        "• Comunicación clara\n" +
                        "• Creatividad con impacto humano\n" +
                        "• Capacidad para conectar con distintas personas",
                        "• Psicología\n" +
                        "• Comunicación\n" +
                        "• Educación\n" +
                        "• Artes con enfoque social\n" +
                        "• Proyectos comunitarios y culturales"
                    );

                case "C+D":
                case "C+F":
                case "D+F":
                    return (
                        "Perfil Científico-Tecnológico",
                        "Tienes una fuerte capacidad para investigar, analizar y resolver problemas complejos con lógica y precisión.",
                        "• Pensamiento lógico\n" +
                        "• Capacidad de análisis\n" +
                        "• Resolución técnica de problemas\n" +
                        "• Atención al detalle\n" +
                        "• Curiosidad intelectual",
                        "• Ingeniería\n" +
                        "• Programación\n" +
                        "• Análisis de datos\n" +
                        "• Desarrollo tecnológico\n" +
                        "• Investigación aplicada"
                    );

                case "C+S":
                case "E+S":
                    return (
                        "Perfil Social-Humanista",
                        "Tienes vocación de servicio y una tendencia natural a comprender y ayudar a las personas.",
                        "• Empatía\n" +
                        "• Escucha activa\n" +
                        "• Sensibilidad social\n" +
                        "• Trabajo colaborativo\n" +
                        "• Interés por el bienestar de otros",
                        "• Psicología\n" +
                        "• Trabajo social\n" +
                        "• Educación\n" +
                        "• Recursos humanos\n" +
                        "• Intervención comunitaria"
                    );

                case "C+L":
                case "D+L":
                case "L+S":
                    return (
                        "Perfil Jurídico-Social",
                        "Tienes pensamiento crítico, capacidad de argumentación y una fuerte inclinación por la estructura, la justicia y el análisis social.",
                        "• Pensamiento crítico\n" +
                        "• Argumentación sólida\n" +
                        "• Interés por normas y estructuras\n" +
                        "• Evaluación racional de situaciones\n" +
                        "• Sentido de justicia",
                        "• Derecho\n" +
                        "• Ciencias políticas\n" +
                        "• Administración pública\n" +
                        "• Criminología\n" +
                        "• Investigación social y jurídica"
                    );

                case "C+E":
                case "D+E":
                case "E+L":
                    return (
                        "Perfil Innovador Integral",
                        "Tu perfil combina estrategia, adaptabilidad y visión interdisciplinaria para resolver problemas y liderar proyectos.",
                        "• Pensamiento multidisciplinario\n" +
                        "• Adaptabilidad\n" +
                        "• Visión estratégica\n" +
                        "• Liderazgo colaborativo\n" +
                        "• Capacidad para integrar distintas áreas",
                        "• Gestión de proyectos\n" +
                        "• Innovación empresarial\n" +
                        "• Consultoría\n" +
                        "• Desarrollo organizacional\n" +
                        "• Soluciones sostenibles"
                    );

                case "E+F":
                case "F+L":
                    return (
                        "Perfil Estratégico-Financiero",
                        "Tienes visión estratégica y capacidad para tomar decisiones bien estructuradas orientadas a resultados.",
                        "• Planeación\n" +
                        "• Organización\n" +
                        "• Toma de decisiones\n" +
                        "• Administración eficiente de recursos\n" +
                        "• Liderazgo orientado a objetivos",
                        "• Administración\n" +
                        "• Finanzas\n" +
                        "• Contaduría\n" +
                        "• Consultoría\n" +
                        "• Dirección empresarial"
                    );

                case "A+F":
                case "F+S":
                    return (
                        "Perfil Creativo-Estratégico",
                        "Combinas creatividad con visión práctica y estratégica, lo que te permite comunicar, diseñar y proyectar con enfoque realista.",
                        "• Creatividad con enfoque\n" +
                        "• Comunicación persuasiva\n" +
                        "• Organización\n" +
                        "• Visión práctica\n" +
                        "• Adaptabilidad",
                        "• Mercadotecnia\n" +
                        "• Comunicación estratégica\n" +
                        "• Negocios creativos\n" +
                        "• Branding\n" +
                        "• Gestión de proyectos"
                    );

                default:
                    return (
                        "Perfil General",
                        "Tienes un perfil equilibrado con intereses diversos. Tu potencial está en explorar y conectar distintas áreas antes de especializarte.",
                        "• Adaptabilidad\n" +
                        "• Curiosidad intelectual\n" +
                        "• Flexibilidad\n" +
                        "• Capacidad de aprendizaje\n" +
                        "• Pensamiento abierto",
                        "• Carreras interdisciplinarias\n" +
                        "• Innovación\n" +
                        "• Gestión de proyectos\n" +
                        "• Investigación aplicada\n" +
                        "• Exploración vocacional"
                    );
            }
        }

        private void abrirForm(Form form)
        {
            if (FormActual != null)
                FormActual.Close();

            FormActual = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panel1.Controls.Add(form);
            panel1.Tag = form;
            form.BringToFront();
            form.Show();

            panelHeader.Hide();
            panelContenido.Hide();
            tableLayoutPanel2.Hide();
            panelFases.Hide();
        }
        private int _modoExploracion = 0;
        private void regresar_Click(object sender, EventArgs e)
        {
            if (_modoExploracion == 0)
            {

                MostrarMasCarrerasPorCampo(_primerCampo);
                _modoExploracion = 1;
                regresar.Text = "Explorar carreras del segundo campo";
            }
            else if (_modoExploracion == 1)
            {
                if (string.IsNullOrWhiteSpace(_segundoCampo))
                {
                    MessageBox.Show("No existe un segundo campo dominante.");
                    return;
                }
                else
                {
                    MostrarMasCarrerasPorCampo(_segundoCampo);
                    _modoExploracion = 2;
                    regresar.Text = "Explorar carreras del tercer campo";
                }
                
            }
            else
            {
                if (string.IsNullOrWhiteSpace(_tercerCampo))
                {
                    MessageBox.Show("No existe un segundo campo dominante.");
                    return;
                }
                else 
                {
                    MostrarMasCarrerasPorCampo(_tercerCampo);
                    _modoExploracion = 0;
                    regresar.Text = "Explorar más carreras";
                }
            }
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            
            abrirForm(new MAPA());
        }
        private int[] NormalizarRespuestasUsuario(int[] respuestas)
        {
            if (respuestas == null || respuestas.Length != 32)
                throw new Exception("Las respuestas de Fase 2 no son válidas.");

            int[] normalizadas = new int[32];

            int[] maximosPorBloque =
            {
        8,8,8,8, // Bloque 1, 4 categorías

        10,10,10,10,10,10,10, // Bloque 2

        10,10,10,10,10,10,10, // Bloque 3

        5,5,5,5,5,5,5, // Bloque 4

        5,5,5,5,5,5,5 // Bloque 5
    };

            for (int i = 0; i < respuestas.Length; i++)
            {
                double proporcion = respuestas[i] / (double)maximosPorBloque[i];

                int valor = (int)Math.Round(proporcion * 5);

                if (valor < 1) valor = 1;
                if (valor > 5) valor = 5;

                normalizadas[i] = valor;
            }

            return normalizadas;
        }
    }

    public class ResultadoCarrera
    {
        public int IdCarrera { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string RutaImagen { get; set; }
        public string CodigoCampo { get; set; }
        public double AfinidadFase2 { get; set; }
        public double AfinidadCampo { get; set; }
        public double PuntajeFinal { get; set; }
        
    }
}