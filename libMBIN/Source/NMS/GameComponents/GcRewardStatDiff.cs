using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x26EF81DE98F050DD, NameHash = 0x9F1240710CA7E631)]
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
