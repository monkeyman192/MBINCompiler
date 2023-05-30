using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcPlanetInfo : NMSTemplate
    {
        public NMSString0x80 PlanetDescription;
        public NMSString0x80 PlanetType;
        public NMSString0x80 Weather;
        public NMSString0x80 Resources;
        public NMSString0x80 Flora;
        public NMSString0x80 Fauna;
        public NMSString0x80 Sentinels;

        public bool IsWeatherExtreme;
        public bool AreSentinelsExtreme;
    }
}
