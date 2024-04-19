using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x83DBFE91AE6CCE32, NameHash = 0xBB8457797F0508AB)]
    public class GcMultitoolPoolData : NMSTemplate
    {
        /* 0x00 */ public int MaxDraw;
        /* 0x04 */ public int MinDraw;
        /* 0x08 */ public float PoolProbability;
        /* 0x0C */ public GcMultitoolPoolType PoolType;
        /* 0x10 */ public NMSString0x80 File;
    }
}
