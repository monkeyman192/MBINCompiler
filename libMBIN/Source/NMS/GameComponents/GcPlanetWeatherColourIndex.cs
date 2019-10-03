using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x4DA6EA7EB1532236, NameHash = 0x8F4800F7EA8399A7)]
    public class GcPlanetWeatherColourIndex : NMSTemplate       // size: 0x8
    {
		public enum WeatherColourSetEnum { Common, Rare }
		public WeatherColourSetEnum WeatherColourSet;
        public int Index;
    }
}
