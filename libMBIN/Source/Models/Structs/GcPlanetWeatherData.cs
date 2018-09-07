namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x150)]
    public class GcPlanetWeatherData : NMSTemplate
    {
        public GcWeatherOptions WeatherOptions;     // weather type?
        //public GcPlanetWeatherColourData NightColours;
        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding4;
        /* 0x010 */ public GcPlanetHeavyAirData HeavyAir;
		public enum WeatherIntensityEnum { Default, Extreme }
		public WeatherIntensityEnum WeatherIntensity;
		public enum StormFrequencyEnum { None, Low, High }
		public StormFrequencyEnum StormFrequency;
		public enum AtmosphereTypeEnum { None, Normal }
		public AtmosphereTypeEnum AtmosphereType;
        /* 0x13C */ public int DayColourIndex;
        /* 0x140 */ public int DuskColourIndex;

        [NMS(Size = 0xC, Ignore = true)]
        /* 0x144 */ public byte[] EndPadding;
    }
}
