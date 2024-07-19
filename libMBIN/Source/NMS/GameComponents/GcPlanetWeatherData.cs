using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEECD24B334604576, NameHash = 0x935FB78B)]
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
        /* 0x150 */ public AtmosphereTypeEnum AtmosphereType;
        [NMS(Index = 5)]
        /* 0x154 */ public int DayColourIndex;
        [NMS(Index = 6)]
        /* 0x158 */ public int DuskColourIndex;
        [NMS(Index = 10)]
        /* 0x15C */ public int NightColourIndex;
        [NMS(Index = 9)]
        /* 0x160 */ public GcRainbowType RainbowType;
        [NMS(Index = 7)]
        /* 0x164 */ public GcScreenFilters ScreenFilter;
        // size: 0x4
        public enum StormFrequencyEnum : uint {
            None,
            Low,
            High,
            Always,
        }
        [NMS(Index = 3)]
        /* 0x168 */ public StormFrequencyEnum StormFrequency;
        [NMS(Index = 8)]
        /* 0x16C */ public GcScreenFilters StormScreenFilter;
        // size: 0x2
        public enum WeatherIntensityEnum : uint {
            Default,
            Extreme,
        }
        [NMS(Index = 2)]
        /* 0x170 */ public WeatherIntensityEnum WeatherIntensity;
        [NMS(Index = 0)]
        /* 0x174 */ public GcWeatherOptions WeatherType;
    }
}
