using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8BD0C64908DD6BBA, NameHash = 0x28731EF9)]
    public class GcRewardStatDiff : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 CompareAndSetStat;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 CoreStat;
        [NMS(Index = 2)]
        /* 0x20 */ public NMSString0x10 SubstanceID;
        [NMS(Index = 4)]
        /* 0x30 */ public int AmountPerStat;
        [NMS(Index = 3)]
        /* 0x34 */ public GcCurrency RewardCurrency;
        [NMS(Index = 5)]
        /* 0x38 */ public int StatRewardCap;
    }
}
