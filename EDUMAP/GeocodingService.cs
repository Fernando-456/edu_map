using Newtonsoft.Json.Linq;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;

namespace EDUMAP
{
    public class ResultadoGeocoding
    {
        public bool Ok { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        public string MensajeError { get; set; }
    }
    public class GeocodingService
    {
        private readonly string _apiKey;

        public GeocodingService(string apiKey)
        {
            _apiKey = apiKey;
        }

        public async Task<ResultadoGeocoding> ObtenerCoordenadasAsync(string direccion)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string url = $"https://maps.googleapis.com/maps/api/geocode/json?address={Uri.EscapeDataString(direccion)}&key={_apiKey}";
                    string json = await client.GetStringAsync(url);

                    JObject obj = JObject.Parse(json);
                    string status = obj["status"]?.ToString();

                    if (status != "OK")
                    {
                        return new ResultadoGeocoding
                        {
                            Ok = false,
                            MensajeError = $"Google respondió: {status}"
                        };
                    }

                    var location = obj["results"]?[0]?["geometry"]?["location"];
                    if (location == null)
                    {
                        return new ResultadoGeocoding
                        {
                            Ok = false,
                            MensajeError = "No se encontró ubicación."
                        };
                    }

                    return new ResultadoGeocoding
                    {
                        Ok = true,
                        Lat = Convert.ToDouble(location["lat"]),
                        Lng = Convert.ToDouble(location["lng"])
                    };
                }
            }
            catch (Exception ex)
            {
                return new ResultadoGeocoding
                {
                    Ok = false,
                    MensajeError = ex.Message
                };
            }
        }
    }
}
