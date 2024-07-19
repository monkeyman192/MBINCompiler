using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x738FDA70AEF6C31, NameHash = 0x3784738)]
    public class GcPassiveFrigateIncome : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 IncomeId;
        [NMS(Index = 2)]
        /* 0x10 */ public int AmountOfIncomeRewarded;
        [NMS(Index = 3)]
        /* 0x14 */ public int ForEveryXAmountOfTheStat;
        [NMS(Index = 1)]
        /* 0x18 */ public GcInventoryType IncomeType;
    }
}
