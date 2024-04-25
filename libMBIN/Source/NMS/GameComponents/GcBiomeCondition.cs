using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCDE7624C86F8A991, NameHash = 0x6EC31F43E233154A)]
    public class GcBiomeCondition : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcBiomeType BiomeType;
    }
}
