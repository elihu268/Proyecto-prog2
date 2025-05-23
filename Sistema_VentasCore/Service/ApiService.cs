using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Net.Http;
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
    }
}
