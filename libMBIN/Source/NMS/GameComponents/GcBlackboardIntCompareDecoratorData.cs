using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDA2D9F26BD8E47DC, NameHash = 0x25FD6D1)]
    public class GcBlackboardIntCompareDecoratorData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public TkBlackboardDefaultValueInteger CompareTo;
        [NMS(Index = 0)]
        /* 0x18 */ public NMSString0x10 Key;
        [NMS(Index = 4)]
        /* 0x28 */ public NMSTemplate OnFalse;
        [NMS(Index = 3)]
        /* 0x38 */ public NMSTemplate OnTrue;
        [NMS(Index = 2)]
        /* 0x48 */ public TkBlackboardComparisonTypeEnum Comparison;
    }
}
