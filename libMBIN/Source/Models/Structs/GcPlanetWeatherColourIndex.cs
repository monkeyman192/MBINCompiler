namespace libMBIN.Models.Structs
{
    public class GcPlanetWeatherColourIndex : NMSTemplate       // size: 0x8
    {
		public enum WeatherColourSetEnum { Common, Rare }
		public WeatherColourSetEnum WeatherColourSet;
        public int Index;
    }
}
