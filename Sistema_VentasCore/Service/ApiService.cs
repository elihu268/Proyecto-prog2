using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Net.Http;
using Newtonsoft.Json;
namespace Sistema_VentasCore.Service
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;//permite comunicarse con diferentes apis

        private readonly string _baseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"] ?? throw new InvalidOperationException("La clave 'ApiBaseUrl' no está configurada en AppSettings.");
        public ApiService()
        {
            _httpClient = new HttpClient();
            _httpClient.Timeout = TimeSpan.FromSeconds(30);
        }

        public async Task<int> GetExistencia(string claveProducto)
        {
            try
            {
                string endpoint = "existenciasapi/existencia";
                string queryString = $"?clave={claveProducto}";

                HttpResponseMessage response = await _httpClient.GetAsync(_baseUrl + endpoint + queryString);

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    return int.Parse(json);
                }
                else
                {
                    // Manejar errores
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener productos: {response.StatusCode} - {errorContent}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en API: {ex.Message}");
                throw;
            }
        }

        public async Task<bool> GetEstatus(string claveProducto)
        {
            try
            {
                string endpoint = "existenciasapi/estatus";
                string queryString = $"?clave={claveProducto}";

                HttpResponseMessage response = await _httpClient.GetAsync(_baseUrl + endpoint + queryString);

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    int estatus = int.Parse(json);
                    if (estatus == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    // Manejar errores
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error al obtener estudiantes: {response.StatusCode} - {errorContent}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en API: {ex.Message}");
                throw;
            }
        }

        public async Task<bool> ActualizarExistencias(int cantidad, string claveProducto)
        {
            try
            {
                string endpoint = "existenciasapi/restar_existencia";
                string queryString = $"?clave={claveProducto}&cantidad={cantidad}";

                // Enviar PUT sin contenido en el body
                var request = new HttpRequestMessage(HttpMethod.Post, _baseUrl + endpoint + queryString);

                HttpResponseMessage response = await _httpClient.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();

                    // Convertir directamente el texto "true" o "false" a bool
                    return bool.Parse(responseContent.Trim());
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en API al actualizar stock: {ex.Message}");
                return false;
            }
        }
    }
}
