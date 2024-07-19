using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB5516B16658C426A, NameHash = 0x19C9B3E9)]
    public class GcSpawnComponentOption : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public GcResourceElement SpecificModel;
        [NMS(Index = 0)]
        /* 0x48 */ public NMSString0x10 Name;
        [NMS(Index = 1)]
        /* 0x58 */ public GcSeed Seed;
    }
}
