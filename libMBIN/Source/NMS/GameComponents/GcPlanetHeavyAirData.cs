using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9B14EDCCD9AFFD2A, NameHash = 0xF2CCFFA0)]
    public class GcPlanetHeavyAirData : NMSTemplate
    {
        [NMS(Index = 1, Size = 0x5)]
        /* 0x000 */ public GcHeavyAirColourData[] Colours;
        [NMS(Index = 0)]
        /* 0x140 */ public VariableSizeString Filename;
    }
}
