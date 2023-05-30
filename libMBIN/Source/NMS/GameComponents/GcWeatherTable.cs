using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcWeatherTable : NMSTemplate
    {
        [NMS(Size = 7)]
        public NMSString0x80[] Table;

        [NMS(Size = 5)]
        public GcHazardValues[] DefaultTemperature;

        [NMS(Size = 5)]
        public GcHazardValues[] DefaultToxicity;

        [NMS(Size = 5)]
        public GcHazardValues[] DefaultRadiation;
    }
}
