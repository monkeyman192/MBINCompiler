using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x346AB6B64FC22307, NameHash = 0x3FD1F99F13543A98)]
    public class GcPassiveFrigateIncome : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 IncomeId;
        /* 0x10 */ public int AmountOfIncomeRewarded;
        /* 0x14 */ public int ForEveryXAmountOfTheStat;
        /* 0x18 */ public GcInventoryType IncomeType;
    }
}
