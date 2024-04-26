using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x27EC480E87BC3618, NameHash = 0xDEB32057FC4A2AC1)]
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
