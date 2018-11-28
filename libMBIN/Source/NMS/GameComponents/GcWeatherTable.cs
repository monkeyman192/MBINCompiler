using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xEB1DFB8AFF12B189)]
    public class GcWeatherTable : NMSTemplate
    {
        [NMS( EnumType = typeof( GcWeatherOptions.WeatherEnum ) )]
        public NMSString0x80[] Table;

        [NMS(Size = 5)]
        public GcHazardValues[] DefaultTemperature;

        [NMS(Size = 5)]
        public GcHazardValues[] DefaultToxicity;

        [NMS(Size = 5)]
        public GcHazardValues[] DefaultRadiation;
    }
}
