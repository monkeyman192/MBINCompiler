using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB21B60117023F6EC, NameHash = 0xE8C35E70B4AA8A05)]
    public class GcBlackboardIntCompareDecoratorData : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public NMSTemplate OnFalse;
        [NMS(Index = 3)]
        /* 0x50 */ public NMSTemplate OnTrue;
        [NMS(Index = 1)]
        /* 0xA0 */ public TkBlackboardDefaultValueInteger CompareTo;
        [NMS(Index = 0)]
        /* 0xB8 */ public NMSString0x10 Key;
        [NMS(Index = 2)]
        /* 0xC8 */ public TkBlackboardComparisonTypeEnum Comparison;
    }
}
