using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x14D9F46D8E0CEDDB, NameHash = 0x2E1B1C402A21253)]
    public class GcPlanetHeavyAirData : NMSTemplate
    {
        [NMS(Index = 1, Size = 0x5)]
        /* 0x00 */ public GcHeavyAirColourData[] Colours;
        [NMS(Index = 0)]
        /* 0xA0 */ public NMSString0x80 Filename;
    }
}
