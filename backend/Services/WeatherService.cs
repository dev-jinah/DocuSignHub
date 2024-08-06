using backend.Models;

public class WeatherService : IWeatherService
{
    public IEnumerable<WeatherForecast> GetForecasts()
    {
        // 예제 데이터 생성
        return new List<WeatherForecast>
        {
            new WeatherForecast { Date = DateTime.Now, TemperatureC = 25, Summary = "Sunny" },
            new WeatherForecast { Date = DateTime.Now.AddDays(1), TemperatureC = 28, Summary = "Hot" }
        };
    }
}
