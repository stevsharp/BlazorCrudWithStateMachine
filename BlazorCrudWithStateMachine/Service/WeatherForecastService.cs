using BlazorCrudWithStateMachine.Model;
using System.Net.Http.Json;

namespace BlazorCrudWithStateMachine.Service
{
    public interface IWeatherForecastService
    {
        Task<IEnumerable<WeatherForecast>> GetForecastAsync();
    }
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly HttpClient httpClient;

        private WeatherForecast[]? forecasts;

        public WeatherForecastService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<WeatherForecast>> GetForecastAsync()
        {
            forecasts = await httpClient.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");

            return forecasts;
        }
    }
}
