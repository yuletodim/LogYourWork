namespace LogYourWork.Data
{
    using System.Collections.Generic;

    public interface IWeatherForecastRepository
    {
        IEnumerable<WeatherForecast> Get();
    }
}
