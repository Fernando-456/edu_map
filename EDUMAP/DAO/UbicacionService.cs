using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDUMAP.DAO
{
    public class UbicacionService
    {
        private readonly MunicipioDAO _municipioDao;
        private readonly GeocodingService _geocodingService;

        public UbicacionService(string googleApiKey)
        {
            _municipioDao = new MunicipioDAO();
            _geocodingService = new GeocodingService(googleApiKey);
        }

        public async Task<string> CompletarMunicipiosSinCoordenadasAsync()
        {
            List<MunicipioPendiente> municipios = _municipioDao.ObtenerMunicipiosSinCoordenadas();

            StringBuilder log = new StringBuilder();
            log.AppendLine($"Municipios pendientes: {municipios.Count}");

            foreach (var item in municipios)
            {
                string direccion = $"{item.Municipio}, {item.Estado}, México";
                var resultado = await _geocodingService.ObtenerCoordenadasAsync(direccion);

                if (resultado.Ok)
                {
                    int filas = _municipioDao.ActualizarCoordenadasMunicipio(
                        item.IdMunicipio,
                        resultado.Lat,
                        resultado.Lng
                    );

                    log.AppendLine($"OK -> {direccion} | Lat: {resultado.Lat}, Lng: {resultado.Lng} | Filas: {filas}");
                }
                else
                {
                    log.AppendLine($"ERROR -> {direccion} | {resultado.MensajeError}");
                }

                await Task.Delay(300);
            }

            return log.ToString();
        }
    }
}
