using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x620ECEEF56DC06F6, NameHash = 0xEBF08BE1E3CAE3AC)]
    public class GcPlanetWeatherData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x000 */ public GcPlanetHeavyAirData HeavyAir;
        // size: 0x2
        public enum AtmosphereTypeEnum : uint {
            None,
            Normal,
        }
        [NMS(Index = 4)]
        /* 0x120 */ public AtmosphereTypeEnum AtmosphereType;
        [NMS(Index = 5)]
        /* 0x124 */ public int DayColourIndex;
        [NMS(Index = 6)]
        /* 0x128 */ public int DuskColourIndex;
        [NMS(Index = 10)]
        /* 0x12C */ public int NightColourIndex;
        [NMS(Index = 9)]
        /* 0x130 */ public GcRainbowType RainbowType;
        [NMS(Index = 7)]
        /* 0x134 */ public GcScreenFilters ScreenFilter;
        // size: 0x3
        public enum StormFrequencyEnum : uint {
            None,
            Low,
            High,
        }
        [NMS(Index = 3)]
        /* 0x138 */ public StormFrequencyEnum StormFrequency;
        [NMS(Index = 8)]
        /* 0x13C */ public GcScreenFilters StormScreenFilter;
        // size: 0x2
        public enum WeatherIntensityEnum : uint {
            Default,
            Extreme,
        }
        [NMS(Index = 2)]
        /* 0x140 */ public WeatherIntensityEnum WeatherIntensity;
        [NMS(Index = 0)]
        /* 0x144 */ public GcWeatherOptions WeatherType;
    }
}
