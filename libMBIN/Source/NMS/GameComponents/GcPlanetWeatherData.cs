using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x150, GUID = 0x3500669C56035A7D, NameHash = 0xEBF08BE1E3CAE3AC)]
    public class GcPlanetWeatherData : NMSTemplate
    {
        public GcWeatherOptions WeatherType;
        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding4;
        /* 0x010 */ public GcPlanetHeavyAirData HeavyAir;
		public enum WeatherIntensityEnum { Default, Extreme }
		/* 0x130 */ public WeatherIntensityEnum WeatherIntensity;
		public enum StormFrequencyEnum { None, Low, High }
		/* 0x134 */ public StormFrequencyEnum StormFrequency;
		public enum AtmosphereTypeEnum { None, Normal }
		/* 0x138 */ public AtmosphereTypeEnum AtmosphereType;
        /* 0x13C */ public int DayColourIndex;
        /* 0x140 */ public int DuskColourIndex;
        /* 0x144 */ public GcScreenFilters ScreenFilter;
        /* 0x148 */ public GcScreenFilters StormScreenFilter;
        /* 0x14C */ public GcRainbowType RainbowType;
    }
}
