using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAF2E90A533CC5E, NameHash = 0x9221BA12)]
    public class GcCooldownDecoratorData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public TkBlackboardDefaultValueFloat CooldownTime;
        [NMS(Index = 2)]
        /* 0x18 */ public NMSTemplate Child;
        [NMS(Index = 0)]
        /* 0x28 */ public NMSString0x10 Key;
    }
}
