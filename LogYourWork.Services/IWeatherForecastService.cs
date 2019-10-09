namespace LogYourWork.Services
{
    using LogYourWork.Data;
    using System.Collections.Generic;

    public interface IWeatherForecastService
    {
        IEnumerable<WeatherForecast> GetWeatherForecast();
    }
}
