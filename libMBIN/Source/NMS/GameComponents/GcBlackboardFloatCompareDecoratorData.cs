using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8A949772CCF6EBE3, NameHash = 0xC8C9C8064A5C8F6E)]
    public class GcBlackboardFloatCompareDecoratorData : NMSTemplate
    {
        /* 0x00 */ public NMSTemplate OnFalse;
        /* 0x50 */ public NMSTemplate OnTrue;
        /* 0xA0 */ public TkBlackboardDefaultValueFloat CompareTo;
        /* 0xB8 */ public NMSString0x10 Key;
        /* 0xC8 */ public TkBlackboardComparisonTypeEnum CompareBlackboardValueType;
    }
}
