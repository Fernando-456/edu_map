using EDUMAP.DAO;
using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDUMAP
{
    public partial class MAPA : Form
    {
        private bool mapaListo = false;
        private bool combosCargados = false;
        private string tipoSeleccionado = null;


        public MAPA()
        {
            InitializeComponent();
        }

        private async void MAPA_Load(object sender, EventArgs e)
        {
            try
            {
                combosCargados = false;
                await InicializarMapaAsync();
                CargarCombos();
                combosCargados = true;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar MAPA: " + ex.Message);
            }
        }

        private async Task InicializarMapaAsync()
        {
            await webViewMapa.EnsureCoreWebView2Async();
            webViewMapa.CoreWebView2.NavigationCompleted += CoreWebView2_NavigationCompleted;

            string rutaMapa = Path.Combine(Application.StartupPath, "mapa.html");

            if (!File.Exists(rutaMapa))
                throw new FileNotFoundException("No se encontró mapa.html");

            webViewMapa.Source = new Uri(rutaMapa);
        }

        private void CoreWebView2_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            mapaListo = e.IsSuccess;
        }

        private void CargarCombos()
        {
            CargarComboEstados();
            CargarComboUniversidades();
            CargarComboCarreras();
        }

        private void CargarComboEstados()
        {
            DataTable dt = UniversidadDAO.ObtenerEstados();

            DataRow fila = dt.NewRow();
            fila["id_estado"] = DBNull.Value;
            fila["nombre"] = "Todos";
            dt.Rows.InsertAt(fila, 0);

            cmbEntidad.DataSource = dt;
            cmbEntidad.DisplayMember = "nombre";
            cmbEntidad.ValueMember = "nombre";
            cmbEntidad.SelectedIndex = 0;
        }

        private void CargarComboUniversidades()
        {
            DataTable dt = UniversidadDAO.ObtenerUniversidadesCombo();

            DataRow fila = dt.NewRow();
            fila["id_universidad"] = DBNull.Value;
            fila["nombre"] = "Todas";
            dt.Rows.InsertAt(fila, 0);

            cmbInstitucion.DataSource = dt;
            cmbInstitucion.DisplayMember = "nombre";
            cmbInstitucion.ValueMember = "nombre";
            cmbInstitucion.SelectedIndex = 0;
        }

        private void CargarComboCarreras()
        {
            DataTable dt = UniversidadDAO.ObtenerCarrerasCombo();

            DataRow fila = dt.NewRow();
            fila["id_carrera"] = DBNull.Value;
            fila["nombre"] = "Todas";
            dt.Rows.InsertAt(fila, 0);

            cmbAreaInteres.DataSource = dt;
            cmbAreaInteres.DisplayMember = "nombre";
            cmbAreaInteres.ValueMember = "nombre";
            cmbAreaInteres.SelectedIndex = 0;
        }

        private FiltroUniversidad ObtenerFiltroActual()
        {
            return new FiltroUniversidad
            {
                Carrera = cmbAreaInteres.SelectedIndex <= 0 ? null : cmbAreaInteres.SelectedValue?.ToString(),
                Universidad = cmbInstitucion.SelectedIndex <= 0 ? null : cmbInstitucion.SelectedValue?.ToString(),
                Estado = cmbEntidad.SelectedIndex <= 0 ? null : cmbEntidad.SelectedValue?.ToString(),
                Tipo = tipoSeleccionado
            };
        }

        private async Task LimpiarMapa()
        {
            if (!mapaListo) return;
            await webViewMapa.ExecuteScriptAsync("limpiarMarcadores()");
        }

        private async Task AgregarMarcadorMapa(double lat, double lng, string universidad, string detalle)
        {
            if (!mapaListo) return;

            string uni = EscapeJs(universidad);
            string det = EscapeJs(detalle);

            string script =
                $"agregarMarcador({lat.ToString(CultureInfo.InvariantCulture)}," +
                $"{lng.ToString(CultureInfo.InvariantCulture)}," +
                $"'{uni}','{det}')";

            await webViewMapa.ExecuteScriptAsync(script);
        }

        private async Task ZoomMapa(double lat, double lng)
        {
            if (!mapaListo) return;

            string script =
                $"enfocarMarcador({lat.ToString(CultureInfo.InvariantCulture)}," +
                $"{lng.ToString(CultureInfo.InvariantCulture)})";

            await webViewMapa.ExecuteScriptAsync(script);
        }

        private string EscapeJs(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return string.Empty;

            return texto
                .Replace("\\", "\\\\")
                .Replace("'", "\\'")
                .Replace("\"", "\\\"")
                .Replace("\r", "")
                .Replace("\n", " ");
        }

        private async Task AplicarFiltros()
        {
            try
            {

                panelUniversidades.SuspendLayout();
                panelUniversidades.Controls.Clear();
                await LimpiarMapa();

                FiltroUniversidad filtro = ObtenerFiltroActual();
                DataTable tabla = UniversidadDAO.ObtenerUniversidadesFiltradas(filtro);

                if (tabla.Rows.Count == 0)
                {
                    panelUniversidades.ResumeLayout();
                    MessageBox.Show(
                        "No se encontraron universidades con los filtros seleccionados.",
                        "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    return;
                }

                foreach (DataRow row in tabla.Rows)
                {
                    if (row["latitud"] == DBNull.Value || row["longitud"] == DBNull.Value)
                        continue;

                    double lat = Convert.ToDouble(row["latitud"]);
                    double lng = Convert.ToDouble(row["longitud"]);
                    string universidad = row["universidad"].ToString();
                    string carrera = row["carrera"].ToString();
                    string tipo = row["tipo"].ToString();

                    await AgregarMarcadorMapa(lat, lng, universidad, $"{tipo} - {carrera}");

                    var card = CrearCard(row);
                    panelUniversidades.Controls.Add(card);
                }

                panelUniversidades.ResumeLayout();
            }
            catch (Exception ex)
            {
                panelUniversidades.ResumeLayout();
                MessageBox.Show("Error al aplicar filtros: " + ex.Message);
            }
        }

        private cardUniversidades CrearCard(DataRow row)
        {
            cardUniversidades card = new cardUniversidades();

            string universidad = row["universidad"].ToString();
            string carrera = row["carrera"].ToString();
            string tipo = row["tipo"].ToString();

            string paginaWeb = row["pagina_web"] == DBNull.Value
            ? ""
            : row["pagina_web"].ToString();

            card.CargarDatos(universidad, tipo, carrera, paginaWeb);

            card.CargarDatos(universidad, tipo, carrera, paginaWeb);

            card.Latitud = Convert.ToDouble(row["latitud"]);
            card.Longitud = Convert.ToDouble(row["longitud"]);

            card.CardClick += async (s, e) =>
            {
                await ZoomMapa(card.Latitud, card.Longitud);
            };

            return card;
        }

        private async void btnTodas_Click(object sender, EventArgs e)
        {
            tipoSeleccionado = null;
            await AplicarFiltros();
        }

        

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            cmbAreaInteres.SelectedIndex = 0;
            cmbInstitucion.SelectedIndex = 0;
            cmbEntidad.SelectedIndex = 0;
            tipoSeleccionado = null;
        }

        private async void cmbAreaInteres_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!combosCargados) return;
            await AplicarFiltros();
        }

        private async void cmbInstitucion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!combosCargados) return;
            await AplicarFiltros();
        }

        private async void cmbEntidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!combosCargados) return;
            await AplicarFiltros();
        }

        private async void btnPublico_Click(object sender, EventArgs e)
        {
            tipoSeleccionado = "Pública";
            await AplicarFiltros();
        }

        private async void btnPrivado_Click(object sender, EventArgs e)
        {
            tipoSeleccionado = "Privada";
            await AplicarFiltros();
        }

        private async void btnAplicarFiltros_Click_1(object sender, EventArgs e)
        {
            await AplicarFiltros();
        }
        private Form FormActual = null;
        private void abrirForm(Form form)
        {
            if (FormActual != null)
            {
                FormActual.Close();
            }

            FormActual = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panel1.Controls.Clear();
            panel1.Controls.Add(form);
            panel1.Tag = form;
            form.BringToFront();
            form.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            abrirForm(new Menu());
        }
    }
}
