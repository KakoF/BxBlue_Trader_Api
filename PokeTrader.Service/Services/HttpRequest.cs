using Microsoft.Extensions.Configuration;
using PokeTrader.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PokeTrader.Service.Services
{
    public class HttpRequest : IHttpRequest
    {
        private readonly HttpClient _httpClient;
        private string _baseUrl;
        public HttpRequest(IConfiguration configuration)
        {
            _httpClient = new HttpClient();
            _baseUrl = configuration["pokemon"];

        }

        public async Task<string> GetRequest(string url)
        {
            string endpointPath = _baseUrl + url;

            HttpResponseMessage response = await _httpClient.GetAsync(endpointPath);
            if (!response.IsSuccessStatusCode)
                throw new Exception("Pokemon não encontrado!");
            return await response.Content.ReadAsStringAsync();
        }
    }
}
