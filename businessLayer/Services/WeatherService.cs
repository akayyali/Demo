namespace businessLayer.Services;

public class WeatherService
{
    public WeatherService(){}

    public string[] GetWeatherData()
    {
        
        return new string[]{ "Freezin", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"};
    }
}