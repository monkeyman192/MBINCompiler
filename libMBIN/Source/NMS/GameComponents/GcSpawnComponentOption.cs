using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1C1176A042D3F0BE, NameHash = 0xA7EE5AECC28F3591)]
    public class GcSpawnComponentOption : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public GcResourceElement SpecificModel;
        [NMS(Index = 0)]
        /* 0x2A8 */ public NMSString0x10 Name;
        [NMS(Index = 1)]
        /* 0x2B8 */ public GcSeed Seed;
    }
}
