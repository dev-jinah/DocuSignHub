using backend.Models;

public interface IWeatherService
{
    IEnumerable<WeatherForecast> GetForecasts();
}
