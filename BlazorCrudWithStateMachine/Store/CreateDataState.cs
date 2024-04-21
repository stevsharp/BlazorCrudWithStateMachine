using BlazorCrudWithStateMachine.Model;

using Fluxor;

namespace BlazorCrudWithStateMachine.Store
{
    [FeatureState]
    public record CreateDataState
    {
        public bool IsLoading { get; init; }
        public WeatherForecast? Forecast { get; init; }
        public string? Error { get; init; }

        private CreateDataState() { }
        public CreateDataState(bool isLoading,
            WeatherForecast? forecast,
            string? error)
        {
            IsLoading = isLoading;
            Forecast = forecast;
            Error = error;
        }
    }
}
