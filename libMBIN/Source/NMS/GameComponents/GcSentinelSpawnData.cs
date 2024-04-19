using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCA230D07FA48ACF9, NameHash = 0xB8C015B2B3985468)]
    public class GcSentinelSpawnData : NMSTemplate
    {
        /* 0x0 */ public int MaxAmount;
        /* 0x4 */ public int MinAmount;
        /* 0x8 */ public GcSentinelTypes Type;
    }
}
