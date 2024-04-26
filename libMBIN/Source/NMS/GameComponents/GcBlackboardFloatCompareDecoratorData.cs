using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8A949772CCF6EBE3, NameHash = 0xC8C9C8064A5C8F6E)]
    public class GcBlackboardFloatCompareDecoratorData : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public NMSTemplate OnFalse;
        [NMS(Index = 3)]
        /* 0x50 */ public NMSTemplate OnTrue;
        [NMS(Index = 1)]
        /* 0xA0 */ public TkBlackboardDefaultValueFloat CompareTo;
        [NMS(Index = 0)]
        /* 0xB8 */ public NMSString0x10 Key;
        [NMS(Index = 2)]
        /* 0xC8 */ public TkBlackboardComparisonTypeEnum CompareBlackboardValueType;
    }
}
