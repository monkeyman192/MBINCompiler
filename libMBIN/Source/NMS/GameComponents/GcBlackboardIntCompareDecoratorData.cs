using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB21B60117023F6EC, NameHash = 0xE8C35E70B4AA8A05)]
    public class GcBlackboardIntCompareDecoratorData : NMSTemplate
    {
        /* 0x00 */ public NMSTemplate OnFalse;
        /* 0x50 */ public NMSTemplate OnTrue;
        /* 0xA0 */ public TkBlackboardDefaultValueInteger CompareTo;
        /* 0xB8 */ public NMSString0x10 Key;
        /* 0xC8 */ public TkBlackboardComparisonTypeEnum Comparison;
    }
}
