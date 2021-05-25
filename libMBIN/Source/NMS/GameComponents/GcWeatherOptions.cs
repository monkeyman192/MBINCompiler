using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0x56E9F4FD69E0DE84, NameHash = 0xA2AEA53FED6497EC)]
    public class GcWeatherOptions : NMSTemplate
    {
        // size: 0x10
		public enum WeatherEnum {
            Clear, Dust, Humid, Snow, Toxic, Scorched, Radioactive, RedWeather, GreenWeather, BlueWeather,
            Swamp, Lava, Bubble, Weird, Fire, ClearCold
        }
		public WeatherEnum Weather;
    }
}