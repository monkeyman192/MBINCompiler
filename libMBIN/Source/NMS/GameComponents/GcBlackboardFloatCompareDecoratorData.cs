using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x75CE42EFD49D6DA8, NameHash = 0xC549D9FC)]
    public class GcBlackboardFloatCompareDecoratorData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public TkBlackboardDefaultValueFloat CompareTo;
        [NMS(Index = 0)]
        /* 0x18 */ public NMSString0x10 Key;
        [NMS(Index = 4)]
        /* 0x28 */ public NMSTemplate OnFalse;
        [NMS(Index = 3)]
        /* 0x38 */ public NMSTemplate OnTrue;
        [NMS(Index = 2)]
        /* 0x48 */ public TkBlackboardComparisonTypeEnum CompareBlackboardValueType;
    }
}
