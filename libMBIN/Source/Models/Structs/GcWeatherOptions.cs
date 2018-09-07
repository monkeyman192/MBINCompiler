namespace libMBIN.Models.Structs
{
    public class GcWeatherOptions : NMSTemplate
    {
		public enum WeatherEnum { Clear, Dust, Humid, Snow, Toxic, Scorched, Radioactive, RedWeather, GreenWeather, BlueWeather }
		public WeatherEnum Weather;
    }
}
