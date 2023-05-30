using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcPlanetHeavyAirData : NMSTemplate
    {
        public NMSString0x80 Filename;
        [NMS(Size = 5)]
        public GcHeavyAirColourData[] Colours;
    }

}
