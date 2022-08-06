using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF703DA92989CFC02, NameHash = 0x35ADD8DCDEBE91B7)]
    public class GcBlackboardIntModify : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Key;
        /* 0x14 */ public int Value;
        public enum ModifyIntTypeEnum { SetValue, IncrementValue }
        /* 0x14 */ public ModifyIntTypeEnum ModifyIntType;
    }
}
