namespace LogYourWork.Services
{
    using System.Collections.Generic;
    using LogYourWork.Data;

    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly IWeatherForecastRepository _weatherForecastRepository;

        public WeatherForecastService(IWeatherForecastRepository weatherForecastRepository)
        {
            this._weatherForecastRepository = weatherForecastRepository;
        }

        public IEnumerable<WeatherForecast> GetWeatherForecast()
            => _weatherForecastRepository.Get();
    }
}
