namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x20)]
    public class GcPassiveFrigateIncome : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string IncomeID;
        /* 0x10 */ public GcInventoryType IncomeType;
        /* 0x14 */ public int AmountOfIncomeRewarded;
        /* 0x18 */ public int ForEveryXAmountOfTheStat;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x1C */ public byte[] EndPadding;
    }
}
