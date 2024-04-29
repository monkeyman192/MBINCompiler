using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD3B86EA46A948C65, NameHash = 0x3FD1F99F13543A98)]
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
