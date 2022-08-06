using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEA1ADDA074B2074B, NameHash = 0xE8C35E70B4AA8A05)]
    public class GcBlackboardIntCompareDecoratorData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Key;
        /* 0x10 */ public TkBlackboardDefaultValueInteger CompareTo;
        /* 0x30 */ public TkBlackboardComparisonTypeEnum Comparison;
        /* 0x38 */ public NMSTemplate OnTrue;
        /* 0x88 */ public NMSTemplate OnFalse;
    }
}
