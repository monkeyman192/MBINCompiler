using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x39A30AD98B79A092, NameHash = 0x3E0EF3AAF2E4B272)]
    public class GcRewardModifyStat : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 OtherStat;
        /* 0x10 */ public NMSString0x10 Stat;
        /* 0x20 */ public int Amount;
        /* 0x24 */ public GcStatModifyType ModifyType;
        /* 0x28 */ public bool UseOtherStat;
    }
}
