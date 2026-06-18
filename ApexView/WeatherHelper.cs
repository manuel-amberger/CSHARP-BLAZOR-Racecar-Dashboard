namespace ApexView;

public class WeatherHelper {
    public static readonly Dictionary<EWeather, string> Map = new() {
        { EWeather.CLEAR, "Wolkenlos" },
        { EWeather.EXTRASUNNY, "Sonnig" },
        { EWeather.RAIN, "Regnerisch" },
        { EWeather.SNOW, "Schnee" },
        { EWeather.THUNDER, "Gewitter" }
    };
}