// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var srv =  new businessLayer.Services.WeatherService();

foreach(var data in srv.GetWeatherData())
{
    Console.WriteLine(data);
}

string s1;

Console.WriteLine("Completed!");
Console.ReadKey();

