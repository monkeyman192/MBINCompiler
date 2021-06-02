using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x128, GUID = 0x2BEFBFF68BD985C8, NameHash = 0x197E91849165F7F4)]
    public class GcMissionSequenceWaitForStat : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public NMSString0x10 Stat;
        /* 0x090 */ public NMSString0x10 StatGroup;
        /* 0x0A0 */ public int Amount;
        /* 0x0A4 */ public NMSString0x80 DebugText;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}