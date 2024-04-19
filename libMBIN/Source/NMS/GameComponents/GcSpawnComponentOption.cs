using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3DC3CC771C566B1A, NameHash = 0xA7EE5AECC28F3591)]
    public class GcSpawnComponentOption : NMSTemplate
    {
        /* 0x000 */ public GcResourceElement SpecificModel;
        /* 0x2A8 */ public NMSString0x10 Name;
        /* 0x2B8 */ public GcSeed Seed;
    }
}
