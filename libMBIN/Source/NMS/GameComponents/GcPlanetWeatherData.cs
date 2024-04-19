using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x620ECEEF56DC06F6, NameHash = 0xEBF08BE1E3CAE3AC)]
    public class GcPlanetWeatherData : NMSTemplate
    {
        /* 0x000 */ public GcPlanetHeavyAirData HeavyAir;
        // size: 0x2
        public enum AtmosphereTypeEnum : uint {
            None,
            Normal,
        }
        /* 0x120 */ public AtmosphereTypeEnum AtmosphereType;
        /* 0x124 */ public int DayColourIndex;
        /* 0x128 */ public int DuskColourIndex;
        /* 0x12C */ public int NightColourIndex;
        /* 0x130 */ public GcRainbowType RainbowType;
        /* 0x134 */ public GcScreenFilters ScreenFilter;
        // size: 0x3
        public enum StormFrequencyEnum : uint {
            None,
            Low,
            High,
        }
        /* 0x138 */ public StormFrequencyEnum StormFrequency;
        /* 0x13C */ public GcScreenFilters StormScreenFilter;
        // size: 0x2
        public enum WeatherIntensityEnum : uint {
            Default,
            Extreme,
        }
        /* 0x140 */ public WeatherIntensityEnum WeatherIntensity;
        /* 0x144 */ public GcWeatherOptions WeatherType;
    }
}
