using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x83DBFE91AE6CCE32, NameHash = 0xBB8457797F0508AB)]
    public class GcMultitoolPoolData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public int MaxDraw;
        [NMS(Index = 1)]
        /* 0x04 */ public int MinDraw;
        [NMS(Index = 3)]
        /* 0x08 */ public float PoolProbability;
        [NMS(Index = 4)]
        /* 0x0C */ public GcMultitoolPoolType PoolType;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x80 File;
    }
}
