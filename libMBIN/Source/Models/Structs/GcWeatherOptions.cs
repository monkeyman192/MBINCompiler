namespace libMBIN.Models.Structs
{
    public class GcWeatherOptions : NMSTemplate
    {
        public int Weather;
        public string[] WeatherValues()
        {
            return new[] { "Clear", "Dust", "Humid", "Snow", "Toxic", "Scorched", "Radioactive", "RedWeather", "GreenWeather", "BlueWeather" };
        }
    }
}
