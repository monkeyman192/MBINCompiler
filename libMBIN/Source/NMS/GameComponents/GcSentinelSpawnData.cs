using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCA230D07FA48ACF9, NameHash = 0xB8C015B2B3985468)]
    public class GcSentinelSpawnData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x0 */ public int MaxAmount;
        [NMS(Index = 1)]
        /* 0x4 */ public int MinAmount;
        [NMS(Index = 0)]
        /* 0x8 */ public GcSentinelTypes Type;
    }
}
