using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xA9410B6550F62352, NameHash = 0xA2AEA53FED6497EC)]
    public class GcWeatherOptions : NMSTemplate
    {
		public enum WeatherEnum { Clear, Dust, Humid, Snow, Toxic, Scorched, Radioactive, RedWeather, GreenWeather, BlueWeather }
		public WeatherEnum Weather;
    }
}
