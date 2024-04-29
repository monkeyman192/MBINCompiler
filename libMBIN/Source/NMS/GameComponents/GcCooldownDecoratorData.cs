using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x389816CBF372F115, NameHash = 0xB526D2F0411DDF0B)]
    public class GcCooldownDecoratorData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSTemplate Child;
        [NMS(Index = 1)]
        /* 0x50 */ public TkBlackboardDefaultValueFloat CooldownTime;
        [NMS(Index = 0)]
        /* 0x68 */ public NMSString0x10 Key;
    }
}
