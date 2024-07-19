using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDCDD177F526E5FF8, NameHash = 0xBC1537BF)]
    public class GcSettlementPerkUsefulData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 BaseID;
        [NMS(Index = 1)]
        /* 0x10 */ public ulong SeedValue;
        [NMS(Index = 2)]
        /* 0x18 */ public float ChangeStrength;
        [NMS(Index = 3)]
        /* 0x1C */ public GcSettlementStatType Stat;
        [NMS(Index = 4)]
        /* 0x20 */ public bool IsNegative;
        [NMS(Index = 5)]
        /* 0x21 */ public bool IsProc;
    }
}
