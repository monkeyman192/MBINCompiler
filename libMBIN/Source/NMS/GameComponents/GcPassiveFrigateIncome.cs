using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0x2E3E5DACD50B6024, NameHash = 0x3FD1F99F13543A98)]
    public class GcPassiveFrigateIncome : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 IncomeID;
        /* 0x10 */ public GcInventoryType IncomeType;
        /* 0x14 */ public int AmountOfIncomeRewarded;
        /* 0x18 */ public int ForEveryXAmountOfTheStat;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x1C */ public byte[] EndPadding;
    }
}
