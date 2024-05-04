using Demo.ApiClient.Models;
using Demo.ApiClient.Models.ApiModels;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Demo.ApiClient
{
    public class DemoApiClientService
    {
        private readonly HttpClient _httpClient;

        public DemoApiClientService(ApiClientOptions apiClientOptions)
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new System.Uri(apiClientOptions.ApiBaseAddress);
        }

        public async Task<List<CulturalEvent>?> GetCulturalEvents()
        {
            return await _httpClient.GetFromJsonAsync<List<CulturalEvent>?>("/api/CulturalEvent");
        }

        public async Task<CulturalEvent?> GetById(int id)
        {
            return await _httpClient.GetFromJsonAsync<CulturalEvent?>($"/api/CulturalEvent/{id}");
        }

        public async Task SaveCulturalEvent(CulturalEvent culturalEvent)
        {
            await _httpClient.PostAsJsonAsync("/api/CulturalEvent", culturalEvent);
        }

        public async Task UpdateCulturalEvent(CulturalEvent culturalEvent)
        {
            await _httpClient.PutAsJsonAsync("/api/CulturalEvent", culturalEvent);
        }

        public async Task DeleteCulturalEvent(int id)
        {
            await _httpClient.DeleteAsync($"/api/CulturalEvent/{id}");
        }
    }
}
