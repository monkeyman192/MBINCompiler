using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7C7ACB127FD92DE5, NameHash = 0xC8C9C8064A5C8F6E)]
    public class GcBlackboardFloatCompareDecoratorData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Key;
        /* 0x10 */ public TkBlackboardDefaultValueFloat CompareTo;
        /* 0x30 */ public TkBlackboardComparisonTypeEnum CompareBlackboardValueType;
        /* 0x38 */ public NMSTemplate OnTrue;
        /* 0x88 */ public NMSTemplate OnFalse;
    }
}
