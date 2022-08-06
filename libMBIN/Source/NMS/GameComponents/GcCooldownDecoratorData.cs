using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB81CB31EB0EA69DE, NameHash = 0xB526D2F0411DDF0B)]
    public class GcCooldownDecoratorData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Key;
        /* 0x10 */ public TkBlackboardDefaultValueFloat CooldownTime;
        /* 0x30 */ public NMSTemplate Child;
    }
}
