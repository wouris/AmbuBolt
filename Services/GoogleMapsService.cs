using System.Diagnostics;
using AmbuBolt.Models;
using System.Text.Json;
using System.Web;

namespace AmbuBolt.Services
{
    public class GoogleMapsService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;

        public GoogleMapsService(HttpClient httpClient, string apiKey)
        {
            _httpClient = httpClient;
            _apiKey = apiKey;
        }

        public async Task<DirectionsData> GetEstimatedTimesAsync(string origin, string destination)
        {
            var encodedOrigin = HttpUtility.UrlEncode(origin);
            var encodedDestination = HttpUtility.UrlEncode(destination);
            var uri =
                $"https://maps.googleapis.com/maps/api/distancematrix/json?origins={encodedOrigin}&destinations={encodedDestination}&key={_apiKey}";
            var response = await _httpClient.GetAsync(uri);
            response.EnsureSuccessStatusCode();
            
            var responseContent = await response.Content.ReadAsStringAsync();
            var directionsData = JsonSerializer.Deserialize<DirectionsData>(responseContent);

            return directionsData;
        }
    }
}

