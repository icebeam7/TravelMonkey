using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;

using Newtonsoft.Json;

using TravelMonkey.Models.AzureMaps;

namespace TravelMonkey.Services.AzureMaps
{
    public class WeatherService
    {
        public async static Task<CurrentConditions> GetCurrentConditionsAsync(double latitude, double longitude)
        {
            try
            {
                var url = $"{AzureMapsUris.GetCurrentConditions}&subscription-key={ApiKeys.AzureMapsApiKey}&query={latitude},{longitude}";
                var response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var jsonResult = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<CurrentConditions>(jsonResult);
                    return result;
                }
            }
            catch (Exception ex)
            {
            }

            return new CurrentConditions();
        }

        public async static Task<POI> GetDestinationPOIsAsync(double latitude, double longitude)
        {
            try
            {
                var url = $"{AzureMapsUris.GetPOIs}&subscription-key={ApiKeys.AzureMapsApiKey}&lat={latitude}&lon={longitude}";
                var response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var jsonResult = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<POI>(jsonResult);
                    return result;
                }
            }
            catch (Exception ex)
            {
            }

            return new POI();
        }

        private static readonly HttpClient client = CreateHttpClient();

        private static HttpClient CreateHttpClient()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(AzureMapsUris.WeatherBaseUrl);
            return client;
        }
    }
}
