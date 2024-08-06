using backend.Models;

public interface IWeatherRepository
{
    IEnumerable<WeatherForecast> GetAll();
}
