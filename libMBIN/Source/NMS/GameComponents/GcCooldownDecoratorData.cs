using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x614385FBCB576753, NameHash = 0xB526D2F0411DDF0B)]
    public class GcCooldownDecoratorData : NMSTemplate
    {
        /* 0x00 */ public NMSTemplate Child;
        /* 0x50 */ public TkBlackboardDefaultValueFloat CooldownTime;
        /* 0x68 */ public NMSString0x10 Key;
    }
}
