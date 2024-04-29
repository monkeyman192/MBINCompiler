using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA1EC67CB72BD4CA3, NameHash = 0x3E0EF3AAF2E4B272)]
    public class GcRewardModifyStat : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 OtherStat;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 Stat;
        [NMS(Index = 2)]
        /* 0x20 */ public int Amount;
        [NMS(Index = 4)]
        /* 0x24 */ public GcStatModifyType ModifyType;
        [NMS(Index = 3)]
        /* 0x28 */ public bool UseOtherStat;
    }
}
