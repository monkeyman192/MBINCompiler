using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC7EE81C4F7A2E524, NameHash = 0x1E9EFBA2)]
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
        [NMS(Index = 5)]
        /* 0x28 */ public bool CanSetToValueLowerThanCurrent;
        [NMS(Index = 3)]
        /* 0x29 */ public bool UseOtherStat;
    }
}
