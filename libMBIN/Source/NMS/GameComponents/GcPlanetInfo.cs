using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x383, GUID = 0x265C96B5655DF648, NameHash = 0x458D53EF402BA3C9)]
    public class GcPlanetInfo : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string PlanetDescription;
        [NMS(Size = 0x80)]
        public string PlanetType;
        [NMS(Size = 0x80)]
        public string Weather;
        [NMS(Size = 0x80)]
        public string Resources;
        [NMS(Size = 0x80)]
        public string Flora;
        [NMS(Size = 0x80)]
        public string Fauna;
        [NMS(Size = 0x80)]
        public string Sentinels;

        public bool IsWeatherExtreme;
        public bool AreSentinelsExtreme;
        public bool AreSentinelsModerate;
    }
}
