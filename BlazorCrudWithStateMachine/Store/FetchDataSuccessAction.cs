using BlazorCrudWithStateMachine.Model;

using static BlazorCrudWithStateMachine.Pages.Weather;

namespace BlazorCrudWithStateMachine.Store
{
    namespace BlazorFluxorStateManagement.Store.FetchDataUseCase
    {
        public record FetchDataSuccessAction(IEnumerable<WeatherForecast> Forecasts);
    }
}
