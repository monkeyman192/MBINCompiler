using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE1CDBA931A48B895, NameHash = 0xF34407FF)]
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
