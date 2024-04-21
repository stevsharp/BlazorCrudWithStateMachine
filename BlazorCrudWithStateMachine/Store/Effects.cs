using BlazorCrudWithStateMachine.Service;
using BlazorCrudWithStateMachine.Store.BlazorFluxorStateManagement.Store.FetchDataUseCase;

using Fluxor;

using MudBlazor;

namespace BlazorCrudWithStateMachine.Store
{
    public class Effects
    {
        private readonly IWeatherForecastService _weatherForecastService;

        public Effects(IWeatherForecastService weatherForecastService)
        {
            _weatherForecastService = weatherForecastService;
        }

        [EffectMethod]
        public async Task HandleAsync(FetchDataAction action, IDispatcher dispatcher)
        {
            try
            {
                var forecasts = await _weatherForecastService.GetForecastAsync();

                dispatcher.Dispatch(new FetchDataSuccessAction(forecasts));
            }
            catch (Exception ex)
            {
                dispatcher.Dispatch(new FetchDataErrorAction(ex.Message));
            }
        }

        [EffectMethod]
        public async Task HandleAsync(CreateDataAction action, IDispatcher dispatcher)
        {
            try
            {
                var parameters = new DialogParameters()
                {

                };

                //var forecasts = await _weatherForecastService.GetForecastAsync();

                //dispatcher.Dispatch(new FetchDataSuccessAction(forecasts));
            }
            catch (Exception ex)
            {
                dispatcher.Dispatch(new FetchDataErrorAction(ex.Message));
            }
        }
    }
}
