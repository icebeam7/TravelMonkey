using System.Collections.Generic;

namespace TravelMonkey
{
    public static class AzureMapsUris
    {
        public static string WeatherBaseUrl = "https://atlas.microsoft.com/";

        public static string GetCurrentConditions = "weather/currentConditions/json?api-version=1.0";

        public static string GetPOIs = "search/poi/json?api-version=1.0&limit=10&query=restaurant";

        public static Dictionary<int, string> WeatherIcons = new Dictionary<int, string>()
        {
            { 1, "https://docs.microsoft.com/en-us/azure/azure-maps/media/weather-services-concepts/sunny-i.png" },
            { 2, "https://docs.microsoft.com/en-us/azure/azure-maps/media/weather-services-concepts/mostly-sunny.png" },
            { 3, "https://docs.microsoft.com/en-us/azure/azure-maps/media/weather-services-concepts/partly-sunny.png" },
            { 4, "https://docs.microsoft.com/en-us/azure/azure-maps/media/weather-services-concepts/intermittent-clouds.png" },
            { 5, "https://docs.microsoft.com/en-us/azure/azure-maps/media/weather-services-concepts/hazy-sunshine.png" },
            { 6, "https://docs.microsoft.com/en-us/azure/azure-maps/media/weather-services-concepts/mostly-cloudy.png" },
            { 7, "https://docs.microsoft.com/en-us/azure/azure-maps/media/weather-services-concepts/cloudy-i.png" },
            { 8, "https://docs.microsoft.com/en-us/azure/azure-maps/media/weather-services-concepts/dreary-overcast.png" },
            { 11, "https://docs.microsoft.com/en-us/azure/azure-maps/media/weather-services-concepts/fog-i.png" },
            { 12, "https://docs.microsoft.com/en-us/azure/azure-maps/media/weather-services-concepts/showers-i.png" },
            { 13, "https://docs.microsoft.com/en-us/azure/azure-maps/media/weather-services-concepts/mostly-cloudy-showers.png" },
            { 14, "https://docs.microsoft.com/en-us/azure/azure-maps/media/weather-services-concepts/partly-sunny-showers.png" },
            { 15, "https://docs.microsoft.com/en-us/azure/azure-maps/media/weather-services-concepts/tstorms-i.png" },
            { 16, "https://docs.microsoft.com/en-us/azure/azure-maps/media/weather-services-concepts/mostly-cloudy-tstorms.png" },
            { 17, "https://docs.microsoft.com/en-us/azure/azure-maps/media/weather-services-concepts/partly-sunny-tstorms.png" },
            { 18, "https://docs.microsoft.com/en-us/azure/azure-maps/media/weather-services-concepts/rain-i.png" },
            { 19, "https://docs.microsoft.com/en-us/azure/azure-maps/media/weather-services-concepts/flurries-i.png" },
            { 20, "https://docs.microsoft.com/en-us/azure/azure-maps/media/weather-services-concepts/mostly-cloudy-flurries.png" },
            { 21, "https://docs.microsoft.com/en-us/azure/azure-maps/media/weather-services-concepts/partly-sunny-flurries.png" },
            { 22, "https://docs.microsoft.com/en-us/azure/azure-maps/media/weather-services-concepts/snow-i.png" },
            { 23, "https://docs.microsoft.com/en-us/azure/azure-maps/media/weather-services-concepts/mostly-cloudy-snow.png" },
            { 24, "https://docs.microsoft.com/en-us/azure/azure-maps/media/weather-services-concepts/ice-i.png" },
            { 25, "https://docs.microsoft.com/en-us/azure/azure-maps/media/weather-services-concepts/sleet-i.png" },
            { 26, "https://docs.microsoft.com/en-us/azure/azure-maps/media/weather-services-concepts/freezing-rain.png" },
            { 29, "https://docs.microsoft.com/en-us/azure/azure-maps/media/weather-services-concepts/rain-snow.png" },
            { 30, "https://docs.microsoft.com/en-us/azure/azure-maps/media/weather-services-concepts/hot-i.png" },
            { 31, "https://docs.microsoft.com/en-us/azure/azure-maps/media/weather-services-concepts/cold-i.png" },
            { 32, "https://docs.microsoft.com/en-us/azure/azure-maps/media/weather-services-concepts/windy-i.png" },
            { 33, "https://docs.microsoft.com/en-us/azure/azure-maps/media/weather-services-concepts/clear-night.png" },
            { 34, "https://docs.microsoft.com/en-us/azure/azure-maps/media/weather-services-concepts/mostly-clear-night.png" },
            { 35, "https://docs.microsoft.com/en-us/azure/azure-maps/media/weather-services-concepts/partly-cloudy-night.png" },
            { 36, "https://docs.microsoft.com/en-us/azure/azure-maps/media/weather-services-concepts/intermittent-clouds-night.png" },
            { 37, "https://docs.microsoft.com/en-us/azure/azure-maps/media/weather-services-concepts/hazymoon-light.png" },
            { 38, "https://docs.microsoft.com/en-us/azure/azure-maps/media/weather-services-concepts/mostly-cloudy-night.png" },
            { 39, "https://docs.microsoft.com/en-us/azure/azure-maps/media/weather-services-concepts/partly-cloudy-showers-night.png" },
            { 40, "https://docs.microsoft.com/en-us/azure/azure-maps/media/weather-services-concepts/mostly-cloudy-showers-night.png" },
            { 41, "https://docs.microsoft.com/en-us/azure/azure-maps/media/weather-services-concepts/partly-cloudy-tstorms-night.png" },
            { 42, "https://docs.microsoft.com/en-us/azure/azure-maps/media/weather-services-concepts/mostly-cloudy-tstorms-night.png" },
            { 43, "https://docs.microsoft.com/en-us/azure/azure-maps/media/weather-services-concepts/mostly-cloudy-flurries-night.png" },
            { 44, "https://docs.microsoft.com/en-us/azure/azure-maps/media/weather-services-concepts/mostly-cloudy-snow.png" }
        };
    }
}
